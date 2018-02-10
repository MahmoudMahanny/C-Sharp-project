using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI_System;

namespace ITI_System
{
    public class Trainee_Trainee_Date
    {
        public int ID { get; set; }
        public int Alert_no { get; set; }
        public int Excuce_no { get; set; }
        public int Lost_Degrees { get; set; }
        public Trainee Trainee { get; set; }
        public Trainee_Date Trainee_Date { get; set; }
        public bool IsAttended { get; set; }
    }
}
