using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCSObjectOP
{
    public partial class frmClass2Struct : Form
    {
        public frmClass2Struct()
        {
            InitializeComponent();
        }
        clsTime current = new clsTime();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            current.Adjust(txtHour.Text, txtMinutes.Text, txtSeconds.Text);
        }

        private void btnDisplayUniversal_Click(object sender, EventArgs e)
        {
            lblUniversal.Text = current.ToUniversal();

        }

        private void btnDisplayStandard_Click(object sender, EventArgs e)
        {
            lblStandard.Text = current.ToStandard();
        }
    }
}
