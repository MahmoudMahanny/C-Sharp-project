using ITI_System.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ITI_System.MonaForms
{
    /// <summary>
    /// Interaction logic for FrmAddCourses.xaml
    /// </summary>
    public partial class FrmAddCourses : Window
    {
        CourseServices courseservice = new CourseServices();
        DataContext Context = new DataContext();
        public FrmAddCourses()
        {
            InitializeComponent();
        }

        public FrmAddCourses(int id)
        {
            InitializeComponent();
            Course query = (from course in Context.Course
                                where course.ID == id
                               select course).FirstOrDefault();
            TxtCourseID.Text = query.ID.ToString();
            TxtCourseName.Text = query.Name;
            TxtCourseDescription.Text = query.Description.ToString();
            TxtCourseMinDeg.Text = query.MinDegree.ToString();
            TxtCourseMaxDeg.Text = query.MaxDegree.ToString();
        }
        //Update button (Update course in the database)
        private void btnUpdateCourse_Click(object sender, RoutedEventArgs e)
        {
            courseservice.updatecourse(this);
 
            // Context = new DataContext();
           // int id= int.Parse(TxtCourseID.Text.ToString());
            //var Course = (from course in Context.Course
            //              where course.ID == id
            //              select course).FirstOrDefault();

            // Course.Name = TxtCourseName.Text;
            // Course.Description = TxtCourseDescription.Text;
            // Course.MinDegree = float.Parse(TxtCourseMinDeg.Text);
            // Course.MaxDegree = float.Parse(TxtCourseMaxDeg.Text);
            // Context.SaveChanges();
            // MessageBox.Show("updated successfully");
            // Context.SaveChanges();                     
       
        }

        //Add Button (ADD course in the Database)
        private void btnAddCourse_Click(object sender, RoutedEventArgs e)
        {
            courseservice.Addcourse(this);
            //Context = new DataContext();
            //Course course = new Course();
            //course.Name = TxtCourseName.Text;
            //course.Description = TxtCourseDescription.Text;
            //course.MinDegree =float.Parse(TxtCourseMinDeg.Text);
            //course.MaxDegree = float.Parse(TxtCourseMaxDeg.Text);
            //Context.Course.Add(course);
            //Context.SaveChanges();
        }

        private void TxtCourseMaxDeg_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //Exit Button
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Clear Button
        private void btnClearCourse_Click(object sender, RoutedEventArgs e)
        {
            courseservice.ClearCourse(this);
            //TxtCourseID.Text = "";
            //TxtCourseName.Text = "";
            //TxtCourseDescription.Text = "";
            //TxtCourseMinDeg.Text = "";
            //TxtCourseMaxDeg.Text = "";
        }
    }
}
