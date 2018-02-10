using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
    [Table("Text_Question_Answer")]
    class Text_Question_Answer: TraineeAnswer
    {
        public string Answer { get; set; }
    }
}
