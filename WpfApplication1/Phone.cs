using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    [ComplexType]
    public class Phone
    {
        public string Ext { get; set; }
        //public int? Number { get; set; }

    }
    [ComplexType]
    public class Address
    {
        public string Gov { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
