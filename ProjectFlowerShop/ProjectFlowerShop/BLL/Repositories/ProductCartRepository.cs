using ProjectFlowerShop.BLL.Interfaces;
using ProjectFlowerShop.DAL;
using ProjectFlowerShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFlowerShop.BLL.Repositories
{
    public class ProductCartRepository : IProductCartRepository
    {
        private readonly ProjectContext db;
        public ProductCartRepository(ProjectContext db)
        {
            this.db = db;
        }

        public void CreateProdCart(ProductCart prodcart)
        {
            db.ProductCart.Add(prodcart);
            db.SaveChanges();
        }
        public void UpdateProdCart(ProductCart prodcart)
        {

            db.ProductCart.Update(prodcart);
            db.SaveChanges();
        }

        public void DeleteProdCart(ProductCart prodcart)
        {
            db.ProductCart.Remove(prodcart);
            db.SaveChanges();
        }
    }
}
