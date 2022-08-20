using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.data.Abstract
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Product GetProductDetails(string name);
        List<Product> GetPopulerProducts();
        List<Product> GetByCategory(string Name, int page, int pagesize);
        List<Product> GetHomeProduct();
        int GetByCategoryCount(string Category,string search);
        List<Product> GetSearchProducts(string search,int page,int pagesize);
        Product GetByIdWidthCategories(int id);
        void Update(Product P, int[] CategoryId);
    }
}
