
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
    public class InstructorCourseLab
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Instructor Instructor { get; set; }
        public Lab Lab { get; set; }
        public Course Course { get; set; }

    }
}
