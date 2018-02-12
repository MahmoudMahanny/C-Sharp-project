using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ITI_System
{
    class Intak_Services
    {
        DataContext context = new DataContext();
       
        

        public void Update(IntackForm n)
        {
            if (n.TxtName.Text == null || n.TxtDesc.Text == null)
                return;
            if (n.TxtName.Text == "" || n.TxtDesc.Text == "")
            {
                MessageBox.Show("Please,Enter Name and Description ");
            }
            else
            {
                int ID = int.Parse(n.TxtID.Text.ToString());

                var intk = (from k in context.Intake
                            where k.ID == ID
                            select k).FirstOrDefault();
                intk.Name = n. TxtName.Text;
                intk.Description =n. TxtDesc.Text;

                context.SaveChanges();
                MessageBox.Show("Sucsesfuly Update");
            }
        }
        public void Add(IntackForm r)
        {
            if (r.TxtName.Text == null ||r.TxtDesc.Text == null)
                return;
            if (r.TxtName.Text == "" || r.TxtDesc.Text == "")
            {
                MessageBox.Show("Please,Enter Name and Description ");
            }

            else
            {
                Intake intk = new Intake()
                {
                    Name =r. TxtName.Text,
                    Description = r.TxtDesc.Text

                };

                context.Intake.Add(intk);
                context.SaveChanges();
                MessageBox.Show("intake inserted");
            }
        }
    }

}
