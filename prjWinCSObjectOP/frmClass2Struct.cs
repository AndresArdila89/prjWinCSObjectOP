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

        private void frmClass2Struct_Load(object sender, EventArgs e)
        {
            clsTime current = new clsTime();

            current.Adjust(15, 30, 20);

            MessageBox.Show(current.ToUniversal());
        }
    }
}
