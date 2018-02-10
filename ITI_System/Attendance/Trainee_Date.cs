using ITI_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
    public class Trainee_Date
    {
        public int ID { get; set; }
        public virtual Trainee Trainee { get; set; }
        public virtual Date Date { get; set; }

    }
}
