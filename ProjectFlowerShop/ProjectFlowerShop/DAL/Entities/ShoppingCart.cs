using ProjectFlowerShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFlowerShop.DAL
{
    public class ShoppingCart
    {
        public Guid Id { get; set; }
        [ForeignKey("Discount")]
        public Guid DiscountId { get; set; }
        public float totalPrice { get; set; }
        public Discount Discount { get; set; }
        public Letter Letter { get; set; }
        public ICollection<ProductCart> ProductCarts { get; set; }
    }
}
