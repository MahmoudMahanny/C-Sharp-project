using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{   enum ExamType:Byte
    {
        FirstTime,
        Corrective
    }
    class Exam
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ExamDate { get; set; }
        public ExamType Type { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int TotalTime { get; set; }
        public double ExamDegree { get; set; }
        public virtual Course course { get; set; }
        public virtual Instructor Instructor { get; set; }
        public virtual ICollection<Exam_Question>Exam_Question { get; set; }
        public virtual ICollection<Exam_Trainee> Exam_Trainee { set; get; }
        public Exam()
        {
            Exam_Question = new List<Exam_Question>();
            Exam_Trainee = new List<Exam_Trainee>();
        }
    }
}
