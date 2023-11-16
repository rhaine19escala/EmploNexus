using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmploNexus.AppData;

namespace EmploNexus.Forms
{
    public partial class Frm_Registration : Form
    {
        public string username = String.Empty;
        EMPLONEXUS_NEWEntities db;
        public Frm_Registration()
        {
            InitializeComponent();
            //
            db = new EMPLONEXUS_NEWEntities();
        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {
            loadCbBoxDepartment();
            loadCbBoxPosition();
            loadCbBoxRole();
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
        }

        private void cbBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void loadCbBoxRole()
        {
            // SELECT * FROM ROLE
            var roles = db.Roles.ToList();

            cmbBoxRole.ValueMember = "roleId";
            cmbBoxRole.DisplayMember = "roleName";
            cmbBoxRole.DataSource = roles;
        }

        public void loadCbBoxDepartment()
        {
            // SELECT * FROM DEPARTMENT
            var department = db.Departments.ToList();

            cmbBoxDepartment.ValueMember = "departmentId";
            cmbBoxDepartment.DisplayMember = "departmentDescription";
            cmbBoxDepartment.DataSource = department;
        }

        public void loadCbBoxPosition()
        {
            // SELECT * FROM DEPARTMENT
            var positions = db.Positions.ToList();

            cmbBoxDepartment.ValueMember = "positionId";
            cmbBoxDepartment.DisplayMember = "positionDescription";
            cmbBoxDepartment.DataSource = positions;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //String cbResultSelected = cbBoxRole.SelectedValue.ToString();
            if (String.IsNullOrEmpty(txtempName.Text))
            {
                errorProvider1.SetError(txtempName, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtuser_name.Text))
            {
                errorProvider1.SetError(txtuser_name, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtpass_word.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtpass_word, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtpass_word, "Empty field");
                return;
            }

            if (!txtpass_word.Text.Equals(txtConfirmPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConfirmPassword, "Password not match");
                return;
            }
            // int code = 123;
            // send email verificode (code)
            // send sms otp (code)

            // find the user id
            // code input equal db. useraccoutn code
            UserAccount nUserAccount = new UserAccount();
            nUserAccount.username = txtuser_name.Text;
            nUserAccount.password = txtpass_word.Text;
            nUserAccount.roleId = (Int32)cmbBoxRole.SelectedValue;

            username = txtuser_name.Text;

            db.UserAccounts.Add(nUserAccount);
            db.SaveChanges();

            txtpass_word.Clear();
            txtConfirmPassword.Clear();
            txtuser_name.Clear();
            MessageBox.Show("Registered!");
        }
    }
}
