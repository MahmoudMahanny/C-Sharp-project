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
    /// Interaction logic for IntackForm.xaml
    /// </summary>
    public partial class IntackForm : Window
    {
        DataContext context = new DataContext();
        Intak_Services k = new Intak_Services();
        public IntackForm()
        {
            InitializeComponent();

          
        }

        public IntackForm(int ID)
        {
            InitializeComponent();

            var ink = (from t in context.Intake
                       where t.ID == ID
                       select t).FirstOrDefault();
            TxtName.Text = ink.Name;
            TxtDesc.Text = ink.Description;
            TxtID.Text = ink.ID.ToString();

            
        }

        



        


        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       
       

       

       

        private void Button_Save(object sender, RoutedEventArgs e)
        {
            
           // int ID = int.Parse(lstBxInk.ToString());

         
            
            if (this.Name == "frmAdd")
            {
              k. Add_Intak(this);
            }
            else if (this.Name == "frmUdate")
            {
                k.Update_Intak(this);
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            k.clear_Intak(this);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
