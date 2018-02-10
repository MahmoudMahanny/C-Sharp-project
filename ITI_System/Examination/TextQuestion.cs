using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
    [Table("TextQuestion")]
    class TextQuestion:Question
    {
        public string correctAnswer { get; set; }
    }
}
