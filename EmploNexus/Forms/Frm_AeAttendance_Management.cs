using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploNexus.Forms
{
    public partial class Frm_AeAttendance_Management : Form
    {
        public Frm_AeAttendance_Management()
        {
            InitializeComponent();
        }

        private void Frm_AeAttendance_Management_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
        }
    }
}
