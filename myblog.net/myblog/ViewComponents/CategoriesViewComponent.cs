using blog.businnes.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace myblog.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {
        private ICatetgoryService _category;
        public CategoriesViewComponent(ICatetgoryService category)
        {
            _category = category;
        }
        public IViewComponentResult Invoke()
        {
            return View(_category.GetList());
        }
    }
}
