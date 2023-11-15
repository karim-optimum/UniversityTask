using DataAccessLayer.Data;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace UniversityTask.Controllers
{
    public class AddingCoursesByTeacherController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AddingCoursesByTeacherController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //List<Course> courses = _context.Courses.ToList();
            List<Course> courses = new List<Course>
            {
                new Course { Name = "Mathematics"},
                new Course { Name = "Physics"},
                new Course { Name = "English Literature"},
                new Course { Name = "Computer Science"},
                new Course { Name = "History"}
            };
            return View(courses);
        }
        [HttpPost]
        public async Task<IActionResult> AddCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(course);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}
