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

namespace ITI_System.Management
{
    /// <summary>
    /// Interaction logic for TraineeForm.xaml
    /// </summary>
    public partial class TraineeForm : Window
    {
        DataContext context = new DataContext();
        public TraineeForm()
        {
            InitializeComponent();

            //var tr = (from t in context.Trainee
            //          where t.ID == ID
            //          select t).FirstOrDefault();

            //txtTraineeName.Text = tr.Name;
            //txtTraineeGender.Text = tr.Gender;
            //txtTraineeMilitaryStatus.Text = tr.MilitaryStatus;
            //txtTraineeQualification.Text = tr.Qualification;
         
        }

        public TraineeForm(int ID)
        {
            InitializeComponent();

            var tr = (from t in context.Trainee
                      where t.ID == ID
                      select t).FirstOrDefault();
            
            if(tr.Gender == "Male")
            {
                rBtnTraineeMale.IsChecked = true;
            }
            else if (tr.Gender == "Female")
            {
                rbtnTraineeFemale.IsChecked = true;
            }
            txtTraineeID.Text = tr.ID.ToString();
            txtTraineeName.Text = tr.Name;
            txtTraineeMilitaryStatus.Text = tr.MilitaryStatus;
            txtTraineeQualification.Text = tr.Qualification;
           
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
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

            if (txtTraineeName.Text == "")
            {
                MessageBox.Show("Please,Enter Name");
            }
            else if (!IsAllLetters(txtTraineeName.Text))
            {
                MessageBox.Show("Please, Enter Letters Only");

            }
            else
            {
                string gen;
                if (rbtnTraineeFemale.IsChecked == true)
                {
                    gen = "Female";
                }
                else {
                    gen = "Male";
                }
                
                int Id = int.Parse(txtTraineeID.Text.ToString());
                var tr = (from t in context.Trainee
                          where t.ID == Id
                          select t).FirstOrDefault();
                tr.Name = txtTraineeName.Text;
                tr.Qualification = txtTraineeQualification.Text;
                tr.Gender = gen;
               tr.MilitaryStatus = txtTraineeMilitaryStatus.Text;
                context.SaveChanges();
                MessageBox.Show("Sucsesfuly update");

            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtTraineeID.Text == null || txtTraineeName.Text == null)
                return;
            if (txtTraineeName.Text == "" || txtTraineeID.Text == "")
            {
                MessageBox.Show("Please,Enter Name and ID ");
            }
            else
            {
                string gen;
                if (rbtnTraineeFemale.IsChecked == true)
                {
                    gen = "Female";
                }
                else
                {
                    gen = "Male";
                }
                Trainee trainee = new Trainee()
                {
                    Name = txtTraineeName.Text,
                    Qualification = txtTraineeQualification.Text,
                    MilitaryStatus = txtTraineeMilitaryStatus.Text,
                    Gender = gen
                };

                context.Trainee.Add(trainee);
                context.SaveChanges();
                MessageBox.Show("Trainee inserted");
                TraineeList trlst = new TraineeList();
                trlst.lstTrainee.DisplayMemberPath = "Name";
                trlst.lstTrainee.SelectedValuePath = "ID";
                trlst.lstTrainee.ItemsSource = context.Trainee.ToList();
                this.Close();
            }
        }
    }
}
