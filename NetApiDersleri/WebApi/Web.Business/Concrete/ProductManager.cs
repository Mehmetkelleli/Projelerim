using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Business.Abstract;
using Web.Data.Abstract;
using Web.Entity;

namespace Web.Business.Concrete
{
    
    public class ProductManager : IProductService
    {

        private IProductRepository _Product;
        public ProductManager(IProductRepository Product)
        {
            _Product = Product;
        }
        public async Task<List<Product>> GetAll()
        {
            return await _Product.GetAll();
        }

        public async Task<List<Product>> GetAllProduct(string search,string CategoryUrl, string Desc,int page,int pagesize)
        {
            return await _Product.GetAllProduct(search,CategoryUrl, Desc,page,pagesize);
        }

        public async Task<int> GetAllProductCount(string Search,string CategoryUrl, string Desc, int page, int pagesize)
        {
            return await _Product.GetAllProductCount(Search,CategoryUrl, Desc, page, pagesize);
        }

        public async Task<Product> GetById(int id)
        {
            return await _Product.GetById(id);
        }

        public async Task<Product> GetProductUrlWidthCategory(string url)
        {
            return await _Product.GetProductIdWidthCategory(url);
        }
    }
}
