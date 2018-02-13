using ITI_System.Management.Services;
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
        TraineeServices TrnSer = new TraineeServices();
        public TraineeForm()
        {
            InitializeComponent();
        }
        public TraineeForm(int ID)
        {
            InitializeComponent();
  
          
            var tr = (from t in context.Trainee
                      where t.ID == ID
                      select t).FirstOrDefault();
            //to check the Gender

            if (tr.Gender == "Male")
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
        
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        { 
            TrnSer.UpdateTrainee(this);
            this.Close();
            TrnSer.FillTraineeList(this);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            TrnSer.AddTrainee(this);
            this.Close();
            
        }
    }
}
