using ProjectFlowerShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFlowerShop.DAL
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        [Foreign_Key("Discount")]
        public Guid Discount { get; set; }

        public Discount Discount { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
