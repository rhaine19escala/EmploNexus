CREATE DATABASE EMPLONEXUS_DATABASE
USE EMPLONEXUS_DATABASE

-- Create a table for users
CREATE TABLE UserAccounts (
    userID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    username VARCHAR(255) NOT NULL UNIQUE,
    [password] VARCHAR(255) NOT NULL,
    roleId INT NOT NULL
)

-- Create a table for employees
CREATE TABLE Employee (
    emp_ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    emp_Name VARCHAR(255) NOT NULL,
	emp_address VARCHAR(255) NOT NULL DEFAULT 'No Address',
	emp_DOB date  NOT NULL,
	emp_Gender VARCHAR(255) NOT NULL,
    emp_Email VARCHAR NOT NULL UNIQUE,
	emp_Department VARCHAR(255) NOT NULL,
	emp_Position VARCHAR(255) NOT NULL,
    emp_Salary DECIMAL(10, 2) DEFAULT 0.00,
    emp_UserID INT,
    FOREIGN KEY(emp_UserID)REFERENCES UserAccounts(UserID)
)

-- Create a table for payroll
CREATE TABLE Payroll (
    payroll_ID INT PRIMARY KEY NOT NULL,
    payroll_PayDate DATE NOT NULL,
    payroll_Amount DECIMAL(10, 2) NOT NULL,
	payroll_EmployeeID INT,
    FOREIGN KEY(payroll_EmployeeID) REFERENCES Employee(emp_ID)
)

-- Create a table for Role
CREATE TABLE [dbo].[Roles](
	[roleId] [int] IDENTITY(1,1) NOT NULL,
	[roleName] [nvarchar](50) NULL,
	[roleDescription] [nvarchar](100) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED
 ([roleId] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

USE [EMPLONEXUS_DATABASE]
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 
INSERT [dbo].[Roles] ([roleId], [roleName], [roleDescription]) VALUES (1, N'Employee', N'Employee ')
INSERT [dbo].[Roles] ([roleId], [roleName], [roleDescription]) VALUES (2, N'Manager', N'Manager ')
INSERT [dbo].[Roles] ([roleId], [roleName], [roleDescription]) VALUES (3, N'Admin', N'Admin ')
SET IDENTITY_INSERT [dbo].[Roles] OFF

CREATE VIEW vw_all_user_role
AS
SELECT R.roleId AS 'ROLE ID', ua.userName AS 'USERNAME', ua.password AS 'PASSWORD', R.roleName AS 'ROLE NAME' FROM Roles R
INNER JOIN UserAccounts ua 
ON ua.roleId = R.roleId

CREATE PROCEDURE sp_newUser @userName nvarchar(50), @userPassword nvarchar(50)
AS
INSERT INTO UserAccounts(username, password) 
	values (@userName, @userPassword)
