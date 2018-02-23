using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

            //var query = (from Inss in context.Instructor
            //             select Inss).ToList();

            //DG1.ItemsSource = query;
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RFITCSA\MSSQLSERVER01;Initial Catalog=ITI_System;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("SELECT * from InstructorCourseLabs", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DG1.ItemsSource = dt.DefaultView;
            }
        }

        private void CBInstructor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddInsCrsLab_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RFITCSA\MSSQLSERVER01; Initial Catalog=ITI_System; Integrated Security=True"))
            {
                try
                {
                    using (var cmd = new SqlCommand("INSERT INTO InstructorCourseLab (InstID,CourseID,LabID) VALUES (@InstID,@CourseID,@LabID)"))
                    {
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@InstID", (int.Parse(CBInstructor.SelectedValue.ToString())));
                        cmd.Parameters.AddWithValue("@CourseID", (int.Parse(CBCourse.SelectedValue.ToString())));
                        cmd.Parameters.AddWithValue("@LabID", (int.Parse(CBLab.SelectedValue.ToString())));
                        con.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Done");
                        }
                        else
                        {
                            MessageBox.Show("No");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           

        }
    }
}
