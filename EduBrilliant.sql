USE [master]
GO
/****** Object:  Database [EduBrilliant]    Script Date: 25/06/2023 05:53:43 ******/
CREATE DATABASE [EduBrilliant]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EduBrilliant', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EduBrilliant.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EduBrilliant_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EduBrilliant_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EduBrilliant] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EduBrilliant].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EduBrilliant] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EduBrilliant] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EduBrilliant] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EduBrilliant] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EduBrilliant] SET ARITHABORT OFF 
GO
ALTER DATABASE [EduBrilliant] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EduBrilliant] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EduBrilliant] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EduBrilliant] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EduBrilliant] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EduBrilliant] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EduBrilliant] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EduBrilliant] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EduBrilliant] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EduBrilliant] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EduBrilliant] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EduBrilliant] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EduBrilliant] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EduBrilliant] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EduBrilliant] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EduBrilliant] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EduBrilliant] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EduBrilliant] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EduBrilliant] SET  MULTI_USER 
GO
ALTER DATABASE [EduBrilliant] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EduBrilliant] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EduBrilliant] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EduBrilliant] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EduBrilliant] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EduBrilliant] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [EduBrilliant] SET QUERY_STORE = OFF
GO
USE [EduBrilliant]
GO
/****** Object:  Table [dbo].[Kategori]    Script Date: 25/06/2023 05:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategori](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nama] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kelas]    Script Date: 25/06/2023 05:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kelas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KategoriID] [int] NOT NULL,
	[Nama] [varchar](100) NOT NULL,
	[Harga] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Score]    Script Date: 25/06/2023 05:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Score](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[SoalID] [int] NOT NULL,
	[Score] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Soal]    Script Date: 25/06/2023 05:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Soal](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nama] [text] NOT NULL,
	[KelasID] [int] NOT NULL,
	[Waktu] [int] NOT NULL,
	[Nomor] [int] NOT NULL,
	[Jawaban] [varchar](3) NOT NULL,
	[Score] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transaksi]    Script Date: 25/06/2023 05:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaksi](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[KelasID] [int] NOT NULL,
	[DateActivated] [datetime] NULL,
	[Token] [varchar](6) NOT NULL,
	[IsActive] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 25/06/2023 05:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[NamaLengkap] [varchar](100) NOT NULL,
	[Username] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[NoTelp] [varchar](15) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Role] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Kelas]  WITH CHECK ADD  CONSTRAINT [FK_Kelas_KategoriID] FOREIGN KEY([KategoriID])
REFERENCES [dbo].[Kategori] ([ID])
GO
ALTER TABLE [dbo].[Kelas] CHECK CONSTRAINT [FK_Kelas_KategoriID]
GO
ALTER TABLE [dbo].[Score]  WITH CHECK ADD  CONSTRAINT [FK_Score_SoalID] FOREIGN KEY([SoalID])
REFERENCES [dbo].[Soal] ([ID])
GO
ALTER TABLE [dbo].[Score] CHECK CONSTRAINT [FK_Score_SoalID]
GO
ALTER TABLE [dbo].[Score]  WITH CHECK ADD  CONSTRAINT [FK_Score_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Score] CHECK CONSTRAINT [FK_Score_UserID]
GO
ALTER TABLE [dbo].[Soal]  WITH CHECK ADD  CONSTRAINT [FK_Soal_KelasID] FOREIGN KEY([KelasID])
REFERENCES [dbo].[Kelas] ([ID])
GO
ALTER TABLE [dbo].[Soal] CHECK CONSTRAINT [FK_Soal_KelasID]
GO
ALTER TABLE [dbo].[Transaksi]  WITH CHECK ADD  CONSTRAINT [FK_Transaksi_KelasID] FOREIGN KEY([KelasID])
REFERENCES [dbo].[Kelas] ([ID])
GO
ALTER TABLE [dbo].[Transaksi] CHECK CONSTRAINT [FK_Transaksi_KelasID]
GO
ALTER TABLE [dbo].[Transaksi]  WITH CHECK ADD  CONSTRAINT [FK_Transaksi_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Transaksi] CHECK CONSTRAINT [FK_Transaksi_UserID]
GO
USE [master]
GO
ALTER DATABASE [EduBrilliant] SET  READ_WRITE 
GO
