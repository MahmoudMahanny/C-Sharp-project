using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
     class Exam_Question
    {
        public int ID { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual Question Question { get; set; }
        public double QuestionDegree { get; set; }
    }
}
