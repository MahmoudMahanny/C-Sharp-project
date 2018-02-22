using ITI_System.Management.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for AddIns.xaml
    /// </summary>
    public partial class AddIns : Window
    {
        DataContext context = new DataContext();
        InstructorServices Services = new InstructorServices();
        public AddIns()
        {

            Database.SetInitializer<DataContext>(new DropCreateDatabaseIfModelChanges<DataContext>());
            InitializeComponent();
        }

        public AddIns(int id)
        {
            InitializeComponent();
            var ins = (from I in context.Instructor
                       where I.ID == id
                       select I).FirstOrDefault();
            txtInstrID.Text = ins.ID.ToString();
            txtInstrName.Text = ins.Name;
            //txtInstrAddress.Text = ins.address;
            txtInstrEmail.Text = ins.Email;
            //txtInstrPhone.Text = ins.phone;

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{

        //}

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (this.Name == "frmAdd")
            {
                Services.AddInstructor(this);
                this.Close();
            }
            else if (this.Name == "frmUpdate")
            {
                Services.updateInstructor(this);
                this.Close();
            }
        }
        
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Services.Clear(this);
            

        }
    }
}
