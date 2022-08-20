using Microsoft.AspNetCore.Mvc;

namespace muhasebe.ViewComponents
{
    public class _SidebarViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(new {});
        }
    }
}
