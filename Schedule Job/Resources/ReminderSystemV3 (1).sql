Create database [ReminderSystem]
go

USE [ReminderSystem]
GO

/****** Object:  UserDefinedFunction [dbo].[NewChiTietCV_ID]    Script Date: 9/8/2021 9:58:51 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[NewCV_ID]    Script Date: 9/8/2021 9:58:51 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[NewLoaiCV_ID]    Script Date: 9/8/2021 9:58:51 AM ******/
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
/****** Object:  UserDefinedFunction [dbo].[NewTaiKhoan_ID]    Script Date: 9/8/2021 9:58:51 AM ******/
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
/****** Object:  Table [dbo].[ChiTietCV]    Script Date: 9/8/2021 9:58:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop table ChiTietCV
Create TABLE [dbo].[ChiTietCV](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_CongViec] [int] NOT NULL,
	[TrangThai] int NULL,
	[ThoiDuKien] int NULL,
	[ThoiThucTe] int NULL,
	[TenChiTietCV] [nvarchar](1000) NULL,
	[MucdoUuTien] [tinyint] NULL,
	[MoTa] nvarchar(1000),
	[TienDo] int
 CONSTRAINT [PK_ChiTietCV] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongViec]    Script Date: 9/8/2021 9:58:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongViec](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nvarchar](255) NULL,
	[TenCongViec] [nvarchar](1000) NULL,
	[ThoiGianBatDau] [smalldatetime] NULL,
	[ThoiGianKetThuc] [smalldatetime] NULL,
	[MucdoUuTien] [tinyint] NULL,
	[TienDo] [tinyint] NOT NULL,
	[ID_LoaiCV] [int] NULL,
	[TrangThai] int,
	[MoTa] nvarchar(1000)
 CONSTRAINT [PK_CongViec] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiCV]    Script Date: 9/8/2021 9:58:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

drop table LoaiCV
CREATE TABLE [dbo].[LoaiCV](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiCV] [nvarchar](1000) NULL,
	[TenDangNhap] [nvarchar](255) NULL
 CONSTRAINT [PK_LoaiCV] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 9/8/2021 9:58:52 AM ******/
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
GO
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiGianBatDau], [ThoiGianKetThuc], [TenChiTietCV], [TienDo]) VALUES (1, 12, 1, CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), N'Giáo viên', 10)
GO
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiGianBatDau], [ThoiGianKetThuc], [TenChiTietCV],[TienDo]) VALUES (2, 13, 1, CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), N'Học sinh', 100)
GO
INSERT [dbo].[ChiTietCV] ([ID], [ID_CongViec], [TrangThai], [ThoiGianBatDau], [ThoiGianKetThuc], [TenChiTietCV],[TienDo]) VALUES (3, 14, 1, CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), N'Kỹ sư',50)
GO

insert ChiTietCV (ID, TenChiTietCV, MoTa, ThoiDuKien,ThoiThucTe,TrangThai,MucdoUuTien,ID_CongViec, TienDo) values (1, N'Soạn giáo án',N'Soạn giáo án cho môn Ngữ Văn lớp 12A4', 30,0,0,1,12, 10)
insert ChiTietCV (ID, TenChiTietCV, MoTa, ThoiDuKien,ThoiThucTe,TrangThai,MucdoUuTien,ID_CongViec, TienDo) values (2, N'Chấm bài thi',N'Chấm bài thi giữa kì lớp 12A1', 30,0,0,1,12, 100)
insert ChiTietCV (ID, TenChiTietCV, MoTa, ThoiDuKien,ThoiThucTe,TrangThai,MucdoUuTien,ID_CongViec, TienDo) values (3, N'Làm đề kiểm tra 15 phút',N'Làm đề kiểm tra 15 phút cho lớp 12A4', 30,0,0,1,12, 50)

select * from LoaiCV

