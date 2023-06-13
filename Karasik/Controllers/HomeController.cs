using Microsoft.AspNetCore.Mvc;

namespace Karasik.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("_Layout");
        }
    }
}
