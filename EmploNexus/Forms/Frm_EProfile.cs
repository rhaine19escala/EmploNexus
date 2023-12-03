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
    public partial class Frm_EProfile : Form
    {
        UserRepository repo;
        EmploNexusu_uEntities db;
        private bool isEditing = false;
        private int loggedInempID;
        private string loggedUsername;

        public Frm_EProfile()
        {    
            InitializeComponent();
            repo = new UserRepository();
            db = new EmploNexusu_uEntities();
            loadUser();
            //
            loggedInempID = UserLogged.GetInstance().UserAccounts.user_empID;
            loggedUsername = UserLogged.GetInstance().UserAccounts.username;

            try
            {
                DisplayEmployeeData(loggedInempID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_Employee_Dashboard_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
            txtCurrentDate.Text = currentTime.ToString("D");

            DOB_date.Format = DateTimePickerFormat.Custom;
            DOB_date.CustomFormat = "MM/dd/yyyy";

            DisableStartProfileState();
            loadUser();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Employee Dashboard
            Frm_Employee_Dashboard employee_Dashboard = new Frm_Employee_Dashboard();
            employee_Dashboard.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            //View Salary
            Frm_EViewSalary eViewSalary = new Frm_EViewSalary();
            eViewSalary.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //View Attendance
            FrmEnAttendance enAttendance = new FrmEnAttendance();
            enAttendance.Show();
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

        //NOTE: COMBO BOX DATA STILL NOT DISPLAYING NEED ASAP ATTENTION!!
        private void DisplayEmployeeData(int userEmpId)
        {
            try
            {
                UserAccount user = repo.GetUserByUsername(loggedUsername);

                if (user != null)
                {
                    txtuserUsername.Text = user.username;
                    txtempID.Text = user.user_empID.ToString();

                    Employee employee = repo.GetEmployeeById(userEmpId);

                    if (employee != null)
                    {
                        txtempName.Text = employee.emp_name;

                        cmbBox_empGender.SelectedValue = employee.emp_genderId;

                        DOB_date.Value = employee.emp_DOB;
                        txtempEmail.Text = employee.emp_email;

                        cmbBox_empDepartment.SelectedValue = employee.emp_departmentId;

                        cmbBox_empPosition.SelectedValue = employee.emp_positionId;
                    }
                    else
                    {
                        MessageBox.Show("Employee details not found!", "EmploNexus: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("User details not found!", "EmploNexus: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadUser()
        {
            loadCbBoxGender();
            loadCbBoxDepartment();
            loadCbBoxPosition();
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
            //Save Button
            btnSAVE.Enabled = true;

            isEditing = true;
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (isEditing)
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
            try
            {
                if (int.TryParse(txtempID.Text, out int empId))
                {
                    string newUsername = txtuserUsername.Text;

                    string empName = txtempName.Text;
                    int genderId = (int)cmbBox_empGender.SelectedValue;
                    DateTime dob = DOB_date.Value;
                    string empEmail = txtempEmail.Text;
                    int departmentId = (int)cmbBox_empDepartment.SelectedValue;
                    int positionId = (int)cmbBox_empPosition.SelectedValue;

                    repo.UpdateUserData(empId, newUsername);

                    repo.UpdateEmployeeData(empId, empName, genderId, dob, empEmail, departmentId, positionId);

                    MessageBox.Show("Employee Info updated successfully.", "EmploNexus: Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableEditing();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message, "EmploNexus: Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
