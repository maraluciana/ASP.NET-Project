using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFlowerShop.DAL.Entities
{
    public class FlowerBouquet
    {
        public Guid FlowerId { get; set; }
        public Guid BouquetId { get; set; }
        public Flower Flower { get; set; }
        public Bouquet Bouquet { get; set; }
    }
}
