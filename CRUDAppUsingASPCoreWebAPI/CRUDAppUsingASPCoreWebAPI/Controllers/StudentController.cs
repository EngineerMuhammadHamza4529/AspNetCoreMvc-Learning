using CRUDAppUsingASPCoreWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace CRUDAppUsingASPCoreWebAPI.Controllers
{
    public class StudentController : Controller
    {
        private string url = "https://localhost:7090/api/StudentAPI";
        private HttpClient client = new HttpClient();

        [HttpGet]

        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            HttpResponseMessage response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                students = JsonConvert.DeserializeObject<List<Student>>(result);
            }

            return View(students);
        }

        [HttpGet]
        public IActionResult Create() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            s.id = 1;
            string data = JsonConvert.SerializeObject(s);
            StringContent content = new StringContent(data , Encoding.UTF8 , "application/json");
            HttpResponseMessage response = client.PostAsync(url , content).Result;
            if (response.IsSuccessStatusCode)
            {
                TempData["Insert_Message"] = "Student Added Successfuly !!😊";
                return RedirectToAction("Index");
            }
            return View();
        }



    }
}
