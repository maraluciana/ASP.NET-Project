using Microsoft.AspNetCore.Mvc;
using ProjectFlowerShop.BLL.Interfaces;
using ProjectFlowerShop.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFlowerShop.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class AuthentificationController : ControllerBase
    {
        private IAuthentificationService authentificationService;

        public AuthentificationController(IAuthentificationService authentificationService)
        {
            this.authentificationService = authentificationService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserModel model)
        {
            try
            {
                await authentificationService.Register(model);

                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest("Failed");
            }
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Register([FromBody] LoginUserModel model)
        {
            try
            {
                var tokens = await authentificationService.Login(model);

                if(tokens != null)
                    return Ok(tokens);
                else
                    return BadRequest("Failed");
            }
            catch (Exception ex)
            {
                return BadRequest("Failed");
            }
        }
    }
}
