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
    /// Interaction logic for TrackForm.xaml
    /// </summary>
    public partial class TrackForm : Window
    {
        DataContext context = new DataContext();

        public object MessageBoxButtons { get; private set; }

        public TrackForm()
        {
            InitializeComponent();

            //fill_lisbox();

        }

        public TrackForm(int ID)
        {
            InitializeComponent();

            var tr = (from t in context.Track
                      where t.ID == ID
                      select t).FirstOrDefault();
            TxtName.Text = tr.Name;
            TxtDesc.Text = tr.Description;
            TxtID.Text = tr.ID.ToString();

            //fill_lisbox();

            
        }

       
        
       

       

        private void TxtDesc_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void add ()
        {
            if (TxtName.Text == null || TxtDesc.Text == null)
                return;
            if (TxtName.Text == "" || TxtDesc.Text == "")
            {
                MessageBox.Show("Please,Enter Name and Description ");
            }

            else
            {
                Track trc = new Track()
                {
                    Name = TxtName.Text,
                    Description = TxtDesc.Text

                };

                context.Track.Add(trc);
                context.SaveChanges();
                MessageBox.Show("Track inserted");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(this.Name == "frmAdd")
            {
                //MessageBox.Show("Add");

                add();
            }
            else if (this.Name == "frmUpdate")
            {
                //MessageBox.Show("Update");
                Update();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            clear();

            
        }
        private void clear ()
        {
            TxtName.Text = "";
            TxtDesc.Text = "";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
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
                var tr = (from t in context.Track
                          where t.ID == ID
                          select t).FirstOrDefault();
                tr.Name = TxtName.Text;
                tr.Description = TxtDesc.Text;

                context.SaveChanges();
                MessageBox.Show("Sucsesfuly update");
            }
        }

        private void btn_up_save_Click(object sender, RoutedEventArgs e)
        {
            Update();
   
        }



        
    }
}
