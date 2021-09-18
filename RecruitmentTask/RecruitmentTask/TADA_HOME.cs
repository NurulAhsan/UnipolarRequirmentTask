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
    public partial class TADA_HOME : Form
    {
        public TADA_HOME()
        {
            InitializeComponent();
        }

        private void btnTADA_Click(object sender, EventArgs e)
        {
            TADA_Entry td = new TADA_Entry();
            td.Show();
            this.Hide();
           
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            TADA_History tdh = new TADA_History();
            tdh.Show();
            this.Hide();
        }

       
    }
}
