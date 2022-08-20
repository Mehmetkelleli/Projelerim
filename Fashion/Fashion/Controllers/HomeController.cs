using Fashion.Business.Abstract;
using Fashion.Models;
using Fashion.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Fashion.Controllers
{
    public class HomeController : Controller
        
    {
        
        private IHomePageSliderService _HomePageSlider;
        private IMainCategoryService _MainCategory;
        private IProductService _Product;
        private ISiteConfigService _Setting;
        public HomeController(IHomePageSliderService HomePageSlider,IMainCategoryService MainCategory, IProductService Product, ISiteConfigService Setting)
        {
            _HomePageSlider = HomePageSlider;
            _MainCategory = MainCategory;
            _Product = Product;
            _Setting = Setting;
            //click process
            var sets = _Setting.GetById(3);
            
            if (sets.Date == DateTime.Now.Date)
            {
                sets.SiteClick++;
                _Setting.Update(sets);
            }
            else
            {
                sets.SiteClick = 0;
                sets.SiteClick++;
                sets.Date = (DateTime.Now.Date);
                _Setting.Update(sets);
            }

        }
        public IActionResult Index()
        {
            var HomeContent = new HomePageViewModel();
            HomeContent.HomePageSliders = _HomePageSlider.GetAll();
            HomeContent.MainCategories = _MainCategory.MainCategoryGetAll();
            HomeContent.Products = _Product.GetProductList();

            return View(HomeContent);
        }
    }
}
