using ProjectFlowerShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFlowerShop.DAL
{
    public class Product
    {
        public Guid Id { get; set; }
        public ProductTypes productType { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public byte[] Image { get; set; }
        public Flower Flower { get; set; }
        public Bouquet Bouquet { get; set; }

    }
}
