using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI_System.Management.Forms;
using System.Data;

namespace ITI_System.Management.Services
{
    public class LabServices
    {
        DataContext context = new DataContext();
        public void FillCombo(FrmLabs frmLab)
        {
            var Labs = from L in context.Lab
                       select L;
            foreach (var item in Labs)
            {
                frmLab.CmBoxLab.DisplayMemberPath = "Name";
                frmLab.CmBoxLab.SelectedValuePath = "ID";
                frmLab.CmBoxLab.Items.Add(item);
            }
        }
        public void FillGrid(FrmLabs frmLab, int LabID)
        {
            var trainees = (from t in context.Trainee
                            where t.LabID == LabID
                            select t).ToList();//).firstordefault();

            frmLab.dgTrainee.ItemsSource = trainees;
            frmLab.dgTrainee.IsReadOnly = true;



            

        }
    }
}
