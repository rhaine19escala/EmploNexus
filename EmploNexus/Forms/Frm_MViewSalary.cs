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
    public partial class Frm_MViewSalary : Form
    {
        public Frm_MViewSalary()
        {
            
            InitializeComponent();         
        }


        private void Frm_MViewSalary_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Frm_Manager_Dashboard manager_Dashboard = new Frm_Manager_Dashboard();
            manager_Dashboard.Show();
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //View Employee
            Frm_MViewEmployee mViewEmployee = new Frm_MViewEmployee();
            mViewEmployee.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Profile
            Frm_MProfile mProfile = new Frm_MProfile();
            mProfile.Show();
            this.Hide();
        }
    }
}
