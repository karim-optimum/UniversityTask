using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class StudentCourse : EntityBase
    {
        public User Student { get; set; }
        public int StudentId { get; set; }

        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
