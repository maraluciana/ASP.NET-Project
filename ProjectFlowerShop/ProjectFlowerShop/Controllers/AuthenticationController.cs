using Microsoft.AspNetCore.Mvc;
using ProjectFlowerShop.BLL.Interfaces;
using ProjectFlowerShop.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFlowerShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IAuthenticationService authenticationSevice;

        public AuthenticationController(IAuthenticationService authenticationSevice)
        {
            this.authenticationSevice = authenticationSevice;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> SignUp([FromBody] RegisterUserModel model)
        {
            try
            {
                await authenticationSevice.Register(model);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("Something failed");
            }
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginUserModel model)
        {
            try
            {
                var tokens = await authenticationSevice.Login(model);

                if (tokens != null)
                    return Ok(tokens);
                else
                {
                    return BadRequest("Something failed");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Exception caught");
            }
        }
    }
}
