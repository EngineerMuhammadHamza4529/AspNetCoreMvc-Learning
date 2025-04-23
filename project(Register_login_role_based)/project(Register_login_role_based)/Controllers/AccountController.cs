using Microsoft.AspNetCore.Mvc;
using project_Register_login_role_based_.Data;
using project_Register_login_role_based_.Models;

namespace project_Register_login_role_based_.Controllers
{
    public class AccountController : Controller
    {

        private readonly AccountDbContext _context;

        public AccountController(AccountDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User u)
        {
            Console.WriteLine("Register POST method called!");

            if (ModelState.IsValid)
            {
                var checkEmail = _context.Users.FirstOrDefault(x => x.Email == u.Email);
                if (checkEmail != null)
                {
                    ViewBag.Error = "Email already registered.";
                    return View();
                }

                // Get current user's role from session
                var currentUserRole = HttpContext.Session.GetString("UserRole");

                // If not admin, force role to "User"
                if (currentUserRole != "Admin")
                {
                    u.Role = "User";
                }

                _context.Users.Add(u);
                _context.SaveChanges();

                TempData["Success"] = "Registration successful!";
                return RedirectToAction("Login");
            }

            ViewBag.Error = "Invalid data!";
            return View(u);
        }



        [HttpPost]
        public IActionResult Login(User u)
        {
            var myuser = _context.Users
                .FirstOrDefault(x => x.Email == u.Email && x.Password == u.Password);

            if (myuser != null)
            {
                HttpContext.Session.SetString("UserSession", myuser.Email);
                HttpContext.Session.SetString("UserRole", myuser.Role);
                TempData["Success"] = "Login Successful!";

                if (myuser.Role == "Admin")
                {
                    return RedirectToAction("AdminDashboard", "Admin");
                }
                else if (myuser.Role == "User")
                {
                    return RedirectToAction("UserDashboard", "User");
                }
                else
                {
                    return RedirectToAction("Dashboard");
                }
            }

            ViewBag.data = "Login Failed. Please check your email and password.";
            return View();
        }
    }
}
