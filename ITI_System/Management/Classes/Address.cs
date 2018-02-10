using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
    [ComplexType]
    public class Address
    {
        public string City { get; set; }
        public string Gov { get; set; }
        public string street { get; set; }
    }
}
