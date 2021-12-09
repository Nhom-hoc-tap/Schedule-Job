USE [ReminderSystem]
GO
/****** Object:  UserDefinedFunction [dbo].[NewChiTietCV_ID]    Script Date: 09-Dec-21 14:20:15 ******/
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
/****** Object:  UserDefinedFunction [dbo].[NewCV_ID]    Script Date: 09-Dec-21 14:20:15 ******/
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
/****** Object:  UserDefinedFunction [dbo].[NewLoaiCV_ID]    Script Date: 09-Dec-21 14:20:15 ******/
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
/****** Object:  UserDefinedFunction [dbo].[NewTaiKhoan_ID]    Script Date: 09-Dec-21 14:20:15 ******/
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
/****** Object:  StoredProcedure [dbo].[_Delete]    Script Date: 09-Dec-21 14:20:15 ******/
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
/****** Object:  StoredProcedure [dbo].[ChiTietCV_Delete]    Script Date: 09-Dec-21 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục Delete ChiTietCV --
alter procedure [dbo].[ChiTietCV_Delete](@ID int)
as
begin
Delete from ChiTietCV where ID =@ID
end
GO
/****** Object:  StoredProcedure [dbo].[ChiTietCV_GetById]    Script Date: 09-Dec-21 14:20:15 ******/
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
/****** Object:  StoredProcedure [dbo].[ChiTietCV_Insert]    Script Date: 09-Dec-21 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter proc [dbo].[ChiTietCV_Insert]
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
end
GO
/****** Object:  StoredProcedure [dbo].[ChiTietCV_Update]    Script Date: 09-Dec-21 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter proc [dbo].[ChiTietCV_Update]
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
end
GO
/****** Object:  StoredProcedure [dbo].[CongViec_Delete]    Script Date: 09-Dec-21 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục Delete CongViec --
alter procedure [dbo].[CongViec_Delete](@ID int)
as
begin
Delete from CongViec where ID =@ID
Delete from ChiTietCV where ID_CongViec =@ID
end
GO
/****** Object:  StoredProcedure [dbo].[CongViec_GetById]    Script Date: 09-Dec-21 14:20:15 ******/
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
/****** Object:  StoredProcedure [dbo].[CongViec_Insert]    Script Date: 09-Dec-21 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter proc [dbo].[CongViec_Insert]
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
/****** Object:  StoredProcedure [dbo].[CongViec_Update]    Script Date: 09-Dec-21 14:20:15 ******/
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
/****** Object:  StoredProcedure [dbo].[DangNhap]    Script Date: 09-Dec-21 14:20:15 ******/
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
/****** Object:  StoredProcedure [dbo].[GetAccountByUserName]    Script Date: 09-Dec-21 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter proc [dbo].[GetAccountByUserName]
	@tenDangNhap nvarchar(255)
as
begin
	select *
	from TaiKhoan
	where TenDangNhap = @tenDangNhap
end
GO
/****** Object:  StoredProcedure [dbo].[GetAll]    Script Date: 09-Dec-21 14:20:15 ******/
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
/****** Object:  StoredProcedure [dbo].[GetJobByAccountName]    Script Date: 09-Dec-21 14:20:15 ******/
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
/****** Object:  StoredProcedure [dbo].[GetJobDetailByJobId]    Script Date: 09-Dec-21 14:20:15 ******/
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
/****** Object:  StoredProcedure [dbo].[GetTypeOfJobByAccountName]    Script Date: 09-Dec-21 14:20:15 ******/
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
/****** Object:  StoredProcedure [dbo].[LoaiCV_Delete]    Script Date: 09-Dec-21 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Thủ tục Delete LoaiCV --
alter procedure [dbo].[LoaiCV_Delete](@ID int)
as
begin
Delete from LoaiCV where ID =@ID
end
GO
/****** Object:  StoredProcedure [dbo].[LoaiCV_Insert]    Script Date: 09-Dec-21 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--------------------------------------------------------------------------------
--------------------------------------------------------------------------------

--- Thủ tục Insert LoaiCV ---
alter Procedure [dbo].[LoaiCV_Insert] (
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
/****** Object:  StoredProcedure [dbo].[LoaiCV_Update]    Script Date: 09-Dec-21 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- Thử nghiệm ---

-- Thủ tục Update LoaiCV --
alter procedure [dbo].[LoaiCV_Update](@ID int output,
@TenLoaiCV nvarchar(1000))
as
begin
Update LoaiCV
set TenLoaiCV = @TenLoaiCV
where ID = @ID
end 
GO
/****** Object:  StoredProcedure [dbo].[TaiKhoan_Delete]    Script Date: 09-Dec-21 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter procedure [dbo].[TaiKhoan_Delete](@TendangNhap nvarchar(255))
as
begin
Delete from TaiKhoan where @TendangNhap = TenDangNhap
end
GO
/****** Object:  StoredProcedure [dbo].[TaiKhoan_Insert]    Script Date: 09-Dec-21 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter Procedure [dbo].[TaiKhoan_Insert] (
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
/****** Object:  StoredProcedure [dbo].[TaiKhoan_Update]    Script Date: 09-Dec-21 14:20:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter procedure [dbo].[TaiKhoan_Update](
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

alter procedure SetJobStatus(@JobId int, @Status int)
as
begin
update CongViec set TrangThai = @Status where ID = @JobId 
end
go

alter procedure SetJobDetailStatus(@JobDetailId int, @Status int)
as
begin
update ChiTietCV set TrangThai = @Status where ID = @JobDetailId
end
go

select * from CongViec
select * from ChiTietCV where ID_CongViec=34