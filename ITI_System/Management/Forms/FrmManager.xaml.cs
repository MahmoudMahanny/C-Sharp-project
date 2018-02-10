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
    /// Interaction logic for FrmManager.xaml
    /// </summary>
    public partial class FrmManager : Window
    {
        public FrmManager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frmProgram pro = new frmProgram();
            pro.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            IntackModification i= new IntackModification();
            i.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TrackModification t = new TrackModification();
            t.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TraineeList t = new TraineeList();
            t.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            WPF1 w = new WPF1();
            w.ShowDialog();
        }
    }
}
