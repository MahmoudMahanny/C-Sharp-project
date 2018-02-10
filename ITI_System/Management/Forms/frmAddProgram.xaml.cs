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
    /// Interaction logic for frmAddProgram.xaml
    /// </summary>
    public partial class frmAddProgram : Window
    {
        DataContext context = new DataContext();
        public frmAddProgram()
        {
            InitializeComponent();
        }
        public frmAddProgram(int ID)
        {
            InitializeComponent();

            var pro = (from t in context.Program
                       where t.ID == ID
                       select t).FirstOrDefault();
            TxtName.Text = pro.Name;
            TxtDesc.Text = pro.Description;
            TxtID.Text = pro.ID.ToString();


        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            TxtName.Text = "";
            TxtDesc.Text = "";
        }

        private void Button_Save(object sender, RoutedEventArgs e)
        {
            if (this.Name == "frmAdd")
            {
                Add();
            }
            else if (this.Name == "frmUdate")
            {
                Update();
            }
            
        }


        private void Add()
        {
            if (TxtName.Text == null || TxtDesc.Text == null)
                return;
            if (TxtName.Text == "" || TxtDesc.Text == "")
            {
                MessageBox.Show("Please,Enter Name and Description ");
            }

            else
            {
                Program PRO = new Program()
                {
                    Name = TxtName.Text,
                    Description = TxtDesc.Text

                };

                context.Program.Add(PRO);
                context.SaveChanges();
                MessageBox.Show("Program inserted");
            }
        }



        private void Update()
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

                var pro = (from k in context.Program
                            where k.ID == ID
                            select k).FirstOrDefault();
                pro.Name = TxtName.Text;
                pro.Description = TxtDesc.Text;

                context.SaveChanges();
                MessageBox.Show("Sucsesfuly Updated");
            }
        }



    }
}
