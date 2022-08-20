using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using shopapp.webui.Identity;
using shopapp.webui.Models;
using System.Threading.Tasks;

namespace shopapp.webui.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _User;
        private SignInManager<User> _Sign;

        public AccountController(UserManager<User> User, SignInManager<User> Sign)
        {
            _User = User;
            _Sign = Sign;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
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
            var user = new User()
            {
                Name = Model.Name,
                LastName = Model.LastName,
                UserName = Model.UserName,
                Email    = Model.EMail,
                PhoneNumber = Model.PhoneNumber
            };
            var response = await _User.CreateAsync(user, Model.Password);
            if (response.Succeeded)
            {
                return RedirectToAction("login");
            }
            return View(Model);
        }
    }
}

