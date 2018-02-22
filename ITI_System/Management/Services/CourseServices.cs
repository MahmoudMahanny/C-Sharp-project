using ITI_System.MonaForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ITI_System.Management
{
   public class CourseServices
    {
        DataContext Context = new DataContext();
        // FrmCourses FrmCourses = new FrmCourses();
       // FrmAddCourses FrmAddCourses;

        public void updatecourse (FrmAddCourses F)
        {
            int id = int.Parse(F.TxtCourseID.Text.ToString());
            var Course = (from cours in Context.Course
                          where cours.ID == id
                          select cours).FirstOrDefault();

           Course.Name =F.TxtCourseName.Text;
           Course.Description =F.TxtCourseDescription.Text;
           Course.MinDegree = float.Parse(F.TxtCourseMinDeg.Text);
           Course.MaxDegree = float.Parse(F.TxtCourseMaxDeg.Text);
           Context.SaveChanges();
           MessageBox.Show("updated successfully");
          
        }

        public void Addcourse(FrmAddCourses F)
        {
            Context = new DataContext();
            Course course = new Course();
            course.Name = F.TxtCourseName.Text;
            course.Description =F.TxtCourseDescription.Text;
            course.MinDegree =float.Parse(F.TxtCourseMinDeg.Text);
            course.MaxDegree = float.Parse(F.TxtCourseMaxDeg.Text);
            Context.Course.Add(course);
            Context.SaveChanges();
            MessageBox.Show("added successfully");

        }
        public void ClearCourse(FrmAddCourses F)
        {
            F.TxtCourseID.Text = "";
            F.TxtCourseName.Text = "";
            F.TxtCourseDescription.Text = "";
            F.TxtCourseMinDeg.Text = "";
            F.TxtCourseMaxDeg.Text = "";
        }
        
        public void DeleteCourse(FrmCourses F)
        {

            int id = int.Parse(F.CoursesListbox.SelectedValue.ToString());
            var query = (from course in Context.Course
                         where course.ID == id
                         select course).FirstOrDefault();
            MessageBox.Show("Are You sure");
            Context.Course.Remove(query);
            Context.SaveChanges();
        }
    }
}
