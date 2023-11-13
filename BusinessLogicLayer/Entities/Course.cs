using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Course : EntityBase
    {
        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<TeacherCourse> TeacherCourses { get; set; }
    }
}
