using Microsoft.AspNetCore.Mvc;
using project_6_passingData_2_.Models;

namespace project_6_passingData_2_.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ViewDataExample()
        {
            ViewData["Message"] = "Welcome to the Student Management System!";
            ViewData["StudentList"] = new List<Student>
        {
            new Student { Id = 1, Name = "John Doe", Age = 20 },
            new Student { Id = 2, Name = "Jane Smith", Age = 22 }
        };

            return View();
        }


        public IActionResult ViewBagExample()
        {
            ViewBag.Title = "Student Details";
            ViewBag.Student = new Student { Id = 1, Name = "Michael Johnson", Age = 21 };

            return View();
        }

        public IActionResult SetTempData()
        {
            TempData["Message"] = "Student details saved successfully!";
            return RedirectToAction("TempDataExample");
        }


        public IActionResult TempDataExample()
        {
            return View();
        }

    }
}
