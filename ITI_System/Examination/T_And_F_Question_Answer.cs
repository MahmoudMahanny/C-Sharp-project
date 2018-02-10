using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{ [Table("T_And_F_Question_Answer")]
    class T_And_F_Question_Answer:TraineeAnswer
    {
        public bool Answer { get; set; }
    }
}
