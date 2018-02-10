using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
    class Exam_Trainee
    {
        public int ID { get; set; }
        public virtual Trainee Trainee { get; set; }
        public virtual Exam Exam { get; set; }
        public int Student_Degree { get; set; }
    }
}
