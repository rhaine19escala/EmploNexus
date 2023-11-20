using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmploNexus;
using EmploNexus.AppData;

namespace EmploNexus.Forms
{
    public partial class Frm_AUser_Management : Form
    {
        UserRepository repo;
        private EMPLONEXUS_ emploNexusEntities;

        public Frm_AUser_Management()
        {
            InitializeComponent();
        }

        private void Frm_AUser_Management_Load(object sender, EventArgs e)
        {
            emploNexusEntities = new EMPLONEXUS_();
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");

            repo = new UserRepository();
            loadUser();
        }

        private void loadUser()
        {
            dgv_AllUserWdetails.DataSource = repo.AllUserRole();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Frm_AEmployee_Management employee_Management = new Frm_AEmployee_Management();
            employee_Management.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_Admin_Dashboard admin_Dashboard = new Frm_Admin_Dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Frm_ASalary_Management aSalary_Management = new Frm_ASalary_Management();
            aSalary_Management.Show();
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

        private void dgv_AllUserWdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUserID.Text = Convert.ToInt32(dgv_AllUserWdetails.Rows[e.RowIndex].Cells[0].Value).ToString();
                txtuserName.Text = dgv_AllUserWdetails.Rows[e.RowIndex].Cells[1].Value as String;
                txtuserUsername.Text = dgv_AllUserWdetails.Rows[e.RowIndex].Cells[2].Value as String;
                txtuserPassword.Text = dgv_AllUserWdetails.Rows[e.RowIndex].Cells[3].Value as String;
                txtRole.Text = dgv_AllUserWdetails.Rows[e.RowIndex].Cells[3].Value as String;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Encountered :" + ex.Message, "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnuserAdd_Click(object sender, EventArgs e)
        {
            String name = txtuserName.Text;
            String username = txtuserUsername.Text;
            String password = txtuserPassword.Text;
            String roleDescription = txtRole.Text;

            if(String.IsNullOrEmpty(name))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtuserName, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(username))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtuserUsername, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(password))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtuserPassword, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(roleDescription))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtRole, "Empty Field!");
                return;
            }
        }

        private void ClearInputFields()
        {
            txtuserName.Text = "";
            txtuserUsername.Text = "";
            txtuserPassword.Text = "";
            txtRole.Text = "";
        }

        private void btnuserClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}
