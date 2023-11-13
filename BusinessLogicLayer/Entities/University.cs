using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class University : EntityBase
    {
        public string Location { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
