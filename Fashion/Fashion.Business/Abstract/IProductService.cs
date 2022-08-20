using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Business.Abstract
{
    public interface IProductService
    {
        void Create(Product T);
        void Update(Product T);
        void Delete(Product T);
        List<Product> GetAll();
        Product GetById(int id);
        Product GetProductDetails(string url);
        List<Product> GetCategoryProducts(string url,int Page,int PageSize,int min_price,int max_price,int ColorId);
        int GetCategoryProductsCount(string url, int Page, int PageSize, int min_price, int max_price, int ColorId);
        List<Product> GetProductList();
        void Click(string url);
        List<Product> GetPopulerProducts();
        void Update(Product T, int[] CategoryId);
    }
}
