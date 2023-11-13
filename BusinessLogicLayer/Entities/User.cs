using EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class User : EntityBase
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public UserTypeEnum UserType { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<TeacherCourse> TeacherCourses { get; set; }
        public University University { get; set; }
        public int UniversityId { get; set; }
    }
}