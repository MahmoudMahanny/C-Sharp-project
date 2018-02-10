using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
    [Table("ChoicesQuestion")]

    class ChoicesQuestion : Question
    {
        public virtual ICollection<Choices> Choices { get; set; }
        public ChoicesQuestion()
        {

            Choices = new List<Choices>();
        }
    }
}
