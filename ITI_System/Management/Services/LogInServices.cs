using ITI_System.Management.Forms;
using ITI_System.Management.OtherForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ITI_System.Management.Services
{
    class LogInServices
    {
        DataContext context = new DataContext();
        public void Clear(FrmLogIN frm)
        {
            frm.txtUserName.Text = "";
            frm.txtpasswordBox.Password = "";
        }
        public void LogIN(FrmLogIN frmLog)
        {
            var userName = frmLog.txtUserName.Text;
            var password = frmLog.txtpasswordBox.Password;
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
                Clear(frmLog);
                MessageBox.Show("Invlaid Username or Password");
            }
            else if (flag == true && AccountType == "Manager")
            {
                FrmManager frm = new FrmManager();
                Clear(frmLog);
                frm.ShowDialog();
            }
            else if (flag == true && AccountType == "Trainee")
            {
                FrmTrainee T = new FrmTrainee();
                //Clear();
                T.ShowDialog();
            }
            else if (flag == true && AccountType == "Instructor")
            {
                frmInstructor i = new frmInstructor();
                Clear(frmLog);
                i.ShowDialog();
            }
            else if (flag == true && AccountType == "Attendance")
            {
                frmAttendanceEmp A = new frmAttendanceEmp();
                Clear(frmLog);
                A.ShowDialog();
            }
        }
    }
}
