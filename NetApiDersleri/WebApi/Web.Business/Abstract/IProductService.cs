using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Entity;

namespace Web.Business.Abstract
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<List<Product>> GetAllProduct(string search,string CategoryUrl, string Desc,int page,int pagesize);
        Task<Product> GetProductUrlWidthCategory(string url);
        Task<int> GetAllProductCount(string Search,string CategoryUrl, string Desc, int page, int pagesize);
    }
}
