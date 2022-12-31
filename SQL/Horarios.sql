Create DataBase Horario 
Go
Use Horario 
Go
Set Nocount on 
Go

CREATE TABLE Users
(IdEmpleado INT PRIMARY KEY NOT NULL,
Usuario NVARCHAR (20) NOT NULL,
Contrasena  VARBINARY(20) NOT NULL,
Nivel_Empleado INT NOT NULL,)
Go
Insert Into Users Values 
(0, LOWER('juan'),HASHBYTES('SHA1',N'bonafont13'),1),
(1, LOWER('paco'),HASHBYTES('SHA1',N'bonafont14'),0)
Go

Create Table Clases
(IdClases NVARCHAR (20) PRIMARY KEY  NOT NULL,
Semestre INT NOT NULL,
Turno NVARCHAR (10) NOT NULL,
NumGrupo INT NOT NULL,
Grupo NVARCHAR (5) NOT NULL,
Materia NVARCHAR (20) NOT NULL,
Profesor NVARCHAR (50) NOT NULL,
Lunes NVARCHAR (12) NOT NULL,
Martes NVARCHAR (12) NOT NULL,
Miercoles NVARCHAR (12) NOT NULL,
Jueves NVARCHAR (12) NOT NULL,
Viernes NVARCHAR (12) NOT NULL )
Go
Insert Into Clases Values
('1IV1101','1','Vespertino','1','1IV1','ÁLGEBRA','JUAN JOSE BELTRAN CORONA','18:00-19:00','18:00-19:00','18:00-19:00','18:00-19:00','19:00-20:00'),
('3IV1301','3','Vespertino','1','3IV1','GEOMETRIA ANALITICA','HECTOR MANUEL MENDOZA QUIROZ','','21:00-22:00','21:00-22:00','21:00-22:00','21:00-22:00'),
('5IV11501','5','Vespertino','11','5IV11','CALCULO INTEGRAL','JESUS GUTIERREZ MORAN','','20:00-21:00','16:00-17:00','19:00-21:00','')
Go

Create Table Profesores
(IdProfe INT PRIMARY KEY NOT NULL,
Nombre NVARCHAR (20) NOT NULL,
PApellido NVARCHAR (15) NOT NULL,
SApellido NVARCHAR (15) NOT NULL,
Semestre INT NOT NULL,
Turno NVARCHAR (10) NOT NULL)
Go
Insert Into Profesores Values
(101,'JUAN JOSE','BELTRAN','CORONA',1,'Vespertino'),
(301,'HECTOR MANUEL','MENDOZA','QUIROZ',3,'Vespertino'),
(501,'JESUS','GUTIERREZ','MORAN',5,'Vespertino')
Go


Create Table Materias
(IdMateria INT PRIMARY KEY NOT NULL,
Nombre NVARCHAR (50) NOT NULL,
Semestre INT NOT NULL)
Go
Insert Into Materias Values
(101,'ÁLGEBRA',1),
(301,'GEOMETRIA ANALITICA',3),
(501,'CALCULO INTEGRAL',5)
Go