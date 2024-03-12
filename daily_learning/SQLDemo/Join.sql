use EmployeeDB
go
Create table Department
(
     ID int primary key,
     DepartmentName nvarchar(50),
     Location nvarchar(50),
     DepartmentHead nvarchar(50)
)
go

Insert into Department values (1, 'IT', 'London', 'Rick')
Insert into Department values (2, 'Payroll', 'Delhi', 'Ron')
Insert into Department values (3, 'HR', 'New York', 'Christie')
Insert into Department values (4, 'Other Department', 'Sydney', 'Cindrella')

go

Create table Employees
(
     ID int primary key,
     Name nvarchar(50),
     Gender nvarchar(50),
     Salary int,
     DepartmentId int foreign key references Department(Id)
)

go

Insert into Employees values (1, 'Tom', 'Male', 4000, 1)
Insert into Employees values (2, 'Pam', 'Female', 3000, 3)
Insert into Employees values (3, 'John', 'Male', 3500, 1)
Insert into Employees values (4, 'Sam', 'Male', 4500, 2)
Insert into Employees values (5, 'Todd', 'Male', 2800, 2)
Insert into Employees values (6, 'Ben', 'Male', 7000, 1)
Insert into Employees values (7, 'Sara', 'Female', 4800, 3)
Insert into Employees values (8, 'Valarie', 'Female', 5500, 1)
Insert into Employees values (9, 'James', 'Male', 6500, NULL)
Insert into Employees values (10, 'Russell', 'Male', 8800, NULL)

go

select * from Department
select * from Employee

go

select Employees.Id,Employees.Name, Department.DepartmentName from Employees 
 join Department on
Employees.DepartmentId = Department.ID

select Employees.Id,Employees.Name,Department.DepartmentName from Employees
left join Department on
Employees.DepartmentId=Department.ID






