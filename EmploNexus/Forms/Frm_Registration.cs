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
using System.Text.RegularExpressions;


namespace EmploNexus.Forms
{
    public partial class Frm_Registration : Form
    {
        public string username = String.Empty;
        EmploNexus_Entities_N db;
        public Frm_Registration()
        {
            InitializeComponent();
            //
            db = new EmploNexus_Entities_N();
        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {
            loadCbBoxGender();
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
            // SELECT * FROM POSITION
            var positions = db.Positions.ToList();

            cmbBoxPosition.ValueMember = "positionId";
            cmbBoxPosition.DisplayMember = "positionDescription";
            cmbBoxPosition.DataSource = positions;
        }

        public void loadCbBoxGender()
        {
            // SELECT * FROM GENDER
            var gender = db.Genders.ToList();

            cmbBoxGender.ValueMember = "genderId";
            cmbBoxGender.DisplayMember = "genderName";
            cmbBoxGender.DataSource = gender;
        }

        private void ClearInputFields()
        {
            txtpass_word.Clear();
            txtConfirmPassword.Clear();
            txtuser_name.Clear();
            txtempName.Clear();
            txtEmail.Clear();
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool isValid = Regex.IsMatch(email, emailPattern);
            return isValid;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //String cbResultSelected = cbBoxRole.SelectedValue.ToString();
            if (String.IsNullOrEmpty(txtempName.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtempName, "Empty field");
                return;
            }

            if (String.IsNullOrEmpty(txtEmail.Text) || !IsValidEmail(txtEmail.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEmail, "Invalid email");
                return;
            }
            if (String.IsNullOrEmpty(txtuser_name.Text))
            {
                errorProvider1.Clear();
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
                errorProvider1.SetError(txtConfirmPassword, "Empty field");
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
            nUserAccount.name = txtempName.Text;
            nUserAccount.email = txtEmail.Text;
            nUserAccount.username = txtuser_name.Text;
            nUserAccount.password = txtpass_word.Text;
            nUserAccount.roleId = (Int32)cmbBoxRole.SelectedValue;
            nUserAccount.genderId = (Int32)cmbBoxGender.SelectedValue;
            nUserAccount.departmentId = (Int32)cmbBoxDepartment.SelectedValue;
            nUserAccount.positionId = (Int32)cmbBoxPosition.SelectedValue;


            username = txtuser_name.Text;

            db.UserAccounts.Add(nUserAccount);
            db.SaveChanges();

            ClearInputFields();
            MessageBox.Show("Registered!", "EmploNexus: Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtempName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpBox_useraccIfno_Enter(object sender, EventArgs e)
        {

        }

        private void txtuser_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_word_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
