using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
   public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float MinDegree { get; set; }
        public float MaxDegree { get; set; }
        public String Description { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<Trainee> Students { get; set; }

    }
}
