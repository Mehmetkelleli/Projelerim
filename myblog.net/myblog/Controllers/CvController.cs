using blog.businnes.Abstract;
using Microsoft.AspNetCore.Mvc;
using myblog.Entity;

namespace myblog.Controllers
{
    public class CvController : Controller
    {
        private ICvService _CvService;
        public CvController(ICvService CvService)
        {
            _CvService = CvService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_CvService.GetById(1));
        }
        [HttpPost]
        public IActionResult Index(Cv c)
        {
            _CvService.update(c);
            return View(c);
        }
    }
}
