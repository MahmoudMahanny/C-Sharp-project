using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
    [ComplexType]
    public class Phone
    {
        public string Ext { get; set; }
        public int? Number { get; set; }
    }
}
