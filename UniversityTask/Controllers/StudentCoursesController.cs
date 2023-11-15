using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UniversityTask.Controllers
{
    public class StudentCoursesController : Controller
    {
        public IActionResult Index()
        {
            //List<Course> courses = _context.Courses.ToList();
            List<StudentCourse> studentCourses = new List<StudentCourse>
            {
                new StudentCourse { Name = "Mathematics"},
                new StudentCourse { Name = "Physics"},
                new StudentCourse { Name = "English Literature"},
                new StudentCourse { Name = "Computer Science"},
                new StudentCourse { Name = "History"}
            };
            return View(studentCourses);
        }
    }
}
