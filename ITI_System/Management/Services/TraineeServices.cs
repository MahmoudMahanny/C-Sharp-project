using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ITI_System.Management.Services
{
    class TraineeServices
    {
        DataContext context = new DataContext();
        public void AddTrainee(TraineeForm t,int LabID)
        {

            if (t.txtTraineeName.Text == "")
            {
                MessageBox.Show("Please,Enter Name");
            }
            else
            {
                string gen;
                if (t.rbtnTraineeFemale.IsChecked == true)
                {
                    gen = "Female";
                }
                else
                {
                    gen = "Male";
                }
                Trainee trainee = new Trainee()
                {

                    Name = t.txtTraineeName.Text,
                    Qualification = t.txtTraineeQualification.Text,
                    MilitaryStatus = t.txtTraineeMilitaryStatus.Text,
                    Gender = gen,
                    LabID = LabID
                };

                context.Trainee.Add(trainee);
                context.SaveChanges();
                MessageBox.Show("Trainee inserted");
            }
        }
        public void UpdateTrainee(TraineeForm t)
        {
            
            if (t.txtTraineeName.Text == "")
            {
                MessageBox.Show("Please,Enter Name");
            }
            else if (!IsAllLetters(t.txtTraineeName.Text))
            {
                MessageBox.Show("Please, Enter Letters Only");

            }
            else
            {
                string gen;
                if (t.rbtnTraineeFemale.IsChecked == true)
                {
                    gen = "Female";
                }
                else
                {
                    
                    gen = "Male";
                }

                int Id = int.Parse(t.txtTraineeID.Text.ToString());
                var tr = (from tre in context.Trainee
                          where tre.ID == Id
                          select tre).FirstOrDefault();
                tr.Name = t.txtTraineeName.Text;
                tr.Qualification = t.txtTraineeQualification.Text;
                tr.Gender = gen;
                tr.MilitaryStatus = t.txtTraineeMilitaryStatus.Text;
                context.SaveChanges();
                MessageBox.Show("Sucsesfuly updated");
                

            }
        }
        public void DeleteTrainee(TraineeList t)
        {

            int ID = int.Parse(t.lstTrainee.SelectedValue.ToString());

            Trainee tr = (from tre in context.Trainee
                          where tre.ID == ID
                          select tre).FirstOrDefault();
            context.Trainee.Remove(tr);
            context.SaveChanges();
            MessageBox.Show("Sucsesfuly delete");
            t.lstTrainee.DisplayMemberPath = "Name";
            t.lstTrainee.SelectedValuePath = "ID";
            t.lstTrainee.ItemsSource = context.Trainee.ToList();
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
        
        public void FillTraineeList(TraineeForm tr)
        {
            TraineeList t = new TraineeList();
            t.lstTrainee.DisplayMemberPath = "Name";
            t.lstTrainee.SelectedValuePath = "ID";
           t.lstTrainee.ItemsSource = context.Trainee.ToList();
        }

        public void ButtonAdd(TraineeList tr)
        {
            if (tr.lstTrainee.SelectedIndex < 0)
            {
                return;
            }
            else if (tr.lstTrainee.SelectedIndex > 0)
            {
                int ID = int.Parse(tr.lstTrainee.SelectedValue.ToString());
                TraineeForm tf = new TraineeForm(ID);
                tf.btnSave.Visibility = Visibility.Hidden;
                tf.ShowDialog();
            }
        }
    }
}