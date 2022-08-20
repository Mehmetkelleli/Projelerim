using blog.businnes.Abstract;
using Microsoft.AspNetCore.Mvc;
using myblog.Entity;

namespace myblog.Controllers
{   
    public class CategoryController : Controller
    {
        private ICatetgoryService _CategoryService;
        public CategoryController(ICatetgoryService CategoryService)
        {
            _CategoryService = CategoryService;
        }
        public IActionResult Index()
        {
            return View(_CategoryService.GetList());
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View(new Category() { });
        }
        [HttpPost]
       public IActionResult CategoryAdd(Category p)
        {
            _CategoryService.create(p);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult CategoryDelete(int id)
        {
            _CategoryService.delete(id);
            return RedirectToAction("index");
        }

        //update category
        [HttpGet]
        public IActionResult CategoryUpdate(int id)
        {
            return View(_CategoryService.GetById(1));
        }
        [HttpPost]
        public IActionResult CategoryUpdate(Category p)
        {
            _CategoryService.update(p);
            return RedirectToAction("index");
        }

    }
}
