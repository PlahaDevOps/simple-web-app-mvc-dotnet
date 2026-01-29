using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAppMVC.Controllers
{
    [ApiController]
    public class HealthController : Controller
    {
        [HttpGet]
        [Route("health")]
        public IActionResult Get()
        {
            return Content("OK");
        }
    }
}
