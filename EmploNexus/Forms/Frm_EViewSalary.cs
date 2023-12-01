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
    public partial class Frm_EViewSalary : Form
    {
        UserRepository repo;
        EmploNexusu_uEntities db;

        public Frm_EViewSalary()
        {
            
            InitializeComponent();
            db = new EmploNexusu_uEntities();
            repo = new UserRepository();
        }

        private void Frm_Employee_Dashboard_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            txtCurrentTime.Text = currentTime.ToString("hh:mm:ss tt");

            payrollDate.Format = DateTimePickerFormat.Custom;
            payrollDate.CustomFormat = "MM/dd/yyyy";

            loadUser();
        }

        private void loadUser()
        {
            int empId = UserLogged.GetInstance().UserAccounts.user_empID;
            dgv_SalaryEmp.DataSource = repo.GetSalary(empId);
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_Employee_Dashboard employee_Dashboard = new Frm_Employee_Dashboard();
            employee_Dashboard.Show();
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

        private void dgv_SalaryEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_SalaryEmp.Rows.Count)
                {
                    if (DateTime.TryParse(dgv_SalaryEmp.Rows[e.RowIndex].Cells[1].Value?.ToString(), out DateTime selectedDate))
                    {
                        payrollDate.Value = selectedDate;
                    }
                    else
                    {
                        payrollDate.Value = DateTime.Today;
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
            payrollDate.Value = DateTime.Today;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
