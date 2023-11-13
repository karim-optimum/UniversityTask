using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class TeacherCourse : EntityBase
    {
        public User Teacher { get; set; }
        public int TeacherId { get; set; }

        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
