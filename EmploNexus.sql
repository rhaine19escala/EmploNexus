CREATE DATABASE EmploNexus

USE EmploNexus

-- Create a table for Role
CREATE TABLE [dbo].[Roles](
	[roleId] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [nvarchar](50) NULL,
	[roleDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED
 ([roleId] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE [EmploNexus]
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 
INSERT [dbo].[Roles] ([roleId], [roleName], [roleDescription]) VALUES (1, N'Employee', N'Employee ')
INSERT [dbo].[Roles] ([roleId], [roleName], [roleDescription]) VALUES (2, N'Manager', N'Manager ')
INSERT [dbo].[Roles] ([roleId], [roleName], [roleDescription]) VALUES (3, N'Admin', N'Admin ')
SET IDENTITY_INSERT [dbo].[Roles] OFF

-- Create a table for Department
CREATE TABLE [dbo].[Departments](
    [departmentId] [int] IDENTITY(1,1) NOT NULL,
    [departmentName] [nvarchar](50) NULL,
    [departmentDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
 ([departmentId] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE [EmploNexus]
GO
SET IDENTITY_INSERT [dbo].[Departments] ON;
INSERT [dbo].[Departments] ([departmentId], [departmentName], [departmentDescription]) VALUES (1, N'HR', N'Human Resources');
INSERT [dbo].[Departments] ([departmentId], [departmentName], [departmentDescription]) VALUES (2, N'Finance', N'Finance');
INSERT [dbo].[Departments] ([departmentId], [departmentName], [departmentDescription]) VALUES (3, N'IT', N'Information Technology');
SET IDENTITY_INSERT [dbo].[Departments] OFF;

-- Create a table for Job Positions
CREATE TABLE [dbo].[Positions](
    [positionId] [int] IDENTITY(1,1) NOT NULL,
    [positionName] [nvarchar](50) NULL,
    [positionDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
 ([positionId] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE [EmploNexus]
GO
SET IDENTITY_INSERT [dbo].[Positions] ON;
INSERT [dbo].[Positions] ([positionId], [positionName], [positionDescription]) VALUES (1, N'HR_Manager', N'Human Resources Manager');
INSERT [dbo].[Positions] ([positionId], [positionName], [positionDescription]) VALUES (2, N'HR_Generalist', N'Human Resources Generalist');
INSERT [dbo].[Positions] ([positionId], [positionName], [positionDescription]) VALUES (3, N'Financial_Controller', N'Financial Controller');
INSERT [dbo].[Positions] ([positionId], [positionName], [positionDescription]) VALUES (4, N'Accountant', N'Accountant');
INSERT [dbo].[Positions] ([positionId], [positionName], [positionDescription]) VALUES (5, N'IT_Manager', N'Information Technology Manager');
INSERT [dbo].[Positions] ([positionId], [positionName], [positionDescription]) VALUES (6, N'Software_Developer', N'Software Developer');
SET IDENTITY_INSERT [dbo].[Positions] OFF;

-- Create a table for Gender
CREATE TABLE [dbo].[Gender](
    [genderId] [int] IDENTITY(1,1) NOT NULL,
    [genderName] [nvarchar](10) NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
 ([genderId] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE [EmploNexus]
GO
SET IDENTITY_INSERT [dbo].[Gender] ON;
INSERT [dbo].[Gender] ([genderId], [genderName]) VALUES (1, N'Male');
INSERT [dbo].[Gender] ([genderId], [genderName]) VALUES (2, N'Female');
SET IDENTITY_INSERT [dbo].[Gender] OFF;

-- Create a table for Status
CREATE TABLE [dbo].[Status] (
	[statusId] [int] IDENTITY(1,1) NOT NULL,
    [statusName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
 ([statusId] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

----STATUSES
--Present/In
--Absent/Out
--Late
--Early Departure
--Half Day
--Remote/Telecommuting
--On Leave
--Business Trip/Travel
--Training/Workshop

USE [EmploNexus]
GO
SET IDENTITY_INSERT [dbo].[Status] ON;
INSERT [dbo].[Status] ([statusId], [statusName]) VALUES (1, N'Present');
INSERT [dbo].[Status] ([statusId], [statusName]) VALUES (2, N'Absent');
INSERT [dbo].[Status] ([statusId], [statusName]) VALUES (3, N'Late');
INSERT [dbo].[Status] ([statusId], [statusName]) VALUES (4, N'Early Departure');
INSERT [dbo].[Status] ([statusId], [statusName]) VALUES (5, N'Half Day');
INSERT [dbo].[Status] ([statusId], [statusName]) VALUES (6, N'Remote');
INSERT [dbo].[Status] ([statusId], [statusName]) VALUES (7, N'On Leave');
INSERT [dbo].[Status] ([statusId], [statusName]) VALUES (8, N'Business Trip');
INSERT [dbo].[Status] ([statusId], [statusName]) VALUES (9, N'Training');
SET IDENTITY_INSERT [dbo].[Status] OFF;

-- Create a table for users
CREATE TABLE UserAccounts (
    userNo INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	user_empID INT NOT NULL UNIQUE,
    username NVARCHAR(255) NOT NULL UNIQUE,
    [password] NVARCHAR(255) NOT NULL,
    roleId INT NOT NULL,
    FOREIGN KEY(roleId) REFERENCES Roles(roleId),
);

-- Create a table for Employees
CREATE TABLE Employees (
	emp_No INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	emp_ID INT NOT NULL UNIQUE,
	emp_name NVARCHAR(255) NOT NULL,
	emp_genderId INT NOT NULL,
	emp_DOB DATE DEFAULT GETDATE() NOT NULL,
    emp_email NVARCHAR(255) NOT NULL,
	emp_departmentId INT NOT NULL,
	emp_positionId INT NOT NULL,	
	FOREIGN KEY(emp_ID) REFERENCES UserAccounts(user_empID),
	FOREIGN KEY(emp_genderId) REFERENCES Gender(genderId),
	FOREIGN KEY(emp_departmentId) REFERENCES Departments(departmentId),
	FOREIGN KEY(emp_positionId) REFERENCES Positions(positionId)
);

-- Create a table for Salary
CREATE TABLE Salary (
    salary_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,	
	salary_Amount DECIMAL(10, 2) NOT NULL DEFAULT 0.00,
    salary_PayDate DATE NOT NULL,
	Salaryemp_ID INT NOT NULL
	FOREIGN KEY(Salaryemp_ID) REFERENCES UserAccounts(user_empID)
);

-- Create a table for Attendance
CREATE TABLE Attendance (
    AttendanceNo INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    AttendanceDate DATE DEFAULT GETDATE() NOT NULL,
    AttendanceStatusId int NOT NULL,
    AttendanceEmp_ID INT NOT NULL,
	FOREIGN KEY (AttendanceStatusId) REFERENCES [Status](statusId),
    FOREIGN KEY (AttendanceEmp_ID) REFERENCES UserAccounts(user_empID)
);

------VIEW ALL USER ROLE
CREATE VIEW vw_all_user_role
AS
SELECT ua.userNo AS 'USER NO.', ua.user_empID AS 'EMPLOYEE ID', ua.userName AS 'USERNAME', ua.password AS 'PASSWORD', R.roleName AS 'ROLE' 
FROM Roles R
INNER JOIN UserAccounts ua ON ua.roleId = R.roleId 

------VIEW ALL USER EMPLOYEE
CREATE VIEW vw_all_employee
AS
SELECT e.emp_No AS 'EMPLOYEE NO.',e.emp_ID AS 'EMPLOYEE_ID', e.emp_name AS 'EMPLOYEE_NAME', e.emp_genderId AS 'GENDER', e.emp_DOB AS 'BIRTHDATE', e.emp_email AS 'EMAIL', e.emp_departmentId AS 'DEPARTMENT', e.emp_positionId AS 'JOB_POSITION'
FROM Employees e
INNER JOIN UserAccounts ua ON e.emp_ID = ua.user_empID
INNER JOIN Gender G ON e.emp_genderId = G.genderId
INNER JOIN Departments D ON e.emp_departmentId = D.departmentId
INNER JOIN Positions P ON e.emp_positionId = P.positionId

------VIEW ALL USER SALARY
CREATE VIEW vw_all_salary
AS
SELECT S.salary_ID AS 'SALARY NO.', S.Salaryemp_ID AS 'EMPLOYEE_ID', S.salary_PayDate AS 'PAY_DATE', S.salary_Amount AS 'SALARY'
FROM Salary S
INNER JOIN UserAccounts ua ON s.Salaryemp_ID = ua.user_empID;

------VIEW ALL USER SALARY
CREATE VIEW vw_emp_salary
AS
SELECT S.Salaryemp_ID AS 'EMPLOYEE_ID', S.salary_PayDate AS 'PAY_DATE', S.salary_Amount AS 'SALARY'
FROM Salary S
INNER JOIN UserAccounts ua ON s.Salaryemp_ID = ua.user_empID;

------VIEW ALL USER ATTENDANCE
CREATE VIEW vw_all_attendance
AS
SELECT A.AttendanceNo AS 'ATTENDANCE NO.', A.AttendanceEmp_ID AS 'EMPLOYEE_ID', A.AttendanceDate AS 'DATE', A.AttendanceStatusId AS 'STATUS'
FROM Attendance A
INNER JOIN Employees E ON A.AttendanceEmp_ID = E.emp_ID;

------VIEW ALL USER ATTENDANCE
CREATE VIEW vw_emp_Attendance
AS
SELECT A.AttendanceEmp_ID AS 'EMPLOYEE_ID', A.AttendanceDate AS 'DATE', A.AttendanceStatusId AS 'STATUS'
FROM Attendance A
INNER JOIN Employees E ON A.AttendanceEmp_ID = E.emp_ID;

------VIEW ALL USER EMPLOYEE ID
CREATE VIEW vw_all_empID
AS
SELECT UA.userNo AS 'USER NO.', UA.user_empID AS 'EMPLOYEE_ID', R.roleDescription AS 'ROLE'
FROM UserAccounts UA
INNER JOIN Roles R ON UA.roleId = R.roleId

------VIEW ALL EMPLOYEE INFO
CREATE VIEW vw_all_empInfo
AS
SELECT E.emp_No AS 'EMPLOYEE NO.', E.emp_ID AS 'EMPLOYEE ID', E.emp_name AS 'EMPLOYEE NAME', E.emp_departmentId AS 'DEPARTMENT', E.emp_positionId AS 'JOB POSITION' 
FROM Employees E

------VIEW ALL EMPLOYEE MANAGE
CREATE VIEW vw_manage_employee
AS
SELECT emp_ID AS 'EMPLOYEE ID', emp_name AS 'EMPLOYEE NAME', emp_genderId AS 'GENDER', emp_email AS 'EMAIL', emp_departmentId AS 'DEPARTMENT', emp_positionId AS 'JOB POSITION'
FROM Employees

------STORED PROCEDURE ADD USER
CREATE PROCEDURE sp_addUser
    @user_empID INT,
    @username NVARCHAR(255),
    @password NVARCHAR(255),
    @roleId INT
AS
BEGIN
    INSERT INTO UserAccounts (user_empID, username, [password], roleId)
    VALUES (@user_empID, @username, @password, @roleId);
END;

------STORED PROCEDURE UPDATE USER
CREATE PROCEDURE sp_updateUser
    @user_empID INT,
    @username NVARCHAR(255),
    @password NVARCHAR(255),
    @roleId INT
AS
BEGIN
    UPDATE UserAccounts
    SET username = @username,
        [password] = @password,
        roleId = @roleId
    WHERE user_empID = @user_empID;
END;

------STORED PROCEDURE DELETE USER
CREATE PROCEDURE sp_deleteUser
    @user_empID INT
AS
BEGIN
    DELETE FROM UserAccounts
    WHERE user_empID = @user_empID;
END;

------STORED PROCEDURE ADD EMPLOYEE
CREATE PROCEDURE sp_addEmployee
    @emp_ID INT,
    @emp_name NVARCHAR(255),
    @emp_genderId INT,
    @emp_DOB DATE,
    @emp_email NVARCHAR(255),
    @emp_departmentId INT,
    @emp_positionId INT
AS
BEGIN
    INSERT INTO Employees (emp_ID, emp_name, emp_genderId, emp_DOB, emp_email, emp_departmentId, emp_positionId)
    VALUES (@emp_ID, @emp_name, @emp_genderId, @emp_DOB, @emp_email, @emp_departmentId, @emp_positionId);
END;

------STORED PROCEDURE UPDATE EMPLOYEE
CREATE PROCEDURE sp_updateEmployee
    @emp_ID INT,
    @emp_name NVARCHAR(255),
    @emp_genderId INT,
    @emp_DOB DATE,
    @emp_email NVARCHAR(255),
    @emp_departmentId INT,
    @emp_positionId INT
AS
BEGIN
    UPDATE Employees
    SET emp_name = @emp_name,
        emp_genderId = @emp_genderId,
        emp_DOB = @emp_DOB,
        emp_email = @emp_email,
        emp_departmentId = @emp_departmentId,
        emp_positionId = @emp_positionId
    WHERE emp_ID = @emp_ID;
END;

------STORED PROCEDURE DELETE EMPLOYEE
CREATE PROCEDURE sp_deleteEmployee
    @emp_ID INT
AS
BEGIN
    DELETE FROM Employees
    WHERE emp_ID = @emp_ID;
END;

------STORED PROCEDURE ADD SALARY
CREATE PROCEDURE sp_addSalary
    @Salaryemp_ID INT,
    @salary_Amount DECIMAL(10, 2),
    @salary_PayDate DATE
AS
BEGIN
    INSERT INTO Salary (Salaryemp_ID, salary_Amount, salary_PayDate)
    VALUES (@Salaryemp_ID, @salary_Amount, @salary_PayDate);
END;

------STORED PROCEDURE UPDATE SALARY
CREATE PROCEDURE sp_updateSalary
    @salary_ID INT,
    @salary_Amount DECIMAL(10, 2),
    @salary_PayDate DATE
AS
BEGIN
    UPDATE Salary
    SET salary_Amount = @salary_Amount,
        salary_PayDate = @salary_PayDate
    WHERE salary_ID = @salary_ID;
END;

------STORED PROCEDURE DELETE SALARY
CREATE PROCEDURE sp_deleteSalary
    @salary_ID INT
AS
BEGIN
    DELETE FROM Salary
    WHERE salary_ID = @salary_ID;
END;

------STORED PROCEDURE ADD ATTENDANCE
CREATE PROCEDURE sp_addAttendance
    @AttendanceEmp_ID INT,
    @AttendanceDate DATE,
    @AttendanceStatusId INT
AS
BEGIN
    INSERT INTO Attendance (AttendanceEmp_ID, AttendanceDate, AttendanceStatusId)
    VALUES (@AttendanceEmp_ID, @AttendanceDate, @AttendanceStatusId);
END;

------STORED PROCEDURE UPDATE ATTENDANCE
CREATE PROCEDURE sp_updateAttendance
    @AttendanceNo INT,
    @AttendanceDate DATE,
    @AttendanceStatusId INT
AS
BEGIN
    UPDATE Attendance
    SET AttendanceDate = @AttendanceDate,
        AttendanceStatusId = @AttendanceStatusId
    WHERE AttendanceNo = @AttendanceNo;
END;

------STORED PROCEDURE DELETE ATTENDANCE
CREATE PROCEDURE sp_deleteAttendance
    @AttendanceNo INT
AS
BEGIN
    DELETE FROM Attendance
    WHERE AttendanceNo = @AttendanceNo;
END;
