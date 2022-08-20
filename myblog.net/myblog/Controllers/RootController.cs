

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using blog.data.Abstract;
using blog.data.Concrete.EfCoreMysql;
using blog.businnes.Abstract;
using myblog.Entity;

namespace myblog.Controllers
{
    public class RootController : Controller
    {
        private ISettingService _SettingService;
        private IMyService _MyService;
        public RootController(ISettingService SettingService,IMyService MyService)
        {
            _SettingService = SettingService;
            _MyService = MyService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Setting()
        {
            var modellist     = new MySettingViewmodel();
            modellist.setting = _SettingService.GetById(1);
            modellist.my      = _MyService.GetById(1);
            return View(modellist);
        }
        [HttpPost]
        public IActionResult Setting(Setting p)
        {
            _SettingService.update(p);
            return RedirectToAction("Setting");

        }
        [HttpPost]
        public IActionResult UserSetting(My m)
        {
            _MyService.update(m);
            return RedirectToAction("Setting");
        }
    }
}
