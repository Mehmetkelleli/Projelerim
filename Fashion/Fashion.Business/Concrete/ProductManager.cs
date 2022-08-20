using Fashion.Business.Abstract;
using Fashion.Data.Abstract;
using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _product;
        public ProductManager(IProductRepository product)
        {
            _product = product;
        }
        public void Create(Product T)
        {
            _product.Create(T);
        }

        public void Delete(Product T)
        {
            _product.Delete(T);
        }

        public List<Product> GetAll()
        {
            return _product.GetAll();
        }

        public Product GetById(int id)
        {
            return _product.GetById(id);
        }

        public Product GetProductDetails(string url)
        {
           return _product.GetProductDetails(url);
        }

        public void Update(Product T)
        {
            _product.Update(T);
        }
        public List<Product> GetCategoryProducts(string url,int page,int PageSize,int min_price,int max_price,int ColorId)
        {
            return _product.GetCategoryProducts(url,page,PageSize,min_price,max_price,ColorId);
        }

        public List<Product> GetProductList()
        {
            return _product.GetProductList();
        }
        public void Click(string url)
        {
            _product.Click(url);
        }

        public List<Product> GetPopulerProducts()
        {
            return _product.GetPopulerProducts();
        }

        public void Update(Product T, int[] CategoryId)
        {
            _product.Update(T, CategoryId);
        }

        public int GetCategoryProductsCount(string url, int Page, int PageSize, int min_price, int max_price, int ColorId)
        {
            return _product.GetCategoryProductsCount(url,Page,PageSize,min_price,max_price,ColorId);
        }
    }
}
