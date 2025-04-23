using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using project_LogInandRegister_.Data;
using project_LogInandRegister_.Models;


namespace project_LogInandRegister_.Controllers
{
    public class AccountController : Controller
    {
        private readonly EcommerceDbContext _context;

        public AccountController(EcommerceDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Login(User u)
        {
            var myuser = _context.Users.FirstOrDefault(x => x.Email == u.Email && x.Password == u.Password);
            if (myuser != null)
            {
                HttpContext.Session.SetString("UserSession", myuser.Email);
                TempData["Success"] = "Login Successful!";
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.data = "Login Failed. Please check your email and password.";
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); // Clear session
            return RedirectToAction("Login"); // Redirect to login page
        }

        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                ViewBag.mysession = HttpContext.Session.GetString("UserSession").ToString();
                ViewBag.data = _context.Users.ToList();
            }
            else
            {
                return RedirectToAction("Login");
            }
            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User u)
        {
            if (ModelState.IsValid)
            {
                // Hash the password before saving
                // (with Hashing password)
                //u.Password = BCrypt.Net.BCrypt.HashPassword(u.Password);
                await _context.Users.AddAsync(u);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Registered Successfully!";
                return RedirectToAction("Login");
            }
            return View();
        }

    }
}
