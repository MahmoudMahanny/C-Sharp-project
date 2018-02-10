using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
    public class Trainee
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Qualification { get; set; }
        public string MilitaryStatus { get; set; }
        //public Address Address { get; set; }
        //public Phone Phone { get; set; }
        public Account Account { get; set; }
        
    }
}
