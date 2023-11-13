using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Course : EntityBase
    {
        public int UniversityId { get; set; }
        public ICollection<UserCourse> UserCourses { get; set; }
        public University University { get; set; }
    }
}
