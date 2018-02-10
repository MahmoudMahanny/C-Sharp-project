using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
    public class TraineeEvaluation
    {
        public int ID { get; set; }
        public Course Course { get; set; }
        public EvaluationCriteria EvaluationCriteria { get; set; }
        public Trainee Trainee { get; set; }
        public float TotalDegree { get; set; }
    }
}
