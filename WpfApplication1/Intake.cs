using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Intake
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Track> Track { get; set; }
    }
}
