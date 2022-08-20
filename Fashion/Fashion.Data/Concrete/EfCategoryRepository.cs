using Fashion.Data.Abstract;
using Fashion.Data.Context;
using Fashion.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Data.Concrete
{
    public class EfCategoryRepository : EfGenericRepository<Category, ShopDataContext>, ICategoryRepository
    {
        public void CategoryProductDelete(int ProductId, int CategoryId)
        {
            using (var db = new ShopDataContext())
            {
                var cmd = $"Delete ProductCategory where ProductId=@p0 and CategoryId=@p1";
                db.Database.ExecuteSqlRaw(cmd, ProductId, CategoryId);
            }
        }

        public Category GetCategoryProducts(int id)
        {
            using(var db = new ShopDataContext())
            {
                return db.Categories.Where(i => i.Id == id).Include(i => i.ProductCategory).ThenInclude(i => i.Product).FirstOrDefault();
            }
        }
    }
}
