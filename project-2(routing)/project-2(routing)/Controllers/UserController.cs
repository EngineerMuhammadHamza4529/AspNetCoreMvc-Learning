using Microsoft.AspNetCore.Mvc;

namespace project_2_routing_.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
