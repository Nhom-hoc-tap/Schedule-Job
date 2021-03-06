USE [master]
GO
use [ReminderSystem]
/****** Object:  Database [ReminderSystem]    Script Date: 12/9/2021 11:25:50 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[NewChiTietCV_ID]    Script Date: 12/9/2021 11:25:50 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[NewCV_ID]    Script Date: 12/9/2021 11:25:50 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[NewLoaiCV_ID]    Script Date: 12/9/2021 11:25:50 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[NewTaiKhoan_ID]    Script Date: 12/9/2021 11:25:50 PM ******/
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
/****** Object:  Table [dbo].[ChiTietCV]    Script Date: 12/9/2021 11:25:50 PM ******/
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
/****** Object:  Table [dbo].[CongViec]    Script Date: 12/9/2021 11:25:50 PM ******/
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
/****** Object:  Table [dbo].[LoaiCV]    Script Date: 12/9/2021 11:25:50 PM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/9/2021 11:25:50 PM ******/
drop table TaiKhoan
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
	[CauHoi] [nvarchar] (255) not null,
	[CauTraloi] [nvarchar] (255) not null,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietCV] ON 

INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (1, 12, 0, 30, 0, N'Soạn giáo án', 1, N'Soạn giáo án cho môn Ngữ Văn lớp 12A4', 10)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (2, 12, 1, 30, 60, N'Chấm bài thi', 1, N'Chấm bài thi giữa kì lớp 12A1', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (3, 12, 0, 30, 0, N'Làm đề kiểm tra 15 phút', 1, N'Làm đề kiểm tra 15 phút cho lớp 12A4', 50)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (4, 20, 1, 45, 30, N'Dạy lớp 12b2', 1, N'Dạy bài mới rồi cho kiểm tra 15p', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (5, 21, 1, 30, 15, N'Quét sân rồi rửa chén cho mẹ khen', 1, N'', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (6, 22, 1, 30, 20, N'Mua áo', 1, N'Áo size to hơn mình béo hơn năm trước rồi', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (7, 22, 1, 30, 60, N'Mua Quần', 1, N'Quần cũng vậy mua size to hơn', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (8, 23, 1, 30, 15, N'Chụp hình thẻ 4*6 để dán vào hồ sơ', 1, N'Nhờ ông chú gần trường chụp cho đẹp', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (9, 24, 1, 30, 20, N'Làm bài Vật Lý trên lớp', 1, N'Làm hết', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (10, 24, 1, 30, 10, N'Làm bài hoá trên lớp', 1, N'Làm câu 2a,4c,5b mấy câu còn lại khỏi cần lại', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (11, 26, 1, 30, 5, N'Chụp hình với lớp', 1, N'', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (12, 26, 1, 30, 5, N'Lấy chìa khoá ở phòng bảo vệ để lấy ghế', 1, N'6h30 mới cho lấy', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (13, 27, 1, 15, 120, N'Vệ sinh cá nhân', 1, N'', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (14, 27, 1, 5, 15, N'Rủ thằng bạn tại hôm nay nó rảnh buổi sáng', 1, N'Đi đu đưa', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (15, 29, 1, 15, 60, N'Ăn mặc, chải chuốt, kiểm tra kỹ lưỡng', 1, N'Sạch sẽ là ghi điểm rồi', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (16, 30, 1, 30, 15, N'Điền thông tin vào đơn tiêm vacxin', 1, N'Nhớ đem theo CMND và thẻ BHYT', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (17, 33, 0, 5, 0, N'Ủy thác số 1', 1, N'', 0)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (22, 23, 1, 20, 60, N'Đi xin việc', 0, N'', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (23, 54, 1, 15, 15, N'Rửa mặt', 1, N'', 100)
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiDuKien], [ThoiThucTe], [TenChiTietCV], [MucdoUuTien], [MoTa], [TienDo]) VALUES (24, 54, 1, 540, 600, N'Lên giường đi ngủ', 1, N'', 100)
SET IDENTITY_INSERT [dbo].[ChiTietCV] OFF
GO
SET IDENTITY_INSERT [dbo].[CongViec] ON 

INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (20, N'Dạy học', CAST(N'2021-12-10T08:00:00' AS SmallDateTime), CAST(N'2021-12-11T18:08:00' AS SmallDateTime), 1, 100, 10, 1, N'Dạy học khóa 12 năm 2021')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (21, N'Việc nhà', CAST(N'2021-04-30T08:00:00' AS SmallDateTime), CAST(N'2021-04-30T08:12:00' AS SmallDateTime), 1, 60, 9, -1, N'Việc nhà tuần 30')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (22, N'Chuẩn bị đồ tết', CAST(N'2021-12-10T08:00:00' AS SmallDateTime), CAST(N'2022-01-26T16:00:00' AS SmallDateTime), 1, 0, 9, 0, N'Chuẩn bị đồ tết năm 2022')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (23, N'Làm hồ sơ xin việc', CAST(N'2021-08-31T00:00:00' AS SmallDateTime), CAST(N'2021-12-18T02:00:00' AS SmallDateTime), 1, 100, 9, 1, N'Dự phòng bị xa thải do ngáo ngơ')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (24, N'Giải bài tập toán', CAST(N'2021-12-09T00:00:00' AS SmallDateTime), CAST(N'2021-12-09T06:00:00' AS SmallDateTime), 1, 100, 8, 1, N'Giải bài tập toán cao cấp để khỏi quên mất')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (25, N'Hoa rơi hữu ý, nước chảy do quên đóng vòi nước', CAST(N'2021-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), 0, 90, 8, -1, N'Đi thả thính đó')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (26, N'Dự khai giảng', CAST(N'2021-08-31T16:00:00' AS SmallDateTime), CAST(N'2021-12-26T00:00:00' AS SmallDateTime), 1, 30, 10, 0, N'Dự khai giảng năm học mới')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (27, N'Tập thể dục vào buổi sáng', CAST(N'2021-04-30T06:00:00' AS SmallDateTime), CAST(N'2021-04-30T06:30:00' AS SmallDateTime), 0, 75, 9, -1, N'Muốn khoẻ đẹp thì hãy tập thể thao')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (28, N'Đi học thêm môn Hoá', CAST(N'2021-09-13T20:00:00' AS SmallDateTime), CAST(N'2021-12-26T06:00:00' AS SmallDateTime), 0, 0, 8, 0, N'Học nhiều thành tài')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (29, N'Đi khám răng định kỳ', CAST(N'2021-12-09T07:30:00' AS SmallDateTime), CAST(N'2021-12-09T09:00:00' AS SmallDateTime), 0, 25, 9, -1, N'Răng bị sâu ăn không khám là xong')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (30, N'Đi hẹn hò', CAST(N'2021-12-09T19:00:00' AS SmallDateTime), CAST(N'2021-12-09T20:00:00' AS SmallDateTime), 0, 100, 9, 1, N'Hẹn hò ở quán trà sữa gần nhà')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (31, N'Đi tiêm vacxin', CAST(N'2021-08-22T07:00:00' AS SmallDateTime), CAST(N'2021-08-22T12:00:00' AS SmallDateTime), 0, 100, 9, 1, N'Đi tiêm theo chỉ thị của Chính Phủ')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (42, N'asdf', CAST(N'2021-12-09T18:00:00' AS SmallDateTime), CAST(N'2021-12-18T00:00:00' AS SmallDateTime), 0, 0, 10, 0, N'')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (43, N'adasd', CAST(N'2021-12-09T09:00:00' AS SmallDateTime), CAST(N'2021-12-25T00:00:00' AS SmallDateTime), 0, 0, 8, 0, N'')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (44, N'12345', CAST(N'2021-12-09T09:00:00' AS SmallDateTime), CAST(N'2021-12-24T00:00:00' AS SmallDateTime), 0, 0, 8, 0, N'')
INSERT [dbo].[CongViec] ([ID], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], [TrangThai], [MoTa]) VALUES (54, N'Đi ngủ', CAST(N'2021-12-09T09:00:00' AS SmallDateTime), CAST(N'2021-12-10T07:00:00' AS SmallDateTime), 1, 100, 13, 1, N'Đây là công việc hết sức quan trọng')
SET IDENTITY_INSERT [dbo].[CongViec] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiCV] ON 

INSERT [dbo].[LoaiCV] ([ID], [TenLoaiCV], [TenDangNhap]) VALUES (8, N'Học tập', N'Huu')
INSERT [dbo].[LoaiCV] ([ID], [TenLoaiCV], [TenDangNhap]) VALUES (9, N'Cá nhân', N'Huu')
INSERT [dbo].[LoaiCV] ([ID], [TenLoaiCV], [TenDangNhap]) VALUES (10, N'Giáo dục đào tạo', N'Huu')
INSERT [dbo].[LoaiCV] ([ID], [TenLoaiCV], [TenDangNhap]) VALUES (11, N'Đọc sách', N'Huu')
INSERT [dbo].[LoaiCV] ([ID], [TenLoaiCV], [TenDangNhap]) VALUES (12, N'Công việc hàng ngày trong game Genshin Impact', N'Huu')
INSERT [dbo].[LoaiCV] ([ID], [TenLoaiCV], [TenDangNhap]) VALUES (13, N'Việc hàng ngày', N'causotuicaine')
SET IDENTITY_INSERT [dbo].[LoaiCV] OFF
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HovaTen], [GioiTinh], [Ngaysinh],[CauHoi],[CauTraloi]) VALUES (N'causotuicaine', N'12345', N'Nguyễn Văn A', 1, CAST(N'2021-12-07T16:26:00' AS SmallDateTime),'Bạn học trường nào','Đại học Đà lạt')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HovaTen], [GioiTinh], [Ngaysinh],[CauHoi],[CauTraloi]) VALUES (N'Hieu', N'123456', N'Cao Dương Sơn Hiếu', 1, CAST(N'2002-04-30T00:00:00' AS SmallDateTime),'Bạn học trường nào','Đại học Đà lạt')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HovaTen], [GioiTinh], [Ngaysinh],[CauHoi],[CauTraloi]) VALUES (N'HongBichTram', N'000', N'Nguyễn Hồng Bích Trâm', 0, CAST(N'2004-04-30T00:00:00' AS SmallDateTime),'Bạn học trường nào','Đại học Đà lạt')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HovaTen], [GioiTinh], [Ngaysinh],[CauHoi],[CauTraloi]) VALUES (N'Huu', N'123', N'Nhữ Văn Hữu', 1, CAST(N'2001-04-30T00:00:00' AS SmallDateTime),'Bạn học trường nào','Đại học Đà lạt')
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HovaTen], [GioiTinh], [Ngaysinh],[CauHoi],[CauTraloi]) VALUES (N'Mai', N'123456', N'Nguyễn Thị Mai', 0, CAST(N'1998-04-30T00:00:00' AS SmallDateTime),'Bạn học trường nào','Đại học Đà lạt')
GO

select TenDangNhap,MatKhau from TaiKhoan where CauHoi = N'Bạn học trường nào' and CauTraloi = N'Đại học đà lạt'
/****** Object:  StoredProcedure [dbo].[_Delete]    Script Date: 12/9/2021 11:25:50 PM ******/
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
/****** Object:  StoredProcedure [dbo].[ChiTietCV_Delete]    Script Date: 12/9/2021 11:25:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[ChiTietCV_Delete](@ID int)
as
begin
Delete from ChiTietCV where ID =@ID
end
GO

alter procedure CheckJobProgress(@IdJob int)
as
begin
	declare @sum int
	declare @count int

	select @sum = SUM(ct.TienDo), @count = COUNT(ct.ID)
	from ChiTietCV ct
	where ct.ID_CongViec= @IdJob

	if(@sum = @count*100)
	begin
		update CongViec set TienDo = 100, TrangThai = 1 where ID = @IdJob
	end
	else
	begin
		update CongViec set TienDo = (@sum/@count), TrangThai = 0 where ID = @IdJob
	end
end
go

select * from CongViec
exec CheckJobProgress 57
/****** Object:  StoredProcedure [dbo].[ChiTietCV_GetById]    Script Date: 12/9/2021 11:25:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ChiTietCV_GetById]
	@id int
as
begin
	select * 
	from ChiTietCV
	where ID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[ChiTietCV_Insert]    Script Date: 12/9/2021 11:25:50 PM ******/
drop proc ChiTietCV_Insert
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[ChiTietCV_Insert]
	@id int output,
	@idCongViec int,
	@ten nvarchar(1000),
	@duKien int,
	@thucTe int,
	@doUuTien tinyint,
	@tienDo int,
	@trangThai int,
	@moTa nvarchar(1000)
as
begin
	insert into ChiTietCV(ID_CongViec, TrangThai, ThoiDuKien, ThoiThucTe, TenChiTietCV, MucdoUuTien, MoTa, TienDo)
	values(@idCongViec, @trangThai, @duKien, @thucTe, @ten, @doUuTien, @moTa, @tienDo)
	set @id = @@IDENTITY

	declare @sum int
	declare @count int
	select @sum = SUM(cv.TienDo), @count = COUNT(cv.ID)
	from ChiTietCV cv
	where ID_CongViec = @idCongViec
	
	if(@sum = @count*100)
	begin
		update CongViec set TienDo = 100, TrangThai = 1 where ID = @idCongViec
	end
	else
	begin
		update CongViec set TienDo = (@sum/@count), TrangThai = 0 where ID = @idCongViec
	end
	
end
GO
exec dbo.ChiTietCV_Insert 25,24,'abc',20,20,1,30,1,'abc'

/****** Object:  StoredProcedure [dbo].[ChiTietCV_Update]    Script Date: 12/9/2021 11:25:50 PM ******/
drop proc ChiTietCV_Update
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ChiTietCV_Update]
	@id int,
	@idCongViec int,
	@ten nvarchar(1000),
	@duKien int,
	@thucTe int,
	@doUuTien tinyint,
	@tienDo int,
	@trangThai int,
	@moTa nvarchar(1000)
as
begin
	update ChiTietCV
	set
		ID_CongViec = @idCongViec,
		TenChiTietCV = @ten,
		ThoiDuKien = @duKien,
		ThoiThucTe = @thucTe,
		MucdoUuTien = @doUuTien,
		TienDo = @tienDo,
		TrangThai = @trangThai,
		MoTa = @moTa
	where ID = @id

	declare @sum int
	declare @count int
	select @sum = SUM(cv.TienDo), @count = COUNT(cv.ID)
	from ChiTietCV cv
	where ID_CongViec = @idCongViec
	
	if(@sum = @count*100)
	begin
		update CongViec set TienDo = 100, TrangThai = 1 where ID = @idCongViec
	end
	else
	begin
		update CongViec set TienDo = (@sum/@count) where ID = @idCongViec
	end

end
GO

exec ChiTietCV_Update 
/****** Object:  StoredProcedure [dbo].[CongViec_Delete]    Script Date: 12/9/2021 11:25:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CongViec_Delete](@ID int)
as
begin
Delete from CongViec where ID =@ID
Delete from ChiTietCV where ID_CongViec =@ID
end
GO
/****** Object:  StoredProcedure [dbo].[CongViec_GetById]    Script Date: 12/9/2021 11:25:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CongViec_GetById]
	@id int
as
begin
	select * 
	from CongViec
	where ID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[CongViec_Insert]    Script Date: 12/9/2021 11:25:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CongViec_Insert]
	@id int output,
	@tenCongViec nvarchar(1000),
	@batDau smalldatetime,
	@ketThuc smalldatetime,
	@doUuTien tinyint,
	@tienDo tinyint,
	@idLoaiCV int,
	@trangThai int,
	@moTa nvarchar(1000)
as
begin
	insert into CongViec(TenCongViec, ThoiGianBatDau, ThoiGianKetThuc, MucdoUuTien, TienDo, ID_LoaiCV, TrangThai, MoTa)
	values(@tenCongViec, @batDau, @ketThuc, @doUuTien, @tienDo, @idLoaiCV, @trangThai, @moTa)
	set @id = @@IDENTITY
end
GO
/****** Object:  StoredProcedure [dbo].[CongViec_Update]    Script Date: 12/9/2021 11:25:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CongViec_Update]
	@id int,
	@tenCongViec nvarchar(1000),
	@batDau smalldatetime,
	@ketThuc smalldatetime,
	@doUuTien tinyint,
	@tienDo tinyint,
	@idLoaiCV int,
	@trangThai int,
	@moTa nvarchar(1000)
as
begin
	update CongViec
	set
		TenCongViec = @tenCongViec,
		ThoiGianBatDau = @batDau,
		ThoiGianKetThuc = @ketThuc,
		MucdoUuTien = @doUuTien,
		TienDo = @tienDo,
		ID_LoaiCV = @idLoaiCV,
		TrangThai = @trangThai,
		MoTa = @moTa
	where ID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[DangNhap]    Script Date: 12/9/2021 11:25:50 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetAccountByUserName]    Script Date: 12/9/2021 11:25:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAccountByUserName]
	@tenDangNhap nvarchar(255)
as
begin
	select *
	from TaiKhoan
	where TenDangNhap = @tenDangNhap
end
GO
/****** Object:  StoredProcedure [dbo].[GetAll]    Script Date: 12/9/2021 11:25:50 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetJobByAccountName]    Script Date: 12/9/2021 11:25:50 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetJobDetailByJobId]    Script Date: 12/9/2021 11:25:50 PM ******/
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
/****** Object:  StoredProcedure [dbo].[GetTypeOfJobByAccountName]    Script Date: 12/9/2021 11:25:50 PM ******/
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
/****** Object:  StoredProcedure [dbo].[LoaiCV_Delete]    Script Date: 12/9/2021 11:25:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục Delete LoaiCV --
CREATE procedure [dbo].[LoaiCV_Delete](@ID int)
as
begin
Delete from LoaiCV where ID =@ID
end
GO
/****** Object:  StoredProcedure [dbo].[LoaiCV_Insert]    Script Date: 12/9/2021 11:25:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[LoaiCV_Insert] (
@ID int output,
@TenLoaiCV nvarchar(1000),
@TenDangNhap nvarchar(255)
)
as 
begin
if(not exists (select TenLoaiCV from LoaiCV where TenLoaiCV =@TenLoaiCV and TenDangNhap = @TenDangNhap))
begin 
insert into LoaiCV(TenLoaiCV, TenDangNhap) values (@TenLoaiCV, @TenDangNhap)
end
set @ID = @@IDENTITY
End
GO
/****** Object:  StoredProcedure [dbo].[LoaiCV_Update]    Script Date: 12/9/2021 11:25:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[LoaiCV_Update](@ID int output,
@TenLoaiCV nvarchar(1000))
as
begin
Update LoaiCV
set TenLoaiCV = @TenLoaiCV
where ID = @ID
end 
GO
/****** Object:  StoredProcedure [dbo].[SetJobDetailStatus]    Script Date: 12/9/2021 11:25:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SetJobDetailStatus](@JobDetailId int, @Status int)
as
begin
update ChiTietCV set TrangThai = @Status where ID = @JobDetailId
end
GO
/****** Object:  StoredProcedure [dbo].[SetJobDetailToDrop]    Script Date: 12/9/2021 11:25:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SetJobDetailToDrop](@JobDetailId int)
as
begin
update ChiTietCV set TrangThai = 2 where ID = @JobDetailId and TrangThai = 0
end
GO
/****** Object:  StoredProcedure [dbo].[SetJobStatus]    Script Date: 12/9/2021 11:25:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SetJobStatus](@JobId int, @Status int)
as
begin
update CongViec set TrangThai = @Status where ID = @JobId 
end
GO
/****** Object:  StoredProcedure [dbo].[SetJobToDrop]    Script Date: 12/9/2021 11:25:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SetJobToDrop](@JobId int)
as
begin

update CongViec set TrangThai = 2 where ID = @JobId and TrangThai = 0 
end
GO
/****** Object:  StoredProcedure [dbo].[TaiKhoan_Delete]    Script Date: 12/9/2021 11:25:50 PM ******/
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
/****** Object:  StoredProcedure [dbo].[TaiKhoan_Insert]    Script Date: 12/9/2021 11:25:50 PM ******/
drop proc TaiKhoan_Insert
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[TaiKhoan_Insert] (
@TenDangNhap nvarchar(255),
@MatKhau nvarchar(1000),
@HovaTen nvarchar(1000),
@GioiTinh bit,
@NgaySinh smalldatetime,
@Cauhoi nvarchar(255),
@Cautraloi nvarchar(255)
)
as 
begin
if(not exists (select TenDangNhap from TaiKhoan where TenDangNhap =@TenDangNhap))
begin 
insert into TaiKhoan(TenDangNhap,MatKhau,HovaTen,GioiTinh,Ngaysinh,CauHoi,CauTraloi) values (@TenDangNhap,@MatKhau,@HovaTen,@GioiTinh,@NgaySinh,@Cauhoi,@Cautraloi)
end
End
GO
/****** Object:  StoredProcedure [dbo].[TaiKhoan_Update]    Script Date: 12/9/2021 11:25:50 PM ******/
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
create proc [dbo].[MatKhauUpdate]
@