using Proiect_asp.net.DAL.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_asp.net.DAL.Entities
{
    public class Discount
    {
        public Guid Id { get; set; }
        public string codeName { get; set; }
        public DiscountTypes discountType { get; set; }
        public float Value { get; set; }
    }
}
