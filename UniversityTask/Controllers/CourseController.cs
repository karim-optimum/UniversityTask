using DataAccessLayer.Data;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UniversityTask.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CourseController(ApplicationDbContext context)
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
    }
}
