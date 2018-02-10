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

namespace ITI_System
{
    /// <summary>
    /// Interaction logic for IntackModification.xaml
    /// </summary>
    public partial class IntackModification : Window
    {
        DataContext context = new DataContext();
        public IntackModification()
        {
            InitializeComponent();

            lstBxInk.DisplayMemberPath = "Name";
            lstBxInk.SelectedValuePath = "ID";
            lstBxInk.ItemsSource = context.Intake.ToList();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            IntackForm ink = new IntackForm();
            ink.Name = "frmAdd";
            ink.TxtID.IsEnabled = false;
            ink.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Update(object sender, RoutedEventArgs e)
        {
            if (lstBxInk.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                int ID = int.Parse(lstBxInk.SelectedValue.ToString());
                IntackForm ink = new IntackForm(ID);
                ink.Name = "frmUdate";
                ink.ShowDialog();
            }
        }

        private void lstBxInk_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int ID = int.Parse(lstBxInk.SelectedValue.ToString());
            IntackForm tt = new IntackForm(ID);
            tt.TxtName.IsEnabled = false;
            tt.TxtDesc.IsEnabled = false;
            tt.TxtID.IsEnabled = false;
            tt.btnsave.IsEnabled = false;
            tt.btnclear.IsEnabled = false;
            //tt.BtnClear.Visibility = Visibility.Hidden;
            tt.ShowDialog();
            
        }


        private void delete()
        {
            if (lstBxInk.SelectedItem == null)
                return;
            else
            {
                int ID = int.Parse(lstBxInk.SelectedValue.ToString());

               
                Intake tr = (from t in context.Intake
                             where t.ID == ID
                             select t).FirstOrDefault();
                context.Intake.Remove(tr); 
                
                context.SaveChanges();
                MessageBox.Show("Sucsesfuly delete");
                lstBxInk.ItemsSource = context.Intake.ToList();

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            delete();
        }
    }
}
