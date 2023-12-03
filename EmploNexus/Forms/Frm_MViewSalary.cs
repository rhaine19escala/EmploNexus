using EmploNexus.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploNexus.Forms
{
    public partial class Frm_MViewSalary : Form
    {
        UserRepository repo;
        EmploNexusu_uEntities db;

        public Frm_MViewSalary()
        {          
            InitializeComponent();
            db = new EmploNexusu_uEntities();
            repo = new UserRepository();
        }

        private void Frm_MViewSalary_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");

            loadUser();
        }

        private void loadUser()
        {
            int empId = UserLogged.GetInstance().UserAccounts.user_empID;
            dgv_SalaryEmp.DataSource = repo.GetSalary(empId);
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Frm_Manager_Dashboard manager_Dashboard = new Frm_Manager_Dashboard();
            manager_Dashboard.Show();
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //View Employee
            Frm_MViewEmployee mViewEmployee = new Frm_MViewEmployee();
            mViewEmployee.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //View Attendance
            Frm_MAttendance mAttendance = new Frm_MAttendance();
            mAttendance.Show();
            this.Hide();
        }

        private void dgv_SalaryEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_SalaryEmp.Rows.Count)
                {
                    txtempID.Text = Convert.ToInt32(dgv_SalaryEmp.Rows[e.RowIndex].Cells[0].Value).ToString();

                    if (DateTime.TryParse(dgv_SalaryEmp.Rows[e.RowIndex].Cells[1].Value?.ToString(), out DateTime selectedDate))
                    {
                        txtWageDate.Text = selectedDate.ToString("MM/dd/yyyy");
                    }
                    else
                    {
                        txtWageDate.Text = DateTime.Today.ToString("MM/dd/yyyy");
                    }

                    if (decimal.TryParse(dgv_SalaryEmp.Rows[e.RowIndex].Cells[2].Value?.ToString(), out decimal salary))
                    {
                        //txtempSalary.Text = salary.ToString("N0");
                        txtempSalary.Text = salary.ToString("C2", CultureInfo.GetCultureInfo("en-PH"));
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

        private void dgv_SalaryEmp_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0 && e.Value != null)
            {
                string money = e.Value.ToString();
                decimal salary;
                if (decimal.TryParse(money, out salary))
                {
                    CultureInfo peso = new CultureInfo("en-PH");
                    e.Value = salary.ToString("C", peso);
                    e.FormattingApplied = true;
                }
            }
            else if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                e.Value = 0.00m.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
                e.FormattingApplied = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadUser();
            txtempSalary.Clear();
            txtempID.Clear();
            txtWageDate.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal totalWageAmount = 0;

            foreach (DataGridViewRow row in dgv_SalaryEmp.Rows)
            {
                if (row.Cells["SALARY"].Value != null && decimal.TryParse(row.Cells["SALARY"].Value.ToString(), out decimal salary))
                {
                    totalWageAmount += salary;
                }
            }

            txtTotalWageAmount.Text = totalWageAmount.ToString("C", CultureInfo.GetCultureInfo("en-PH"));
        }
    }
}
