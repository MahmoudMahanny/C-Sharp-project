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
    /// Interaction logic for frmProgram.xaml
    /// </summary>
    public partial class frmProgram : Window
    {
        DataContext context = new DataContext();
        public frmProgram()
        {
            
            InitializeComponent();
            fill_listbox();
        }

        private void fill_listbox()
        {
            lstBxprogram.DisplayMemberPath = "Name";
            lstBxprogram.SelectedValuePath = "ID";
            lstBxprogram.ItemsSource = context.Program.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            delete();
        }
        private void delete()
        {
            if (lstBxprogram.SelectedItem == null)
                return;
            else
            {
                int ID = int.Parse(lstBxprogram.SelectedValue.ToString());


                Program pr = (from t in context.Program
                             where t.ID == ID
                             select t).FirstOrDefault();
                context.Program.Remove(pr);

                context.SaveChanges();
                MessageBox.Show("Sucsesfuly deleted");
                lstBxprogram.ItemsSource = context.Program.ToList();

            }
        }

        private void Button_Update(object sender, RoutedEventArgs e)
        {
            if (lstBxprogram.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                int ID = int.Parse(lstBxprogram.SelectedValue.ToString());
                frmAddProgram pro = new frmAddProgram(ID);
                pro.Name = "frmUdate";
                pro.ShowDialog();
            }
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            frmAddProgram pre = new frmAddProgram();
            pre.Name = "frmAdd";
            pre.TxtID.IsEnabled = false;
            pre.ShowDialog();
        }

        private void lstBxprogram_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lstBxInk_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int ID = int.Parse(lstBxprogram.SelectedValue.ToString());
            frmAddProgram pro = new frmAddProgram(ID);

            pro.TxtName.IsEnabled = false;
            pro.TxtDesc.IsEnabled = false;
            //pro.btn_add_save.Visibility = Visibility.Hidden;
            //pro.btn_up_save.Visibility = Visibility.Hidden;
            //pro.BtnClear.IsEnabled = false;
            pro.ShowDialog();
        }
    }
}
