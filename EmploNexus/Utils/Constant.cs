using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploNexus
{
    public enum ErrorCode
    {
        Success = 0,
        Error = 1
    }
    public enum Roles
    {
        Employee = 1,
        Manager = 2,
        Admin = 3
    }

    public enum Genders
    {
        Male = 1,
        Female = 2
    }

    public enum Departments
    {
        HR = 1,
        Finance = 2,
        IT = 3
    }

    public enum Positions
    {
        HR_Manager = 1,
        HR_Generalist = 2,
        Financial_Controller = 3,
        Accountant = 4,
        IT_Manager = 5,
        Software_Developer = 6
    }

    public enum Status
    {
        Present = 1,
        Absent = 2,
        Late = 3,
        Early_Departure = 4,
        Half_Day = 5,
        Remote = 6,
        On_Leave = 7,
        Business_Trip = 8,
        Training = 9
    }

    public class Constant
    {
        
    }
}
