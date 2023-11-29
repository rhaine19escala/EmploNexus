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
    public partial class FrmEnAttendance : Form
    {
        public FrmEnAttendance()
        {
            
            InitializeComponent();         
        }

        private void Frm_Employee_Dashboard_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FrmEnAttendance enAttendance = new FrmEnAttendance();
            enAttendance.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //View Salary
            Frm_EViewSalary eViewSalary = new Frm_EViewSalary();
            eViewSalary.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_Employee_Dashboard employee_Dashboard = new Frm_Employee_Dashboard();
            employee_Dashboard.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "EmploNexus: Log out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Frm_Login logout = new Frm_Login();
                logout.Show();
                this.Hide();
            }
        }
    }  
}
