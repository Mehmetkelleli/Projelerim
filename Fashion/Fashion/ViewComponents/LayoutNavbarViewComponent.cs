using Fashion.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Fashion.ViewComponents
{
    public class LayoutNavbarViewComponent : ViewComponent
    {
        private IMainCategoryService _Category;
        public LayoutNavbarViewComponent(IMainCategoryService Category)
        {
            _Category = Category;
        }
        public IViewComponentResult Invoke()
        {
            return View(_Category.MainCategoryGetAll());
        }
    }
}
