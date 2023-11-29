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
using EmploNexus;

namespace EmploNexus.Forms
{
    public partial class Frm_AProfile : Form
    {
        UserRepository repo;
        EmploNexusu_uEntities db;
        private bool isEditing = false;
        private int loggedInempID;
        private string loggedUsername;

        public Frm_AProfile()
        {
            InitializeComponent();
            repo = new UserRepository();
            db = new EmploNexusu_uEntities();

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

        private void Frm_AProfile_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
            txtCurrentDate.Text = currentTime.ToString("D");

            DOB_date.Format = DateTimePickerFormat.Custom;
            DOB_date.CustomFormat = "MM/dd/yyyy";

            DisableStartProfileState();
            loadUser();
        }

        private void DisplayEmployeeData(int userEmpId)
        {
            try
            {
                UserAccount user = repo.GetUserByUsername(loggedUsername);

                if (user != null)
                {
                    // Display UserAccount details
                    txtuserUsername.Text = user.username;

                    // Display Employee details
                    Employee employee = repo.GetEmployeeById(userEmpId);

                    if (employee != null)
                    {
                        txtempID.Text = employee.emp_ID.ToString();
                        txtempName.Text = employee.emp_name;

                        // Set Gender based on the gender ID
                        cmbBox_empGender.SelectedValue = employee.emp_genderId; 

                        DOB_date.Value = employee.emp_DOB;
                        txtempEmail.Text = employee.emp_email;

                        // Set Department based on the department ID
                        cmbBox_empDepartment.SelectedValue = employee.emp_departmentId;

                        // Set Position based on the position ID
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

        private void SetComboBoxTextByValue(ComboBox comboBox, int value)
        {
            foreach (var item in comboBox.Items)
            {
                if (item is KeyValuePair<int, string>)
                {
                    var comboItem = (KeyValuePair<int, string>)item;
                    if (comboItem.Key == value)
                    {
                        comboBox.SelectedItem = comboItem;
                        break;
                    }
                }
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

        private void back_Click(object sender, EventArgs e)
        {
            //Admin Dashboard
            Frm_Admin_Dashboard admin_Dashboard = new Frm_Admin_Dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }

        private void useraccount_Click(object sender, EventArgs e)
        {
            //User Management
            Frm_AUser_Management aUser_Management = new Frm_AUser_Management();
            aUser_Management.Show();
            this.Hide();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            //Employee Management
            Frm_AEmployee_Management employee_Management = new Frm_AEmployee_Management();
            employee_Management.Show();
            this.Hide();
        }

        private void salary_Click(object sender, EventArgs e)
        {
            //Salary Management
            Frm_ASalary_Management aSalary_Management = new Frm_ASalary_Management();
            aSalary_Management.Show();
            this.Hide();
        }

        private void attendance_Click(object sender, EventArgs e)
        {
            //Attendance Management
            Frm_AeAttendance_Management attendance_Management = new Frm_AeAttendance_Management();
            attendance_Management.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "EmploNexus: Log out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Frm_Login logout = new Frm_Login();
                logout.Show();
                this.Hide();
            }
        }
    }
}
