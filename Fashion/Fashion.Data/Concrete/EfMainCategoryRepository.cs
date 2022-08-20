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
    public class EfMainCategoryRepository : EfGenericRepository<MainCategory, ShopDataContext>, IMainCategoryRepository
    {
        public void Clicks(string url)
        {
            using(var db = new ShopDataContext())
            {
                var a = db.MainCategories.FirstOrDefault(i =>i.Url == url);
                if (a != null)
                {
                    a.clicsk += 1;
                    db.SaveChanges();
                }
                else { }
            }
        }

        public List<MainCategory> GetPopulerMainCategory()
        {
            using (var db = new ShopDataContext())
            {
                var cmd = "Select TOP 3 * From MainCategories Order By clicsk Desc";
                var populer = db.MainCategories.FromSqlRaw(cmd).ToList();
                return populer;
            }
        }

        public List<MainCategory> MainCategoryGetAll()
        {
            using(var db = new ShopDataContext())
            {
                return db.MainCategories
                    .Include(i => i.Categories)
                    .ThenInclude(i=>i.ProductCategory)
                    .ThenInclude(i=>i.Product)
                    .ToList();
            }
        }
    }
}
