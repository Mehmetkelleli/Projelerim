using Api.Core.DbModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Core.interfaces
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Task<List<Product>> GetAllProductAsync(int? BrandTypeId,string Desc);
        
    }
}
