namespace ITI_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class management : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        AccountType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        MinDegree = c.Single(nullable: false),
                        MaxDegree = c.Single(nullable: false),
                        Track_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tracks", t => t.Track_ID)
                .Index(t => t.Track_ID);
            
            CreateTable(
                "dbo.Dates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ToDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EvaluationCriterias",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EvaluationType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ExamDate = c.DateTime(nullable: false),
                        Type = c.Byte(nullable: false),
                        StartTime = c.Time(nullable: false, precision: 7),
                        EndTime = c.Time(nullable: false, precision: 7),
                        TotalTime = c.Int(nullable: false),
                        ExamDegree = c.Double(nullable: false),
                        course_ID = c.Int(),
                        Instructor_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.course_ID)
                .ForeignKey("dbo.Instructors", t => t.Instructor_ID)
                .Index(t => t.course_ID)
                .Index(t => t.Instructor_ID);
            
            CreateTable(
                "dbo.Exam_Question",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        QuestionDegree = c.Double(nullable: false),
                        Exam_ID = c.Int(),
                        Question_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Exams", t => t.Exam_ID)
                .ForeignKey("dbo.Questions", t => t.Question_ID)
                .Index(t => t.Exam_ID)
                .Index(t => t.Question_ID);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        content = c.String(),
                        QuestionType = c.Byte(nullable: false),
                        course_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.course_ID)
                .Index(t => t.course_ID);
            
            CreateTable(
                "dbo.Choices",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Choice = c.String(),
                        IsTrue = c.Boolean(nullable: false),
                        ChoicesQuestion_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ChoicesQuestion", t => t.ChoicesQuestion_ID)
                .Index(t => t.ChoicesQuestion_ID);
            
            CreateTable(
                "dbo.Exam_Trainee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Student_Degree = c.Int(nullable: false),
                        Exam_ID = c.Int(),
                        Trainee_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Exams", t => t.Exam_ID)
                .ForeignKey("dbo.Trainees", t => t.Trainee_ID)
                .Index(t => t.Exam_ID)
                .Index(t => t.Trainee_ID);
            
            CreateTable(
                "dbo.Trainees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Gender = c.String(),
                        Qualification = c.String(),
                        MilitaryStatus = c.String(),
                        Account_ID = c.Int(),
                        Lab_ID = c.Int(),
                        Track_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.Account_ID)
                .ForeignKey("dbo.Labs", t => t.Lab_ID)
                .ForeignKey("dbo.Tracks", t => t.Track_ID)
                .Index(t => t.Account_ID)
                .Index(t => t.Lab_ID)
                .Index(t => t.Track_ID);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Gender = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        Email = c.String(),
                        IsManager = c.Boolean(nullable: false),
                        Account_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Accounts", t => t.Account_ID)
                .Index(t => t.Account_ID);
            
            CreateTable(
                "dbo.InstructorCourseLabs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InstID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                        LabID = c.Int(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Instructors", t => t.InstID, cascadeDelete: true)
                .ForeignKey("dbo.Labs", t => t.LabID, cascadeDelete: true)
                .Index(t => t.InstID)
                .Index(t => t.CourseID)
                .Index(t => t.LabID);
            
            CreateTable(
                "dbo.Labs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Intakes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Program_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Programs", t => t.Program_ID)
                .Index(t => t.Program_ID);
            
            CreateTable(
                "dbo.Tracks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Intake_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Intakes", t => t.Intake_ID)
                .Index(t => t.Intake_ID);
            
            CreateTable(
                "dbo.Programs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Trainee_Date",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Date_ID = c.Int(),
                        Trainee_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Dates", t => t.Date_ID)
                .ForeignKey("dbo.Trainees", t => t.Trainee_ID)
                .Index(t => t.Date_ID)
                .Index(t => t.Trainee_ID);
            
            CreateTable(
                "dbo.Trainee_Trainee_Date",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Alert_no = c.Int(nullable: false),
                        Excuce_no = c.Int(nullable: false),
                        Lost_Degrees = c.Int(nullable: false),
                        IsAttended = c.Boolean(nullable: false),
                        Trainee_ID = c.Int(),
                        Trainee_Date_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Trainees", t => t.Trainee_ID)
                .ForeignKey("dbo.Trainee_Date", t => t.Trainee_Date_ID)
                .Index(t => t.Trainee_ID)
                .Index(t => t.Trainee_Date_ID);
            
            CreateTable(
                "dbo.TraineeAnswers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Student_Question_Degree = c.Double(nullable: false),
                        Exam_Question_ID = c.Int(),
                        Trainee_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Exam_Question", t => t.Exam_Question_ID)
                .ForeignKey("dbo.Trainees", t => t.Trainee_ID)
                .Index(t => t.Exam_Question_ID)
                .Index(t => t.Trainee_ID);
            
            CreateTable(
                "dbo.Choices_Answer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Choice_ID = c.Int(),
                        M_choice_Question_Answer_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Choices", t => t.Choice_ID)
                .ForeignKey("dbo.Multiple_Choices_Question_Answer", t => t.M_choice_Question_Answer_ID)
                .Index(t => t.Choice_ID)
                .Index(t => t.M_choice_Question_Answer_ID);
            
            CreateTable(
                "dbo.TraineeEvaluations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TotalDegree = c.Single(nullable: false),
                        Course_ID = c.Int(),
                        EvaluationCriteria_ID = c.Int(),
                        Trainee_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.Course_ID)
                .ForeignKey("dbo.EvaluationCriterias", t => t.EvaluationCriteria_ID)
                .ForeignKey("dbo.Trainees", t => t.Trainee_ID)
                .Index(t => t.Course_ID)
                .Index(t => t.EvaluationCriteria_ID)
                .Index(t => t.Trainee_ID);
            
            CreateTable(
                "dbo.ChoicesQuestion",
                c => new
                    {
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Questions", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.TAndFQuestion",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        IsTrue = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Questions", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.TextQuestion",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        correctAnswer = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Questions", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Multiple_Choices_Question_Answer",
                c => new
                    {
                        ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TraineeAnswers", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.T_And_F_Question_Answer",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Answer = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TraineeAnswers", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Text_Question_Answer",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Answer = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TraineeAnswers", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Text_Question_Answer", "ID", "dbo.TraineeAnswers");
            DropForeignKey("dbo.T_And_F_Question_Answer", "ID", "dbo.TraineeAnswers");
            DropForeignKey("dbo.Multiple_Choices_Question_Answer", "ID", "dbo.TraineeAnswers");
            DropForeignKey("dbo.TextQuestion", "ID", "dbo.Questions");
            DropForeignKey("dbo.TAndFQuestion", "ID", "dbo.Questions");
            DropForeignKey("dbo.ChoicesQuestion", "ID", "dbo.Questions");
            DropForeignKey("dbo.TraineeEvaluations", "Trainee_ID", "dbo.Trainees");
            DropForeignKey("dbo.TraineeEvaluations", "EvaluationCriteria_ID", "dbo.EvaluationCriterias");
            DropForeignKey("dbo.TraineeEvaluations", "Course_ID", "dbo.Courses");
            DropForeignKey("dbo.Choices_Answer", "M_choice_Question_Answer_ID", "dbo.Multiple_Choices_Question_Answer");
            DropForeignKey("dbo.Choices_Answer", "Choice_ID", "dbo.Choices");
            DropForeignKey("dbo.TraineeAnswers", "Trainee_ID", "dbo.Trainees");
            DropForeignKey("dbo.TraineeAnswers", "Exam_Question_ID", "dbo.Exam_Question");
            DropForeignKey("dbo.Trainee_Trainee_Date", "Trainee_Date_ID", "dbo.Trainee_Date");
            DropForeignKey("dbo.Trainee_Trainee_Date", "Trainee_ID", "dbo.Trainees");
            DropForeignKey("dbo.Trainee_Date", "Trainee_ID", "dbo.Trainees");
            DropForeignKey("dbo.Trainee_Date", "Date_ID", "dbo.Dates");
            DropForeignKey("dbo.Intakes", "Program_ID", "dbo.Programs");
            DropForeignKey("dbo.Tracks", "Intake_ID", "dbo.Intakes");
            DropForeignKey("dbo.Trainees", "Track_ID", "dbo.Tracks");
            DropForeignKey("dbo.Courses", "Track_ID", "dbo.Tracks");
            DropForeignKey("dbo.InstructorCourseLabs", "LabID", "dbo.Labs");
            DropForeignKey("dbo.Trainees", "Lab_ID", "dbo.Labs");
            DropForeignKey("dbo.InstructorCourseLabs", "InstID", "dbo.Instructors");
            DropForeignKey("dbo.InstructorCourseLabs", "CourseID", "dbo.Courses");
            DropForeignKey("dbo.Exams", "Instructor_ID", "dbo.Instructors");
            DropForeignKey("dbo.Instructors", "Account_ID", "dbo.Accounts");
            DropForeignKey("dbo.Exam_Trainee", "Trainee_ID", "dbo.Trainees");
            DropForeignKey("dbo.Trainees", "Account_ID", "dbo.Accounts");
            DropForeignKey("dbo.Exam_Trainee", "Exam_ID", "dbo.Exams");
            DropForeignKey("dbo.Exam_Question", "Question_ID", "dbo.Questions");
            DropForeignKey("dbo.Choices", "ChoicesQuestion_ID", "dbo.ChoicesQuestion");
            DropForeignKey("dbo.Questions", "course_ID", "dbo.Courses");
            DropForeignKey("dbo.Exam_Question", "Exam_ID", "dbo.Exams");
            DropForeignKey("dbo.Exams", "course_ID", "dbo.Courses");
            DropIndex("dbo.Text_Question_Answer", new[] { "ID" });
            DropIndex("dbo.T_And_F_Question_Answer", new[] { "ID" });
            DropIndex("dbo.Multiple_Choices_Question_Answer", new[] { "ID" });
            DropIndex("dbo.TextQuestion", new[] { "ID" });
            DropIndex("dbo.TAndFQuestion", new[] { "ID" });
            DropIndex("dbo.ChoicesQuestion", new[] { "ID" });
            DropIndex("dbo.TraineeEvaluations", new[] { "Trainee_ID" });
            DropIndex("dbo.TraineeEvaluations", new[] { "EvaluationCriteria_ID" });
            DropIndex("dbo.TraineeEvaluations", new[] { "Course_ID" });
            DropIndex("dbo.Choices_Answer", new[] { "M_choice_Question_Answer_ID" });
            DropIndex("dbo.Choices_Answer", new[] { "Choice_ID" });
            DropIndex("dbo.TraineeAnswers", new[] { "Trainee_ID" });
            DropIndex("dbo.TraineeAnswers", new[] { "Exam_Question_ID" });
            DropIndex("dbo.Trainee_Trainee_Date", new[] { "Trainee_Date_ID" });
            DropIndex("dbo.Trainee_Trainee_Date", new[] { "Trainee_ID" });
            DropIndex("dbo.Trainee_Date", new[] { "Trainee_ID" });
            DropIndex("dbo.Trainee_Date", new[] { "Date_ID" });
            DropIndex("dbo.Tracks", new[] { "Intake_ID" });
            DropIndex("dbo.Intakes", new[] { "Program_ID" });
            DropIndex("dbo.InstructorCourseLabs", new[] { "LabID" });
            DropIndex("dbo.InstructorCourseLabs", new[] { "CourseID" });
            DropIndex("dbo.InstructorCourseLabs", new[] { "InstID" });
            DropIndex("dbo.Instructors", new[] { "Account_ID" });
            DropIndex("dbo.Trainees", new[] { "Track_ID" });
            DropIndex("dbo.Trainees", new[] { "Lab_ID" });
            DropIndex("dbo.Trainees", new[] { "Account_ID" });
            DropIndex("dbo.Exam_Trainee", new[] { "Trainee_ID" });
            DropIndex("dbo.Exam_Trainee", new[] { "Exam_ID" });
            DropIndex("dbo.Choices", new[] { "ChoicesQuestion_ID" });
            DropIndex("dbo.Questions", new[] { "course_ID" });
            DropIndex("dbo.Exam_Question", new[] { "Question_ID" });
            DropIndex("dbo.Exam_Question", new[] { "Exam_ID" });
            DropIndex("dbo.Exams", new[] { "Instructor_ID" });
            DropIndex("dbo.Exams", new[] { "course_ID" });
            DropIndex("dbo.Courses", new[] { "Track_ID" });
            DropTable("dbo.Text_Question_Answer");
            DropTable("dbo.T_And_F_Question_Answer");
            DropTable("dbo.Multiple_Choices_Question_Answer");
            DropTable("dbo.TextQuestion");
            DropTable("dbo.TAndFQuestion");
            DropTable("dbo.ChoicesQuestion");
            DropTable("dbo.TraineeEvaluations");
            DropTable("dbo.Choices_Answer");
            DropTable("dbo.TraineeAnswers");
            DropTable("dbo.Trainee_Trainee_Date");
            DropTable("dbo.Trainee_Date");
            DropTable("dbo.Programs");
            DropTable("dbo.Tracks");
            DropTable("dbo.Intakes");
            DropTable("dbo.Labs");
            DropTable("dbo.InstructorCourseLabs");
            DropTable("dbo.Instructors");
            DropTable("dbo.Trainees");
            DropTable("dbo.Exam_Trainee");
            DropTable("dbo.Choices");
            DropTable("dbo.Questions");
            DropTable("dbo.Exam_Question");
            DropTable("dbo.Exams");
            DropTable("dbo.EvaluationCriterias");
            DropTable("dbo.Dates");
            DropTable("dbo.Courses");
            DropTable("dbo.Accounts");
        }
    }
}
