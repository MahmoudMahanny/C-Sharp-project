using ITI_System.Management.Forms;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ITI_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var t1 = DateTime.Now;
            DataContext context = new DataContext();
            Account Account = new Account() { UserName = "Manar", Password = "ASD" };
            context.Account.Add(Account);
            context.SaveChanges();
            var t2 = DateTime.Now;
            var CurTime = t2 - t1;
            btnConect.Content = CurTime.ToString();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrmLogIN L = new FrmLogIN();
            L.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrmAccount acc = new FrmAccount();
            acc.ShowDialog();
        }
    }
}
