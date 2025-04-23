using Microsoft.AspNetCore.Mvc;
using project_6_passingData_2_.Models;

namespace project_6_passingData_2_.Controllers
{
	public class StudentController : Controller
	{
		public IActionResult Index()
		{
			var students = new List<Student>
		{
			new Student { Id = 1, Name = "Azan", Age = 20 },
			new Student { Id = 2, Name = "Faham", Age = 22 },
			new Student { Id = 3, Name = "Sameer", Age = 19 }
		};
			return View(students);   // Passing data using a strongly typed model
		}
	}
}
