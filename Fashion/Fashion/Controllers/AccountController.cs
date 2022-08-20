using Fashion.Business.Abstract;
using Fashion.Functions;
using Fashion.Identity;
using Fashion.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Fashion.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _User;
        private SignInManager<User> _Sign;
        private ISenderMail _Mail;
        private ICartService _Cart;
        public AccountController(UserManager<User> User, SignInManager<User> Sign, ISenderMail Mail, ICartService Cart)
        {
            _User = User;
            _Sign = Sign;
            _Mail = Mail;
            _Cart = Cart;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            if (!ModelState.IsValid)
            {
                
                return View(login);
            }
            var user =await _User.FindByEmailAsync(login.EMail);
            if (user == null)
            {
                TempData["Message"] = "Not Found User";
                return View();
            }
            if(user != null)
            {
                if(!await _User.IsEmailConfirmedAsync(user))
                {
                    TempData["Message"] = "User is not confirm";
                    return View();
                }
                var result =await _Sign.PasswordSignInAsync(user, login.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("index", "root");
                }
                TempData["Message"] = "False Password";
                return View();
            }
            TempData["Message"] = "Yetkisiz erişim";
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return View(new Register { });
        }
        [HttpPost]
        public async Task<IActionResult> Register(Register Model)
        {
            if (!ModelState.IsValid)
            {
                return View(Model);
            }
            var user =await _User.FindByEmailAsync(Model.EPosta);
            if(user != null)
            {
                TempData["Message"] = "Use Alrady E Posta";
                return View(Model);
            }
            //create user
            var CreateUser = new User()
            {
                Name = Model.Name,
                LastName = Model.LastName,
                Email = Model.EPosta,
                UserName = Model.UserName
            };
            var result =await _User.CreateAsync(CreateUser, Model.Password);
            if (result.Succeeded)
            {
                var Token =await _User.GenerateEmailConfirmationTokenAsync(CreateUser);
                var url = Url.Action("ConfirmMail", "Account", new
                {
                    UserId = CreateUser.Id,
                    UserToken = Token
                });
                await _Mail.SendMail(CreateUser.Email, "Hesabınız Onaylayınız", $"Hesabınızı onaylamak için <a href='https://localhost:44376{url}'>Tıklayınız</>");
                TempData["Message"] = "E Postanızı Kontrol Ediniz";
                return RedirectToAction("Login");
            }
            TempData["Message"] = "Bir Hata Meydana Geldi";
            return View(Model);
        }
        public async Task<IActionResult> ConfirmMail(string UserId,string UserToken)
        {
            if(UserId == null || UserToken == null)
            {
                TempData["Message"] = "Yetkisiz Erişim";
                return RedirectToAction("Login");
            }
            var user = await _User.FindByIdAsync(UserId);
            if(user == null)
            {
                TempData["Message"] = "Sifresi Sıfırlanacak Kullanıcı Bulunamadı";
                return RedirectToAction("Login");
            }
            var result = await _User.ConfirmEmailAsync(user, UserToken);
            if (result.Succeeded)
            {
                _Cart.InitializeCart(user.Id);
                TempData["Message"] = "Hesabınız Onaylandı";
                return RedirectToAction("Login");
            }
            TempData["Message"] = "Yetkisiz Erişim";
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult FortgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> FortgotPassword(string EMail)
        {
            if (string.IsNullOrEmpty(EMail))
            {
                TempData["Message"] = "E Posta Alanı Boş Bırakılamaz";
                return View();
            }
            var user =await _User.FindByEmailAsync(EMail);
            if(user == null)
            {
                TempData["Message"] = "E Postaya Ait Kulanıcı Bulunamadı";
                return View();
            }
            var token = await _User.GeneratePasswordResetTokenAsync(user);
            var url = Url.Action("ResetPassword", "Account", new
            {
                UserId = user.Id,
                UserToken = token
            });
            await _Mail.SendMail(user.Email, "Reset Password", $"Sifrenizi yenilemek için <a href='{url}'>Tıklayınız</a>");
            TempData["Message"] = "E Postanızı Kontrol Ediniz";
            return RedirectToAction("Login");
        }
        [HttpGet]
        public async Task<IActionResult> ResetPassword(string UserId,string UserToken)
        {
            if(UserId == null || UserToken  == null)
            {
                TempData["Message"] = "E Postanızı Kontrol Ediniz";
                return RedirectToAction("Login");
            }
            var user =await _User.FindByIdAsync(UserId);
            if(user == null)
            {
                TempData["Message"] = "Kullanıcı Bulunamadı";
                return RedirectToAction("Login");
            }
            var resetpassword = new ResetPassword()
            {
                UserToken = UserToken,
                UserId = UserId,
            };
            return View(resetpassword);
            
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPassword Reset)
        {
            if (!ModelState.IsValid)
            {
                return View(Reset);
            }
            var user =await _User.FindByIdAsync(Reset.UserId);
            if (user == null)
            {
                TempData["Message"] = "Kullanıcı Bulunamadı";
                return RedirectToAction("Login");
            }
            var result =await _User.ResetPasswordAsync(user, Reset.UserToken, Reset.Password);
            if (result.Succeeded)
            {
                TempData["Message"] = "Sifreniz Güncellendi";
                return RedirectToAction("Login");
            }
            TempData["Message"] = "Yetkisiz Erişim";
            return RedirectToAction("Login");
        }
        public async Task<IActionResult> LogOut()
        {
            await _Sign.SignOutAsync();
            return RedirectToAction("Login");
        }

    }
}
