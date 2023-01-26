using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace ProjectFlowerShop.DAL.Entities
{
    public class Flower
    {
        [ForeignKey("Product")]
        public Guid Id { get; set; }
        public string Color { get; set; }
        public ICollection<FlowerBouquet> FlowerBouquets { get; set; }
        public Product Product { get; set; }
    }
}
