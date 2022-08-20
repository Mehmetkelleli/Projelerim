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
    public class EfProductRepository : EFCoreGenericRepository<Product, MysqlShopContext>, IProductRepository
    {
        public List<Product> GetByCategory(string Name,int page,int pagesize)
        {
            using (var db = new MysqlShopContext())
            {
                var products = db.Products.Where(a=>a.IsApproved).AsQueryable();
                if (!string.IsNullOrEmpty(Name))
                {
                    products = products
                        .Include(i => i.ProductCategory)
                        .ThenInclude(i => i.Category)
                        .Where(i => i.ProductCategory.Any(a => a.Category.Url.ToLower().Contains(Name.ToLower())));
                }
                return products.Skip((page-1)*pagesize).Take(pagesize).ToList();
            }
        }

        public int GetByCategoryCount(string Category,string search)
        {
           using(var db = new MysqlShopContext())
            {
                var products = db.Products.Where(a=>a.IsApproved).AsQueryable();
                if (!string.IsNullOrEmpty(Category)) 
                {
                    products = products
                        .Include(i => i.ProductCategory)
                        .ThenInclude(i => i.Category)
                        .Where(i => i.ProductCategory.Any(a=>a.Category.Url.ToLower().Contains(Category.ToLower())));
                }
                else if (!string.IsNullOrEmpty(search))
                {
                    products = products
                        .Where(a => a.Name.ToLower()
                        .Contains(search) || a.ProductCategory
                        .Any(i => i.Category.Name.ToLower().Contains(search.ToLower())) || a.Description.ToLower().Contains(search.ToLower()));
                }
                return products.Count();
            }
        }

        public Product GetByIdWidthCategories(int id)
        {
            using (var db = new MysqlShopContext())
            {
                return db.Products.Where(i => i.ProductId == id).Include(i => i.ProductCategory).ThenInclude(i => i.Category).FirstOrDefault();
            }
        }

        public List<Product> GetHomeProduct()
        {
            using (var db = new MysqlShopContext())
            {
                return db.Products.Where(i => i.IsHome && i.IsApproved).ToList();
            }
        }

        public List<Product> GetPopulerProducts()
        {
            throw new NotImplementedException();
        }

        public Product GetProductDetails(string name)
        {
            using (var db = new MysqlShopContext())
            {
                return db.Products.Where(i => i.Url.ToLower() == name.ToLower()).Include(i => i.ProductCategory).ThenInclude(i => i.Category).FirstOrDefault();
            }
        }

        public List<Product> GetSearchProducts(string search, int page, int pagesize)
        {
            using(var db = new MysqlShopContext()){
                var products = db.Products.Where(a => a.IsApproved).Include(a=>a.ProductCategory).ThenInclude(a=>a.Category).AsQueryable();
                if (!string.IsNullOrEmpty(search))
                {
                    products = products
                        .Where(a => a.Name.ToLower()
                        .Contains(search)|| a.ProductCategory
                        .Any(i=>i.Category.Name.ToLower().Contains(search.ToLower())) || a.Description.ToLower().Contains(search.ToLower()));
                }
                return products.Skip((page - 1) * pagesize).Take(pagesize).ToList();
            }
        }

        public void Update(Product P, int[] CategoryId)
        {
            using(var db = new MysqlShopContext())
            {
                var product = db.Products.Include(i=>i.ProductCategory).FirstOrDefault(i=>i.ProductId==P.ProductId);
                if (product != null)
                {
                    product.Name = P.Name;
                    product.Description = P.Description;
                    product.Price = P.Price;
                    product.ImageUrl = P.ImageUrl;
                    product.Url = P.Url;
                    product.IsHome = P.IsHome;
                    product.IsApproved = P.IsApproved;

                    product.ProductCategory = CategoryId.Select(i=>
                        new ProductCategory() { 
                            CategoryId = i,
                            ProductId = product.ProductId
                        }).ToList();
                    db.SaveChanges();
                }
            }
        }
    }

    }
