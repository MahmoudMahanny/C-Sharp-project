using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
    [Table("Choices")]
    class Choices
    {
        public int ID { get; set; }
        public string Choice { get; set; }
        public bool IsTrue { get; set; }
        public virtual ChoicesQuestion ChoicesQuestion { get; set; }
    }
}
