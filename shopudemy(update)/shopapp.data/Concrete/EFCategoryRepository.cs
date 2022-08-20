using Microsoft.EntityFrameworkCore;
using shopapp.data.Abstract;
using shopapp.data.Concrete.Context;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopapp.data.Concrete
{
    public class EFCategoryRepository : EFCoreGenericRepository<Category, MysqlShopContext>, ICategoryRepository
    {
        public void DeleteFromCategory(int CategoryId, int ProductId)
        {
            using(var db = new MysqlShopContext())
            {
                var cmd = "Delete From productcategory Where ProductId=@p0 And CategoryId=@p1";
                db.Database.ExecuteSqlCommand(cmd, ProductId, CategoryId);
            }
        }

        public Category GetByIdWidthProducts(int CategoryId)
        {
            using (var db = new MysqlShopContext())
            {
                return db.Categories.Where(a => a.CategoryId == CategoryId)
                            .Include(a=>a.ProductCategory)
                            .ThenInclude(a=>a.Product).FirstOrDefault();
            }
        }

        public List<Category> GetPopulerCategories()
        {
            throw new NotImplementedException();
        }
    }
}
