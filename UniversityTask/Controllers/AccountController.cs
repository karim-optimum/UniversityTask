using DataAccessLayer.Data;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UniversityTask.Services;

namespace UniversityTask.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserService _service;
        private readonly ApplicationDbContext _context;

        public AccountController(UserService service, ApplicationDbContext context)
        {
            _service = service;
            _context = context;
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
            var findingUserEmail = _context.Users.FirstOrDefault(x => x.Email == email);
            var findingUserPasswprd = _context.Users.FirstOrDefault(x => x.Password == password);

            if (findingUserEmail != null && findingUserPasswprd != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Invalid email or password.");
                return View();
            }
        }

        public async Task<IActionResult> Signup()
        {

            var universities = await _context.Universities.ToListAsync();
            ViewBag.Universities = universities;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(string email, string password, int universityId)
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
            
            await _service.CreateUserAsync(email, password,universityId);
            return RedirectToAction("Login", "Account");
        }
    }
}