using Microsoft.AspNetCore.Mvc;
using UniversityTask.Services;

namespace UniversityTask.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserService _service;

        public AccountController(UserService service)
        {
            _service = service;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ModelState.AddModelError("", "Email and password are required.");
                return View();
            }
            if (email == "user@example.com" && password == "123456")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Invalid email or password.");
                return View();
            }
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ModelState.AddModelError("", "Email and password are required.");
                return View();
            }
            if (email == "user@example.com")
            {
                ModelState.AddModelError("", "User with the same email already exists.");
                return View();
            }

            // User creation successful, redirect to login action
            _service.CreateUserAsync(email, password);
            return RedirectToAction("Login", "Account");
        }
    }
}