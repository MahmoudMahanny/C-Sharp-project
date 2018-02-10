using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
    [Table("Multiple_Choices_Question_Answer")]
    class Multiple_Choices_Question_Answer:TraineeAnswer
    {
        public virtual ICollection<Choices_Answer> Choices_Answer { get; set; }
        public Multiple_Choices_Question_Answer()
        {
            Choices_Answer = new List<Choices_Answer>();
        }
    }
}