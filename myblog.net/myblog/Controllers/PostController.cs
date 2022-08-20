using blog.businnes.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using myblog.Entity;
using myblog.model;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using PostCategoriesViewModel = myblog.model.PostCategoriesViewModel;

namespace myblog.Controllers
{
    public class PostController : Controller
    {
        private IPostService _PostService;
        private ICatetgoryService _CategoryService;
        public PostController(IPostService PostService, ICatetgoryService CategoryService)
        {
            _PostService = PostService;
            _CategoryService = CategoryService;
        }

        public IActionResult Index()
        {
            var PostCategories = new PostCategoriesViewModel();
            PostCategories.Categories = _CategoryService.GetList();
            PostCategories.Posts = _PostService.GetPosts(null);
            return View(PostCategories);
        }
        [HttpGet]
        public IActionResult PostAdd()
        {
                var liste = _CategoryService.GetList();
                ViewBag.liste = new SelectList(liste, "Id", "Name");
                return View(new Post() { });
            
        }
        [HttpPost]
        public async Task<IActionResult> PostAdd(Post p,IFormFile FileImage)
        {
            if (FileImage == null)
            {
                return View(p);
            }
            var random = $"{DateTime.Now.Ticks}.jpg";
            p.Picture = random;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\blog\\assets\\img", random);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await FileImage.CopyToAsync(stream);
            }
            _PostService.create(p);
            return RedirectToAction("index");

        }
        [HttpGet]
        public IActionResult PostUpdate(int id)
        {
            
                    var post = _PostService.GetById(id);
                    var liste = _CategoryService.GetList();
                    ViewBag.liste = new SelectList(liste, "Id", "Name");
                    return View(post);
         }
        [HttpPost]
        public  async Task<IActionResult> PostUpdate(Post p,IFormFile FileImage)
        {
            if (FileImage == null)
            {
                return View(p);
            }
            var random = $"{DateTime.Now.Ticks}.jpg";
            p.Picture = random;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\blog\\assets\\img", random);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await FileImage.CopyToAsync(stream);
            }
            _PostService.update(p);
            return RedirectToAction("index", "post");

        }
        [HttpGet]
        public IActionResult Postdelete(int id)
        {
            _PostService.delete(id);           
            return RedirectToAction("index", "post");

        }

    }
}
