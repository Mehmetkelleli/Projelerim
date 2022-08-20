using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shopapp.business.Abstract;

namespace shopapp.webui.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        private ICategoryService _category;
        public CategoriesViewComponent(ICategoryService category)
        {
            _category = category;
        }
        public IViewComponentResult Invoke()
        {
        
            return View(_category.GetList());
        }
    }
}