using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Entity;

namespace Web.Data.Abstract
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Task<List<Product>> GetAllProduct(string search, string CategoryUrl,string Desc,int page,int pagesize);
        Task<int> GetAllProductCount(string search,string CategoryUrl, string Desc, int page, int pagesize);
        Task<Product> GetProductIdWidthCategory(string url);
    }
}
