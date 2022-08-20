using blog.businnes.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace myblog.ViewComponents
{
    public class SettingViewComponent : ViewComponent
    {
        private IMyService _my;
        private ISettingService _Setting;
        public SettingViewComponent(IMyService my, ISettingService Setting)
        {
            _my = my;
            _Setting = Setting;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.author = _my.GetById(1).Name;
            return View(_Setting.GetById(1));
        }
    }
}
