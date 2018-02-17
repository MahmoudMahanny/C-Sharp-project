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

namespace ITI_System.Management.Forms
{
    /// <summary>
    /// Interaction logic for InstructorCourseLab.xaml
    /// </summary>
    public partial class InstructorCourseLab : Window
    {
        DataContext context = new DataContext();
        public InstructorCourseLab()
        {
            InitializeComponent();
            CBInstructor.SelectedValuePath = "ID";
            CBInstructor.DisplayMemberPath = "Name";
            var instructor = (from Ins in context.Instructor
                         select Ins);
            foreach (var item in instructor)
            {
                CBInstructor.Items.Add(item);
            }

            CBCourse.SelectedValuePath = "ID";
            CBCourse.DisplayMemberPath = "Name";
            var course = (from crs in context.Course
                         select crs);
            foreach (var item in course)
            {
                CBCourse.Items.Add(item);
            }

            CBLab.SelectedValuePath = "ID";
            CBLab.DisplayMemberPath = "Name";
            var lab = (from lb in context.Lab
                          select lb);
            foreach (var item in lab)
            {
                CBLab.Items.Add(item);
            }

            var query = (from Inss in context.Instructor
                         select Inss).ToList();
               
            DG1.ItemsSource = query;
        }

        private void CBInstructor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddInsCrsLab_Click(object sender, RoutedEventArgs e)
        {
            var query = (from icl in context.InstructorCourseLab
                        select icl).FirstOrDefault();
            InstructorCourseLab icl2 = new InstructorCourseLab();
            //icl2.Name = CBInstructor.SelectedValue.ToString();
            //string abc = CBInstructor.SelectedValue.ToString();
            //query.ID = int.Parse(CBInstructor.SelectedValue.ToString());
            //context.InstructorCourseLab.Add(query);
            //context.InstructorCourseLab.Add(icl2);
            //context.SaveChanges();
            //query.Instructor =/*(Instructor)*/CBInstructor.SelectedIndex.ToString();


        }
    }
}
