CREATE DATABASE EMPLONEXUS_NEW
USE EMPLONEXUS_NEW

-- Create a table for Role
CREATE TABLE [dbo].[Roles](
	[roleId] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [nvarchar](50) NULL,
	[roleDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED
 ([roleId] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE [EMPLONEXUS_NEW]
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 
INSERT [dbo].[Roles] ([roleId], [roleName], [roleDescription]) VALUES (1, N'Employee', N'Employee ')
INSERT [dbo].[Roles] ([roleId], [roleName], [roleDescription]) VALUES (2, N'Manager', N'Manager ')
INSERT [dbo].[Roles] ([roleId], [roleName], [roleDescription]) VALUES (3, N'Admin', N'Admin ')
SET IDENTITY_INSERT [dbo].[Roles] OFF

-- Create a table for Department
-- Department Table
CREATE TABLE [dbo].[Departments](
    [departmentId] [int] IDENTITY(1,1) NOT NULL,
    [departmentName] [nvarchar](50) NULL,
    [departmentDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
 ([departmentId] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE [EMPLONEXUS_NEW]
GO
SET IDENTITY_INSERT [dbo].[Departments] ON;
INSERT [dbo].[Departments] ([departmentId], [departmentName], [departmentDescription]) VALUES (1, N'HR', N'Human Resources');
INSERT [dbo].[Departments] ([departmentId], [departmentName], [departmentDescription]) VALUES (2, N'Finance', N'Finance');
INSERT [dbo].[Departments] ([departmentId], [departmentName], [departmentDescription]) VALUES (3, N'IT', N'Information Technology');
SET IDENTITY_INSERT [dbo].[Departments] OFF;


-- Create a table for Job Positions
-- Position Table
CREATE TABLE [dbo].[Positions](
    [positionId] [int] IDENTITY(1,1) NOT NULL,
    [positionName] [nvarchar](50) NULL,
    [positionDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
 ([positionId] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

-- Inserting data into Position Table
USE [EMPLONEXUS_NEW]
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

USE [EMPLONEXUS_NEW]
GO
SET IDENTITY_INSERT [dbo].[Gender] ON;
INSERT [dbo].[Gender] ([genderId], [genderName]) VALUES (1, N'Male');
INSERT [dbo].[Gender] ([genderId], [genderName]) VALUES (2, N'Female');
SET IDENTITY_INSERT [dbo].[Gender] OFF;

-- Create a table for users
CREATE TABLE UserAccounts (
    userID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	emp_ID INT NOT NULL,
	emp_Salary DECIMAL(10, 2) DEFAULT 0.00,
    name NVARCHAR(255) NOT NULL,
    email NVARCHAR(255) NOT NULL,
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

---- Create a table for employees
--CREATE TABLE Employee (
--    emp_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
--    emp_Name NVARCHAR(255) NOT NULL,
--    emp_Email NVARCHAR(255) NOT NULL UNIQUE,
--    emp_Salary DECIMAL(10, 2) DEFAULT 0.00,
--    emp_UserID INT,
--	emp_GenderId INT NOT NULL,
--	emp_DepartmentId INT NOT NULL,
--	emp_PositionId INT NOT NULL,
--    FOREIGN KEY(emp_UserID) REFERENCES UserAccounts(userID),
--    FOREIGN KEY(emp_GenderId) REFERENCES Gender(genderId),
--    FOREIGN KEY(emp_DepartmentId) REFERENCES Departments(departmentId),
--	FOREIGN KEY(emp_PositionId) REFERENCES Positions(positionId)
--);

-- Create a table for payroll
CREATE TABLE Payroll (
    payroll_ID INT IDENTITY(1,1) NOT NULL,
    payroll_PayDate DATE NOT NULL,
    payroll_Amount DECIMAL(10, 2) NOT NULL,
	--payroll_EmployeeID INT,
    FOREIGN KEY(payroll_ID) REFERENCES UserAccounts(userID)
)

------VIEW ALL USER ROLE
CREATE VIEW vw_all_user_role
AS
SELECT ua.userID AS 'USER ID', ua.name AS 'EMPLOYEE NAME', ua.userName AS 'USERNAME', ua.password AS 'PASSWORD', R.roleName AS 'ROLE' FROM Roles R
INNER JOIN UserAccounts ua 
ON ua.roleId = R.roleId



------STORED PROCEDURE NEW USER
CREATE PROCEDURE sp_newUser @userId int, @name nvarchar(50), @userName nvarchar(50), @userPassword nvarchar(50), @roleId int 
AS
INSERT INTO UserAccounts(userID,name,username, password, roleId) 
	values (@userId , @name, @userName, @userPassword, @roleId)
