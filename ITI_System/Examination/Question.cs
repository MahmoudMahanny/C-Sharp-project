using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
      enum QuestionTypes:Byte
        {
            M_Choice,
            TAndF,
            Text
        }
    class Question
    {
        public int ID { get; set; }
        public string content { get; set; }
        public QuestionTypes QuestionType { get; set; }
        public Course course { get; set; }
    }
}