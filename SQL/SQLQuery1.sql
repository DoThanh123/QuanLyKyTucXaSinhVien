﻿USE [master]
GO
/* Object:  Database [QLKTXSV]*/
CREATE DATABASE [QLKTXSV]
 
GO
ALTER DATABASE [QLKTXSV] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLKTXSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLKTXSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLKTXSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLKTXSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLKTXSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLKTXSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLKTXSV] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLKTXSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLKTXSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLKTXSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLKTXSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLKTXSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLKTXSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLKTXSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLKTXSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLKTXSV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLKTXSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLKTXSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLKTXSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLKTXSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLKTXSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLKTXSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLKTXSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLKTXSV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLKTXSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLKTXSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLKTXSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLKTXSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLKTXSV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLKTXSV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLKTXSV] SET QUERY_STORE = OFF
GO
USE [QLKTXSV]
GO
/* Object:  Table [dbo].[Account] */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [varchar](50) NOT NULL,
	[PassWord] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/** Object:  Table [dbo].[Room]   **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomID] [int] NOT NULL,
	[RoomName] [varchar](200) NULL,
	[Number] [varchar](10) NULL,
	[RoomDevice] [nvarchar](50) NULL,
 CONSTRAINT [PK__Room] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/* Object:  Table [dbo].[Student]   */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [int] NOT NULL,
	[StudentName] [nvarchar](200) NULL,
	[RoomID] [int] NULL,
	[DateOfBirth] [date] NULL,
	[Gender] [nvarchar](6) NULL,
	[Class] [nvarchar](50) NULL,
	[Department] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[Email] [nvarchar](200) NULL,
	[PhoneNumber] [int] NULL,
 CONSTRAINT [PK__Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/* Object:  Table [dbo].[Contract]  */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract](
	[ContractID] [int] NOT NULL,
	[RoomID] [int] NULL,
	[StudentID] [int] NULL,
	[CheckInDay] [date] NULL,
	[CheckOutDay] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ContractID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/* Object:  Table [dbo].[DienNuoc]  */
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DienNuoc](
	[DNID] [int] NOT NULL,
	[RoomID] [int] NULL,
	[Dien] [int] NULL,
	[Nuoc] [int] NULL,
	[DateMake] [date] NULL,
	[Paid] [int] NULL,
	[Owed] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[DNID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/*Thêm Khóa ngoại cho bảng Student */
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK__Student__Room] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([RoomID])
ON DELETE CASCADE
GO
/*Thêm Khóa ngoại cho bảng Contract */
ALTER TABLE [dbo].[Contract]  DROP  CONSTRAINT [FK__Contract__Room] 
GO
ALTER TABLE [dbo].[Contract] WITH CHECK ADD  CONSTRAINT [FK__Contract__Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
GO

/*Thêm Khóa ngoại cho bảng DienNuoc */
ALTER TABLE [dbo].[DienNuoc]  WITH CHECK ADD  CONSTRAINT [FK__DN__Room] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([RoomID])
ON DELETE CASCADE
GO

/*thêm tài khoản*/
INSERT INTO [dbo].[Account] ([UserName], [PassWord]) VALUES (N'thanh', N'123') 
GO
/*Danh sách phòng*/
INSERT INTO [dbo].[Room] VALUES
('1','P101','0/4',N'Tốt'),
('2','P102','0/4',N'Tốt'),
('3','P103','0/4',N'Hỏng Quạt'),
('4','P104','0/4',N'Tốt'),
('5','P201','0/4',N'Tốt'),
('6','P202','0/4',N'Tốt'),
('7','P203','0/4',N'Tốt'),
('8','P204','0/4',N'Tốt'),
('9','P301','0/4',N'Tốt'),
('10','P302','0/4',N'Tốt'),
('11','P303','0/4',N'Tốt'),
('12','P304','0/4',N'Tốt'),
('13','P401','0/4',N'Tốt'),
('14','P402','0/4',N'Tốt'),
('15','P403','0/4',N'Tốt'),
('16','P404','0/4',N'Tốt'),
('17','P501','0/4',N'Tốt'),
('18','P502','0/4',N'Tốt'),
('19','P503','0/4',N'Tốt'),
('20','P504','0/4',N'Tốt')
GO

insert into Student values
(N'1',N'Nhi', N'1',N'22/06/2002',N'Nữ',N'20KT1',N'Kinh Tế',N'Hà Nội',N'a1@gmail.com','1234567890')
go

insert into Contract values 
(N'1',N'1',N'1',N'20/1/2023',N'20/6/2023')
go
insert into DienNuoc values
(N'1',N'1',N'15',N'12',N'20/2/2023',N'32000',N'32000',N'0')
go
/**/
USE [master]
GO
ALTER DATABASE [QLKTXSV] SET  READ_WRITE 
GO