delete CongViec
SET IDENTITY_INSERT [dbo].[ChiTietCV] OFF
GO
SET IDENTITY_INSERT [dbo].[CongViec] ON 
GO
INSERT [dbo].[CongViec] ([ID], [TenDangNhap], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], TrangThai, MoTa) VALUES (12, N'Nguyễn Văn A', N'Dạy học', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), 1, 20, 8, 0, N'Dạy học khóa 12 năm 2021')
GO
INSERT [dbo].[CongViec] ([ID], [TenDangNhap], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], TrangThai, MoTa) VALUES (15, N'Nguyễn Văn A', N'Việc nhà', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), 1, 60, 8, 0, N'Việc nhà tuần 30')
GO
INSERT [dbo].[CongViec] ([ID], [TenDangNhap], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], TrangThai, MoTa) VALUES (16, N'Nguyễn Văn A', N'Chuẩn bị đồ tết', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), 1, 50, 8, 0, N'Chuẩn bị đồ tết năm 2022')
GO
INSERT [dbo].[CongViec] ([ID], [TenDangNhap], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], TrangThai, MoTa) VALUES (17, N'Nguyễn Văn A', N'Làm hồ sơ xin việc', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), 1, 0, 8, 0, N'Dự phòng bị xa thải do ngáo ngơ')
GO
INSERT [dbo].[CongViec] ([ID], [TenDangNhap], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], TrangThai, MoTa) VALUES (18, N'Nguyễn Văn A', N'Giải bài tập', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), 1, 100, 8, 0, N'Giải bài tập toán cao cấp để khỏi quên mất')
INSERT [dbo].[CongViec] ([ID], [TenDangNhap], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], TrangThai, MoTa) VALUES (19, N'Nguyễn Văn A', N'Hoa rơi hữu ý, nước chảy do quên đóng vòi nước', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), 0, 90, 8, 0, N'Đi thả thính đó')
GO

delete from CongViec


INSERT [dbo].[CongViec] ([ID], [TenDangNhap], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], TrangThai, MoTa) VALUES (13, N'Nguyễn Văn B', N'Bà Còng đi chợ trời mưa', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), 1, 40, 9, 0, null)
GO
INSERT [dbo].[CongViec] ([ID], [TenDangNhap], [TenCongViec], [ThoiGianBatDau], [ThoiGianKetThuc], [MucdoUuTien], [TienDo], [ID_LoaiCV], TrangThai, MoTa) VALUES (14, N'Nguyễn Văn C', N'Sắp mưa, sắp mưa, những con mối bay ra', CAST(N'2014-04-30T00:00:00' AS SmallDateTime), CAST(N'2014-04-30T00:00:00' AS SmallDateTime), 1, 80, 10, 0, null)
GO
SET IDENTITY_INSERT [dbo].[CongViec] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiCV] ON 
GO
INSERT [dbo].[LoaiCV] ([ID], [TenLoaiCV], TenDangNhap) VALUES (8, N'Học tập',N'Nguyễn Văn A')
GO
INSERT [dbo].[LoaiCV] ([ID], [TenLoaiCV], TenDangNhap) VALUES (9, N'Giải trí',N'Nguyễn Văn A')
GO
INSERT [dbo].[LoaiCV] ([ID], [TenLoaiCV],TenDangNhap) VALUES (10, N'Viễn tưởng',N'Nguyễn Văn A')
GO

