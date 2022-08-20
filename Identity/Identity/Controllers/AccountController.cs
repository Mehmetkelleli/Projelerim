using Identity.EMailSender;
using Identity.Identity;
using Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Identity.Controllers
{
 
    public class AccountController : Controller
    {
        private UserManager<User> _UserManager;
        private SignInManager<User> _SignInManager;
        private IEMailSender _Mail;
        public AccountController(UserManager<User> UserManager, SignInManager<User> SignInManager, IEMailSender Mail)
        {
            _UserManager = UserManager;
            _SignInManager = SignInManager;
            _Mail = Mail;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View(new Login { });
        }
        [HttpPost]

        public async Task<IActionResult> Login(Login Model)
        {
            if (!ModelState.IsValid)
            {
                return View(Model);
            }
            var user_name = await _UserManager.FindByNameAsync(Model.Username);
            var user_mail = await _UserManager.FindByEmailAsync(Model.Username);
            if(user_name == null && user_mail == null)
            {
                ModelState.AddModelError("Username", "Username is null");
                return View(new Login { });
            }

           if(user_name!= null)
            {
                if(!await _UserManager.IsEmailConfirmedAsync(user_name))
                {
                    TempData["Message"] = "E posta dogrulanmalı";
                    return View(new Login { });
                }
                var result = await _SignInManager.PasswordSignInAsync(user_name, Model.Password, false, false); 

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "Root");
                }
                TempData["Message"] = "Sifre Yanlış";
                return View(new Login { });

            }
            else
            {
                if (!await _UserManager.IsEmailConfirmedAsync(user_mail))
                {
                    TempData["Message"] = "E posta dogrulanmalı";
                    return View(new Login { });
                }
                var result = await _SignInManager.PasswordSignInAsync(user_mail, Model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "Root");
                }
                TempData["Message"] = "Sifre Yanlış";
                return View(new Login { });

            }

            TempData["Message"] = "Error Preccess";
            return View(new Login { });
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View(new Register { });
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Register(Register Model)
        {
            if (!ModelState.IsValid)
            {
                return View(Model);
            }
            var User1 = await _UserManager.FindByNameAsync(Model.Username);
            //if(User1 != null)
            //{
            //    ModelState.AddModelError("Username", "username  Already use");
            //    return View(Model);
            //}
            var user = new User()
            {
                FirstName = Model.Name,
                LastName = Model.LastName,
                Email    = Model.Mail,
                UserName = Model.Username
            };
           
            var result = await _UserManager.CreateAsync(user, Model.Password);
            if (result.Succeeded)
            {
                var Code = await _UserManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmMail", "Account", new
                {
                    UserId = user.Id,
                    UserToken = Code
                });
                
                await _Mail.Send(user.Email, "Kimlik Doğrulama", $"Hesabı Doğrulamak için lütfen <a href='http://localhost:4206{url}'>Tıklayınız</a>");
                TempData["Message"] = " E Postanıza doğrulama kodu gönderildi";
                return RedirectToAction("Login");
            }
            return View(Model);

        }
        public async Task<IActionResult> LogOut()
        {
            await _SignInManager.SignOutAsync();
            return RedirectToAction("index", "Home");
        }
        public async Task<IActionResult> ConfirmMail(string UserId, string UserToken)
        {
            if(UserId == null || UserToken == null)
            {
                TempData["Message"] = "Yetkisiz Erişim";
                return RedirectToAction("Login");
            }
            var user = await _UserManager.FindByIdAsync(UserId);
            if(user == null)
            {
                TempData["Message"] = "Hata Böylr bir kullanıcı bulunmamakta";
                return RedirectToAction("Login");
            }
            var result = await _UserManager.ConfirmEmailAsync(user,UserToken);
            if (result.Succeeded)
            {
                TempData["Message"] = "Hesabınız Onaylandı";
                return RedirectToAction("Login");
            }
            TempData["Message"] = "Sikir Lan yarrak";
            return RedirectToAction("Login");
        }
        //forgot password
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string EMail)
        {
            if (string.IsNullOrEmpty(EMail))
            {
                TempData["Message"] = "Hatalı İşlem E Posta alanı Boş Bırakılamaz";
                return View();
            }
            var user =await _UserManager.FindByEmailAsync(EMail);
            if(user == null)
            {
                TempData["Message"] = "Böyle bir kullanıcı bulunamadı";
                return View();
            }
            var token =await _UserManager.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", "account", new
            {
                UserId = user.Id,
                UserToken = token
            });
            await _Mail.Send(user.Email, "Password Reset", $"Sifrenizi yenilemek için lütfen <a href='http://localhost:4206{url}'>Tıklayınız</a>");
            TempData["Message"] = "Sifre yenileme linki e postanıza gönderildi";
            return RedirectToAction("login");
        }
        [HttpGet]
        public IActionResult ResetPassword(string UserId,string UserToken)
        {
            if(UserId == null || UserToken == null)
            {
                TempData["Message"] = "Böyle bir kullanıcı bulunmamaktadır";
                return RedirectToAction("login");
            }
            var user = _UserManager.FindByIdAsync(UserId);
            if(user == null)
            {
                TempData["Message"] = "Böyle bir kullanıcı bulunmamaktadır";
                return RedirectToAction("login");
            }
            var resetPassword = new ResetPassword()
            {
                UserToken = UserToken,
                UserId = UserId
            };
            return View(resetPassword);
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPassword RP)
        {
            // Rp is reset password vlass
            if (!ModelState.IsValid)
            {
                return View(RP);
            }
            var user = await _UserManager.FindByIdAsync(RP.UserId);
            if (user == null)
            {
                TempData["Message"] = "Böyle bir kullanıcı bulunmamaktadır";
                return RedirectToAction("login");
            }
            var result =await _UserManager.ResetPasswordAsync(user, RP.UserToken,RP.Password);
            if (result.Succeeded)
            {
                TempData["Message"] = "Sifreniz Güncellendi";
                return RedirectToAction("Login");
            }
            TempData["Message"] = "Yetkisiz Erişim";
            return RedirectToAction("login");
            
        }
    }
}
