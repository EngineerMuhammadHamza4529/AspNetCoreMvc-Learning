using Microsoft.AspNetCore.Mvc;

namespace project_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            
            return View();
        }

        public IActionResult about()
        {
            return View();
        }

        public IActionResult contact()
        {
            return View();
        }
    }
}
