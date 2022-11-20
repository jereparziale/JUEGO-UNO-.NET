USE [master]
GO
/****** Object:  Database [ParcialDos]    Script Date: 20/11/2022 19:53:42 ******/
CREATE DATABASE [ParcialDos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ParcialDos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ParcialDos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ParcialDos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ParcialDos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ParcialDos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ParcialDos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ParcialDos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ParcialDos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ParcialDos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ParcialDos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ParcialDos] SET ARITHABORT OFF 
GO
ALTER DATABASE [ParcialDos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ParcialDos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ParcialDos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ParcialDos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ParcialDos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ParcialDos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ParcialDos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ParcialDos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ParcialDos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ParcialDos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ParcialDos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ParcialDos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ParcialDos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ParcialDos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ParcialDos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ParcialDos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ParcialDos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ParcialDos] SET RECOVERY FULL 
GO
ALTER DATABASE [ParcialDos] SET  MULTI_USER 
GO
ALTER DATABASE [ParcialDos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ParcialDos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ParcialDos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ParcialDos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ParcialDos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ParcialDos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ParcialDos', N'ON'
GO
ALTER DATABASE [ParcialDos] SET QUERY_STORE = OFF
GO
USE [ParcialDos]
GO
/****** Object:  Table [dbo].[Partidas]    Script Date: 20/11/2022 19:53:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partidas](
	[IdPartida] [int] IDENTITY(1000,1) NOT NULL,
	[IdJugador1] [int] NOT NULL,
	[CartasRestantesJ1] [int] NOT NULL,
	[IdJugador2] [int] NOT NULL,
	[CartasRestantesJ2] [int] NOT NULL,
	[IdJugadorGanador] [int] NOT NULL,
	[NombreJugadorGanador] [varchar](50) NOT NULL,
	[CantidadMasCuatro] [int] NULL,
	[CantidadMasDos] [int] NULL,
	[CantidadBloqueoReversa] [int] NULL,
	[CantidadManosJugadas] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 20/11/2022 19:53:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[NombreApellido] [varchar](50) NOT NULL,
	[NombreUsuario] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Partidas] ON 
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1000, 3, 10, 2, 4, 2, N'Edu', 1, 1, 1, 9)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1001, 3, 7, 1, 8, 1, N'Jere', 1, 0, 0, 24)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1002, 3, 7, 1, 8, 3, N'MaxiCASLA', 0, 0, 0, 11)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1003, 3, 7, 1, 8, 3, N'MaxiCASLA', 1, 1, 1, 11)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1013, 4, 3, 6, 7, 4, N'JaviCiclon', 1, 1, 2, 10)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1014, 3, 8, 5, 9, 0, N'', 1, 2, 1, 30)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1015, 3, 8, 5, 9, 3, N'MaxiCASLA', 0, 0, 2, 30)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1016, 6, 1, 7, 2, 7, N'Luqui', 2, 1, 3, 30)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1017, 6, 1, 7, 2, 6, N'Nachito', 1, 2, 1, 19)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1018, 6, 1, 7, 2, 6, N'Nachito', 0, 5, 0, 30)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1019, 6, 1, 7, 2, 6, N'Nachito', 2, 3, 3, 30)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1020, 2, 5, 4, 4, 4, N'JaviCiclon', 4, 1, 3, 30)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1021, 4, 2, 6, 4, 4, N'JaviCiclon', 0, 3, 4, 30)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1022, 1, 9, 2, 0, 2, N'Edu', 1, 1, 1, 16)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1023, 1, 4, 5, 9, 1, N'Jere', 3, 1, 1, 18)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1024, 3, 5, 7, 5, 3, N'MaxiCASLA', 1, 1, 0, 12)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1025, 1, 11, 7, 6, 7, N'Luqui', 2, 2, 0, 10)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1026, 1, 5, 10, 4, 10, N'Ori =)', 0, 1, 0, 10)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1027, 4, 5, 5, 6, 4, N'JaviCiclon', 0, 0, 0, 10)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1028, 9, 3, 10, 5, 9, N'Maika', 0, 1, 0, 20)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1029, 4, 8, 5, 4, 5, N'Orne', 1, 1, 1, 15)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1030, 3, 3, 2, 12, 3, N'MaxiCASLA', 3, 0, 1, 15)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1031, 9, 4, 8, 4, 0, N'', 0, 0, 2, 15)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1032, 7, 1, 1, 6, 7, N'Luqui', 1, 0, 0, 15)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1033, 6, 7, 10, 7, 0, N'', 2, 3, 0, 15)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2024, 1, 7, 2, 9, 1, N'Jere', 2, 2, 0, 13)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2025, 4, 1, 7, 6, 4, N'JaviCiclon', 0, 0, 1, 13)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2026, 8, 11, 5, 6, 5, N'Orne', 1, 1, 0, 13)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2027, 9, 3, 6, 4, 6, N'Nachito', 1, 0, 0, 13)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2028, 9, 3, 6, 4, 9, N'Maika', 0, 0, 1, 13)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2029, 3, 3, 10, 8, 3, N'MaxiCASLA', 0, 1, 0, 13)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2030, 3, 2, 6, 2, 3, N'MaxiCASLA', 0, 0, 2, 13)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2031, 3, 2, 6, 2, 0, N'', 0, 0, 2, 13)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2032, 1, 6, 9, 5, 9, N'Maika', 1, 2, 1, 13)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2033, 8, 5, 5, 5, 0, N'', 0, 0, 0, 13)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2034, 4, 7, 7, 9, 4, N'JaviCiclon', 0, 0, 0, 13)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2035, 2, 5, 10, 9, 2, N'Edu', 1, 1, 1, 13)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2036, 8, 4, 1, 1, 8, N'Naty', 1, 0, 0, 13)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2037, 8, 4, 1, 1, 1, N'Jere', 0, 2, 0, 13)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2038, 3, 0, 5, 7, 3, N'MaxiCASLA', 1, 0, 2, 11)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2039, 6, 2, 2, 2, 0, N'', 0, 0, 0, 11)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2040, 3, 2, 8, 7, 3, N'MaxiCASLA', 1, 1, 2, 11)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2042, 1, 3, 9, 4, 1, N'Jere', 0, 0, 0, 7)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2043, 2, 4, 8, 10, 2, N'Edu', 1, 2, 1, 7)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2044, 7, 3, 1, 4, 7, N'Luqui', 0, 0, 0, 7)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2045, 5, 4, 4, 2, 4, N'JaviCiclon', 0, 0, 2, 7)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2046, 6, 6, 10, 6, 0, N'', 0, 0, 0, 7)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2047, 3, 5, 9, 10, 3, N'MaxiCASLA', 1, 0, 1, 7)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2048, 2, 3, 8, 8, 2, N'Edu', 1, 0, 0, 7)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2049, 7, 8, 1, 6, 1, N'Jere', 0, 0, 1, 7)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2050, 3, 8, 9, 6, 9, N'Maika', 1, 1, 1, 7)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2051, 5, 7, 4, 4, 4, N'JaviCiclon', 1, 0, 0, 7)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2052, 6, 9, 10, 4, 10, N'Ori =)', 1, 1, 0, 7)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2054, 5, 6, 1, 8, 5, N'Orne', 1, 1, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2055, 8, 4, 3, 5, 8, N'Naty', 0, 0, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2061, 5, 11, 2, 4, 2, N'Edu', 1, 0, 1, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2062, 9, 7, 7, 5, 7, N'Luqui', 1, 0, 2, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2063, 3, 9, 4, 8, 4, N'JaviCiclon', 1, 1, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2064, 6, 5, 1, 8, 6, N'Nachito', 1, 0, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2065, 8, 11, 10, 7, 10, N'Ori =)', 1, 2, 1, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2066, 8, 4, 10, 4, 0, N'', 0, 0, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2067, 6, 4, 1, 8, 6, N'Nachito', 1, 0, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2075, 4, 8, 9, 8, 0, N'', 2, 0, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2076, 6, 4, 10, 7, 6, N'Nachito', 0, 1, 1, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2077, 9, 4, 8, 6, 9, N'Maika', 0, 1, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2078, 3, 5, 2, 3, 2, N'Edu', 0, 0, 1, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2079, 4, 4, 2, 11, 4, N'JaviCiclon', 1, 1, 0, 5)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2080, 6, 6, 1, 5, 1, N'Jere', 0, 0, 0, 5)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2081, 6, 5, 1, 11, 6, N'Nachito', 0, 2, 0, 5)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1004, 3, 7, 1, 8, 3, N'MaxiCASLA', 0, 1, 2, 11)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1005, 3, 7, 1, 8, 3, N'MaxiCASLA', 0, 0, 1, 11)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1006, 3, 7, 1, 8, 3, N'MaxiCASLA', 1, 3, 1, 11)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1007, 4, 9, 7, 6, 0, N'', 1, 2, 1, 24)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1008, 4, 9, 7, 6, 4, N'JaviCiclon', 2, 0, 1, 11)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1009, 4, 9, 7, 6, 7, N'Luqui', 1, 1, 2, 11)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1010, 6, 6, 2, 4, 2, N'Edu', 2, 0, 2, 24)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1011, 6, 6, 2, 4, 6, N'Nachito', 2, 0, 0, 11)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (1012, 6, 6, 2, 4, 2, N'Edu', 1, 1, 0, 11)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2041, 2, 3, 9, 4, 2, N'Edu', 0, 0, 0, 7)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2056, 1, 8, 7, 8, 0, N'', 0, 0, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2057, 5, 4, 3, 8, 5, N'Orne', 1, 0, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2058, 8, 5, 2, 5, 0, N'', 0, 0, 3, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2059, 6, 4, 9, 4, 0, N'', 0, 0, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2060, 4, 10, 10, 4, 10, N'Ori =)', 1, 1, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2068, 7, 4, 9, 6, 7, N'Luqui', 0, 1, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2069, 1, 9, 8, 4, 8, N'Naty', 1, 0, 1, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2070, 6, 5, 3, 7, 6, N'Nachito', 0, 1, 1, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2071, 5, 8, 2, 8, 0, N'', 2, 0, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2072, 4, 4, 10, 8, 4, N'JaviCiclon', 1, 0, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2073, 6, 7, 3, 4, 3, N'MaxiCASLA', 0, 0, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2074, 1, 4, 8, 7, 1, N'Jere', 0, 0, 0, 6)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2082, 7, 8, 1, 8, 0, N'', 1, 1, 0, 5)
GO
INSERT [dbo].[Partidas] ([IdPartida], [IdJugador1], [CartasRestantesJ1], [IdJugador2], [CartasRestantesJ2], [IdJugadorGanador], [NombreJugadorGanador], [CantidadMasCuatro], [CantidadMasDos], [CantidadBloqueoReversa], [CantidadManosJugadas]) VALUES (2083, 7, 8, 1, 5, 1, N'Jere', 1, 0, 0, 5)
GO
SET IDENTITY_INSERT [dbo].[Partidas] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [NombreApellido], [NombreUsuario]) VALUES (1, N'Jeremias Parziale', N'Jere')
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [NombreApellido], [NombreUsuario]) VALUES (2, N'Eduardo Parziale', N'Edu')
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [NombreApellido], [NombreUsuario]) VALUES (3, N'Maxi Parziale', N'MaxiCASLA')
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [NombreApellido], [NombreUsuario]) VALUES (4, N'Javier Rondinelli', N'JaviCiclon')
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [NombreApellido], [NombreUsuario]) VALUES (5, N'Orne Curcio', N'Orne')
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [NombreApellido], [NombreUsuario]) VALUES (6, N'Nacho', N'Nachito')
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [NombreApellido], [NombreUsuario]) VALUES (7, N'Lucas Rodriguez', N'Luqui')
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [NombreApellido], [NombreUsuario]) VALUES (8, N'Natalia Caballero', N'Naty')
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [NombreApellido], [NombreUsuario]) VALUES (9, N'Maia Parziale', N'Maika')
GO
INSERT [dbo].[Usuarios] ([IdUsuario], [NombreApellido], [NombreUsuario]) VALUES (10, N'Oriana', N'Ori =)')
GO
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
USE [master]
GO
ALTER DATABASE [ParcialDos] SET  READ_WRITE 
GO
