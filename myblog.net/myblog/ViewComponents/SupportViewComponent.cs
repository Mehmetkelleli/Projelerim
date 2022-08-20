using blog.businnes.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace myblog.ViewComponents
{
    public class SupportViewComponent : ViewComponent
    {
        private IMyService _my;
        public SupportViewComponent(IMyService my)
        {
            _my = my;
        }
        public IViewComponentResult Invoke()
        {
            return View(_my.GetById(1));
        }
    }
}
