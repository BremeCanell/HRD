using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRD
{
    public partial class AddTeamForm : Form
    {
        public AddTeamForm()
        {
            InitializeComponent();
        }

        private void confirmB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void canselB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
