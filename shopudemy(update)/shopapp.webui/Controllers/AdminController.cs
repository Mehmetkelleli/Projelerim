using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using shopapp.business.Abstract;
using shopapp.entity;
using shopapp.entity.message;
using shopapp.webui.ViewModels;
using System.Linq;
using System;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace shopapp.webui.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IProductService _Product;
        private ICategoryService _Category;
        public AdminController(IProductService Product, ICategoryService Category)
        {
            _Product = Product;
            _Category = Category;
        }
        public IActionResult ProductList()
        {
            var liste = new ProductListViewModel();
            liste.Products = _Product.GetList();
            return View(liste);
        }
        [HttpGet]
        public IActionResult ProductCreate()
        {
            return View(new Product());
        }
        [HttpPost]
        public async Task<IActionResult> ProductCreate(Product Product, IFormFile FileImg)
        {
            if(FileImg != null)
            {
                if ((string)Path.GetExtension(FileImg.FileName) != ".jpg")
                {
                    Message msg = new Message()
                    {
                        MessageString = $"Jpg Formatında Resim Yukleyiniz",
                        MessageType = "danger"
                    };

                    TempData["message"] = JsonSerializer.Serialize(msg);
                    return View(Product);
                }
                string random = $"{DateTime.Now.Ticks}.jpg";
                Product.ImageUrl = random;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", random);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await FileImg.CopyToAsync(stream);
                }
            }
            if(_Product.Create(Product))
            {
                Message msg = new Message()
                {
                    MessageString = $"{Product.Name} Added",
                    MessageType = "success"
                };

                TempData["message"] = JsonSerializer.Serialize(msg);
                return RedirectToAction("ProductList");
            }
            Message(_Product.ErrorMesage, "danger");
            return View(Product);

        }
        [HttpGet]
        public IActionResult ProductEdit(int id)
        {
            if (id != null)
            {
                ViewBag.Categories = _Category.GetList();

                return View(_Product.GetByIdWidthCategories(id));
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> ProductEdit(Product P, int[] CategoryId,IFormFile FileImg)
        {
            if (FileImg != null)
            {
                if ((string)Path.GetExtension(FileImg.FileName) != ".jpg")
                {
                    Message msg = new Message()
                    {
                        MessageString = $"Jpg Formatında Resim Yukleyiniz",
                        MessageType = "danger"
                    };

                    TempData["message"] = JsonSerializer.Serialize(msg);
                    return View(_Product.GetByIdWidthCategories(P.ProductId));
                }
                string random = $"{DateTime.Now.Ticks}.jpg";
                P.ImageUrl = random;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img", random);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await FileImg.CopyToAsync(stream);
                }
            }
                if (_Product.Update(P, CategoryId))
            {
                Console.WriteLine(CategoryId);
                Message msg = new Message()
                {
                    MessageString = $"{P.Name} Edited",
                    MessageType = "success"
                };

                TempData["message"] = JsonSerializer.Serialize(msg);
                return RedirectToAction("ProductList");
            }
            if (P.ProductId != null)
            {
                ViewBag.Categories = _Category.GetList();
                Message(_Product.ErrorMesage, "danger");
                return View(_Product.GetByIdWidthCategories(P.ProductId));
            }
            return NotFound();

        }
        [HttpPost]
        public IActionResult ProductDelete(int ProductId)
        {
            var prdel = _Product.GetById(ProductId);
            _Product.Delete(prdel);
            Message msg = new Message()
            {
                MessageString = $"{prdel.Name} Deleted",
                MessageType = "warning"
            };

            TempData["message"] = JsonSerializer.Serialize(msg);
            return RedirectToAction("ProductList");
        }
        // bu kısımda kategori işlmeleri yapılmaktadır
        public IActionResult CategoryList()
        {
            var a = new CategoryViewModel();
            a.Categories = _Category.GetList();
            return View(a);
        }
        [HttpGet]
        public IActionResult CategoryEdit(int Id)
        {
            var liste = new CategoryViewModel();
            liste.Categories = _Category.GetByIdWidthProducts(Id).ProductCategory.Select(i=>i.Category).ToList();
            liste.Products = _Category.GetByIdWidthProducts(Id).ProductCategory.Select(i => i.Product).ToList();
            return View(liste);
        }
        [HttpPost]
        public IActionResult CategoryEdit(Category Category)
        {
            if (_Category.Update(Category))
            {
                
                Message msg = new Message()
                {
                    MessageString = $"{Category.Name} Edited",
                    MessageType = "success"
                };

                TempData["message"] = JsonSerializer.Serialize(msg);
                return RedirectToAction("CategoryList");
            }
            else
            {
                Message msg = new Message()
                {
                    MessageString = $"{_Category.ErrorMesage}",
                    MessageType = "danger"
                };

                TempData["message"] = JsonSerializer.Serialize(msg);
                var liste = new CategoryViewModel();
                liste.Categories = _Category.GetByIdWidthProducts(Category.CategoryId).ProductCategory.Select(i => i.Category).ToList();
                liste.Products = _Category.GetByIdWidthProducts(Category.CategoryId).ProductCategory.Select(i => i.Product).ToList();
                return View(liste);
            }
        }
        [HttpGet]
        public IActionResult CategoryCreate()
        {
            return View(new Category());
        }
        [HttpPost]
        public IActionResult CategoryCreate(Category Category)
        {
            _Category.Create(Category);
            Message msg = new Message()
            {
                MessageString = $"{Category.Name} Added",
                MessageType = "success"
            };

            TempData["message"] = JsonSerializer.Serialize(msg);
            return RedirectToAction("CategoryList");
        }
        [HttpPost]
        public IActionResult CategoryDelete(int CategoryId)
        {
            var a = _Category.GetById(CategoryId);
            _Category.Delete(a);
            Message msg = new Message()
            {
                MessageString = $"{a.Name} Added",
                MessageType = "success"
            };

            TempData["message"] = JsonSerializer.Serialize(msg);
            return RedirectToAction("CategoryList");
        }
        [HttpPost]
        public IActionResult DeleteFromCategory(int CategoryId,int ProductId)
        {
            _Category.DeleteFromCategory(CategoryId,ProductId);
            Message msg = new Message()
            {
                MessageString = $"Deleted Product",
                MessageType = "danger"
            };

            TempData["message"] = JsonSerializer.Serialize(msg);
            return Redirect($"/admin/Category/{CategoryId}");
        }
        private void Message(string message,string type)
        {
            Message msg = new Message()
            {
                MessageString = $"{message}",
                MessageType = type
            };

            TempData["message"] = JsonSerializer.Serialize(msg);
        }

    }
}
