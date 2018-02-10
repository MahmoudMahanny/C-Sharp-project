﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ITI_System;

namespace ITI_System
{
    class DataContext:DbContext
    {
        public DataContext() : base(@"Data Source=DESKTOP-C3NTTGB\M_MAHANNY;Initial Catalog=ITI_System;Integrated Security=True") { }
        //Managment
        public virtual DbSet<Instructor> Instructor { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Trainee> Trainee { get; set; }
        public virtual DbSet<Lab> Lab { get; set; }
        public virtual DbSet<InstructorCourseLab> InstructorCourseLab { get; set; }
        public virtual DbSet<EvaluationCriteria> EvaluationCriteria { get; set; }
        public virtual DbSet<TraineeEvaluation> TraineeEvaluation { get; set; }
        public virtual DbSet<Program> Program { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Intake> Intake { get; set; }
        public virtual DbSet<Track> Track { get; set; }


        //Attendance
        public virtual DbSet<Date> Date { get; set; }
        public virtual DbSet<Trainee_Date> Trainee_Date { get; set; }
        public virtual DbSet<Trainee_Trainee_Date> Trainee_Trainee_Date { get; set; }

        //Examination
        public virtual DbSet<Question> Question { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<TraineeAnswer> TraineeAnswer { get; set; }

    }
}