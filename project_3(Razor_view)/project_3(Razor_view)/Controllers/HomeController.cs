using Microsoft.AspNetCore.Mvc;

namespace project_3_Razor_view_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
