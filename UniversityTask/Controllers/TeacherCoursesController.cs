using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace UniversityTask.Controllers
{
    public class TeacherCoursesController : Controller
    {
        public IActionResult Index()
        {
            //List<Course> courses = _context.Courses.ToList();
            List<TeacherCourse> teacherCourses = new List<TeacherCourse>
            {
                new TeacherCourse { Name = "Mathematics"},
                new TeacherCourse { Name = "Physics"},
                new TeacherCourse { Name = "English Literature"},
                new TeacherCourse { Name = "Computer Science"},
                new TeacherCourse { Name = "History"}
            };
            return View(teacherCourses);
        }
    }
}
