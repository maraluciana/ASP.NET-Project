using ProjectFlowerShop.BLL.Interfaces;
using ProjectFlowerShop.DAL;
using ProjectFlowerShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFlowerShop.BLL.Repositories
{
    public class DiscountRepository : IDiscountRepository
    {
        private readonly ProjectContext db;
        public DiscountRepository(ProjectContext db)
        {
            this.db = db;
        }

        public IQueryable<Discount> GetAllDiscountsIQueryable()
        {
            var discounts = db.Discounts
                .OrderBy(x => x.Id);

            return discounts;
        }

        public IQueryable<Discount> GetDiscountsByTypeIQueryable(string type)
        {
            var discounts = GetAllDiscountsIQueryable()
                .Where(x => x.discountType == type);

            return discounts;
        }

        public Discount GetDiscountById(int id)
        {
            var discount = db.Discounts
                .FirstOrDefault(x => x.Id == id);

            return discount;
        }

        public void CreateDiscount(Discount discount)
        {
            db.Discounts.Add(discount);
            db.SaveChanges();
        }

        public void DeleteDiscount(Discount discount)
        {
            db.Discounts.Remove(discount);
            db.SaveChanges();
        }
    }
}
