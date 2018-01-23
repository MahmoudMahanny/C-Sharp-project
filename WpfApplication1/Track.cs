using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Track
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string TrackType { get; set; }
        public Intake Intake { get; set; }

        public virtual ICollection<Trainee> Trainee { get; set; }

    }
}
