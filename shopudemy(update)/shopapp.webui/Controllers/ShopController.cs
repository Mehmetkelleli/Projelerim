using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;
using shopapp.entity;
using shopapp.webui.Models;
using shopapp.webui.ViewModels;
using System.Linq;

namespace shopapp.webui.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _product;
        public ShopController(IProductService product)
        {
            _product = product;
        }
        public IActionResult List(string category,string search,int page=1)
        {
            const int pagesize = 1;
            if (!string.IsNullOrEmpty(search)) {
                var productViewModel = new ProductListViewModel()
                {
                    PageInfo = new page()
                    {
                        TotalItem = _product.GetByCategoryCount(category,search),
                        ItemsPerPage = pagesize,
                        CurrentPage = page,
                        CurretCategory = category
                    },
                    Products = _product.GetSearchProducts(search,page,pagesize)
                };
                ViewBag.Search = search;
                return View(productViewModel);
            }
            else
            {
                var productViewModel = new ProductListViewModel()
                {
                    PageInfo = new page()
                    {
                        TotalItem = _product.GetByCategoryCount(category,search),
                        ItemsPerPage = pagesize,
                        CurrentPage = page,
                        CurretCategory = category
                    },
                    Products = _product.GetByCategory(category, page, pagesize)
                };
                return View(productViewModel);
            }
        }
        public IActionResult Details(string url)
        {
            if(url == null)
            {
                return NotFound();
            }
            Product Product = _product.GetproductDetails(url);
            if(Product == null)
            {
                return NotFound();
            }
            var model1 = new ProductCategoriesViewModel();
            model1.Product = Product;
            model1.Categories = Product.ProductCategory.Select(i=>i.Category).ToList();
            return View(model1);
        }
    }
}
