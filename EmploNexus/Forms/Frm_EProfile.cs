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
    public partial class Frm_EProfile : Form
    {
        public Frm_EProfile()
        {
            
            InitializeComponent();         
        }

        private void Frm_Employee_Dashboard_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //View Salary
            Frm_EViewSalary eViewSalary = new Frm_EViewSalary();
            eViewSalary.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Employee_Dashboard employee_Dashboard = new Frm_Employee_Dashboard();
            employee_Dashboard.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem2_Click(object sender, EventArgs e)
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
