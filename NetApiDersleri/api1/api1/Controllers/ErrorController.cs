using api1.Error;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api1.Controllers
{
    public class ErrorController : BaseApiController
    {
        [HttpGet("/error/{Code}")]
        public ActionResult Index(int Code)
        {
            return new ObjectResult(new ErrorClass(Code));
        }
    }
}
