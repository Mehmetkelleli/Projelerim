using Application.Repositories;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace WepApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductWriteRepository _Write;
        private IProductReadrepository _Read;
        public ProductController(IProductWriteRepository Write, IProductReadrepository Read)
        {
            _Write = Write;
            _Read = Read;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
           await _Write.CreateRange(new()
            {
                new() {Name="Denemee",Description="loooooo",CreatedTime=DateTime.Now,Price=100000,Stock=10 },
                new() {Name="Denemee",Description="loooooo",CreatedTime=DateTime.Now,Price=100000,Stock=10 },
                new() {Name="Denemee",Description="loooooo",CreatedTime=DateTime.Now,Price=100000,Stock=10 },
                new() {Name="Denemee",Description="loooooo",CreatedTime=DateTime.Now,Price=100000,Stock=10 },

            });
            await _Write.SaveAsync();
            return Ok(_Read.GetAll());
        }
        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            return Ok(_Read.GetAll(false));
        }
    }
}
