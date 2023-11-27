using System;
using System.Collections.Generic;
using System.Data;
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
        private EmploNexusu_uEntities emploNexusEntities;

        public UserRepository()
        {
            emploNexusEntities = new EmploNexusu_uEntities();
        }
     
        public UserAccount GetUserByUsername(String username)
        {
            // re-initialize emploNexusEntities object because sometimes data in the list not updated
            emploNexusEntities = new EmploNexusu_uEntities();
            // SELECT TOP 1 * FROM USERACCOUNT WHERE username == username
            return emploNexusEntities.UserAccounts.Where(s => s.username == username).FirstOrDefault();
        }

        public Employee GetEmployeeById(int userEmpId)
        {
            emploNexusEntities = new EmploNexusu_uEntities();
            return emploNexusEntities.Employees.FirstOrDefault(e => e.emp_ID == userEmpId);
        }

        public List<vw_all_user_role> GetAllUserRole()
        {
            emploNexusEntities = new EmploNexusu_uEntities();

            return emploNexusEntities.vw_all_user_role.OrderBy(e => e.USER_NO_).ToList();
        }

        public List<vw_all_employee> GetEmployeeList()
        {
            emploNexusEntities = new EmploNexusu_uEntities();
            return emploNexusEntities.vw_all_employee.OrderBy(e => e.EMPLOYEE_NO_).ToList();
        }

        public List<vw_all_salary> GetEmployeeSalary()
        {
            emploNexusEntities = new EmploNexusu_uEntities();

            return emploNexusEntities.vw_all_salary.OrderBy(e => e.SALARY_NO_).ToList();
        }

        public List<vw_all_attendance> GetAllAttendance()
        {
            emploNexusEntities = new EmploNexusu_uEntities();

            return emploNexusEntities.vw_all_attendance.OrderBy(e => e.ATTENDANCE_NO_).ToList();
        }

        public List<vw_all_empID> AllEmployeeID()
        {
            emploNexusEntities = new EmploNexusu_uEntities();

            return emploNexusEntities.vw_all_empID.OrderBy(e => e.USER_NO_).ToList();
        }

        public List<vw_all_empInfo> AllEmployeeInfo()
        {
            emploNexusEntities = new EmploNexusu_uEntities();
            return emploNexusEntities.vw_all_empInfo.OrderBy(e => e.EMPLOYEE_NO_).ToList();
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
                { 2, "Information Technology" }
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
                using (var emploNexusEntities = new EmploNexusu_uEntities())
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
