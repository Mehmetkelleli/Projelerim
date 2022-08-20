using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Web.Business.Abstract;
using Web.Data.Abstract;
using Web.Entity;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IProductService _Products;
        private readonly IGenericRepository<Category> _Category;
        public HomeController(IProductService Products, IGenericRepository<Category> Category)
        {
            _Products = Products;
            _Category = Category;
        }
        [HttpGet]
        public async Task<ActionResult> GetProducts(string CategoryUrl, string Desc)
        {
            return Ok(_Products.GetAll());
        }
        [HttpGet("{url}")]
        public async Task<ActionResult> GetProductByUrl(string Url)
        {
            return Ok(await _Products.GetProductUrlWidthCategory(Url));
        }
        [HttpGet]
        public async Task<ActionResult> GetCategories()
        {
            return Ok(_Category.GetAll());
        }
    }
}
