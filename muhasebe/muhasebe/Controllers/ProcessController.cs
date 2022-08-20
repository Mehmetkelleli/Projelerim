using Microsoft.AspNetCore.Mvc;
using muhasebe.business.Abstract;

namespace muhasebe.Controllers
{
    public class ProcessController : Controller
    {
        private IProcessService _Process;
        public ProcessController(IProcessService Process)
        {
            _Process = Process;
        }
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
