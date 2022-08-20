using Api.Core.DbModels;
using Api.Core.interfaces;
using Api.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Infrastructure.Implements
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository

    {
        public async Task<List<Product>> GetAllProductAsync(int? ProductTypeId,string Desc)
        {
            using (var db = new DataS1Context())
            {
                var products = db.Products.Include(i => i.ProductBrand).Include(i => i.ProductType).AsQueryable();
                if(ProductTypeId != null)
                {
                    products = products.Where(i => i.ProductBrandId == ProductTypeId);
                }
                if(!string.IsNullOrEmpty(Desc))
                {
                    if(Desc == "UpPrice")
                    {
                        products = products.OrderByDescending(i => i.Price);
                    }
                    if(Desc == "DownPrice")
                    {
                        products = products.OrderBy(i => i.Price);
                    }
                }
                return await products.ToListAsync();
            }
        }

    }
}
