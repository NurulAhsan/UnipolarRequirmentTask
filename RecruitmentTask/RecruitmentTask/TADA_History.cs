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
    public partial class TADA_History : Form
    {
        public TADA_History()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TADA_HOME fm = new TADA_HOME();
            fm.Show();
            this.Hide();
        }

        
    }
}
