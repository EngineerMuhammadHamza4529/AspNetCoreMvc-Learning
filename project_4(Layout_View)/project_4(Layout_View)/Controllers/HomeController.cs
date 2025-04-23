using Microsoft.AspNetCore.Mvc;

namespace project_4_Layout_View_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
    }
}
