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
    public partial class Frm_AeAttendance_Management : Form
    {
        UserRepository repo;
        EmploNexusu_uEntities db;
        public Frm_AeAttendance_Management()
        {
            InitializeComponent();
            repo = new UserRepository();
            db = new EmploNexusu_uEntities();
        }

        private void Frm_AeAttendance_Management_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");
            loadUser();
            ConfigureAttendanceDate();
        }

        private void attendanceDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime selectedDate = attendanceDate.Value.Date;

            if (selectedDate != DateTime.Today)
            {
                e.Cancel = true;
                MessageBox.Show("Please select the current date for attendance.", "EmploNexus: Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                attendanceDate.Value = DateTime.Today;
            }
        }

        private void ConfigureAttendanceDate()
        {
            attendanceDate.Validating += attendanceDate_Validating;

            attendanceDate.Format = DateTimePickerFormat.Custom;
            attendanceDate.CustomFormat = "MM/dd/yyyy";
            attendanceDate.MinDate = DateTime.Today;
        }

        private void loadUser()
        {
            dgv_AllAttendanceWdetails.DataSource = repo.GetAllAttendance();
            dgv_allempInfo.DataSource = repo.AllEmployeeInfo();
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

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Frm_AEmployee_Management aEmployee_Management = new Frm_AEmployee_Management();
            aEmployee_Management.Show();
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

        private void dgv_AllAttendanceWdetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_AllAttendanceWdetails.Rows.Count)
                {
                    txtempID.Text = Convert.ToInt32(dgv_AllAttendanceWdetails.Rows[e.RowIndex].Cells[1].Value).ToString();

                    if (DateTime.TryParse(dgv_AllAttendanceWdetails.Rows[e.RowIndex].Cells[2].Value?.ToString(), out DateTime selectedDate))
                    {
                        attendanceDate.Value = selectedDate;
                    }
                    else
                    {
                        attendanceDate.Value = DateTime.Today;
                    }


                }
                else
                {
                    MessageBox.Show("Invalid row index selected.", "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Encountered : " + ex.Message, "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
