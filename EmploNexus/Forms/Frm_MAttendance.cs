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
    public partial class Frm_MAttendance : Form
    {
        UserRepository repo;
        EmploNexusu_uEntities db;
        public Frm_MAttendance()
        {         
            InitializeComponent();
            db = new EmploNexusu_uEntities();
            repo = new UserRepository();
        }

        private void Frm_MAttendance_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");

            loadUser();
        }

        private void loadUser()
        {
            int empId = UserLogged.GetInstance().UserAccounts.user_empID;
            dgv_EmpAttendance.DataSource = repo.GetAttendance(empId);
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Frm_Manager_Dashboard manager_Dashboard = new Frm_Manager_Dashboard();
            manager_Dashboard.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to log out?", "EmploNexus: Log out", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Frm_Login logout = new Frm_Login();
                logout.Show();
                this.Hide();
            }
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //View Salary
            Frm_MViewSalary mViewSalary = new Frm_MViewSalary();
            mViewSalary.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //View Employee
            Frm_MViewEmployee mViewEmployee = new Frm_MViewEmployee();
            mViewEmployee.Show();
            this.Hide();
        }

        private void dgv_EmpAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_EmpAttendance.Rows.Count)
                {
                    txtempID.Text = Convert.ToInt32(dgv_EmpAttendance.Rows[e.RowIndex].Cells[0].Value).ToString();

                    if (DateTime.TryParse(dgv_EmpAttendance.Rows[e.RowIndex].Cells[1].Value?.ToString(), out DateTime selectedDate))
                    {
                        txtAttendanceDate.Text = selectedDate.ToString("MM/dd/yyyy");
                    }
                    else
                    {
                        txtAttendanceDate.Text = DateTime.Today.ToString("MM/dd/yyyy");
                    }

                    Status();
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

        private void Status()
        {
            int selectedRowIndex = dgv_EmpAttendance.SelectedCells[0].RowIndex;
            int columnIndex = 2;
            object formattedValue = dgv_EmpAttendance.Rows[selectedRowIndex].Cells[columnIndex].FormattedValue;
            txtAttendanceStatus.Text = formattedValue.ToString();
        }

        private void dgv_EmpAttendance_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0 && e.Value != null)
            {
                string stringValue = e.Value.ToString();
                int statusvalue;
                if (int.TryParse(stringValue, out statusvalue))
                {
                    if (statusvalue == 1)
                    {
                        e.Value = "Present";
                    }
                    else if (statusvalue == 2)
                    {
                        e.Value = "Absent";
                    }
                    else if (statusvalue == 3)
                    {
                        e.Value = "Late";
                    }
                    else if (statusvalue == 4)
                    {
                        e.Value = "Early Departure";
                    }
                    else if (statusvalue == 5)
                    {
                        e.Value = "Half Day";
                    }
                    else if (statusvalue == 6)
                    {
                        e.Value = "Remote";
                    }
                    else if (statusvalue == 7)
                    {
                        e.Value = "On Leave";
                    }
                    else if (statusvalue == 8)
                    {
                        e.Value = "Business Trip";
                    }
                    else if (statusvalue == 9)
                    {
                        e.Value = "Training";
                    }
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadUser();
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            txtempID.Clear();
            txtAttendanceStatus.Clear();
            txtAttendanceDate.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
    }
}
