using EmploNexus.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploNexus.Forms
{
    public partial class Frm_AEmployee_Management : Form
    {
        //String strConnection = @"Data Source=.\sqlexpress;Initial Catalog=EMPLONEXUS_NEW;Integrated Security=True";
        UserRepository repo;
        EMPLONEXUS_ db;

        public Frm_AEmployee_Management()
        {
            InitializeComponent();
            //
            db = new EMPLONEXUS_();
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


        private void Frm_Employee_Management_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");


            repo = new UserRepository();
            loadUser();
        }
        private void loadUser()
        {
            dgv_AllEmployeesWdetails.DataSource = repo.GetEmployeeList();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_Admin_Dashboard admin_Dashboard = new Frm_Admin_Dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Frm_AUser_Management aUser_Management = new Frm_AUser_Management();
            aUser_Management.Show();
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
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Frm_ASalary_Management aSalary_Management = new Frm_ASalary_Management();
            aSalary_Management.Show();
            this.Hide();
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

        private void dgv_AllEmployeesWdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtempID.Text = Convert.ToInt32(dgv_AllEmployeesWdetails.Rows[e.RowIndex].Cells[0].Value).ToString();
                txtempName.Text = dgv_AllEmployeesWdetails.Rows[e.RowIndex].Cells[1].Value as String;
                txtempEmail.Text = dgv_AllEmployeesWdetails.Rows[e.RowIndex].Cells[2].Value as String;

                int genderID = Convert.ToInt32(dgv_AllEmployeesWdetails.Rows[e.RowIndex].Cells[3].Value);
                cmbBox_empGender.SelectedValue = genderID;

                int department = Convert.ToInt32(dgv_AllEmployeesWdetails.Rows[e.RowIndex].Cells[4].Value);
                cmbBox_empDepartment.SelectedValue = department;

                int position = Convert.ToInt32(dgv_AllEmployeesWdetails.Rows[e.RowIndex].Cells[5].Value);
                cmbBox_empPosition.SelectedValue = position;

                txtempSalary.Text = dgv_AllEmployeesWdetails.Rows[e.RowIndex].Cells[6].Value as String;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Encountered :" + ex.Message, "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
