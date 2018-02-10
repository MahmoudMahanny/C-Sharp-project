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
    /// Interaction logic for TrackModification.xaml
    /// </summary>
    public partial class TrackModification : Window
    {
        DataContext context = new DataContext();
        public TrackModification()
        {
            InitializeComponent();
            fill_listbox();
        }

        private void fill_listbox()
        {
            LstTrack.DisplayMemberPath = "Name";
            LstTrack.SelectedValuePath = "ID";
            LstTrack.ItemsSource = context.Track.ToList();
        }


        



        private void ListBox_MouseDoubleClick ()
        {
            int ID = int.Parse(LstTrack.SelectedValue.ToString());
            TrackForm trk = new TrackForm(ID);

            trk.TxtName.IsEnabled = false;
            trk.TxtDesc.IsEnabled = false;
            trk.btn_add_save.Visibility = Visibility.Hidden;
            trk.btn_up_save.Visibility = Visibility.Hidden;
            trk.BtnClear.IsEnabled = false;
            trk.ShowDialog();
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListBox_MouseDoubleClick();
        }





        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TrackForm trk = new TrackForm();

        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            

           
               // int ID = int.Parse(LstTrack.SelectedValue.ToString());
                TrackForm tr = new TrackForm();
                tr.Name = "frmAdd";
                tr.TxtID.IsEnabled = false;
                //tr.btn_up_save.Visibility = Visibility.Hidden;
                tr.ShowDialog();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Update(object sender, RoutedEventArgs e)
        {
            if (LstTrack.SelectedIndex<0)
            {
                return;
            }
            else
            {
                int ID = int.Parse(LstTrack.SelectedValue.ToString());
                TrackForm trk = new TrackForm(ID);
                trk.TxtID.IsEnabled = false;

        
                trk.Name = "frmUpdate";
                //tr.btn_add_save.Visibility = Visibility.Hidden;
                trk.ShowDialog();

            }
        }



        private void delete ()
        {
            if (LstTrack.SelectedItem == null)
                return;
            else
            {
                int ID = int.Parse(LstTrack.SelectedValue.ToString());

                Track tr = (from t in context.Track
                            where t.ID == ID
                            select t).FirstOrDefault();

                context.Track.Remove(tr);
                context.SaveChanges();
                MessageBox.Show("Sucsesfuly delete");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            delete();
        }

       
        private void LstTrack_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
