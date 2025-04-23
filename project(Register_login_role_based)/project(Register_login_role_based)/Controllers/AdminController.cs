using Microsoft.AspNetCore.Mvc;

namespace project_Register_login_role_based_.Controllers
{
    public class AdminController : Controller
    {
       
        public IActionResult AdminDashboard()
        {
            if (HttpContext.Session.GetString("UserRole") == "Admin")
            {
                ViewBag.Email = HttpContext.Session.GetString("UserSession");
                return View();
            }
            return RedirectToAction("Login");
        }

        

        
    }
}
