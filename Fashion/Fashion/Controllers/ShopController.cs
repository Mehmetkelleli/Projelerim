using Fashion.Business.Abstract;
using Fashion.Models;
using Fashion.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Fashion.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _Product;
        private ICategoryService _Category;
        private IMainCategoryService _MainCategory;
        private IColorService _Color;

        public ShopController(IProductService Product,ICategoryService Category, IMainCategoryService MainCategory, IColorService Color)
        {
            _Product = Product;
            _Category = Category;
            _MainCategory = MainCategory;
            _Color = Color;
        }
        public IActionResult List(string url, int ColorId=-1 ,int page=1,int min_price=1, int max_price=999999)
        {
            ViewData["Colors"] = _Color.GetAll();
            int pageSize=1;
            if (!string.IsNullOrEmpty(url))
            {
                if (min_price != 1 || max_price != 999999)
                {
                    var ProductCategory = new ProductCategoryViewModel();
                    ProductCategory.Product = _Product.GetCategoryProducts(url, page, 99999, min_price, max_price, ColorId);
                    ProductCategory.MainCategories = _MainCategory.MainCategoryGetAll();
                    _MainCategory.Clicks(url);
                    ViewBag.Category = url;
                    var WebPage = new Page()
                    {
                        TotalItem = 0,
                        PageSize = pageSize,
                        CurrentCategory = url,
                        CurrentPage = page

                    };
                    ProductCategory.Page = WebPage;
                    return View(ProductCategory);
                }
                else
                {
                    var ProductCategory = new ProductCategoryViewModel();
                    ProductCategory.Product = _Product.GetCategoryProducts(url, page, pageSize, min_price, max_price, ColorId);
                    ProductCategory.MainCategories = _MainCategory.MainCategoryGetAll();
                    _MainCategory.Clicks(url);
                    ViewBag.Category = url;
                    var WebPage = new Page()
                    {
                    TotalItem = _Product.GetCategoryProductsCount(url, page, pageSize, min_price, max_price, ColorId),
                        PageSize = pageSize,
                        CurrentCategory = url,
                        CurrentPage = page

                    };
                    ProductCategory.Page = WebPage;
                    return View(ProductCategory);
                }
            }
            else
            {
                var ProductCategory = new ProductCategoryViewModel();
               if(min_price != 1 || max_price != 999999)
                {
                    ProductCategory.Product = _Product.GetCategoryProducts(url, page, 999999, min_price, max_price, ColorId);
                }
                else {
                    ProductCategory.Product = _Product.GetCategoryProducts(url, page, pageSize, min_price, max_price, ColorId);

                }
                ProductCategory.MainCategories = _MainCategory.MainCategoryGetAll();
                if (min_price != 1 || max_price != 999999)
                {
                    var WebPage = new Page()
                    {
                        TotalItem = 0,
                        PageSize = pageSize,
                        CurrentCategory = url,
                        CurrentPage = page,
                        CurrentMinPrice = min_price,
                        CurrentMaxPrice = max_price,
                        CurrentColor = ColorId
                    };
                    ProductCategory.Page = WebPage;
                    return View(ProductCategory);
                }
                else
                {
                    var WebPage = new Page()
                    {
                        TotalItem = _Product.GetCategoryProductsCount(url, page, pageSize, min_price, max_price, ColorId),
                        PageSize = pageSize,
                        CurrentCategory = url,
                        CurrentPage = page,
                        CurrentMinPrice = min_price,
                        CurrentMaxPrice = max_price,
                        CurrentColor = ColorId
                    };
                    ProductCategory.Page = WebPage;
                    return View(ProductCategory);
                }
                
            }

        }        
        public IActionResult Details(string url)
        {
            if(url != null)
            {
                var ProductViewModel =new ProductCategoryViewModel();
                //bu kısımda veri coklu nesne olarak Gönderildi
                ProductViewModel.product = _Product.GetProductDetails(url); 
                ProductViewModel.Categories = _Product.GetProductDetails(url)
                                .ProductCategory
                                .Select(i => i.Category)
                                .ToList();
                ProductViewModel.PopulerProducts = _Product.GetPopulerProducts();
                var product = _Product.GetProductDetails(url);
                _Product.Click(url);
                return View(ProductViewModel) ;
            }
            return NotFound();
        }
    }
}
