using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
    [Table("Choices_Answer")]
    class Choices_Answer
    {
        public int ID { get; set; }
        public Choices Choice { get; set; }
        public Multiple_Choices_Question_Answer M_choice_Question_Answer  { get; set; }
    }
}
