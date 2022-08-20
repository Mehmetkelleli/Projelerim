using blog.businnes.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myblog.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace myblog.Controllers
{
    public class HomeController : Controller
    {
 
        private ISettingService _Setting;
        private IMyService _My;
        private ICvService _Cv;
        private IPostService _Post;
        public HomeController(ISettingService Setting, IMyService My,ICvService Cv, IPostService Post)
        {
            _Setting = Setting;
            _Cv = Cv;
            _My = My;
            _Post = Post;
        }
        public IActionResult Index()
        {
            return View(_Setting.GetById(1));
        }
        public IActionResult About()
        {
            return View(_Cv.GetById(1));
        }
        public IActionResult Blog(int? id)
        {   
            if(id != null)
            {
                return View(_Post.GetPosts(id));
            }
            return View(_Post.GetPosts(id));
        }
        public IActionResult BlogDetails(int id)
        {
            return View(_Post.GetById(id));
        }



    }
}
