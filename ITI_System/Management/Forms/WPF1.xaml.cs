using ITI_System;
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
    /// Interaction logic for WPF1.xaml
    /// </summary>
    public partial class WPF1 : Window
    {
        DataContext context = new DataContext();
        public WPF1()
        {
            InitializeComponent();
            lboxinstructor.DisplayMemberPath = "name";
            lboxinstructor.SelectedValuePath = "ID";
            lboxinstructor.ItemsSource = context.Instructor.ToList();
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lboxinstructor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lboxinstructor_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //int ID = int.Parse(lboxinstructor.SelectedValue.ToString());
            //MainWindow WPF2 = new MainWindow(ID);
            //WPF2.txtInstrID.IsEnabled = false;
            //WPF2.txtInstrAccountID.IsEnabled = false;
            //WPF2.txtInstrAddress.IsEnabled = false;
            //WPF2.txtInstrEmail.IsEnabled = false;
            //WPF2.txtInstrName.IsEnabled = false;
            //WPF2.txtInstrPhone.IsEnabled = false;
            //WPF2.rbInstrGenderFM.IsEnabled = false;
            //WPF2.rbInstrGenderM.IsEnabled = false;
            //WPF2.rbInstrIsMngrNo.IsEnabled = false;
            //WPF2.rbInstrIsMngrYes.IsEnabled = false;
            //WPF2.dpInstrBDate.IsEnabled = false;
            //WPF2.ShowDialog();
        }

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
           
        //}

        private void btnAddIns_Click(object sender, RoutedEventArgs e)
        {
            AddIns add = new AddIns();
            add.Name = "frmAdd";
            add.ShowDialog();
        }

        private void btnUpdateIns_Click(object sender, RoutedEventArgs e)
        {
            if (lboxinstructor.SelectedIndex<0)
            {
                return;
            }
            else if (lboxinstructor.SelectedIndex > 0)
            {
                
                int ID = int.Parse(lboxinstructor.SelectedValue.ToString());
                AddIns add = new AddIns(ID);
                add.Name = "frmUpdate";
                add.ShowDialog();
                

            }

        }

        private void btnDeleteIns_Click(object sender, RoutedEventArgs e)
        {
            if (lboxinstructor.SelectedIndex < 0)
            {
                return;
            }
            else if (lboxinstructor.SelectedIndex > 0)
            {


                int ID = int.Parse(lboxinstructor.SelectedValue.ToString());
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
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
