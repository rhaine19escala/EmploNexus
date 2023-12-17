using EmploNexus.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            loadStatus();
            ConfigureAttendanceDate();
        }

        private void attendanceDate_Validating(object sender, CancelEventArgs e)
        {
            //DateTime selectedDate = attendanceDate.Value.Date;

            //if (selectedDate != DateTime.Today)
            //{
            //    e.Cancel = true;
            //    MessageBox.Show("Please select the current date for attendance.", "EmploNexus: Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    attendanceDate.Value = DateTime.Today.Date;
            //}

            DateTime selectedDate = attendanceDate.Value.Date;

            DateTime minDate = DateTime.Today.Date;
            DateTime maxDate = DateTime.Today.AddDays(7).Date;

            if (selectedDate < minDate || selectedDate > maxDate)
            {
                e.Cancel = true;

                MessageBox.Show($"Please select a date between {minDate.ToShortDateString()} and {maxDate.ToShortDateString()} for attendance.", "EmploNexus: Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                attendanceDate.Value = minDate;
            }
        }

        private void ConfigureAttendanceDate()
        {
            attendanceDate.Validating += attendanceDate_Validating;

            attendanceDate.Format = DateTimePickerFormat.Custom;
            attendanceDate.CustomFormat = "MM/dd/yyyy";
            attendanceDate.MinDate = DateTime.Today.AddDays(-7).Date;
            attendanceDate.MaxDate = DateTime.Today.AddDays(7).Date;
            attendanceDate.Value = DateTime.Today.Date;
        }

        private void loadUser()
        {
            dgv_AllAttendanceWdetails.DataSource = repo.GetAllAttendance();
            dgv_allempInfo.DataSource = repo.AllEmployeeInfo();
        }

        public void loadStatus()
        {
            // SELECT * FROM STATUS
            var status = db.Status.ToList();

            cmbBox_status.ValueMember = "statusId";
            cmbBox_status.DisplayMember = "statusName";
            cmbBox_status.DataSource = status;
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
            //try
            //{
                if (e.RowIndex >= 0 && e.RowIndex < dgv_AllAttendanceWdetails.Rows.Count)
                {

                    int attendanceId = Convert.ToInt32(dgv_AllAttendanceWdetails.Rows[e.RowIndex].Cells[0].Value);
                    var attendanceRecord = db.Attendances.FirstOrDefault(u => u.AttendanceNo == attendanceId);
                    if (attendanceRecord != null)
                    {
                        txtAttendanceNo.Text = attendanceRecord.AttendanceNo.ToString();
                    }

                    //txtAttendanceNo.Text = Convert.ToInt32(dgv_AllAttendanceWdetails.Rows[e.RowIndex].Cells[0].Value).ToString();
                    txtempID.Text = Convert.ToInt32(dgv_AllAttendanceWdetails.Rows[e.RowIndex].Cells[1].Value).ToString();

                    if (DateTime.TryParse(dgv_AllAttendanceWdetails.Rows[e.RowIndex].Cells[2].Value?.ToString(), out DateTime selectedDate))
                    {
                        attendanceDate.Value = selectedDate;
                    }
                    else
                    {
                        attendanceDate.Value = DateTime.Today.Date;
                    }



                    int status = Convert.ToInt32(dgv_AllAttendanceWdetails.Rows[e.RowIndex].Cells[3].Value);
                    cmbBox_status.SelectedValue = status;
                }
                else
                {
                    MessageBox.Show("Invalid row index selected.", "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error Encountered : " + ex.Message, "EmploNexus : Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void dgv_allempInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgv_allempInfo.Rows.Count)
                {
                    txtempID.Text = Convert.ToInt32(dgv_allempInfo.Rows[e.RowIndex].Cells[1].Value).ToString();
                    cmbBox_status.SelectedIndex = 0;
                    attendanceDate.Value = DateTime.Today.Date;
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

        private void dgv_AllAttendanceWdetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0 && e.Value != null)
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

        private void dgv_allempInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0 && e.Value != null)
            {
                string stringValue = e.Value.ToString();
                int departmentvalue;
                if (int.TryParse(stringValue, out departmentvalue))
                {
                    if (departmentvalue == 1)
                    {
                        e.Value = "HR";
                    }
                    else if (departmentvalue == 2)
                    {
                        e.Value = "Finance";
                    }
                    else if (departmentvalue == 3)
                    {
                        e.Value = "IT";
                    }
                    e.FormattingApplied = true;
                }
            }

            if (e.ColumnIndex == 4 && e.RowIndex >= 0 && e.Value != null)
            {
                string stringValue = e.Value.ToString();
                int positionvalue;
                if (int.TryParse(stringValue, out positionvalue))
                {
                    if (positionvalue == 1)
                    {
                        e.Value = "HR Manager";
                    }
                    else if (positionvalue == 2)
                    {
                        e.Value = "HR Generalist";
                    }
                    else if (positionvalue == 3)
                    {
                        e.Value = "Financial Controller";
                    }
                    else if (positionvalue == 4)
                    {
                        e.Value = "Accountant";
                    }
                    else if (positionvalue == 5)
                    {
                        e.Value = "IT Manager";
                    }
                    else if (positionvalue == 6)
                    {
                        e.Value = "Software Developer";
                    }
                    e.FormattingApplied = true;
                }
            }
        }

        private bool EmpIDExistsInOtherTable(int empID, DataGridView otherTable)
        {
            foreach (DataGridViewRow row in otherTable.Rows)
            {
                if (!row.IsNewRow)
                {
                    int otherEmpID = Convert.ToInt32(row.Cells["EMPLOYEE_ID"].Value);
                    if (otherEmpID == empID)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool IsValidEmpID(string employeeID)
        {
            // Use \d to match digits, and {8} to specify the length as 8
            string employeeIDPattern = @"^\d{8}$";
            bool isValid = Regex.IsMatch(employeeID, employeeIDPattern);
            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String emp_id = txtempID.Text;
            errorProvider1.Clear();

            if (String.IsNullOrEmpty(emp_id))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtempID, "Empty Field!");
                return;
            }
            if (!IsValidEmpID(emp_id))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtempID, "Invalid Employee ID Format!");
                return;
            }
            //int empID = Convert.ToInt32(emp_id);
            //if (EmpIDExistsInOtherTable(empID, dgv_AllAttendanceWdetails))
            //{
            //    errorProvider1.Clear();
            //    errorProvider1.SetError(txtempID, $"Employee with ID {empID} is already added!");
            //    return;
            //}

            try
            {
                using (var db = new EmploNexusu_uEntities())
                {
                    if (!int.TryParse(txtAttendanceNo.Text, out int attendanceNo))
                    {
                        MessageBox.Show("Invalid Attendance No.", "EmploNexus: Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    int user_empIDToAdd = Convert.ToInt32(txtempID.Text);
                    int statusId = (Int32)cmbBox_status.SelectedValue;
                    DateTime attendance = attendanceDate.Value.Date;

                    bool isDuplicateDate = db.Attendances.Any(u => u.AttendanceNo == attendanceNo && u.AttendanceEmp_ID == user_empIDToAdd && u.AttendanceDate == attendance);

                    if (!isDuplicateDate)
                    {
                        Attendance att = new Attendance
                        {
                            AttendanceEmp_ID = user_empIDToAdd,
                            AttendanceStatusId = statusId,
                            AttendanceDate = attendance
                        };

                        db.Attendances.Add(att);
                        db.SaveChanges();
                        loadUser();
                        MessageBox.Show("Attendance Info Added Successfully!", "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputFields();
                    }
                    else
                    {
                        MessageBox.Show("Attendance Info not Added. Duplicate date found!", "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                //using (var db = new EmploNexusu_uEntities())
                //{
                //    if (!int.TryParse(txtAttendanceNo.Text, out int attendanceNo))
                //    {
                //        MessageBox.Show("Invalid Attendance No.", "EmploNexus: Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        return;
                //    }

                //    int user_empIDToAdd = Convert.ToInt32(txtempID.Text);
                //    int statusId = (Int32)cmbBox_status.SelectedValue;
                //    DateTime attendance = attendanceDate.Value.Date;

                //    bool isDuplicateDate = db.Attendances.Any(u => u.AttendanceNo == attendanceNo && u.AttendanceEmp_ID == user_empIDToAdd && u.AttendanceDate == attendance);

                //    if (!isDuplicateDate)
                //    {
                //        db.Database.ExecuteSqlCommand(
                //            "sp_addAttendance @AttendanceEmp_ID, @AttendanceDate, @AttendanceStatusId",
                //            new SqlParameter("@AttendanceEmp_ID", user_empIDToAdd),
                //            new SqlParameter("@AttendanceDate", attendance),
                //            new SqlParameter("@AttendanceStatusId", statusId)
                //        );

                //        loadUser();
                //        MessageBox.Show("Attendance Info Added Successfully!", "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        ClearInputFields();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Attendance Info not Added. Duplicate date found!", "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Attendance Info not Added Successfully! \nError :" + ex.Message, "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInputFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String emp_id = txtempID.Text;
            errorProvider1.Clear();

            if (String.IsNullOrEmpty(emp_id))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtempID, "Empty Field!");
                return;
            }
            if (!IsValidEmpID(emp_id))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtempID, "Invalid Employee ID Format!");
                return;
            }

            using (var db = new EmploNexusu_uEntities())
            {
                try
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to Update this Attendance Information?", "EmploNexus: Attendance Information Management", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        int attendanceNo = Convert.ToInt32(txtAttendanceNo.Text);
                        int user_empIDToUpdate = Convert.ToInt32(txtempID.Text);
                        int statusId = (Int32)cmbBox_status.SelectedValue;
                        DateTime attendance = attendanceDate.Value;

                        Attendance existingUser = db.Attendances.FirstOrDefault(u => u.AttendanceNo == attendanceNo && u.AttendanceEmp_ID == user_empIDToUpdate);

                        if (existingUser != null)
                        {
                            bool isDuplicate = db.Attendances.Any(u => u.AttendanceEmp_ID == user_empIDToUpdate
                                && u.AttendanceDate == attendance
                                && u.AttendanceNo != existingUser.AttendanceNo);

                            if (!isDuplicate)
                            {
                                existingUser.AttendanceEmp_ID = user_empIDToUpdate;
                                existingUser.AttendanceStatusId = statusId;
                                existingUser.AttendanceDate = attendance;

                                db.SaveChanges();
                                loadUser();
                                MessageBox.Show("Attendance Info Updated Successfully!", "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearInputFields();
                            }
                            else
                            {
                                MessageBox.Show("Attendance Info not found!", "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Attendance Info not Updated. No matching record found!", "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        //int attendanceNo = Convert.ToInt32(txtAttendanceNo.Text);
                        //int user_empIDToUpdate = Convert.ToInt32(txtempID.Text);
                        //int statusId = (Int32)cmbBox_status.SelectedValue;
                        //DateTime attendance = attendanceDate.Value;

                        //using (var db = new EmploNexusu_uEntities())
                        //{
                        //    Attendance existingAttendance = db.Attendances.FirstOrDefault(u => u.AttendanceNo == attendanceNo && u.AttendanceEmp_ID == user_empIDToUpdate);

                        //    if (existingAttendance != null)
                        //    {
                        //        bool isDuplicate = db.Attendances.Any(u => u.AttendanceEmp_ID == user_empIDToUpdate
                        //            && u.AttendanceDate == attendance
                        //            && u.AttendanceNo != existingAttendance.AttendanceNo);

                        //        if (!isDuplicate)
                        //        {
                        //            db.Database.ExecuteSqlCommand(
                        //                "sp_updateAttendance @AttendanceNo, @AttendanceDate, @AttendanceStatusId",
                        //                new SqlParameter("@AttendanceNo", attendanceNo),
                        //                new SqlParameter("@AttendanceDate", attendance),
                        //                new SqlParameter("@AttendanceStatusId", statusId)
                        //            );

                        //            loadUser();
                        //            MessageBox.Show("Attendance Info Updated Successfully!", "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //            ClearInputFields();
                        //        }
                        //        else
                        //        {
                        //            MessageBox.Show("Attendance Info not Updated. Duplicate date found!", "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //        }
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("Attendance Info not Updated. No matching record found!", "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //    }
                        //}
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Attendance Info not Updated Successfully!. \nError :" + ex.Message, "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearInputFields();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Delete this Attendance Information?", "EmploNexus: Attendance Information Management", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    using (var db = new EmploNexusu_uEntities())
                    {
                        int user_empIDToDelete = Convert.ToInt32(txtempID.Text);

                        Attendance userToDelete = db.Attendances.FirstOrDefault(u => u.AttendanceEmp_ID == user_empIDToDelete);

                        if (userToDelete != null)
                        {
                            db.Attendances.Remove(userToDelete);
                            db.SaveChanges();
                            loadUser();
                            MessageBox.Show("Attendance Info Deleted Successfully!", "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Attendance Info not found!", "EmploNexus:  Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    //using (var db = new EmploNexusu_uEntities())
                    //{
                    //    int user_empIDToDelete = Convert.ToInt32(txtempID.Text);

                    //    db.Database.ExecuteSqlCommand(
                    //        "sp_deleteAttendance @AttendanceNo",
                    //        new SqlParameter("@AttendanceNo", user_empIDToDelete)
                    //    );

                    //    loadUser();
                    //    MessageBox.Show("Attendance Info Deleted Successfully!", "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Attendance Info not Deleted Successfully! \nError :" + ex.Message, "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var db = new EmploNexusu_uEntities())
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(txtempSearch.Text))
                    {
                        MessageBox.Show("Please enter a valid Employee ID.", "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int user_empIDToSearch = Convert.ToInt32(txtempSearch.Text);
                        Attendance existingUser = db.Attendances.FirstOrDefault(u => u.AttendanceEmp_ID == user_empIDToSearch);
                        if (existingUser != null)
                        {
                            var foundUserList = new List<vw_all_attendance>
                            {
                                new vw_all_attendance
                                {
                                    ATTENDANCE_NO_ = existingUser.AttendanceNo,
                                    EMPLOYEE_ID = existingUser.AttendanceEmp_ID,
                                    DATE = existingUser.AttendanceDate,
                                    STATUS = existingUser.AttendanceStatusId
                                }
                            };

                            dgv_AllAttendanceWdetails.DataSource = foundUserList;
                            MessageBox.Show("Employee ID Found!", "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtempSearch.Clear();
                        }
                        else
                        {
                            loadUser();
                            txtempSearch.Clear();
                            MessageBox.Show("Employee ID not found!", "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch (Exception ex)
                {
                    loadUser();
                    txtempSearch.Text = "";
                    MessageBox.Show($"Error searching for Employee ID. \nError: {ex.Message}", "EmploNexus: Attendance Information Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ClearInputFields()
        {
            errorProvider1.Clear();
            txtAttendanceNo.Clear();
            txtempID.Clear();
            cmbBox_status.SelectedIndex = 0;
            attendanceDate.Value = DateTime.Today;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadUser();
            ClearInputFields();
        }

    }
}
