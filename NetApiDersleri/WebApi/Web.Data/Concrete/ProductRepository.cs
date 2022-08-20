using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Data.Abstract;
using Web.Data.Context;
using Web.Entity;

namespace Web.Data.Concrete
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public async Task<List<Product>> GetAllProduct(string search,string CategoryUrl, string Desc,int page,int pagesize)
        {
            using (var db = new DataContext())
            {
                var product = db.Products.OrderByDescending(i=>i.Id).Include(i => i.Category).AsQueryable();
                if (!string.IsNullOrEmpty(search))
                {
                    product = product.Where(i => 
                    i.Name.ToLower().Contains(search.ToLower()) || 
                    i.NameUrl.ToLower().Contains(search.ToLower())||
                    i.Description.ToLower().Contains(search.ToLower())||
                    i.Category.Name.ToLower().Contains(search.ToLower())||
                    i.Category.CategoryUrl.ToLower().Contains(search.ToLower())
                    );
                }
                if(CategoryUrl != null)
                {
                    product = product.Where(i => i.Category.CategoryUrl.ToLower() == CategoryUrl.ToLower());
                }
                if(Desc != null)
                {
                    if(Desc == "Up")
                    {
                        product = product.OrderBy(i => i.Price);
                    }
                    else
                    {
                        product = product.OrderByDescending(i => i.Price);
                    }
                }
                return await product.Skip((page-1)*pagesize).Take(pagesize).ToListAsync();
            }
        }

        public async Task<int> GetAllProductCount(string search,string CategoryUrl, string Desc, int page, int pagesize)
        {
            using (var db = new DataContext())
            {
                var product = db.Products.OrderByDescending(i => i.Id).Include(i => i.Category).AsQueryable();
                if (!string.IsNullOrEmpty(search))
                {
                    product = product.Where(i =>
                    i.Name.ToLower().Contains(search.ToLower()) ||
                    i.NameUrl.ToLower().Contains(search.ToLower()) ||
                    i.Description.ToLower().Contains(search.ToLower()) ||
                    i.Category.Name.ToLower().Contains(search.ToLower()) ||
                    i.Category.CategoryUrl.ToLower().Contains(search.ToLower())
                    );
                }
                if (CategoryUrl != null)
                {
                    product = product.Where(i => i.Category.CategoryUrl.ToLower() == CategoryUrl.ToLower());
                }
                if (Desc != null)
                {
                    if (Desc == "Up")
                    {
                        product = product.OrderBy(i => i.Price);
                    }
                    else
                    {
                        product = product.OrderByDescending(i => i.Price);
                    }
                }
                return product.Count();
            }
        }

        public async Task<Product> GetProductIdWidthCategory(string url)
        {
            using (var db = new DataContext())
            {
                return await db.Products.Include(i => i.Category).Where(i=>i.NameUrl == url).FirstOrDefaultAsync();
            }
        }
    }
}
