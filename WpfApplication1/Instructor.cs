using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
   public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        //public Phone phone { get; set; }
        //public Address Address { get; set; }
        public string Email { get; set; }
        public Account Account { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Trainee> Students { get; set; }


    }
}
