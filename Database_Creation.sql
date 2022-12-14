CREATE DATABASE Student_Details;
GO
USE Student_Details;
GO
CREATE TABLE Codes
(
Module_Code Char(10) PRIMARY KEY,
Module_Name VarChar(30),
Description VarChar(50),
Source_Link VarChar(2084)
);
GO
CREATE TABLE STUDENTS
(
StudentID int PRIMARY KEY NOT NULL,
Name VarChar(30),
Surname VarChar(30),
ST_Image VARBINARY(MAX),
DOB DATE,
Gender Char(10),
Phone VarChar(15),
Student_Address VarChar(100),
Module_Code Char(10)  REFERENCES Codes(Module_Code)
);
GO
CREATE TABLE Lectures
(
 EmpID int Primary Key NOT NULL,
 Name varchar(50),
 Surname varchar(50),
 Class_Module char(10) references Codes(Module_Code)
)
GO
INSERT INTO Codes values ('PRG282', 'Programming', 'Learn Using C# with Databases', 'https://www.google.com/search?q=programming&sxsrf=ALiCzsbeiwuvRxZnuCeeIveutJtk7_OwLA:1667840911595&source=lnms&tbm=vid&sa=X&ved=2ahUKEwixgc_Ix5z7AhWSQUEAHZNoB1wQ_AUoA3oECAEQBQ&biw=1920&bih=969&dpr=1#fpstate=ive&vld=cid:b7418bb7,vid:zOjov-2OZ0E');
INSERT INTO Codes values ('DBD282', 'Database Development', 'Learn MS SQL Server', 'https://learn.microsoft.com/en-us/events/teched-2012/dbi311');
INSERT INTO Codes values ('WPR282', 'Web Programming', 'Learn how to create websites using JS', 'https://www.youtube.com/watch?v=3JluqTojuME');
INSERT INTO Codes values ('PRG281', 'Programming 1', 'Learning C#', 'https://www.google.com/search?q=programming&sxsrf=ALiCzsbeiwuvRxZnuCeeIveutJtk7_OwLA:1667840911595&source=lnms&tbm=vid&sa=X&ved=2ahUKEwixgc_Ix5z7AhWSQUEAHZNoB1wQ_AUoA3oECAEQBQ&biw=1920&bih=969&dpr=1#fpstate=ive&vld=cid:b7418bb7,vid:zOjov-2OZ0E');
INSERT INTO Codes values ('MAT282', 'Mathematics', 'Learn Calculus', 'https://www.youtube.com/watch?v=w3GV9pumczQ');
INSERT INTO Codes values ('STA282', 'Statistics', 'Continous Probability', 'https://www.youtube.com/watch?v=GUQJ7zMoSCM');
INSERT INTO Codes values ('INF282', 'Information Systems', 'Learn about the cloud', 'https://www.youtube.com/watch?v=a9__D53WsUs');
INSERT INTO Codes values ('PMM282', 'Project Management', 'Learn how to manage a project', 'https://www.teamgantt.com/project-management-guide/what-is-project-management');
Go
INSERT INTO STUDENTS (StudentID, Name, Surname, DOB, Gender, Phone, Student_Address, Module_Code) values(1, 'Dylan', 'McMaster', '2002/03/22', 'Male', '083-385-2865', 'Kamp street', 'PRG281');
INSERT INTO STUDENTS (StudentID, Name, Surname, DOB, Gender, Phone, Student_Address, Module_Code) values(2, 'George', 'Hammond', '2002/06/18', 'Male', '083-545-2785', 'Road street', 'WPR282');
INSERT INTO STUDENTS (StudentID, Name, Surname, DOB, Gender, Phone, Student_Address, Module_Code) values(3, 'Vuyo', 'Mayo', '2000/09/12', 'Male', '033-385-2455', 'Plank street', 'PRG282');
Go
INSERT INTO Lectures values(1, 'Alfred', 'Mazorodse', 'PRG282');
INSERT INTO Lectures values(2, 'Andries', 'Welgemoed', 'MAT282');
INSERT INTO Lectures values(3, 'Evange', 'Elize', 'DBD282');
INSERT INTO Lectures values(4, 'Jan', 'Mentz', 'PRG281');
INSERT INTO Lectures values(5, 'Jan', 'Goffing', 'INF282');
INSERT INTO Lectures values(6, 'Robert', 'Rodgers', 'STA282');
INSERT INTO Lectures values(7, 'Mpho', 'Matloga', 'WPR282');
INSERT INTO Lectures values(8, 'Skalie', 'Pretorious', 'PMM282');
INSERT INTO Lectures values(9, 'Bob', 'Swannepoel', 'INF282');
GO
CREATE PROCEDURE StudentsPerLecturer
AS
BEGIN
SELECT Lectures.EmpID, Lectures.Name, Lectures.Surname, Codes.Module_Code, count(STUDENTS.Module_Code) AS 'Number of Students per Lecturer'
FROM Lectures
FULL OUTER JOIN STUDENTS
ON Lectures.Class_Module = STUDENTS.Module_Code
Right JOIN Codes
ON Lectures.Class_Module = Codes.Module_Code
Group By Lectures.EmpID, Lectures.Name, Lectures.Surname, Codes.Module_Code;
END
GO
CREATE PROCEDURE spModules
AS
BEGIN
SELECT Module_Code FROM Codes;
END;
 

