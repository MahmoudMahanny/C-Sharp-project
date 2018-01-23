using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
  public class Trainee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //public Address Address { get; set; }
        //public Phone phone { get; set; }
        public string Gender { get; set; }
        public string Qualification { get; set; }
        public string MilitaryStatus { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<Course> Courses { get; set; }



    }
}
