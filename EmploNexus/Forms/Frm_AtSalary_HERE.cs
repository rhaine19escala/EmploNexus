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
    public partial class Frm_AtSalary_HERE : Form
    {
        public Frm_AtSalary_HERE()
        {
            InitializeComponent();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Frm_ASalary_Management aSalary_Management = new Frm_ASalary_Management();
            aSalary_Management.Show();
            this.Hide();
        }

        private void btnAttendancePersonal_Click(object sender, EventArgs e)
        {
            Frm_ApersonalAttendance apersonalAttendance = new Frm_ApersonalAttendance();
            apersonalAttendance.Show();
            this.Hide();
        }
    }
}
