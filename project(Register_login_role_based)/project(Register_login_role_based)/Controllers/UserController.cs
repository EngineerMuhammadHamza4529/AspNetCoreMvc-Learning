using Microsoft.AspNetCore.Mvc;

namespace project_Register_login_role_based_.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UserDashboard()
        {
            if (HttpContext.Session.GetString("UserRole") == "User")
            {
                ViewBag.Email = HttpContext.Session.GetString("UserSession");
                return View();
            }
            return RedirectToAction("Login");
        }
    }
}
