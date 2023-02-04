using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ProjectFlowerShop.BLL.Interfaces;
using ProjectFlowerShop.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFlowerShop.BLL.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService service;

        public ProductController(IProductService productService)
        {
            this.service = productService;
        }

        [HttpGet("Get_All_Products")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = service.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("Get_Products_By_Type{type}")]
        public async Task<IActionResult> GetProductsByType([FromRoute] string type)
        {
            var products = service.GetProductsByType(type);
            return Ok(products);
        }

        [HttpPost("Create_Product")]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> CreatePost([FromBody] ProductCreateModel model)
        {
            service.CreateProduct(model);
            return Ok();
        }

        [HttpPut("Update_Product")]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> UpdatePost([FromBody] ProductUpdateModel model)
        {
            service.UpdateProduct(model);
            return Ok();
        }

        [HttpDelete("Delete_Product{id}")]
        [Authorize(Policy = "Admin")]
        public async Task<IActionResult> DeletePost([FromRoute] int id)
        {
            service.DeleteProduct(id);
            return Ok();
        }
    }
}
