using System;
using System.Windows.Forms;

namespace prjWinCSObjectOP
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            //clsTime RV = new clsTime();
            //RV.Hour = 23;
            //MessageBox.Show(RV.Hour.ToString());

            clsDate RV = new clsDate();
            RV.Initialize(-12, 56, -1956);
            MessageBox.Show(RV.ToLongDate());

        }
    }
}
