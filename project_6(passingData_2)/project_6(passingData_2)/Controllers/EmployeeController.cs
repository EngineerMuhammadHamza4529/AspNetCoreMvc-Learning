using Microsoft.AspNetCore.Mvc;

namespace project_6_passingData_2_.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["data1"] = "view data";
            ViewBag.data2 = "view bag"; 
            TempData["data3"] = "Temp data";
            TempData.Keep("data3");
            return View();
        }

        public IActionResult About()
        {
   
         
            return View();
        }

        public IActionResult Contact()
        {
          
            TempData.Keep("data3");

            return View();
        }
    }
}
