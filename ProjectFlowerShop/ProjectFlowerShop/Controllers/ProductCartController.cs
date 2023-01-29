using ProjectFlowerShop.BLL.Interfaces;
using ProjectFlowerShop.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace ProjectFlowerShop.BLL.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class ProductCartController : ControllerBase
    {
        private readonly IProductCartService service;

        public ProductCartController(IProductCartService productService)
        {
            this.service = productService;
        }

        [HttpPut("Add_Product_To_ShCart")]
        public async Task<IActionResult> UpdateShCartProducts([FromBody] ProductCartModel model)
        {
            service.AddProductToShCart(model);
            return Ok();
        }
    }
}
