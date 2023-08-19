 
-- crear la base de datos
CREATE DATABASE Gestion_de_Inventario;
go

-- crear la Usuario
CREATE TABLE Usuario
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50),
    Apellido NVARCHAR(50),
    Correo NVARCHAR(50),
    Contrase�a NVARCHAR(50),
    Fecha DATE,
    Genero NVARCHAR(10),
    Imagen image
)
go

--prosedimiento armacenado agregar usuario
Create Proc spUsuario
@Nombre NVARCHAR(50),
@Apellido NVARCHAR(50),
@Correo NVARCHAR(50),
@Contrase�a NVARCHAR(50),
@Fecha DATE,
@Genero NVARCHAR(10),
@Imagen image
as
INSERT INTO Usuario (Nombre, Apellido, Correo, Contrase�a, Fecha, Genero, Imagen)
VALUES (@Nombre, @Apellido, @Correo, @Contrase�a,@Fecha,@Genero,@Imagen);

