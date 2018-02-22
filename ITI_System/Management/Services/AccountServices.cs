using ITI_System.Management.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ITI_System.Management.Services
{
    class AccountServices
    {
        DataContext Context = new DataContext();
        public void Clear(FrmAccount Acc)
        {
            Acc.txtUserName.Text = "";
            Acc.txtpasswordBox.Password = "";
            Acc.txtpasswordBox_Copy.Password = "";
        }
        public void AddAcount(FrmAccount Acc)
        {
            var userName = Acc.txtUserName.Text;
            var password = Acc.txtpasswordBox.Password;
            var CofirmPassword = Acc.txtpasswordBox_Copy.Password;
            bool flag = false;
            foreach (var account in Context.Account)
            {
                if (userName == account.UserName)
                {
                    flag = true;
                    break;
                }
            }
            if (userName == "")
            {
                MessageBox.Show("Please,Enter UserName");
                Clear(Acc);
            }
            else if (password == "")
            {
                MessageBox.Show("Please,Enter Password");
                Clear(Acc);
            }
            else if (CofirmPassword == "")
            {
                MessageBox.Show("Please,Confirm Password");
                Clear(Acc);
            }
            else if (password != CofirmPassword)
            {
                MessageBox.Show("Password Not Matched");
                Clear(Acc);
            }
            
            else if (flag == true)
            {
                MessageBox.Show("Can Not Enter Two Accounts with same Name");
                Clear(Acc);
            }
            else
            {
                MessageBox.Show("Added");
            }



            //int ID = int.Parse(Acc.TxtID.Text.ToString());

            //    var intk = (from k in Context.Intake
            //                where k.ID == ID
            //                select k).FirstOrDefault();
            //    intk.Name = Acc.TxtName.Text;
            //    intk.Description = Acc.TxtDesc.Text;

            //    context.SaveChanges();
            //  MessageBox.Show("Sucsesfuly Update");
        }
    }
}
