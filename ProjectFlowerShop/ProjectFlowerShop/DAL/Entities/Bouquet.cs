using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFlowerShop.DAL.Entities
{
    public class Bouquet
    {
        [ForeignKey("Product")]
        public Guid Id { get; set; }
        public string Occasion { get; set; }
        public ICollection<FlowerBouquet> BouquetFlowers { get; set; }
        public Product Product { get; set;  }
    }
}
