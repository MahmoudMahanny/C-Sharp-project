using ITI_System.Management.Services;
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

namespace ITI_System.Management.Forms
{
    /// <summary>
    /// Interaction logic for FrmLabs.xaml
    /// </summary>
    public partial class FrmLabs : Window
    {
        LabServices LabServices = new LabServices();
        
        int LabID;
        public FrmLabs()
        {
            InitializeComponent();
            LabServices.FillCombo(this);
        }

        private void CmBoxLab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LabID = int.Parse(CmBoxLab.SelectedValue.ToString());
            LabServices.FillGrid(this,LabID);

        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
