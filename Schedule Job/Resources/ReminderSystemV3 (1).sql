USE [ReminderSystem]
GO
/****** Object:  Database [ReminderSystem]    Script Date: 12/9/2021 7:48:44 AM ******/
CREATE DATABASE [ReminderSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ReminderSystem', FILENAME = N'D:\SQL\MSSQL15.SQLEXPRESS\MSSQL\DATA\ReminderSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ReminderSystem_log', FILENAME = N'D:\SQL\MSSQL15.SQLEXPRESS\MSSQL\DATA\ReminderSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ReminderSystem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ReminderSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ReminderSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ReminderSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ReminderSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ReminderSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ReminderSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [ReminderSystem] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ReminderSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ReminderSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ReminderSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ReminderSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ReminderSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ReminderSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ReminderSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ReminderSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ReminderSystem] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ReminderSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ReminderSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ReminderSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ReminderSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ReminderSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ReminderSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ReminderSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ReminderSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ReminderSystem] SET  MULTI_USER 
GO
ALTER DATABASE [ReminderSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ReminderSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ReminderSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ReminderSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ReminderSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ReminderSystem] SET QUERY_STORE = OFF
GO
USE [ReminderSystem]
GO
/****** Object:  UserDefinedFunction [dbo].[NewChiTietCV_ID]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[NewChiTietCV_ID]() returns int
As
begin
declare @NewID int

if exists(select * from ChiTietCV)
begin
select @NewID = MAX(ID)+1
from ChiTietCV
end
else
set @NewID = 1
return @NewID
End
GO
/****** Object:  UserDefinedFunction [dbo].[NewCV_ID]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[NewCV_ID]() returns int
As
begin
declare @NewID int

if exists(select * from CongViec)
begin
select @NewID = MAX(ID)+1
from CongViec
end
else
set @NewID = 1
return @NewID
End
GO
/****** Object:  UserDefinedFunction [dbo].[NewLoaiCV_ID]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[NewLoaiCV_ID]() returns int
As
begin
declare @NewID int

if exists(select * from LoaiCV)
begin
select @NewID = MAX(ID)+1
from LoaiCV
end
else
set @NewID = 1
return @NewID
End
GO
/****** Object:  UserDefinedFunction [dbo].[NewTaiKhoan_ID]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[NewTaiKhoan_ID]() returns int
As
begin
declare @NewID int

if exists(select * from TaiKhoan)
begin
select @NewID = MAX(ID)+1
from TaiKhoan
end
else
set @NewID = 1
return @NewID
End
GO
/****** Object:  Table [dbo].[ChiTietCV]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietCV](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_CongViec] [int] NOT NULL,
	[TrangThai] [int] NULL,
	[ThoiDuKien] [int] NULL,
	[ThoiThucTe] [int] NULL,
	[TenChiTietCV] [nvarchar](1000) NULL,
	[MucdoUuTien] [tinyint] NULL,
	[MoTa] [nvarchar](1000) NULL,
	[TienDo] [int] NULL,
 CONSTRAINT [PK_ChiTietCV] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongViec]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongViec](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenCongViec] [nvarchar](1000) NULL,
	[ThoiGianBatDau] [smalldatetime] NULL,
	[ThoiGianKetThuc] [smalldatetime] NULL,
	[MucdoUuTien] [tinyint] NULL,
	[TienDo] [tinyint] NOT NULL,
	[ID_LoaiCV] [int] NULL,
	[TrangThai] [int] NULL,
	[MoTa] [nvarchar](1000) NULL,
 CONSTRAINT [PK_CongViec] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiCV]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiCV](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiCV] [nvarchar](1000) NULL,
	[TenDangNhap] [nvarchar](255) NULL,
 CONSTRAINT [PK_LoaiCV] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [nvarchar](255) NOT NULL,
	[MatKhau] [nvarchar](1000) NULL,
	[HovaTen] [nvarchar](1000) NULL,
	[GioiTinh] [bit] NULL,
	[Ngaysinh] [smalldatetime] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietCV] ON 

INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (1, 12, 0, 30, 0, N'Soạn giáo án', 1, N'Soạn giáo án cho môn Ngữ Văn lớp 12A4', 10)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (2, 12, 0, 30, 0, N'Chấm bài thi', 1, N'Chấm bài thi giữa kì lớp 12A1', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (3, 12, 0, 30, 0, N'Làm đề kiểm tra 15 phút', 1, N'Làm đề kiểm tra 15 phút cho lớp 12A4', 50)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (4, 18, 1, 30, 10, N'Chi tiết công việc 1', 1, N'Mô tả chi tiết công việc', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (5, 18, 1, 30, 40, N'Chi tiết công việc 2', 1, N'Mô tả chi tiết công việc', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (6, 18, 1, 30, 10, N'Chi tiết công việc 3', 1, N'Mô tả chi tiết công việc', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (7, 18, 1, 30, 50, N'Chi tiết công việc 4', 1, N'Mô tả chi tiết công việc', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (8, 18, 1, 30, 5, N'Chi tiết công việc 5', 1, N'Mô tả chi tiết công việc', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (9, 18, 1, 60, 5, N'Chi tiết công việc 6', 1, N'Mô tả chi tiết công việc', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (10, 20, 0, 60, 0, N'Chi tiết công việc 6', 1, N'Mô tả chi tiết công việc', 10)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (11, 20, 0, 60, 30, N'Chi tiết công việc 6', 1, N'Mô tả chi tiết công việc', 100)
SET IDENTITY_INSERT [dbo].[ChiTietCV] OFF
GO
SET IDENTITY_INSERT [dbo].[CongViec] ON 

INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (12, N'Dạy học', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), 1, 20, 8, 0, N'Dạy học khóa 12 năm 2021')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (15, N'Việc nhà', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), 1, 60, 8, 0, N'Việc nhà tuần 30')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (16, N'Chuẩn bị đồ tết', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), 1, 50, 8, 0, N'Chuẩn bị đồ tết năm 2022')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (17, N'Làm hồ sơ xin việc', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), 1, 0, 8, 0, N'Dự phòng bị xa thải do ngáo ngơ')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (18, N'Giải bài tập', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), 1, 100, 8, 0, N'Giải bài tập toán cao cấp để khỏi quên mất')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (19, N'Hoa rơi hữu ý, nước chảy do quên đóng vòi nước', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), 0, 90, 8, 0, N'Đi thả thính đó')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (20, N'Hoa rơi cửa Phật, vạn sự coi lịch vạn niên', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2021-12-10T00:00:00' AS SmallDateTime), 1, 50, 9, 0, N'Ra cửa nhớ xem ngày hoàng đạo')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (21, N'Sang sông phải bắc cầu Kiều, muốn con hay chữ phải bắc cầu Kiều', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2021-12-10T00:00:00' AS SmallDateTime), 1, 50, 10, 0, N'Ca dao tục ngữ hệ Gen Z')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (23, N'Gần mực thì đen, gần đèn thì cháy xém', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2021-12-10T00:00:00' AS SmallDateTime), 1, 50, 9, 0, N'Ca dao tục ngữ hệ Gen Z')
SET IDENTITY_INSERT [dbo].[CongViec] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiCV] ON 

INSERT [dbo].[LoaiCV] ([ID], [TenLoaiCV], [TenDangNhap]) VALUES (8, N'Học tập', N'Nguyễn Văn A')
INSERT [dbo].[LoaiCV] ([ID], [TenLoaiCV], [TenDangNhap]) VALUES (9, N'Giải trí', N'Nguyễn Văn A')
INSERT [dbo].[LoaiCV] ([ID], [TenLoaiCV], [TenDangNhap]) VALUES (10, N'Viễn tưởng', N'Nguyễn Văn A')
SET IDENTITY_INSERT [dbo].[LoaiCV] OFF
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HovaTen], [GioiTinh], [Ngaysinh]) VALUES (N'Nguyễn Văn A', N'123456', N'Nguyễn Văn A', 1, CAST(N'2014-04-30T00:00:00' AS SmallDateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HovaTen], [GioiTinh], [Ngaysinh]) VALUES (N'Nguyễn Văn B', N'123456', N'Nguyễn Văn B', 0, CAST(N'2014-04-30T00:00:00' AS SmallDateTime))
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HovaTen], [GioiTinh], [Ngaysinh]) VALUES (N'Nguyễn Văn C', N'123456', N'Nguyễn Văn C', 1, CAST(N'2014-04-30T00:00:00' AS SmallDateTime))
GO
/****** Object:  StoredProcedure [dbo].[_Delete]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[_Delete](@TableName nvarchar(200),@ID int)
as
begin
declare @sql nvarchar(1000)
set @sql = 'delete from '+@TableName +' where ID = '+CAST(@ID as nvarchar(50))
Exec (@sql)
end
GO
/****** Object:  StoredProcedure [dbo].[ChiTietCV_Delete]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục Delete ChiTietCV --
Create procedure [dbo].[ChiTietCV_Delete](@ID int)
as
begin
Delete from ChiTietCV where ID =@ID
end
GO
/****** Object:  StoredProcedure [dbo].[ChiTietCV_Insert]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[ChiTietCV_Insert] (
@ID int output,
@ID_CongViec int,
@TrangThai bit,
@ThoiGianBatDau smalldatetime,
@ThoiGianKetThuc smalldatetime,
@TenChiTietCV nvarchar(1000)
)
as 
begin
if(not exists (select TenChiTietCV from ChiTietCV where TenChiTietCV =@TenChiTietCV and ID_CongViec = @ID_CongViec))
begin 
insert into ChiTietCV (ID,ID_CongViec,TrangThai,ThoiGianBatDau,ThoiGianKetThuc,TenChiTietCV) values (@ID,@ID_CongViec,@TrangThai,@ThoiGianBatDau,@ThoiGianKetThuc,@TenChiTietCV)
end
set @ID = @@IDENTITY
End
GO
/****** Object:  StoredProcedure [dbo].[ChiTietCV_Update]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- Thử nghiệm ---

-- Thủ tục Update ChiTietCV --
create procedure [dbo].[ChiTietCV_Update](@ID int output,
@ID_CongViec int,
@TrangThai bit,
@ThoiGianBatDau smalldatetime,
@ThoiGianKetThuc smalldatetime,
@TenChiTietCV nvarchar(1000))
as
begin
Update ChiTietCV
set ID_CongViec = @ID_CongViec, TrangThai = @TrangThai, ThoiGianBatDau = @ThoiGianBatDau, ThoiGianKetThuc = @ThoiGianKetThuc, TenChiTietCV = @TenChiTietCV
where ID = @ID
end 
GO
/****** Object:  StoredProcedure [dbo].[CongViec_Delete]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục Delete CongViec --
Create procedure [dbo].[CongViec_Delete](@ID int)
as
begin
Delete from CongViec where ID =@ID
end
GO
/****** Object:  StoredProcedure [dbo].[CongViec_Insert]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[CongViec_Insert] (
@ID int output,
@TenDangNhap nvarchar(255),
@TenCongViec nvarchar(1000),
@ThoiGianBatDau smalldatetime,
@ThoiGianKetThuc smalldatetime,
@MucDoUuTien tinyint,
@TienDo tinyint,
@ID_LoaiCV int
)
as 
begin
if(not exists (select TenCongViec from CongViec where TenCongViec =@TenCongViec and ID_LoaiCV = @ID_LoaiCV))
begin 
insert into CongViec(TenDangNhap,TenCongViec,ThoiGianBatDau,ThoiGianKetThuc,MucdoUuTien,TienDo,ID_LoaiCV) values (@TenDangNhap,@TenCongViec,@ThoiGianBatDau,@ThoiGianKetThuc,@MucDoUuTien,@TienDo,@ID_LoaiCV)
end
set @ID = @@IDENTITY
End
GO
/****** Object:  StoredProcedure [dbo].[GetAll]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetAll](@TableName nvarchar(200))
as
begin
declare @sql nvarchar (2000)
set @sql = 'select * from '+@TableName
Exec (@sql)
end
GO
/****** Object:  StoredProcedure [dbo].[GetJobByAccountName]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetJobByAccountName](
@AccountName nvarchar(255))
as
begin
select c.ID, c.ID_LoaiCV, c.MoTa,c.MucdoUuTien,c.TenCongViec,c.ThoiGianBatDau,c.ThoiGianKetThuc,c.TienDo,c.TrangThai from CongViec c, LoaiCV l where c.ID_LoaiCV = l.ID and l.TenDangNhap = @AccountName
end
GO
/****** Object:  StoredProcedure [dbo].[GetJobDetailByJobId]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetJobDetailByJobId] (@JobId int)
as
begin
select * from ChiTietCV where ID_CongViec = @JobId
end
GO
/****** Object:  StoredProcedure [dbo].[GetTypeOfJobByAccountName]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetTypeOfJobByAccountName] (@AccountName nvarchar(255))
as
begin
select * from LoaiCV where TenDangNhap = @AccountName
end
GO
/****** Object:  StoredProcedure [dbo].[LoaiCV_Delete]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục Delete LoaiCV --
Create procedure [dbo].[LoaiCV_Delete](@ID int)
as
begin
Delete from LoaiCV where ID =@ID
end
GO
/****** Object:  StoredProcedure [dbo].[LoaiCV_Insert]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------------------------------
--------------------------------------------------------------------------------

--- Thủ tục Insert LoaiCV ---
create Procedure [dbo].[LoaiCV_Insert] (
@ID int output,
@TenLoaiCV nvarchar(1000)
)
as 
begin
if(not exists (select TenLoaiCV from LoaiCV where TenLoaiCV =@TenLoaiCV))
begin 
insert into LoaiCV(TenLoaiCV) values (@TenLoaiCV)
end
set @ID = @@IDENTITY
End
GO
/****** Object:  StoredProcedure [dbo].[LoaiCV_Update]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- Thử nghiệm ---

-- Thủ tục Update LoaiCV --
create procedure [dbo].[LoaiCV_Update](@ID int output,
@TenLoaiCV nvarchar(1000))
as
begin
Update LoaiCV
set TenLoaiCV = @TenLoaiCV
where ID = @ID
end 
GO
/****** Object:  StoredProcedure [dbo].[TaiKhoan_Delete]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TaiKhoan_Delete](@TendangNhap nvarchar(255))
as
begin
Delete from TaiKhoan where @TendangNhap = TenDangNhap
end
GO
/****** Object:  StoredProcedure [dbo].[TaiKhoan_Insert]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[TaiKhoan_Insert] (
@TenDangNhap nvarchar(255),
@MatKhau nvarchar(1000),
@HovaTen nvarchar(1000),
@GioiTinh bit,
@NgaySinh smalldatetime
)
as 
begin
if(not exists (select TenDangNhap from TaiKhoan where TenDangNhap =@TenDangNhap))
begin 
insert into TaiKhoan(TenDangNhap,MatKhau,HovaTen,GioiTinh,Ngaysinh) values (@TenDangNhap,@MatKhau,@HovaTen,@GioiTinh,@NgaySinh)
end
End
GO
/****** Object:  StoredProcedure [dbo].[TaiKhoan_Update]    Script Date: 12/9/2021 7:48:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[TaiKhoan_Update](
@TenDangNhap nvarchar(255),
@MatKhau nvarchar(1000),
@HovaTen nvarchar(1000),
@GioiTinh bit,
@NgaySinh smalldatetime)
as
begin
Update TaiKhoan
set MatKhau =@MatKhau, HovaTen= @HovaTen,GioiTinh=@GioiTinh,Ngaysinh=@NgaySinh
where TenDangNhap = @TenDangNhap
end 
GO
USE [master]
GO
ALTER DATABASE [ReminderSystem] SET  READ_WRITE 
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetAccountByUserName]
	@tenDangNhap nvarchar(255)
as
begin
	select *
	from TaiKhoan
	where TenDangNhap = @tenDangNhap
end
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DangNhap]
	@tenDangNhap nvarchar(255),
	@matKhau nvarchar(1000)
as
begin
	select *
	from TaiKhoan
	where TenDangNhap = @tenDangNhap and MatKhau = @matKhau
end
GO

select * from TaiKhoan