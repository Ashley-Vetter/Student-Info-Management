CREATE DATABASE StudentManager
GO

USE StudentManager
GO

CREATE TABLE Logins(
username VARCHAR(20) PRIMARY KEY NOT NULL, 
password VARCHAR(25) NOT NULL);

INSERT INTO Logins VALUES
('PSmal298', 'Peter#577298'),
('AVetter605', 'Ashley#577605'),
('MDeLange610', 'Marcel#577610'),
('SMathosa415', 'Simphiwe#577415'),
('NSeloana490', 'Nthabiseng#577490');

GO

CREATE TABLE Students(
studentNumber INT PRIMARY KEY, 
firstName VARCHAR(50) NOT NULL, 
surname VARCHAR(50) NOT NULL, 
studentImage varchar(max),
dob varchar(50), 
gender VARCHAR(6) NOT NULL, 
phone VARCHAR(14) NOT NULL, 
stuAddress VARCHAR(50) NOT NULL, 
moduleCodes INT FOREIGN KEY REFERENCES modules(moduleCode)
);

GO 

INSERT INTO Students VALUES
(1200, 'John', 'Doe','"\John Doe.jpg"', '1990-12-02','Male', '065 678 5364', '123 Berg Ave.', 1010),
(1201, 'Jane', 'Doe','"\Jane Doe.png"' , '1999-05-12','Female','071 234 5687', '764 Beacon St.', 1011),
(1202, 'Samantha', 'Smith','"\Samantha Smith.jpg"' , '2000-02-23','Female', '064 333 7654', '825 Jean Ave.', 1012),
(1203, 'Steve', 'Smith', 'Steve Smith.jpg"' , '2003-09-30','Male', '082 209 6478', '23 Church St.', 1013);

GO 

CREATE TABLE Modules(
moduleCode INT PRIMARY KEY, 
moduleName VARCHAR(25) NOT NULL,
moduleDescription VARCHAR(125) NOT NULL, 
links VARCHAR(125)
)

GO

INSERT INTO Modules VALUES
(1010, 'Programming', 'Learning how to connect a database to applications', ''),
(1011, 'IOT', 'Learning how to build circuits', ''),
(1012, 'Database Development', 'Learning how to create databases and run queries', ''),
(1013, 'CNA', 'Learning how to use docker', ''),
(1014, 'Web Programming', 'Learning the basics of Javascript', ''),
(1015, 'Linear Programming', 'LPR is a tool for solving optimisation problems', '');