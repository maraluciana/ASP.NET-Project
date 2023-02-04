using Microsoft.AspNetCore.Identity;
using ProjectFlowerShop.BLL.Interfaces;
using ProjectFlowerShop.BLL.Models;
using ProjectFlowerShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFlowerShop.BLL.Services
{
    public class AuthentificationService : IAuthentificationService
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly ITokenService tokenService;
        public AuthentificationService(UserManager<User> userManager, SignInManager<User> signInManager, ITokenService tokenService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.tokenService = tokenService;
        }
        public async Task Register(RegisterUserModel registerModel)
        {
            var user = new User
            {
                Email = registerModel.Email,
                UserName = registerModel.UserName,
            };

            var result = await userManager.CreateAsync(user, registerModel.Password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, registerModel.RoleId.ToString());
            }

        }
        public async Task<TokenModel> Login(LoginUserModel loginModel)
        {
            var user = await userManager.FindByEmailAsync(loginModel.Email);

            if(user != null)
            {
                var result = await signInManager.CheckPasswordSignInAsync(user, loginModel.Password, false);
                if(result.Succeeded)
                {
                    var token = await tokenService.CreateToken(user);
                    return new TokenModel { Token = token };
                }
            }

            return null;
        }
    }
}
