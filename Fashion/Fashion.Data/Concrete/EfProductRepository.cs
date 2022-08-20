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
    public class EfProductRepository : EfGenericRepository<Product, ShopDataContext>, IProductRepository
    {
        public List<Product> GetCategoryProducts(string url,int Page,int PageSize,int min_price,int max_price,int ColorId)
        {
            using(var db = new ShopDataContext())
            {
                var products = db.Products.Where(i => i.Stock > 0).AsQueryable();
                if (!string.IsNullOrEmpty(url))
                {
                    products = products
                                .Include(i => i.ProductCategory)
                                .ThenInclude(i => i.Category)
                                .ThenInclude(i=>i.MainCategory)
                                .Where(i => i.ProductCategory.
                                        Any(i => i.Category.Url.ToLower() == url.ToLower())||
                                        i.ProductCategory.Any(i=>i.Category.MainCategory.Url.ToLower() == url.ToLower()));
                }
                if (min_price != null)
                {
                    products = products.Where(i => i.Price >= min_price);
                }
                if (max_price != null)
                {
                    products = products.Where(i => i.Price <= max_price);
                }
                if (ColorId != -1)
                {
                    products = products.Where(i => i.ColorId == ColorId);
                }
                return products.Skip((Page-1)*PageSize).Take(PageSize).ToList();
            }
        }
        public int GetCategoryProductsCount(string url, int Page, int PageSize, int min_price, int max_price,int ColorId)
        {
            using (var db = new ShopDataContext())
            {
                var products = db.Products.Where(i => i.Stock > 0).AsQueryable();
                if (!string.IsNullOrEmpty(url))
                {
                    products = products
                                .Include(i => i.ProductCategory)
                                .ThenInclude(i => i.Category)
                                .ThenInclude(i => i.MainCategory)
                                .Where(i => i.ProductCategory.
                                        Any(i => i.Category.Url.ToLower() == url.ToLower()) ||
                                        i.ProductCategory.Any(i => i.Category.MainCategory.Url.ToLower() == url.ToLower()));
                }
                if (min_price != null)
                {
                    products = products.Where(i => i.Price >= min_price);
                }
                if (max_price != null)
                {
                    products = products.Where(i => i.Price <= max_price);
                }
                if (ColorId != -1)
                {
                    products = products.Where(i => i.ColorId == ColorId);
                }
                return products.Count();
            }
        }

        public Product GetProductDetails(string url)
        {
            using (var db = new ShopDataContext())
            {
                var product = db.Products.Where(i => i.Url.ToLower() == url.ToLower()).Include(i=>i.ProductSize).Include(i => i.ProductCategory).ThenInclude(i => i.Category).FirstOrDefault();
                    return product;
     
                
            }
        }
        public List<Product> GetProductList()
        {
            using (var db = new ShopDataContext())
            {
                return db.Products.Include(i => i.ProductCategory).ThenInclude(i => i.Category).ThenInclude(i => i.MainCategory).ToList();
            }
        }
        public List<Product> GetPopulerProducts()
        {
            using (var db = new ShopDataContext())
            {
                var cmd = "Select TOP 3 * From Products Order By click Desc";
                var populer = db.Products.FromSqlRaw(cmd).ToList();
                return populer;
            }
        }
        public void Click(string url)
        {
            using (var db = new ShopDataContext())
            {
                var product = db.Products.FirstOrDefault(i => i.Url == url);
                product.Click += 1; 
            }
        }

        public void Update(Product T, int[] CategoryId)
        {
            using (var db = new ShopDataContext())
            {
                var product = db.Products.Include(i=>i.ProductCategory).FirstOrDefault(i => i.Id == T.Id);
                product.Active = T.Active;
                product.Description = T.Description;
                product.ImgUrl = T.ImgUrl;
                product.IsHome = T.IsHome;
                product.Name = T.Name;
                product.Price = T.Price;
                product.ColorId = T.ColorId;
                product.Stock = T.Stock;
                product.Url = T.Url;
                product.ProductCategory = CategoryId.Select(i =>
                    new ProductCategory()
                    {
                        ProductId = product.Id,
                        CategoryId = i
                    }
                ).ToList();
                db.SaveChanges();
            }
        }
    }
}
