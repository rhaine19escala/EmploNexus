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
    public partial class Frm_Manager_Dashboard : Form
    {
        public Frm_Manager_Dashboard()
        {
            InitializeComponent();
        }

        private void Frm_Manager_Dashboard_Load(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            txtName_User.Text = frm.LoggedInUsername;

            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
            txtCurrentDate.Text = currentTime.ToString("MM-d-yyyy");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "EmploNexus: Log out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Frm_Login logout = new Frm_Login();
                logout.Show();
                this.Hide();
            }
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Profile
            Frm_MProfile mProfile = new Frm_MProfile();
            mProfile.Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Frm_MProfile mProfile = new Frm_MProfile();
            mProfile.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //View Employee
            Frm_MViewEmployee mViewEmployee = new Frm_MViewEmployee();
            mViewEmployee.Show();
            this.Hide();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Frm_MViewEmployee mViewEmployee = new Frm_MViewEmployee();
            mViewEmployee.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //View Salary
            Frm_MViewSalary mViewSalary = new Frm_MViewSalary();
            mViewSalary.Show();
            this.Hide();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            Frm_MViewSalary mViewSalary = new Frm_MViewSalary();
            mViewSalary.Show();
            this.Hide();
        }
    }
}
