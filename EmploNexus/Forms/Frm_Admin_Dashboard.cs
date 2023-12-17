using EmploNexus.AppData;
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
    public partial class Frm_Admin_Dashboard : Form
    {
        UserRepository repo;
        public Frm_Admin_Dashboard()
        {
            InitializeComponent();
            repo = new UserRepository();
        }

        private void Frm_Admin_Dashboard_Load(object sender, EventArgs e)
        {
            string username = UserLogged.GetInstance().UserAccounts.username;
            txtName_User.Text = $"{char.ToUpper(username[0])}{username.Substring(1).ToLower()}";

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
            if(res == DialogResult.OK)
            {
                Frm_Login logout = new Frm_Login();
                logout.Show();
                this.Hide();
            }             
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Frm_AEmployee_Management employee_Management = new Frm_AEmployee_Management();
            employee_Management.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AEmployee_Management employee_Management = new Frm_AEmployee_Management();
            employee_Management.Show();
            this.Hide();
        }
        
        private void btnUser_Click(object sender, EventArgs e)
        {
            Frm_AUser_Management aUser_Management = new Frm_AUser_Management();
            aUser_Management.Show();
            this.Hide();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AUser_Management aUser_Management = new Frm_AUser_Management();
            aUser_Management.Show();
            this.Hide();
        }
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            //Attendance
            Frm_Attendance_HERE attendance_Management = new Frm_Attendance_HERE();
            attendance_Management.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //Profile
           Frm_AProfile aProfile = new Frm_AProfile();
            aProfile.Show();
            this.Hide();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Attendance Personal Details
            Frm_ApersonalAttendance apersonalAttendance = new Frm_ApersonalAttendance();
            apersonalAttendance.Show();
            this.Hide();
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Attendance
            Frm_AeAttendance_Management attendance_Management = new Frm_AeAttendance_Management();
            attendance_Management.Show();
            this.Hide();
        }

        private void managementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ASalary_Management aSalary_Management = new Frm_ASalary_Management();
            aSalary_Management.Show();
            this.Hide();
        }

        private void detailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ApersonalSalary apersonalSalary = new Frm_ApersonalSalary();
            apersonalSalary.Show();
            this.Hide();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            Frm_AtSalary_HERE atSalary_HERE = new Frm_AtSalary_HERE();
            atSalary_HERE.Show();
            this.Hide();
        }
    }
}
