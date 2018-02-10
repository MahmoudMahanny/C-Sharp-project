using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace ITI_System
{
    /// <summary>
    /// Interaction logic for AddIns.xaml
    /// </summary>
    public partial class AddIns : Window
    {
        DataContext context = new DataContext();

        public AddIns()
        {

            Database.SetInitializer<DataContext>(new DropCreateDatabaseIfModelChanges<DataContext>());
            InitializeComponent();
        }

        public AddIns(int id)
        {
            InitializeComponent();
            var ins = (from I in context.Instructor
                       where I.ID == id
                       select I).FirstOrDefault();
            txtInstrID.Text = ins.ID.ToString();
            txtInstrName.Text = ins.Name;
            //txtInstrAddress.Text = ins.address;
            txtInstrEmail.Text = ins.Email;
            //txtInstrPhone.Text = ins.phone;

        }
    
        private bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{

        //}

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (this.Name == "frmAdd")
            {


                if (txtInstrName.Text == "")
                {
                    MessageBox.Show("Please,Enter Instructor's Number");
                }
                else if (!IsAllLetters(txtInstrName.Text))
                {
                    MessageBox.Show("Please, Enter Letters Only");
                }
                else
                {
                    string g;
                    if (rbInstrGenderFM.IsChecked == true)
                    {
                        g = "Female";
                    }
                    else
                    {
                        g = "Male";
                    }
                    bool m;
                    if (rbInstrIsMngrYes.IsChecked == true)
                    {
                        m = true;
                    }
                    else
                    {
                        m = false;
                    }
                    var ins = new Instructor
                    {
                        Name = txtInstrName.Text,
                        Gender = g,
                        Birthdate = dpInstrBDate.SelectedDate.Value,
                        Email = txtInstrEmail.Text,
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
            else if (this.Name == "frmUpdate")
            {
                if (txtInstrName.Text == "")
                {
                    MessageBox.Show("Please,Enter Name");
                }
                else if (!IsAllLetters(txtInstrName.Text))
                {
                    MessageBox.Show("Please, Enter Letters Only");

                }
                else
                {
                    string g;
                    if (rbInstrGenderFM.IsChecked == true)
                    {
                        g = "Female";
                    }
                    else
                    {
                        g = "male";
                    }
                    bool m;
                    if (rbInstrIsMngrYes.IsChecked == true)
                    {
                        m = true;
                    }
                    else
                    {
                        m = false;
                    }
                    int ID = int.Parse(txtInstrID.Text);
                    var ins =
                    (from I in context.Instructor
                     where I.ID == ID
                     select I).FirstOrDefault();

                    ins.ID = int.Parse(txtInstrID.Text);
                    ins.Name = txtInstrName.Text;
                    ins.Gender = g;
                    //ins.birthdate = dpInstrBDate.SelectedDate.Value;
                    ins.Email = txtInstrEmail.Text;
                  //  ins.phone = txtInstrPhone.Text;
                  //  ins.address = txtInstrAddress.Text;
                    ins.IsManager = m;
                    //accountID = int.Parse(txtInstrAccountID.Text)
                }
                context.SaveChanges();

                MessageBox.Show("Successfully Edited");
            }
        }
    
        private void Clear()
        {
            txtInstrID.Text = "";
            txtInstrName.Text = "";
            txtInstrPhone.Text = "";
            txtInstrEmail.Text = "";
            txtInstrAddress.Text = "";
            txtInstrAccountID.Text = "";
            dpInstrBDate.SelectedDate = DateTime.Today;
            if (rbInstrGenderFM.IsChecked == true)
            {
                rbInstrGenderFM.IsChecked = false;
            }
            else
            {
                rbInstrGenderM.IsChecked = false;
            }
            if (rbInstrIsMngrNo.IsChecked == true)
            {
                rbInstrIsMngrNo.IsChecked = false;
            }
            else
            {
                rbInstrIsMngrYes.IsChecked = false;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Clear(); 
          
        }
    }
}
