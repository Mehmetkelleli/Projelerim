using GenericWeb.Data.Abstract;
using GenericWeb.Entity;
using GenericWebUi.Functions;
using GenericWebUi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace GenericWebUi.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _User;
        private SignInManager<User> _Sign;
        private IGenericRepository<SiteConfig> _Setting; 
        private IMailSender _Send;
        private IImageSender _ImageSend;
        public AccountController(
            UserManager<User> User,
            SignInManager<User> Sign,
            IMailSender Send,
            IImageSender ImageSend
            )
        {
            _User = User;
            _Sign = Sign;
            _Send = Send;
            _ImageSend = ImageSend;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View(new SignUpModel { });
        }
        [HttpPost]
        public async Task<IActionResult> Register(SignUpModel Model,IFormFile FileImage)
        {
            if (!ModelState.IsValid)
            {
                TempData["Message"] = "Page is not true";
                return View(Model);
            }
            var user_Mail = await _User.FindByEmailAsync(Model.EMail);
            var user_Name = await _User.FindByNameAsync(Model.UserName);
            if(user_Mail != null)
            {
                TempData["Message"] = "Already user Mail";
                return View(Model);
            }
            if (user_Name != null)
            {
                TempData["Message"] = "Already user Name";
                return View(Model);
            }
            var user = new User();
            user.Email = Model.EMail;
            user.ImgUrl = "defaults.jpg";
            user.Name = Model.Name;

            user.LastName = Model.LastName;
            user.UserName = Model.UserName;
            if(FileImage != null)
            {
                if ((string)Path.GetExtension(FileImage.FileName) != ".jpg")
                {
                    TempData["Message"] = "img must jpg file";
                    return View(Model);
                }
                var random = $"{DateTime.Now.Ticks}.jpg";
                user.ImgUrl = random;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\files", random);
                _ImageSend.ImageSend(path, FileImage);
            }
            var result = await _User.CreateAsync(user);
            if (result.Succeeded)
            {
                var token = await _User.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmMail", "account", new
                {
                    UserId = user.Id,
                    UserToken = token
                });
                // bu kısım ileride düzenlenecek domaine göre sekillendirilecek
                await _Send.Send(user.Email, "Lütfen Hesabınızı Onaylayınız", $"Hesabınızı oanaylamak için <a href='{url}'>Tıklayınız</a>");
                TempData["Message"] = "E Postanızı Kontrol Ediniz";
                return RedirectToAction("Login");
            }
        }
        public async Task<IActionResult> ConfirmMail(string UserId,string UserToken)
        {   if(string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(UserToken))
            {
                TempData["Message"] = "Yetkisiz Erişim";
                return RedirectToAction("Login");
            }
            var user = await _User.FindByIdAsync(UserId);
            if(user == null)
            {
                TempData["Message"] = "Yetkisiz Erişim";
                return RedirectToAction("Login");
            }
            var result = await _User.ConfirmEmailAsync(user, UserToken);
            if (result.Succeeded)
            {
                TempData["Message"] = "Proccess Complate";
                return RedirectToAction("Login");
            }
            TempData["Message"] = "Yetkisiz Erişim";
            return View();
        }

    }
}
