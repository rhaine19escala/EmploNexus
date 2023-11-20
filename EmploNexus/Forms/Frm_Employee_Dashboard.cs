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
    public partial class Frm_Employee_Dashboard : Form
    {
        public Frm_Employee_Dashboard()
        {
            
            InitializeComponent();         
        }

        private void Frm_Employee_Dashboard_Load(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            txtName_User.Text = frm.user_Name;

            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
            txtCurrentDate.Text = currentTime.ToString("MM-d-yyyy");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Profile
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //View Salary
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
