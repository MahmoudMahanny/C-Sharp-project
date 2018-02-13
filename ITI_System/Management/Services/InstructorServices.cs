using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System.Management.Services
{
    public class InstructorServices
    {
        void DeleteInstructor(int ID)
        {


        }

       public void Clear(AddIns a)
        {
            
            a.txtInstrID.Text = "";
            a.txtInstrName.Text = "";
            a.txtInstrPhone.Text = "";
            a.txtInstrEmail.Text = "";
            a.txtInstrAddress.Text = "";
            a.txtInstrAccountID.Text = "";
            a.dpInstrBDate.SelectedDate = DateTime.Today;
            if (a.rbInstrGenderFM.IsChecked == true)
            {
                a.rbInstrGenderFM.IsChecked = false;
            }
            else
            {
                a.rbInstrGenderM.IsChecked = false;
            }
            if (a.rbInstrIsMngrNo.IsChecked == true)
            {
                a.rbInstrIsMngrNo.IsChecked = false;
            }
            else
            {
               a.rbInstrIsMngrYes.IsChecked = false;
            }
        }

    }
}
