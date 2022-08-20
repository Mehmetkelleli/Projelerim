using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Abstract
{
    public interface IProductService:IValidation<Product>
    {
        Product GetById(int i);
        List<Product> GetList();
        void Update(Product P);
        bool Create(Product P);
        void Delete(Product P);
        Product GetproductDetails(string name);
        List<Product> GetByCategory(string name, int page, int pagesize);
        int GetByCategoryCount(string Category,string search);
        List<Product> GetHomeProducts();
        List<Product> GetSearchProducts(string search, int page, int pagesize);
        Product GetByIdWidthCategories(int id);
        bool Update(Product p, int[] categoryId);
    }
}
