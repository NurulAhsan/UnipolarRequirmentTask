using RecruitmentTask.TADAClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecruitmentTask
{
    public partial class TADA_Entry : Form
    {
        public TADA_Entry()
        {
            InitializeComponent();
        }
        tadaclass c = new tadaclass();

        private void button1_Click(object sender, EventArgs e)
        {
            TADA_HOME fm = new TADA_HOME();
            fm.Show();
            this.Hide();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            c.Date = datetexbox.Text;
            c.EmployeeName = ENametextBox.Text;
            c.TravelCost = TCtextBox.Text;
            c.LunchCost = LCtextBox.Text;
            c.InstrumentCost = ICtextBox.Text;
            c.Paid = PaidcomboBox.ToString();


            //insert value in databasehh

            bool success = c.Insert(c);
            
            if (success == true )
            {
                MessageBox.Show("Data Enter Successfully");
            }
            else
            {
                MessageBox.Show("Data Entry Faild!! Try Again");
            }
        }
    }
}
