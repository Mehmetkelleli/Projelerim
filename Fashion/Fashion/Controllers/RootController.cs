using Fashion.Business.Abstract;
using Fashion.entity;
using Fashion.Identity;
using Fashion.Models;
using Fashion.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Fashion.Controllers
{
    [Authorize(Roles ="Admin")]
    public class RootController : Controller
    {
        private IProductService _Product;
        private IMainCategoryService _MainCategory;
        private ICategoryService _Category;
        private IColorService _Color;
        private ISiteConfigService _Setting;
        private RoleManager<IdentityRole> _Role;
        private UserManager<User> _User;
        public RootController(
                IProductService Product,
                IMainCategoryService MainCategory,
                ICategoryService Category,
                IColorService Color,
                ISiteConfigService Setting,
                RoleManager<IdentityRole> Role,
                UserManager<User> User
            )
        {
            _Product = Product;
            _MainCategory = MainCategory;
            _Category = Category;
            _Color = Color;
            _Setting = Setting;
            _User = User;
            _Role = Role;
            
        }
        public IActionResult Index()
        {
            ViewBag.ProductPiece = _Product.GetAll().Count;
            return View(_Setting.GetById(3));
        }
        //product proccess
        public IActionResult ProductList()
        {
            return View(_Product.GetAll());
        }
        [HttpGet]
        public IActionResult ProductAdd()
        {
            ViewBag.ColorList = new SelectList(_Color.GetAll(), "Id", "Name");
            return View(new Product() { });
        }
        [HttpPost]
        public async Task<IActionResult> ProductAdd(Product P,IFormFile FileImg)
        {
            if (FileImg != null)
            {
                if((string)Path.GetExtension(FileImg.FileName) !=".jpg")
                {
                    TempData["message"] = "img must jpg file";
                    return View(P);
                }
                var random = $"{DateTime.Now.Ticks}.jpg";
                P.ImgUrl = random;
                var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\img\\product-img",random);
                using(var stream = new FileStream(path, FileMode.Create))
                {
                    await FileImg.CopyToAsync(stream);
                }
                _Product.Create(P);
                TempData["message"] = "Product Create";
                return RedirectToAction("ProductList");
            }
            TempData["message"] = "Img is Null";
            return View(P);
        }
        [HttpGet]
        public IActionResult ProductEdit(string url)
        {
            var liste = new ProductCategoryViewModel();
            liste.product = _Product.GetProductDetails(url);
            liste.Categories = _Product.GetProductDetails(url).ProductCategory.Select(i => i.Category).ToList();
            ViewData["ProductCategories"] = _Category.GetAll();
            ViewBag.ColorList = new SelectList(_Color.GetAll(), "Id", "Name");
            return View(liste);
        }
        [HttpPost]

        public async Task<IActionResult> ProductEdit(Product P, int[] CategoryId, IFormFile FileImg)
        {

            if (FileImg == null)
            {
                _Product.Update(P, CategoryId);
                return RedirectToAction("ProductList");
            }
            if((string)Path.GetExtension(FileImg.FileName) != ".jpg")
            {
                return RedirectToAction("ProductList");
            }
            var random = $"{DateTime.Now.Ticks}.jpg";
            P.ImgUrl = random;
            var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot\\img\\product-img",random);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await FileImg.CopyToAsync(stream);
            }
            _Product.Update(P, CategoryId);
            return RedirectToAction("ProductList");
        }
        [HttpPost]
        public IActionResult ProductDelete(string url)
        {
            var product = _Product.GetProductDetails(url);
            _Product.Delete(product);
            return RedirectToAction("ProductList");
        }
        //main categories proccess
        public IActionResult MainCategoryList()
        {
            return View(_MainCategory.GetAll());
        }
        [HttpGet]
        public IActionResult MainCategoryAdd()
        {
            return View(new MainCategory { });
        }
        [HttpPost]
        public IActionResult MainCategoryAdd(MainCategory M)
        {
            _MainCategory.Create(M);
            return RedirectToAction("MainCategoryList");
        }
        [HttpGet]
        public IActionResult MainCategoryEdit(int id)
        {
            return View(_MainCategory.GetById(id));
        }
        [HttpPost]
        public IActionResult MainCategoryEdit(MainCategory M)
        {
            _MainCategory.Update(M);
            return RedirectToAction("MainCategoryList");
        }
        [HttpPost]
        public IActionResult MainCategoryDelete(int id)
        {
            var maincategory = _MainCategory.GetById(id);
            _MainCategory.Delete(maincategory);
            return RedirectToAction("MainCategoryList");
        }
        //Category Process
        public IActionResult CategoryList()
        {
            return View(_Category.GetAll());
        }
        [HttpGet]
        public IActionResult CategoryAdd()
        {
            var liste = _MainCategory.GetAll();
            ViewBag.Liste = new SelectList(liste, "Id", "Name");
            return View(new Category { });
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category C)
        {
            _Category.Create(C);
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public IActionResult CategoryEdit(int id)
        {
            var liste = _MainCategory.GetAll();
            ViewBag.Liste = new SelectList(liste, "Id", "Name");
            var ProductCategory = new ProductCategoryViewModel();
            ProductCategory.Category = _Category.GetCategoryProducts(id);
            ProductCategory.Product = _Category.GetCategoryProducts(id).ProductCategory.Select(i => i.Product).ToList();
            return View(ProductCategory);
        }
        [HttpPost]
        public IActionResult CategoryEdit(Category C)
        {
            _Category.Update(C);
            return RedirectToAction("CategoryList");
        }
        [HttpPost]
        public IActionResult CategoryDelete(int id)
        {
            var category = _Category.GetById(id);

            _Category.Delete(category);
            return RedirectToAction("CategoryList");
        }
        [HttpPost]
        public IActionResult CategoryProductDelete(int ProductId,int CategoryId)
        {
            _Category.CategoryProductDelete(ProductId, CategoryId);
            return Redirect($"/root/CategoryEdit/{CategoryId}");
        }
        [HttpGet]
        public IActionResult ColorAdd()
        {
            return View(new Color { });
        }
        [HttpPost]
        public IActionResult ColorAdd(Color C)
        {
            _Color.Create(C);
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult SiteConfig()
        {
            return View(_Setting.GetById(3));
        }
        [HttpPost]
        public async Task<IActionResult> Siteconfig(SiteConfig T,IFormFile FileImage)
        {
            if(FileImage == null)
            {
                _Setting.Update(T);
                return RedirectToAction("index");
            }
            var random = $"{DateTime.Now.Ticks}.jpg";
            T.LogoUrl = random;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\img\\core-img", random);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await FileImage.CopyToAsync(stream);
            }
            return RedirectToAction("index");

        }
        //roller kısmı
        [HttpGet]
        public IActionResult RoleList()
        {
            return View(_Role.Roles);
        }
        [HttpGet]
        public IActionResult RoleCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RoleCreate(RoleModel Model)
        {
            if (!ModelState.IsValid)
            {
                TempData["Message"] = "Role Adı Boş Bırakılamaz";
                return View();
            }
            var result = await _Role.CreateAsync(new IdentityRole(Model.Name));
            if (result.Succeeded)
            {
                TempData["Message"] = "Role Eklendi";
                return RedirectToAction("RoleList");
            }
            TempData["Message"] = "Hatalı İşlem";
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> RoleEdit(string Id)
        {
            if(string.IsNullOrEmpty(Id))
            {
                TempData["Message"] = "Role Adı Boş Bırakılamaz";
                return View();
            }
            var role =await _Role.FindByIdAsync(Id);
            var members = new List<User>();
            var NonMembers = new List<User>();
            foreach (var item in _User.Users)
            {
                if(await _User.IsInRoleAsync(item, role.Name))
                {
                    members.Add(item);
                }
                else
                {
                    NonMembers.Add(item);
                }
            }
            var Role = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMember = NonMembers
            };
            return View(Role);
        }
        [HttpPost]
        public async Task<IActionResult> RoleEdit(string Name, string id, string[] MembersAdd, string[] MembersDelete)
        {
            if (Name == null || id == null)
            {
                TempData["Message"] = "Role Adı Boş Bırakılamaz";
                return Redirect($"/Root/RoleEdit/{id}");
            }
            var Role = await _Role.FindByIdAsync(id);
            if (Role == null)
            {
                TempData["Message"] = "Role Bulunamadı";
                return Redirect($"/Root/RoleEdit/{id}");
            }
            foreach (var UserId in MembersAdd)
            {
                var user = await _User.FindByIdAsync(UserId);
                if (user != null)
                {
                    var result = await _User.AddToRoleAsync(user, Role.Name);
                    if (result.Succeeded)
                    {
                        TempData["Message"] = "Role Updated";
                        return Redirect($"/Root/RoleEdit/{id}");
                    }
                    TempData["Message"] = "Error Try Again";
                    return Redirect($"/Root/RoleEdit/{id}");
                }
                TempData["Message"] = "Error Try Again";
                return Redirect($"/Root/RoleEdit/{id}");

            }
            foreach (var UserId in MembersDelete)
            {
                var user = await _User.FindByIdAsync(UserId);
                if (user != null)
                {
                    var result = await _User.RemoveFromRoleAsync(user,Role.Name);
                    if (result.Succeeded)
                    {
                        TempData["Message"] = "Role Deleted";
                        return Redirect($"/Root/RoleEdit/{id}");

                    }
                    TempData["Message"] = "Error Try Again";
                    return Redirect($"/Root/RoleEdit/{id}");

                }
                TempData["Message"] = "Error Try Again";
                return Redirect($"/Root/RoleEdit/{id}");


            }

            TempData["Message"] = "Error Try Again";
                return Redirect($"/Root/RoleEdit/{id}");


        }
        public async Task<IActionResult> RoleDelete(string id)
        {
            var role =await _Role.FindByIdAsync(id);
            if(role == null)
            {
                TempData["Message"] = "Role Not Found";
                return RedirectToAction("RoleList");
            }
            var result = await _Role.DeleteAsync(role);
            if (!result.Succeeded) {
                TempData["Message"] = "Role Error";
                return RedirectToAction("RoleList");
            }
            TempData["Message"] = "Role Deleted";
            return RedirectToAction("RoleList");
        }

        // user proccess
        public async Task<IActionResult> Users()
        {
            return View(_User.Users);
        }
        [HttpGet]
        public async Task<IActionResult> UserDetails(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                TempData["Message"] = "Id is Null or Empty";
                return RedirectToAction("Users");
            }
            var user = await _User.FindByIdAsync(id);
            if(user == null)
            {
                TempData["Message"] = "User is not found";
                return RedirectToAction("Users");
            }
            
            var Roles = _Role.Roles.Select(i=>i.Name);
            ViewBag.Roles = Roles; 
            var UserRoles = await _User.GetRolesAsync(user);
            var UserDetail = new Userdetails()
            {
               User = user,

               UserRoles = UserRoles
            };
            return View(UserDetail);
        }
        [HttpPost]
        public async Task<IActionResult> UserDetails(Userdetails Data, string[] UserRoles)
        {
            if (!ModelState.IsValid)
            {
                return View(Data);
            }
            var user =await _User.FindByIdAsync(Data.User.Id);
            if(user == null)
            {
                TempData["Message"] = "Kullanıcı Bulununamadı";
                return RedirectToAction("Users");
            }
            user.Name = Data.User.Name;
            user.LastName = Data.User.LastName;
            user.Email = Data.User.Email;
            user.EmailConfirmed = Data.User.EmailConfirmed;
            user.UserName = Data.User.UserName;
            var result =await _User.UpdateAsync(user);
            if (result.Succeeded)
            {
                var UserRolles =await _User.GetRolesAsync(user);
                if(UserRoles == null)
                {
                    UserRoles = new string[] {};
                    await _User.AddToRolesAsync(user, UserRoles.Except(UserRolles).ToArray<string>());
                    await _User.RemoveFromRolesAsync(user, UserRolles.Except(UserRoles).ToArray<string>());

                }
                TempData["Message"] = "Users Update";
                return RedirectToAction("Users");
            }
            return RedirectToAction("Users");
        }

    }

    }

