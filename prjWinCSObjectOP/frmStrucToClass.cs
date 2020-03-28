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
    public partial class frmStrucToClass : Form
    {
        public frmStrucToClass()
        {
            InitializeComponent();
        }

        struct Time
        {
            public Int16 Hours;
            public Int16 Minuts;
            public Int16 Seconds;
        }

        Time current;

        private Time Adjust(Int16 aHour, Int16 aMinute, Int16 aSecond)
        {
            Time tmp;
            tmp.Hours = aHour;
            tmp.Minuts = aMinute;
            tmp.Seconds = aSecond;
            return tmp;
        }

        private string DisplayUniversal(Time anyTime)
        {
            String info = $"{ anyTime.Hours}:{anyTime.Minuts}:{anyTime.Seconds}";
            return info;
        }

        private void frmStrucToClass_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Int16 hr = Convert.ToInt16(txtHour.Text);
            Int16 mn = Convert.ToInt16(txtMinutes.Text);
            Int16 sc = Convert.ToInt16(txtSeconds.Text);
            current = Adjust(hr, mn, sc);
            MessageBox.Show("appointment created succesfully");
        }

        private void btnDisplayUniversal_Click(object sender, EventArgs e)
        {
            lblUniversal.Text = DisplayUniversal(current);
        }
    }
}
