using ITI_System.Management;
using ITI_System.MonaForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace ITI_System
{
    /// <summary>
    /// Interaction logic for FrmCourses.xaml
    /// </summary>
    public partial class FrmCourses : Window
    {
        DataContext Context;
        CourseServices courseservice = new CourseServices();

        public object MessageBoxButtons { get; private set; }

        public FrmCourses()
        {
            InitializeComponent();
            CoursesListbox.DisplayMemberPath = "Name";
            CoursesListbox.SelectedValuePath = "ID";
            ReturnCourses();

        }

        //Function that returns courses to the listbox
        public void ReturnCourses()
        {
            Context = new DataContext();
            CoursesListbox.DisplayMemberPath = "Name";
            CoursesListbox.SelectedValuePath = "ID";
            var query = (from Course in Context.Course
                         select Course).ToList();
            CoursesListbox.ItemsSource = query;
        }

       
        //Add Button
        private void btnAddCourse_Click(object sender, RoutedEventArgs e)
        {
            FrmAddCourses F = new FrmAddCourses();
            //F.btnUpdateCourse.IsEnabled = false;
            F.btnUpdateCourse.Visibility = Visibility.Hidden;
            F.ShowDialog();
        }
        //Update Button
        private void btnUpdateCourse_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(CoursesListbox.SelectedValue.ToString());
            FrmAddCourses F = new FrmAddCourses(id);
            F.btnAddCourse.Visibility = Visibility.Hidden;
            F.ShowDialog();
        }

        //Delete Button  
        private void btnDeleteCourse_Click(object sender, RoutedEventArgs e)
        {
            courseservice.DeleteCourse(this);
            //DataContext context = new DataContext();
            //int id = int.Parse(CoursesListbox.SelectedValue.ToString());
            //var query = (from course in context.Course
            //             where course.ID == id
            //             select course).FirstOrDefault();
            //MessageBox.Show("Are You sure");
            //context.Course.Remove(query);
            //context.SaveChanges();
        }
        //Exit button
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }
        //when double clicked at item in the list open another form
        private void CoursesListbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int id = int.Parse(CoursesListbox.SelectedValue.ToString());
            FrmAddCourses F = new FrmAddCourses(id);
            F.btnAddCourse.Visibility = Visibility.Hidden;
            F.btnUpdateCourse.Visibility = Visibility.Hidden;
            F.btnClearCourse.Visibility = Visibility.Hidden;
            F.TxtCourseName.IsEnabled = false;
            F.TxtCourseDescription.IsEnabled = false;
            F.TxtCourseMinDeg.IsEnabled = false;
            F.TxtCourseMaxDeg.IsEnabled = false;
            F.ShowDialog();
        }
    }
}

