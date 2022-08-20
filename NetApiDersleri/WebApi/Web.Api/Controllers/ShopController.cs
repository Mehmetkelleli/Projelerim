using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web.Api.Model;
using Web.Business.Abstract;
using Web.Data.Abstract;
using Web.Entity;

namespace Web.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        private IProductService _Product;
        private IGenericRepository<Category> _Category;
        public ShopController(IProductService Product, IGenericRepository<Category> Category)
        {
            _Product = Product;
            _Category = Category;
        }


        [HttpGet]
        public async Task<ActionResult> GetProduct(string search,string CategoryUrl, string Desc, int page = 1)
        {
            const int pagesize = 1;
            var product = await _Product.GetAllProduct(search,CategoryUrl, Desc, page, pagesize);
            var Pagination = new Page(await _Product.GetAllProductCount(search,CategoryUrl, Desc, page, pagesize),page,CategoryUrl,pagesize);
            
            var PaginitionWithProduct = new PaginitionWithProduct()
            {
                Page = Pagination,
                Product = product
            };
            return Ok(PaginitionWithProduct);
        }
        [HttpGet]
        public async Task<ActionResult> GetByUrlProduct(string Url)
        {
            return Ok(await _Product.GetProductUrlWidthCategory(Url));
        }
        [HttpGet]
        public async Task<ActionResult> GetCategory()
        {
            return Ok(await _Category.GetAll());
        }
    }
}
