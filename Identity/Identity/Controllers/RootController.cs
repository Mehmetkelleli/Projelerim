using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers
{
    public class RootController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
