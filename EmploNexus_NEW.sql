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

-- Create a table for users
CREATE TABLE UserAccounts (
    userNo INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	user_empID INT NOT NULL UNIQUE,
    username NVARCHAR(255) NOT NULL UNIQUE,
    [password] NVARCHAR(255) NOT NULL,
    roleId INT NOT NULL,
    departmentId INT NOT NULL,
	positionId INT NOT NULL,
	genderId INT NOT NULL,
    FOREIGN KEY(roleId) REFERENCES Roles(roleId),
    FOREIGN KEY(departmentId) REFERENCES Departments(departmentId),
	FOREIGN KEY(positionId) REFERENCES Positions(positionId),
	FOREIGN KEY(genderId) REFERENCES Gender(genderId)
);

------VIEW ALL USER ROLE
CREATE VIEW vw_all_user_role
AS
SELECT ua.userNo AS 'USER NO.', ua.user_empID AS 'EMPLOYEE ID', ua.userName AS 'USERNAME', ua.password AS 'PASSWORD', R.roleName AS 'ROLE' 
FROM Roles R
INNER JOIN UserAccounts ua ON ua.roleId = R.roleId

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

------VIEW ALL USER EMPLOYEE
CREATE VIEW vw_all_employee
AS
SELECT e.emp_No AS 'EMPLOYEE NO.',e.emp_ID AS 'EMPLOYEE_ID', e.emp_name AS 'EMPLOYEE_NAME', e.emp_genderId AS 'GENDER', e.emp_DOB AS 'BIRTHDATE', e.emp_email AS 'EMAIL', ua.departmentId AS 'DEPARTMENT', ua.positionId AS 'JOB_POSITION'
FROM Employees e
INNER JOIN UserAccounts ua ON e.emp_ID = ua.user_empID
INNER JOIN Gender G ON e.emp_genderId = G.genderId
INNER JOIN Departments D ON e.emp_departmentId = D.departmentId
INNER JOIN Positions P ON e.emp_positionId = P.positionId

-- Create a table for Salary
CREATE TABLE Salary (
    salary_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,	
	salary_Amount DECIMAL(10, 2) NOT NULL DEFAULT 0.00,
    salary_PayDate DATE NOT NULL,
	Salaryemp_ID INT NOT NULL
	FOREIGN KEY(Salaryemp_ID) REFERENCES UserAccounts(user_empID)
);

------VIEW ALL EMPLOYEE SALARY
CREATE VIEW vw_all_salary
AS
SELECT S.salary_ID AS 'SALARY NO.', S.Salaryemp_ID AS 'EMPLOYEE_ID', S.salary_PayDate AS 'PAY_DATE', S.salary_Amount AS 'SALARY'
FROM Salary S
INNER JOIN UserAccounts ua ON s.Salaryemp_ID = ua.user_empID;

-- Create a table for Attendance
CREATE TABLE Attendance (
    AttendanceNo INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    AttendanceDate DATE DEFAULT GETDATE() NOT NULL,
    AttendanceStatus VARCHAR(20) DEFAULT 'Present' NOT NULL,
    AttendanceEmp_ID INT NOT NULL,
    FOREIGN KEY (AttendanceEmp_ID) REFERENCES UserAccounts(user_empID)
);

------VIEW ALL EMPLOYEE ATTENDANCE
CREATE VIEW vw_all_attendance
AS
SELECT A.AttendanceNo AS 'ATTENDANCE NO.', A.AttendanceEmp_ID AS 'EMPLOYEE_ID', A.AttendanceDate AS 'DATE', A.AttendanceStatus AS 'STATUS'
FROM Attendance A
INNER JOIN UserAccounts ua ON A.AttendanceEmp_ID = ua.user_empID;


------STORED PROCEDURE NEW USER
CREATE PROCEDURE sp_newUser
    @empId INT,
    @name NVARCHAR(255),
    @email NVARCHAR(255),
    @userName NVARCHAR(255),
    @userPassword NVARCHAR(255),
    @roleId INT
AS
INSERT INTO UserAccounts (emp_ID, [name], email, username, [password], roleId)
VALUES (@empId, @name, @email, @userName, @userPassword, @roleId);