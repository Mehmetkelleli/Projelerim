using Fashion.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Fashion.ViewComponents
{
   public class NavbarViewComponent : ViewComponent
    {
        private IMainCategoryService _Category;
        public NavbarViewComponent(IMainCategoryService Category)
        {
            _Category = Category;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.GetPopulerMainCategory = _Category.GetPopulerMainCategory();
            return View(_Category.GetAll());
        }
    }
}