SET IDENTITY_INSERT [dbo].[LoaiCV] OFF
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HovaTen], [GioiTinh], [Ngaysinh]) VALUES (N'Nguyễn Văn A', N'123456', N'Nguyễn Văn A', 1, CAST(N'2014-04-30T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HovaTen], [GioiTinh], [Ngaysinh]) VALUES (N'Nguyễn Văn B', N'123456', N'Nguyễn Văn B', 0, CAST(N'2014-04-30T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [HovaTen], [GioiTinh], [Ngaysinh]) VALUES (N'Nguyễn Văn C', N'123456', N'Nguyễn Văn C', 1, CAST(N'2014-04-30T00:00:00' AS SmallDateTime))
GO
ALTER TABLE [dbo].[ChiTietCV]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietCV_CongViec] FOREIGN KEY([ID_CongViec])
REFERENCES [dbo].[CongViec] ([ID])
GO
ALTER TABLE [dbo].[ChiTietCV] CHECK CONSTRAINT [FK_ChiTietCV_CongViec]
GO
ALTER TABLE [dbo].[CongViec]  WITH CHECK ADD  CONSTRAINT [FK_CongViec_LoaiCV] FOREIGN KEY([ID_LoaiCV])
REFERENCES [dbo].[LoaiCV] ([ID])
GO
ALTER TABLE [dbo].[CongViec] CHECK CONSTRAINT [FK_CongViec_LoaiCV]
GO
ALTER TABLE [dbo].[CongViec]  WITH CHECK ADD  CONSTRAINT [FK_CongViec_TaiKhoan] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[TaiKhoan] ([TenDangNhap])
GO
ALTER TABLE [dbo].[CongViec] CHECK CONSTRAINT [FK_CongViec_TaiKhoan]
GO
/****** Object:  StoredProcedure [dbo].[_Delete]    Script Date: 9/8/2021 9:58:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[ChiTietCV_Delete]    Script Date: 9/8/2021 9:58:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[ChiTietCV_Insert]    Script Date: 9/8/2021 9:58:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[ChiTietCV_Update]    Script Date: 9/8/2021 9:58:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[CongViec_Delete]    Script Date: 9/8/2021 9:58:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[CongViec_Insert]    Script Date: 9/8/2021 9:58:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[CongViec_Update]    Script Date: 9/8/2021 9:58:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- Thử nghiệm ---

-- Thủ tục Update CongViec --
create procedure [dbo].[CongViec_Update](@ID int output,
@ID_Taikhoan int,
@TenCongViec nvarchar(1000),
@ThoiGianBatDau smalldatetime,
@ThoiGianKetThuc smalldatetime,
@MucDoUuTien tinyint,
@TienDo tinyint,
@ID_LoaiCV int)
as
begin
Update CongViec
set ID_TaiKhoan = @ID_Taikhoan, TenCongViec = @TenCongViec,ThoiGianBatDau = @ThoiGianBatDau, ThoiGianKetThuc = @ThoiGianKetThuc, MucdoUuTien = @MucDoUuTien,TienDo = @TienDo,ID_LoaiCV=@ID_LoaiCV
where ID = @ID
end 
GO
/****** Object:  StoredProcedure [dbo].[GetAll]    Script Date: 9/8/2021 9:58:52 AM ******/
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
execute dbo.GetAll 'CongViec'

/****** Object:  StoredProcedure [dbo].[LoaiCV_Delete]    Script Date: 9/8/2021 9:58:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[LoaiCV_Insert]    Script Date: 9/8/2021 9:58:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[LoaiCV_Update]    Script Date: 9/8/2021 9:58:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[TaiKhoan_Delete]    Script Date: 9/8/2021 9:58:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[TaiKhoan_Insert]    Script Date: 9/8/2021 9:58:52 AM ******/
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
/****** Object:  StoredProcedure [dbo].[TaiKhoan_Update]    Script Date: 9/8/2021 9:58:52 AM ******/
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

select * from CongViec
select * from ChiTietCV
select * from TaiKhoan
go
create procedure GetJobByAccountName(
@AccountName nvarchar(255))
as
begin
select * from CongViec where TenDangNhap = @AccountName
end
go

            
execute GetJobByAccountName N'Nguyễn Văn A'
go
create procedure GetJobDetailByJobId (@JobId int)
as
begin
select * from ChiTietCV where ID_CongViec = @JobId
end
go

create procedure GetTypeOfJobByAccountName (@AccountName nvarchar(255))
as
begin
select * from LoaiCV where TenDangNhap = @AccountName
end
go

exec GetJobDetailByJobId 12

