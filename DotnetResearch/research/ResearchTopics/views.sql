
CREATE DATABASE StudentsDB
go
USE StudentDB
go
CREATE TABLE StudentDetails(Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(20),Address VARCHAR(20),Age INT check(age>0));
go
INSERT INTO  StudentDetails(Name,Address,Age)VALUES('Athira','Puthiyadathu',24),
('Anusree','Pulappadi',25),('Bhagyalakshmi','Alappuzha',24)
go
CREATE TABLE StudentMark(Id INT PRIMARY KEY IDENTITY,Name VARCHAR(20),Mark INT)
go
INSERT INTO StudentMark VALUES('Athira',92),('Anusree',85),('Bhagylakshmi',82)
go
--CREATE VIEW FROM ONE TABLE
CREATE VIEW Students AS SELECT Id,Name,Age FROM StudentDetails
go
SELECT * FROM Students
go
--CREATING VIEW FROM MULTIPLE TABLE
CREATE VIEW StudentRecord AS SELECT StudentDetails.Name,StudentDetails.Age,
StudentMark.Mark FROM StudentDetails,StudentMark where StudentDetails.Name=StudentMark.Name
go
SELECT * FROM StudentRecord
go
--CREATE OR REPLACE VIEW
CREATE OR ALTER  VIEW  Students AS SELECT id,Name,Age, Address FROM StudentDetails
go
SELECT * FROM Students

--INSERTING INTO VIEWS
INSERT INTO StudentDetails VALUES('Maria','Panathur',24)
INSERT INTO StudentMark VALUES('Maria',79)
--DELETING ROW
DELETE FROM Students WHERE Id=4
SELECT * FROM Students



