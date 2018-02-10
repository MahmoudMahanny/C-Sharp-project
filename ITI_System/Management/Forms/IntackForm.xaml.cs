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

        private void Add ()
        {
            if (TxtName.Text == null || TxtDesc.Text == null)
                return;
            if (TxtName.Text == "" || TxtDesc.Text == "")
            {
                MessageBox.Show("Please,Enter Name and Description ");
            }

            else
            {
                Intake intk = new Intake()
                {
                    Name = TxtName.Text,
                    Description = TxtDesc.Text

                };

                context.Intake.Add(intk);
                context.SaveChanges();
                MessageBox.Show("intake inserted");
            }
        }

       

        private void Update ()
        {
            if (TxtName.Text == null || TxtDesc.Text == null)
                return;
            if (TxtName.Text == "" || TxtDesc.Text == "")
            {
                MessageBox.Show("Please,Enter Name and Description ");
            }
            else
            {
                int ID = int.Parse(TxtID.Text.ToString());

                var intk = (from k in context.Intake
                            where k.ID == ID
                            select k).FirstOrDefault();
                intk.Name = TxtName.Text;
                intk.Description = TxtDesc.Text;

                context.SaveChanges();
                MessageBox.Show("Sucsesfuly Update");
            }
        }
        

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       
        private void Clear()
        {
            TxtName.Text = "";
            TxtDesc.Text = "";
        }

       

       

        private void Button_Save(object sender, RoutedEventArgs e)
        {
            if(this.Name== "frmAdd")
            {
                Add();
            }
            else if(this.Name== "frmUdate")
            {
                Update();
            }

           

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Clear();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
