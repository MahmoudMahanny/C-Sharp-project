using ITI_System.Management.Forms;
using ITI_System.Management.OtherForms;
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
    /// Interaction logic for FrmLogIN.xaml
    /// </summary>
    public partial class FrmLogIN : Window
    {
        DataContext context = new DataContext();
        public FrmLogIN()
        {
            InitializeComponent();
            //Account a = new Account() { UserName = "admin", Password = "admin", AccountType = "Manager" };
            //context.Account.Add(a);
            //context.SaveChanges();
        }
        
        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Clear()
        {
            txtUserName.Text = "";
            txtpasswordBox.Password = "";
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            var userName = txtUserName.Text;
            var password = txtpasswordBox.Password;
            var AccountType = "";
            bool flag = false;
            foreach (var account in context.Account)
            {
                if (userName == account.UserName && password == account.Password)
                {
                    flag = true;
                    AccountType = account.AccountType;
                    break;
                }
            }

            if (flag == false)
            {
                Clear();
                MessageBox.Show("Invlaid Username or Password");
            }
            else if(flag == true && AccountType == "Manager")
            {
                FrmManager frm = new FrmManager();
                Clear();
                frm.ShowDialog();
            }
            else if (flag == true && AccountType == "Trainee")
            {
                FrmTrainee T = new FrmTrainee();
                Clear();
                T.ShowDialog();
            }
            else if (flag == true && AccountType == "Instructor")
            {
                frmInstructor i = new frmInstructor();
                Clear();
                i.ShowDialog();
            }
            else if (flag == true && AccountType == "Attendance")
            {
                frmAttendanceEmp A = new frmAttendanceEmp();
                Clear();
                A.ShowDialog();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}