using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ITI_System.Management.Services
{
    public class InstructorServices
    {
        DataContext context = new DataContext();
        public void AddInstructor(AddIns a)
        {
            if (a.txtInstrName.Text == "")
            {
                MessageBox.Show("Please,Enter Instructor's Number");
            }
            else
            {
                string g;
                if (a.rbInstrGenderFM.IsChecked == true)
                {
                    g = "Female";
                }
                else
                {
                    g = "Male";
                }
                bool m;
                if (a.rbInstrIsMngrYes.IsChecked == true)
                {
                    m = true;
                }
                else
                {
                    m = false;
                }
                var ins = new Instructor
                {
                    Name = a.txtInstrName.Text,
                    Gender = g,
                    Birthdate = a.dpInstrBDate.SelectedDate.Value,
                    Email = a.txtInstrEmail.Text,
                    // phone = txtInstrPhone.Text,
                    // address = txtInstrAddress.Text,
                    IsManager = m
                    //accountID = int.Parse(txtInstrAccountID.Text)
                };

                context.Instructor.Add(ins);
                context.SaveChanges();
                MessageBox.Show("Successfully Added");
            }
        }

        public void updateInstructor(AddIns a)
        {
            if (a.txtInstrName.Text == "")
            {
                MessageBox.Show("Please,Enter Name");
            }
            else if (!IsAllLetters(a.txtInstrName.Text))
            {
                MessageBox.Show("Please, Enter Letters Only");

            }
            else
            {
                string g;
                if (a.rbInstrGenderFM.IsChecked == true)
                {
                    g = "Female";
                }
                else
                {
                    g = "male";
                }
                bool m;
                if (a.rbInstrIsMngrYes.IsChecked == true)
                {
                    m = true;
                }
                else
                {
                    m = false;
                }
                int ID = int.Parse(a.txtInstrID.Text);
                var ins =
                (from I in context.Instructor
                 where I.ID == ID
                 select I).FirstOrDefault();

                ins.ID = int.Parse(a.txtInstrID.Text);
                ins.Name = a.txtInstrName.Text;
                ins.Gender = g;
                //ins.birthdate = dpInstrBDate.SelectedDate.Value;
                ins.Email = a.txtInstrEmail.Text;
                //  ins.phone = txtInstrPhone.Text;
                //  ins.address = txtInstrAddress.Text;
                ins.IsManager = m;
                //accountID = int.Parse(txtInstrAccountID.Text)
            }
            context.SaveChanges();

            MessageBox.Show("Successfully Edited");
        }
        void DeleteInstructor(WPF1 w)
        {
            int ID = int.Parse(w.lboxinstructor.SelectedValue.ToString());
            var ins =
                (from I in context.Instructor
                 where I.ID == ID
                 select I).FirstOrDefault();
            MessageBoxResult Result = MessageBox.Show("DELETE instructor, Are you Sure ?", "DELETE", MessageBoxButton.YesNo);
            if (Result == MessageBoxResult.Yes)
            {
                context.Instructor.Remove(ins);
                context.SaveChanges();
                MessageBox.Show("Deleted!");
            }
            else if (Result == MessageBoxResult.No)
            {
                return;
            }
        }

        public void Clear(AddIns a)
        {

            a.txtInstrID.Text = "";
            a.txtInstrName.Text = "";
            a.txtInstrPhone.Text = "";
            a.txtInstrEmail.Text = "";
            a.txtInstrAddress.Text = "";
            a.txtInstrAccountID.Text = "";
            a.dpInstrBDate.SelectedDate = DateTime.Today;
            if (a.rbInstrGenderFM.IsChecked == true)
            {
                a.rbInstrGenderFM.IsChecked = false;
            }
            else
            {
                a.rbInstrGenderM.IsChecked = false;
            }
            if (a.rbInstrIsMngrNo.IsChecked == true)
            {
                a.rbInstrIsMngrNo.IsChecked = false;
            }
            else
            {
                a.rbInstrIsMngrYes.IsChecked = false;
            }


        }
        private bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c) || c == ' ')
                    return false;
            }
            return true;
        }
    }
}
    

        
