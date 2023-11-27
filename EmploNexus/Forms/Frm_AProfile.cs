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
    public partial class Frm_AProfile : Form
    {
        UserRepository repo;
        EmploNexusu_uEntities db;
        private bool isEditing = false;

        public Frm_AProfile()
        {
            InitializeComponent();
            repo = new UserRepository();
            db = new EmploNexusu_uEntities();
        }

        private void Frm_AProfile_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
            txtCurrentDate.Text = currentTime.ToString("D");

            DisableStartProfileState();
            loadUser();
        }

        public void loadUser()
        {
            loadCbBoxGender();
            loadCbBoxDepartment();
            loadCbBoxPosition();
            loadCbBoxRole();
        }

        public void loadCbBoxRole()
        {
            // SELECT * FROM ROLE
            var roles = db.Roles.ToList();

            cmbBoxRole.ValueMember = "roleId";
            cmbBoxRole.DisplayMember = "roleName";
            cmbBoxRole.DataSource = roles;
        }

        public void loadCbBoxGender()
        {
            // SELECT * FROM GENDER
            var gender = db.Genders.ToList();

            cmbBox_empGender.ValueMember = "genderId";
            cmbBox_empGender.DisplayMember = "genderName";
            cmbBox_empGender.DataSource = gender;
        }

        public void loadCbBoxDepartment()
        {
            // SELECT * FROM DEPARTMENT
            var department = db.Departments.ToList();

            cmbBox_empDepartment.ValueMember = "departmentId";
            cmbBox_empDepartment.DisplayMember = "departmentDescription";
            cmbBox_empDepartment.DataSource = department;
        }

        public void loadCbBoxPosition()
        {
            // SELECT * FROM POSITION
            var positions = db.Positions.ToList();

            cmbBox_empPosition.ValueMember = "positionId";
            cmbBox_empPosition.DisplayMember = "positionDescription";
            cmbBox_empPosition.DataSource = positions;
        }

        private void DisableStartProfileState()
        {
            //Employee Details
            txtempID.Enabled = false;
            txtempName.Enabled = false;
            cmbBox_empGender.Enabled = false;
            DOB_date.Enabled = false;
            txtempEmail.Enabled = false;
            cmbBox_empDepartment.Enabled = false;
            cmbBox_empPosition.Enabled = false;
            //User Account Details
            txtuserUsername.Enabled = false;
            txtuserPassword.Enabled = false;
            cmbBoxRole.Enabled = false;
            //Save Button
            btnSAVE.Enabled = false;
        }

        private void DisableEditing()
        {
            //Employee Details
            txtempID.Enabled = false;
            txtempName.Enabled = false;
            cmbBox_empGender.Enabled = false;
            DOB_date.Enabled = false;
            txtempEmail.Enabled = false;
            cmbBox_empDepartment.Enabled = false;
            cmbBox_empPosition.Enabled = false;
            //User Account Details
            txtuserUsername.Enabled = false;
            txtuserPassword.Enabled = false;
            cmbBoxRole.Enabled = false;
            //Save Button
            btnSAVE.Enabled = false;

            isEditing = false;
        }

        private void EnableEditing()
        {
            //Employee Details
            txtempID.Enabled = true;
            txtempName.Enabled = true;
            cmbBox_empGender.Enabled = true;
            DOB_date.Enabled = true;
            txtempEmail.Enabled = true;
            cmbBox_empDepartment.Enabled = true;
            cmbBox_empPosition.Enabled = true;
            //User Account Details
            txtuserUsername.Enabled = true;
            txtuserPassword.Enabled = true;
            cmbBoxRole.Enabled = true;
            //Save Button
            btnSAVE.Enabled = true;

            isEditing = true;
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if(isEditing)
            {
                DisableEditing();
            }
            else
            {
                EnableEditing();
            }
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {

        }
    }
}
