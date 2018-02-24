using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                MessageBox.Show("Please Enter Instructor's Name");
                Clear(a);
            }
            else if (!IsAllLetters(a.txtInstrName.Text))
            {
                MessageBox.Show("Invalid Name, Enter Letters Only");
                Clear(a);
            }
            if (a.rbInstrGenderFM.IsChecked == false && a.rbInstrGenderM.IsChecked == false)
            {
                MessageBox.Show("Select Instructor's Gender");
                Clear(a);
            }
            if (a.dpInstrBDate.SelectedDate.Value == null)
            {
                MessageBox.Show("Choose a Birthdate");
                Clear(a);
            }
            if (a.txtInstrEmail.Text == "")
            {
                MessageBox.Show("Enter Email Address");
                Clear(a);
            }
            else if (!IsValidEmail(a.txtInstrEmail.Text))
            {
                MessageBox.Show("Invalid Email Address");
                Clear(a);
            }

            if (a.txtInstrPhone.Text == "")
            {
                MessageBox.Show("Enter Phone number");
                Clear(a);
            }
            else if (!IsvalidPhone(a.txtInstrPhone.Text))
            {
                MessageBox.Show("Invalid Phone Number");
                Clear(a);
            }
            if (a.txtInstrAddress.Text == "")
            {
                MessageBox.Show("Enter Address");
                Clear(a);
            }
            if (a.rbInstrIsMngrNo.IsChecked == false && a.rbInstrIsMngrYes.IsChecked == false)
            {
                MessageBox.Show("Is Manager Or Not?");
                Clear(a);
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
                MessageBox.Show("Please Enter Instructor's Name");
                Clear(a);
            }
            else if (!IsAllLetters(a.txtInstrName.Text))
            {
                MessageBox.Show("Invalid Name, Enter Letters Only");
                Clear(a);
            }
            if (a.rbInstrGenderFM.IsChecked == false && a.rbInstrGenderM.IsChecked == false)
            {
                MessageBox.Show("Select Instructor's Gender");
                Clear(a);
            }
            if (a.dpInstrBDate.SelectedDate.Value == null)
            {
                MessageBox.Show("Choose a Birthdate");
                Clear(a);
            }
            if (a.txtInstrEmail.Text == "")
            {
                MessageBox.Show("Enter Email Address");
                Clear(a);
            }
            else if (!IsValidEmail(a.txtInstrEmail.Text))
            {
                MessageBox.Show("Invalid Email Address");
                Clear(a);
            }

            if (a.txtInstrPhone.Text == "")
            {
                MessageBox.Show("Enter Phone number");
                Clear(a);
            }
            else if (!IsvalidPhone(a.txtInstrPhone.Text))
            {
                MessageBox.Show("Invalid Phone Number");
                Clear(a);
            }
            if (a.txtInstrAddress.Text == "")
            {
                MessageBox.Show("Enter Address");
                Clear(a);
            }
            if (a.rbInstrIsMngrNo.IsChecked == false && a.rbInstrIsMngrYes.IsChecked == false)
            {
                MessageBox.Show("Is Manager Or Not?");
                Clear(a);
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
        public bool IsValidEmail(string email)
        {
            if (!Regex.IsMatch(email, @"/^[\x20-\x7E]+$/"))
            {
                if (Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                    return true;
                else
                    return false;
            }
            //MessageBox.Show("E-mail must be in English");
            return false;
        }
        public bool IsvalidPhone(string phone)
        {
            Regex phoneNumpattern = new Regex(@"^01[0-2][0-9]{8}$");
            if (phoneNumpattern.IsMatch(phone))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
    

        
