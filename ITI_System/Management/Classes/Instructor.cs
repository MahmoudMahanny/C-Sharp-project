using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
    public class Instructor
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        //public Phone phone { get; set; }
        //public Address Address { get; set; }
        public string Email { get; set; }
        public Account Account { get; set; }
        [Required]
        public bool IsManager { get; set; }

    }
}
