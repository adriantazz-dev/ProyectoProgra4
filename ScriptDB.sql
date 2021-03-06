USE [master]
GO
/****** Object:  Database [Proyecto2]    Script Date: 10/12/2020 20:21:50 ******/
CREATE DATABASE [Proyecto2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Proyecto2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Proyecto2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Proyecto2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Proyecto2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Proyecto2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Proyecto2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Proyecto2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Proyecto2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Proyecto2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Proyecto2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Proyecto2] SET ARITHABORT OFF 
GO
ALTER DATABASE [Proyecto2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Proyecto2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Proyecto2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Proyecto2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Proyecto2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Proyecto2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Proyecto2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Proyecto2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Proyecto2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Proyecto2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Proyecto2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Proyecto2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Proyecto2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Proyecto2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Proyecto2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Proyecto2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Proyecto2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Proyecto2] SET RECOVERY FULL 
GO
ALTER DATABASE [Proyecto2] SET  MULTI_USER 
GO
ALTER DATABASE [Proyecto2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Proyecto2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Proyecto2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Proyecto2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Proyecto2] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Proyecto2', N'ON'
GO
ALTER DATABASE [Proyecto2] SET QUERY_STORE = OFF
GO
USE [Proyecto2]
GO
/****** Object:  User [usr_Acceso]    Script Date: 10/12/2020 20:21:50 ******/
CREATE USER [usr_Acceso] FOR LOGIN [usr_Acceso] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [ADRIAN-PC\Admin]    Script Date: 10/12/2020 20:21:50 ******/
CREATE USER [ADRIAN-PC\Admin] FOR LOGIN [ADRIAN-PC\Admin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [ADRIAN-PC/Admin]    Script Date: 10/12/2020 20:21:50 ******/
CREATE USER [ADRIAN-PC/Admin] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [usr_Acceso]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [usr_Acceso]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [usr_Acceso]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [usr_Acceso]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [usr_Acceso]
GO
ALTER ROLE [db_datareader] ADD MEMBER [usr_Acceso]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [usr_Acceso]
GO
USE [Proyecto2]
GO
/****** Object:  Sequence [dbo].[SecuenciaIdPrestamo]    Script Date: 10/12/2020 20:21:50 ******/
CREATE SEQUENCE [dbo].[SecuenciaIdPrestamo] 
 AS [int]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -2147483648
 MAXVALUE 2147483647
 CACHE 
GO
/****** Object:  Table [dbo].[Contactos]    Script Date: 10/12/2020 20:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contactos](
	[Nombre] [varchar](50) NOT NULL,
	[Telefono] [int] NOT NULL,
	[PalabraClave] [varchar](50) NOT NULL,
	[Correo] [varchar](80) NOT NULL,
	[TipoContacto] [varchar](50) NOT NULL,
	[Servicios] [varchar](50) NOT NULL,
	[EstadoContacto] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 10/12/2020 20:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [varchar](15) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Contrasena] [varchar](15) NOT NULL,
	[Email] [varchar](40) NOT NULL,
	[Estado] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[PA_AgregarContacto]    Script Date: 10/12/2020 20:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_AgregarContacto]
(
	@Nombre varchar(50),           
	@Telefono int,
	@PalabraClave varchar(50), 
	@Correo varchar(80),
	@TipoContacto varchar(50),
	@Servicios varchar(50), 
	@EstadoContacto bit
)
AS
BEGIN   

	INSERT INTO Contactos (Nombre, Telefono, PalabraClave, Correo,TipoContacto , Servicios, EstadoContacto) 
	VALUES (@Nombre, @Telefono, @PalabraClave, @Correo, @TipoContacto, @Servicios, @EstadoContacto)

END
GO
/****** Object:  StoredProcedure [dbo].[PA_AgregarUsuario]    Script Date: 10/12/2020 20:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PA_AgregarUsuario]
(
	@idusuario varchar(15),  
	@nombre varchar(50),
	@contrasena varchar(15), 
	@email varchar(40),
	@estado bit
)
AS
BEGIN   --Aqui se colocan las instrucciones de SQL que requiere ejecutar

	INSERT INTO Usuarios (idusuario, nombre, contrasena, email, estado) VALUES (@idusuario, @nombre, @contrasena, @email, @estado)

END
GO
/****** Object:  StoredProcedure [dbo].[PA_EliminarContacto]    Script Date: 10/12/2020 20:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_EliminarContacto]
(
	@PalabraClave varchar(50)
)
AS
BEGIN   --Aqui se colocan las instrucciones de SQL que requiere ejecutar

	DELETE from Contactos WHERE PalabraClave = @PalabraClave

END
GO
/****** Object:  StoredProcedure [dbo].[PA_EliminarUsuario]    Script Date: 10/12/2020 20:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PA_EliminarUsuario]
(
	@idusuario varchar(15)  
)
AS
BEGIN   --Aqui se colocan las instrucciones de SQL que requiere ejecutar

	DELETE from Usuarios WHERE IdUsuario = @idusuario

END
GO
/****** Object:  StoredProcedure [dbo].[PA_ListarContactos]    Script Date: 10/12/2020 20:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ListarContactos]
AS
BEGIN   

		SELECT Nombre, Telefono, PalabraClave, Correo,TipoContacto , Servicios, EstadoContacto from Contactos

END
GO
/****** Object:  StoredProcedure [dbo].[PA_ListarUsuarios]    Script Date: 10/12/2020 20:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ListarUsuarios]
AS
BEGIN   --Aqui se colocan las instrucciones de SQL que requiere ejecutar

		SELECT idusuario, nombre, contrasena, email, estado from Usuarios order by IdUsuario desc

END
GO
/****** Object:  StoredProcedure [dbo].[PA_ModificarContacto]    Script Date: 10/12/2020 20:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_ModificarContacto]
(
	@Nombre varchar(50),           
	@Telefono int,
	@PalabraClave varchar(50), 
	@Correo varchar(80),
	@TipoContacto varchar(50),
	@Servicios varchar(50), 
	@EstadoContacto bit
)
AS
BEGIN   --Aqui se colocan las instrucciones de SQL que requiere ejecutar

	UPDATE Contactos SET Nombre = @Nombre, Telefono = @Telefono, Correo = @Correo,TipoContacto = @TipoContacto, Servicios = @Servicios, EstadoContacto = @EstadoContacto WHERE PalabraClave = @PalabraClave

END
GO
/****** Object:  StoredProcedure [dbo].[PA_ModificarUsuario]    Script Date: 10/12/2020 20:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PA_ModificarUsuario]
(
	@idusuario varchar(15),  
	@nombre varchar(50),
	@contrasena varchar(15), 
	@email varchar(40),
	@estado bit
)
AS
BEGIN   --Aqui se colocan las instrucciones de SQL que requiere ejecutar

	Update Usuarios set nombre = @nombre, contrasena = @contrasena, email = @email, estado = @estado WHERE IdUsuario = @idusuario

END
GO
/****** Object:  StoredProcedure [dbo].[PA_VerificarEmailUsuario]    Script Date: 10/12/2020 20:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_VerificarEmailUsuario]
(
	@idusuario varchar(15)
)

AS
BEGIN
	select Email, Contrasena

	from usuarios where idusuario = @idusuario;

END
GO
/****** Object:  StoredProcedure [dbo].[PA_VerificarUsuario]    Script Date: 10/12/2020 20:21:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PA_VerificarUsuario]
(
	@idusuario varchar(15),
	@contrasena varchar(15)
)

AS
BEGIN
	select *

	from usuarios where idusuario = @idusuario and Contrasena = @contrasena;

END
GO
USE [master]
GO
ALTER DATABASE [Proyecto2] SET  READ_WRITE 
GO
