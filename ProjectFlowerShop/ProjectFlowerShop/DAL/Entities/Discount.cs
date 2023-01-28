using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFlowerShop.DAL.Entities
{
    public class Discount
    {
        public Guid Id { get; set; }
        public string codeName { get; set; }
        public DiscountTypes discountType { get; set; }
        public float Value { get; set; }
        public ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
