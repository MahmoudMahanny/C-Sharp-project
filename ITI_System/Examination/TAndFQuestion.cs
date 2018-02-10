using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
    [Table("TAndFQuestion")]
    class TAndFQuestion:Question
    {
        public bool IsTrue { get; set; }
    }
}
