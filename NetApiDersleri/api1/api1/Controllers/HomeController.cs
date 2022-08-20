using Api.Core.DbModels;
using Api.Core.interfaces;
using Api.Infrastructure.Context;
using api1.Error;
using api1.ModelDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api1.Controllers
{
    public class HomeController : BaseApiController
    {
        private readonly IProductRepository _Product;
        private readonly IGenericRepository<ProductBrand> _ProductBrand;
        private readonly IGenericRepository<ProductType> _ProductType;
        public HomeController(
            IProductRepository Product,
            IGenericRepository<ProductBrand> ProductBrand,
            IGenericRepository<ProductType> ProductType
            )
        {
            _Product = Product;
            _ProductBrand = ProductBrand;
            _ProductType = ProductType;
        }
        
        [HttpGet]
        
        public async Task<ActionResult<List<ProductDto>>> GetProducts(int? id,string Desc)
        {
            var data = await _Product.GetAllProductAsync(id,Desc);
            //transfer data dbo object
            return Ok(data.Select(i => new ProductDto()
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description,
                Price = i.Price,
                ImgUrl = i.ImgUrl,
                ProductBrand = i.ProductBrand,
                ProductBrandId = i.ProductBrandId,
                ProductType = i.ProductType,
                ProductTypeId=i.ProductTypeId

            }).ToList());
            
        }

        [HttpGet("{id}")]
        
        public async Task<ActionResult<ProductDto>> GetProductById(int id)
        {
            var data = await _Product.GetByIdAsync(id);
            if(data != null)
            {
                var Product = new ProductDto()
                {
                    Id = data.Id,
                    Name = data.Name,
                    Description = data.Description,
                    Price = data.Price,
                    ImgUrl = data.ImgUrl,
                    ProductBrand = data.ProductBrand != null ? data.ProductBrand : new ProductBrand(),
                    ProductBrandId = data.ProductBrandId,
                    ProductType = data.ProductType != null ? data.ProductType : new ProductType(),
                    ProductTypeId = data.ProductTypeId
                };
                return Ok(Product);
            }
            return NotFound(new ErrorClass(400));
        }
        [HttpGet]
        public async Task<ActionResult<List<ProductBrand>>> GetAllProductBrand()
        {
            var data = await _ProductBrand.GetAllAsync();
            return Ok(data);

        }
        [HttpGet]
        public async Task<ActionResult<List<ProductType>>> GetAllProductType()
        {
            var data = await _ProductType.GetAllAsync() ;
            return Ok(data);

        }
    }
}
