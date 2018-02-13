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
    /// Interaction logic for TraineeList.xaml
    /// </summary>
    public partial class TraineeList : Window
    {
        DataContext context = new DataContext();
        TraineeServices trnSer = new TraineeServices();
        public TraineeList()
        {
            InitializeComponent();
            lstTrainee.DisplayMemberPath = "Name";
            lstTrainee.SelectedValuePath = "ID";
            lstTrainee.ItemsSource = context.Trainee.ToList();
            // trnSer.FillTraineeList();
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int ID = int.Parse(lstTrainee.SelectedValue.ToString());
            Management.TraineeForm tra = new Management.TraineeForm(ID);
            //  tra.btnAdd.Visibility = Visibility.Hidden;
            tra.btnUpdate.Visibility = Visibility.Hidden;
            // tra.btnDelete.Visibility = Visibility.Hidden;
            tra.toolBar.Visibility = Visibility.Hidden;
            tra.txtTraineeGender.IsEnabled = false;
            tra.txtTraineeID.IsEnabled = false;
            tra.txtTraineeName.IsEnabled = false;
            tra.txtTraineeMilitaryStatus.IsEnabled = false;
            tra.ShowDialog();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


       

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            trnSer.DeleteTrainee(this);
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
           
        }
          
        
        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            string se = txtSearch.Text;
            for (int i = lstTrainee.Items.Count-1; i >=0; i--)
            {
                if (lstTrainee.Items[i].ToString().ToLower().Contains(se)&se!="")
                {
                    MessageBox.Show("founded");
                 

                }
                else
                {
                    MessageBox.Show(" not founded");

                }
            }
            
        }

        private void btnEixt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Management.TraineeForm tra = new Management.TraineeForm();

            tra.btnUpdate.Visibility = Visibility.Hidden;
          

            tra.ShowDialog();

            trnSer.ButtonAdd(this);
        }
    }
}
