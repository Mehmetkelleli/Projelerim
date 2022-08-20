using blog.businnes.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace myblog.ViewComponents
{
    public class NavbarViewComponent:ViewComponent
    {
        private ISettingService _Setting;
        public NavbarViewComponent(ISettingService Setting)
        {
            _Setting = Setting;
        }
        public IViewComponentResult Invoke()
        {
            return View(_Setting.GetById(1));
        }
    }
}
