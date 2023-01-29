﻿using Microsoft.AspNetCore.Mvc;
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
    public class ShCartController : ControllerBase
    {
        private readonly IShoppingCartService service;

        public ShCartController(IShoppingCartService shcartService)
        {
            this.service = shcartService;
        }

        [HttpPut("Add_Discount_To_ShCart")]
        public async Task<IActionResult> UpdateShCartDiscount([FromBody] ShCartDiscountModel model)
        {
            service.AddDiscountToShCart(model);
            return Ok();
        }



        //just for debuging
        [HttpPost("Create_ShCart")]
        public async Task<IActionResult> CreateShCart()
        {
            service.CreateShCart();
            return Ok();
        }

        [HttpGet("Get_All_ShCarts")]
        public async Task<IActionResult> GetAllShCarts()
        {
            var shcarts = service.GetAllShCarts();
            return Ok(shcarts);
        }

        [HttpDelete("Delete_ShCart{id}")]
        public async Task<IActionResult> DeletePost([FromRoute] int id)
        {
            service.DeleteShCart(id);
            return Ok();
        }
    }
}
