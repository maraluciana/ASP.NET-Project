using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFlowerShop.DAL.Entities
{
    public class ProductCart
    {
        public Guid ProductId { get; set; }
        public Guid CartId { get; set; }
        public Product Product { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
