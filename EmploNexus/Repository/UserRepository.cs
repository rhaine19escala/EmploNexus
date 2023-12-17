using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmploNexus.AppData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EmploNexus
{
    public class UserRepository
    {
        private EmploNexusT_TEntities emploNexusEntities;

        public UserRepository()
        {
            emploNexusEntities = new EmploNexusT_TEntities();
        }
     
        public UserAccount GetUserByUsername(String username)
        {
            // re-initialize emploNexusEntities object because sometimes data in the list not updated
            emploNexusEntities = new EmploNexusT_TEntities();
            // SELECT TOP 1 * FROM USERACCOUNT WHERE username == username
            return emploNexusEntities.UserAccounts.Where(s => s.username == username).FirstOrDefault();
        }

        public Employee GetEmployeeById(int userEmpId)
        {
            emploNexusEntities = new EmploNexusT_TEntities();
            return emploNexusEntities.Employees.FirstOrDefault(e => e.emp_ID == userEmpId);
        }

        public List<vw_all_user_role> GetAllUserRole()
        {
            emploNexusEntities = new EmploNexusT_TEntities();

            return emploNexusEntities.vw_all_user_role.OrderBy(e => e.USER_NO_).ToList();
        }

        public List<vw_all_employee> GetEmployeeList()
        {
            emploNexusEntities = new EmploNexusT_TEntities();
            return emploNexusEntities.vw_all_employee.OrderBy(e => e.EMPLOYEE_NO_).ToList();
        }

        public List<vw_all_salary> GetEmployeeSalary()
        {
            emploNexusEntities = new EmploNexusT_TEntities();

            return emploNexusEntities.vw_all_salary.OrderBy(e => e.SALARY_NO_).ToList();
        }

        public List<vw_all_attendance> GetAllAttendance()
        {
            emploNexusEntities = new EmploNexusT_TEntities();

            return emploNexusEntities.vw_all_attendance.OrderBy(e => e.ATTENDANCE_NO_).ToList();
        }

        public List<vw_all_empID> AllEmployeeID()
        {
            emploNexusEntities = new EmploNexusT_TEntities();

            return emploNexusEntities.vw_all_empID.OrderBy(e => e.USER_NO_).ToList();
        }

        public List<vw_all_empInfo> AllEmployeeInfo()
        {
            emploNexusEntities = new EmploNexusT_TEntities();
            return emploNexusEntities.vw_all_empInfo.OrderBy(e => e.EMPLOYEE_NO_).ToList();
        }

        public List<vw_emp_salary> GetSalary(int employeeId)
        {
            emploNexusEntities = new EmploNexusT_TEntities();

            return emploNexusEntities.vw_emp_salary.Where(e => e.EMPLOYEE_ID == employeeId).OrderBy(e => e.PAY_DATE).ToList();
        }

        public List<vw_emp_Attendance> GetAttendance(int employeeId)
        {
            emploNexusEntities = new EmploNexusT_TEntities();

            return emploNexusEntities.vw_emp_Attendance.Where(e => e.EMPLOYEE_ID == employeeId).OrderBy(e => e.DATE).ToList();
        }

        public List<vw_manage_employee> GetEmployeesInSameDepartment(int currentUserId, int currentDepartmentId)
        {
            emploNexusEntities = new EmploNexusT_TEntities();

            return emploNexusEntities.vw_manage_employee.Where(e => e.EMPLOYEE_ID != currentUserId && e.DEPARTMENT == currentDepartmentId).OrderBy(e => e.EMPLOYEE_ID).ToList();
        }


        public void UpdateEmployeeData(int empId, string empName, int genderId, DateTime dob, string empEmail, int departmentId, int positionId)
        {
            var userAccount = emploNexusEntities.UserAccounts.FirstOrDefault(e => e.user_empID == empId);
            try
            {
                if (userAccount != null)
                {
                    var employeeInfo = emploNexusEntities.Employees.FirstOrDefault(e => e.emp_ID == userAccount.user_empID);

                    if (employeeInfo != null)
                    {
                        employeeInfo.emp_name = empName;
                        employeeInfo.emp_genderId = genderId;
                        employeeInfo.emp_DOB = dob;
                        employeeInfo.emp_email = empEmail;
                        employeeInfo.emp_departmentId = departmentId;
                        employeeInfo.emp_positionId = positionId;

                        emploNexusEntities.SaveChanges();
                    }
                    else
                    {
                        throw new InvalidOperationException("Employee not found");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("User account not found :" + ex.Message, "EmploNexus: Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void UpdateUserData(int empId, string newUsername, string newPassword)
        {
            var user = emploNexusEntities.UserAccounts.FirstOrDefault(u => u.user_empID == empId);

            if (user != null)
            {
                if (!string.IsNullOrEmpty(newUsername))
                {
                    user.username = newUsername;
                    user.password = newPassword;
                    emploNexusEntities.SaveChanges();
                }
                else
                {
                    throw new ArgumentException("Invalid new username");
                }
            }
            else
            {
                throw new InvalidOperationException("User not found");
            }
        }

        public string GetRoleNameById(int roleId)
        {
            var roleMapping = new Dictionary<int, string>
            {
                { 1, "Employee" },
                { 2, "Manager" },
                { 3, "Admin" },
            };

            if (roleMapping.TryGetValue(roleId, out var roleName))
            {
                return roleName;
            }
            return "Employee";
        }

        public string GetGenderNameById(int genderId)
        {
            var genderMapping = new Dictionary<int, string>
            {
                { 1, "Male" },
                { 2, "Female" },
            };

            if (genderMapping.TryGetValue(genderId, out var genderName))
            {
                return genderName;
            }
            return "Male";
        }

        public string GetDepartmentNameById(int departmentId)
        {
            var departmentMapping = new Dictionary<int, string>
            {
                { 1, "Human Resources" },
                { 2, "Finance" },
                { 3, "Information Technology" }
            };

            if (departmentMapping.TryGetValue(departmentId, out var departmentName))
            {
                return departmentName;
            }
            return "Human Resources";
        }

        public string GetPositionNameById(int positionId)
        {
            var positionMapping = new Dictionary<int, string>
            {
                { 1, "HR Manager" },
                { 2, "HR Generalist" },
                { 3, "Finance Controller" },
                { 4, "Accountant" },
                { 5, "IT Manager" },
                { 6, "Software Developer" },
            };

            if (positionMapping.TryGetValue(positionId, out var positionName))
            {
                return positionName;
            }
            return "HR Manager";
        }

        public ErrorCode Register(String username, String password)
        {
            try
            {
                using (var emploNexusEntities = new EmploNexusT_TEntities())
                {
                    var newUser = new UserAccount();
                    newUser.username = username;
                    newUser.password = password;

                    emploNexusEntities.UserAccounts.Add(newUser);
                    emploNexusEntities.SaveChanges();

                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return ErrorCode.Error;
            }
        }

        public ErrorCode NewUser(UserAccount aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                emploNexusEntities.UserAccounts.Add(aUserAccount);
                emploNexusEntities.SaveChanges();

                outMessage = "Inserted";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        public ErrorCode UpdateUser(int? userId, UserAccount aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                // Find the user with id
                UserAccount user = emploNexusEntities.UserAccounts.Where(m => m.userNo == userId).FirstOrDefault();
                // Update the value of the retrieved user
                user.username = aUserAccount.username;
                user.password = aUserAccount.password;

                emploNexusEntities.SaveChanges();// Execute the update

                outMessage = "Updated";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                retValue = ErrorCode.Success;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        public ErrorCode RemoveUser(int? userId, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                UserAccount user = emploNexusEntities.UserAccounts.Where(m => m.userNo == userId).FirstOrDefault();
                // Remove the user
                emploNexusEntities.UserAccounts.Remove(user);
                emploNexusEntities.SaveChanges();       // Execute the update

                outMessage = "Deleted";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                retValue = ErrorCode.Error;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }
    }
}
