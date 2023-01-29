using ProjectFlowerShop.BLL.Models;
using ProjectFlowerShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFlowerShop.BLL.Services
{
    public class ProductCartService
    {
        public void AddProductToShCart(ProductCartModel model)
        {
            var productcart = new ProductCart();
            productcart.ProductId = model.ProductId;
            productcart.CartId = model.CartId;


        }

    }
}
