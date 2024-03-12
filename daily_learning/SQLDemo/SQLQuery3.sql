CREATE DATABASE CustomersDB

go

USE CustomersDB

go

CREATE TABLE Country(CountryId INT PRIMARY KEY IDENTITY,CountryName VARCHAR(20))

go


INSERT INTO Country VALUES('INDIA'),
('USA'),('ENGLAND'),('FRANCE')

go

SELECT * FROM Country

go

CREATE TABLE GENDER (GenderId INT PRIMARY KEY IDENTITY,GenderType VARCHAR(20))

go

INSERT INTO GENDER VALUES('MALE'),('FEMALE')

go

SELECT * FROM GENDER

go

CREATE TABLE Customer(ID INT PRIMARY KEY IDENTITY(1000,5),Name VARCHAR(20),
CountryId INT FOREIGN KEY REFERENCES Country(CountryId),
GenderId INT FOREIGN KEY REFERENCES Gender(GenderId))

go


INSERT INTO Customer VALUES('John',1,1),
('Jessie',4,2),
('Tina',2,2),
('Thomas',3,NULL),
('Johnson',2,1),
('Riya',3,2),
('Tommy',4,NULL),
('Preeti',1,2)

go

SELECT * FROM Customer

go

CREATE PROCEDURE sp_GetAllDetails
AS
BEGIN
SELECT c.ID,c.Name,g.GenderType,co.CountryName
FROM Customer c LEFT JOIN GENDER g ON c.GenderId=g.GenderId 
JOIN Country co ON c.CountryId=co.CountryId
END

go

execute sp_GetAllDetails

go

CREATE PROCEDURE sp_GetDetailsByGenderType(@GenderType VARCHAR(20))
AS
BEGIN
SELECT Customer.ID,Customer.Name,Country.CountryName,
GENDER.GenderType FROM Customer 
JOIN GENDER ON Customer.GenderId=GENDER.GenderId
JOIN  Country ON Customer.CountryId=Country.CountryId
WHERE GENDER.GenderType=@GenderType
End
execute sp_GetDetailsByGenderType Female

go

CREATE FUNCTION GetData(@CountryId int,@GenderId int)
RETURNS TABLE
AS
RETURN(SELECT Customer.ID,Customer.Name,GENDER.GenderType,Country.CountryName From 
Customer JOIN Country ON Customer.CountryId=Country.CountryId
JOIN Gender ON Customer.GenderId=GENDER.GenderId WHERE
Country.CountryId=@CountryId AND GENDER.GenderId=@GenderId)

go

SELECT * FROM GetData(1,1)

go

CREATE PROCEDURE TotalCustomer
AS
BEGIN 
SELECT Country.CountryName,COUNT(*) FROM Customer 
JOIN Country ON  Customer.CountryId=Country.CountryId Group by CountryName
End

go

execute TotalCustomer
