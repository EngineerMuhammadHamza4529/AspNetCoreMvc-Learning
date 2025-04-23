using Microsoft.AspNetCore.Mvc;

namespace project_2_routing_.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Home")]
        //[Route("Home/Index")]
        [Route("~/")]
        public IActionResult Index()
        {

            return View();
        }

        [Route("Home/About")]
        public IActionResult About()
        {

            return View();
        }

        [Route("Home/Details/{id?}")]
        public int Details(int? id)
        {

            return id ?? 1;
        }
    }
}
