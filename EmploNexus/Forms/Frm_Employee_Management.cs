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
    public partial class Frm_Employee_Management : Form
    {
        public Frm_Employee_Management()
        {
            InitializeComponent();
        }

        private void Frm_Employee_Management_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_Admin_Dashboard admin_Dashboard = new Frm_Admin_Dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "EmploNexus: Log out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Frm_Login logout = new Frm_Login();
                logout.Show();
                this.Hide();
            }
        }

        private void btnempAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnempUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnempDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnempClear_Click(object sender, EventArgs e)
        {
            txtempID.Clear();
            txtempName.Clear();
            txtempEmail.Clear();
            txtempSalary.Clear();
        }


    }
}
