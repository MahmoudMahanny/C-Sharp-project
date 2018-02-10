using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
     class TraineeAnswer
    {
        public int ID { get; set; }
        public Exam_Question Exam_Question { get; set; }
        public Trainee Trainee { get; set; }
        public double Student_Question_Degree { get; set; }
    }
}
