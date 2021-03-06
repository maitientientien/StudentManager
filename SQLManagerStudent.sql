USE [QLSINHVIEN]
GO
/****** Object:  Table [dbo].[Diem]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diem](
	[MaSV] [nvarchar](10) NOT NULL,
	[MaMH] [nvarchar](10) NOT NULL,
	[DIemCC] [int] NULL,
	[DiemKT] [float] NULL,
	[DiemThi] [float] NULL,
	[DiemTB] [float] NULL,
	[MaGV] [nvarchar](10) NOT NULL,
	[MaHK] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Diem] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiangVien]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiangVien](
	[MaGV] [nvarchar](10) NOT NULL,
	[TenGV] [nvarchar](50) NULL,
 CONSTRAINT [PK_GiangVien] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocKi]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocKi](
	[MaHK] [nvarchar](10) NOT NULL,
	[TenHK] [nvarchar](50) NULL,
 CONSTRAINT [PK_HocKi] PRIMARY KEY CLUSTERED 
(
	[MaHK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [nvarchar](10) NOT NULL,
	[TenKhoa] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [nvarchar](10) NOT NULL,
	[TenLop] [nvarchar](50) NULL,
	[MaKhoa] [nvarchar](10) NOT NULL,
	[MaGV] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [nvarchar](10) NOT NULL,
	[TenMH] [nvarchar](50) NULL,
	[MaGV] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [nvarchar](10) NOT NULL,
	[HoSV] [nvarchar](30) NOT NULL,
	[TenSV] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[MaLop] [nvarchar](10) NOT NULL,
	[MaKhoa] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_GiangVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiangVien] ([MaGV])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_GiangVien]
GO
ALTER TABLE [dbo].[Diem]  WITH CHECK ADD  CONSTRAINT [FK_Diem_HocKi] FOREIGN KEY([MaHK])
REFERENCES [dbo].[HocKi] ([MaHK])
GO
ALTER TABLE [dbo].[Diem] CHECK CONSTRAINT [FK_Diem_HocKi]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_GiangVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiangVien] ([MaGV])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_GiangVien]
GO
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_MonHoc_GiangVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiangVien] ([MaGV])
GO
ALTER TABLE [dbo].[MonHoc] CHECK CONSTRAINT [FK_MonHoc_GiangVien]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Khoa]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop1] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop1]
GO
/****** Object:  StoredProcedure [dbo].[Delete_MonHoc]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Delete_MonHoc]
@MaMH nvarchar(10)
as
delete from MonHoc
where MaMH=@MaMH
GO
/****** Object:  StoredProcedure [dbo].[DeleteKhoa]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteKhoa]
@MaKhoa nvarchar(10)
as 
delete from Khoa
where MaKhoa=@MaKhoa
GO
/****** Object:  StoredProcedure [dbo].[DeleteLop]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteLop]
@MaLop nvarchar(10)
as
delete from Lop
where MaLop=@MaLop
GO
/****** Object:  StoredProcedure [dbo].[DeleteSV]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteSV]
@MaSV nvarchar(10)
as
delete from SinhVien
where MaSV=@MaSV
GO
/****** Object:  StoredProcedure [dbo].[dssinhvientheokhoa]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[dssinhvientheokhoa]
@maKhoa nvarchar(10)
as
begin
select ROW_NUMBER() over (order by MaSV) as STT, MaSV as [Mã Sinh Viên], TenSV as [Tên sinh viên],NgaySinh as [Ngày sinh], MaLop as [Mã lớp],MaKhoa as [Mã khoa] from SinhVien where MaKhoa = @maKhoa
end
GO
/****** Object:  StoredProcedure [dbo].[dssinhvientheolop]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[dssinhvientheolop]
@MaLop nvarchar(10)
as
begin
select ROW_NUMBER() over (order by MaSV) as STT, MaSV as [Mã Sinh Viên], TenSV as [Tên sinh viên],DiaChi as [Địa Chỉ], MaLop as [lớp],MaKhoa as [khoa] from SinhVien where MaLop = @MaLop
end
GO
/****** Object:  StoredProcedure [dbo].[GetData_Diem]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetData_Diem]
as
select * from Diem
GO
/****** Object:  StoredProcedure [dbo].[GetData_MonHoc]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetData_MonHoc]
as
select* from MonHoc
GO
/****** Object:  StoredProcedure [dbo].[GetData_SinhVien]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetData_SinhVien]
as
select* from SinhVien
GO
/****** Object:  StoredProcedure [dbo].[GetDataGiangVien]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetDataGiangVien]
as
select * from GiangVien
GO
/****** Object:  StoredProcedure [dbo].[GetDataHocKi]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetDataHocKi]
as
select * from HocKi
GO
/****** Object:  StoredProcedure [dbo].[GetDataKhoa]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetDataKhoa]
as
select * from khoa
GO
/****** Object:  StoredProcedure [dbo].[GetDataLop]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetDataLop]
as
select * from Lop
GO
/****** Object:  StoredProcedure [dbo].[Insert_Diem]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insert_Diem]
@MaSV nvarchar(10),
@MaMH nvarchar(10),
@DiemCC int,
@DiemKT float,
@DiemThi float,
@DiemTB float,
@MaGV nvarchar(10),
@MaHK nvarchar(10)
as
insert into Diem(MaSV,MaMH,DiemCC,DiemKT,DiemThi,DiemTB,MaGV,MaHK)
values (@MaSV,@MaMH,@DiemCC,@DiemKT,@DiemThi,@DiemTB,@MaGV,@MaHK)
GO
/****** Object:  StoredProcedure [dbo].[Insert_Khoa]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insert_Khoa]
@MaKhoa nvarchar(10),
@TenKhoa nvarchar(50)
as 
insert into Khoa (MaKhoa,TenKhoa)
values (@MaKhoa,@TenKhoa)
GO
/****** Object:  StoredProcedure [dbo].[Insert_Lop]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insert_Lop]
@MaLop nvarchar(10),
@TenLop nvarchar(50),
@MaKhoa nvarchar(10),
@MaGV nvarchar(10)
as 
insert into Lop (MaLop,TenLop,MaKhoa,MaGV)
values (@MaLop,@TenLop,@MaKhoa,@MaGV)
GO
/****** Object:  StoredProcedure [dbo].[Insert_MonHoc]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insert_MonHoc]
@MaMH nvarchar(10),
@TenMH nvarchar(50),
@MaGV nvarchar(10)
as
insert into MonHoc(MaMH,TenMH,MaGV)
values (@MaMH,@TenMH,@MaGV)
GO
/****** Object:  StoredProcedure [dbo].[Insert_SinhVien]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insert_SinhVien]
@MaSV nvarchar(10),
@HoSV nvarchar(50),
@TenSV nvarchar(50),
@NgaySinh date ,
@DiaChi nvarchar(50),
@MaLop nvarchar(10),
@MaKhoa nvarchar(10)
as 
insert into SinhVien (MaSV,HoSV,TenSV,NgaySinh,DiaChi,MaLop,MaKhoa)
values (@MaSV,@HoSV,@TenSV,@NgaySinh,@DiaChi,@MaLop,@MaKhoa)
GO
/****** Object:  StoredProcedure [dbo].[Update_Diem]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Update_Diem]
@MaSV nvarchar(10),
@MaMH nvarchar(10),
@DiemCC int,
@DiemKT float,
@DiemThi float,
@DiemTB float,
@MaGV nvarchar(10),
@MaHK nvarchar(10)
as 
update Diem
set MaMH=@MaMH,
DiemCC=@DiemCC,
DiemKT=@DiemKT,
DiemThi=@DiemThi,
DiemTB=@DiemTB,
MaGV=@MaGV,
MaHK=@MaHK
where MaSV=@MaSV
GO
/****** Object:  StoredProcedure [dbo].[Update_MonHoc]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Update_MonHoc]
@MaMH nvarchar(10),
@TenMH nvarchar(50),
@MaGV nvarchar(10)
as
update MonHoc
set 
TenMH=@TenMH,
MaGV=@MaGV
where MaMH=@MaMH
GO
/****** Object:  StoredProcedure [dbo].[UpdateKhoa]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateKhoa]
@MaKhoa nvarchar(10),
@TenKhoa nvarchar(50)
as 
update Khoa
set TenKhoa=@TenKhoa

where MaKhoa= @MaKhoa
GO
/****** Object:  StoredProcedure [dbo].[UpdateLop]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateLop]
@MaLop nvarchar(10),
@TenLop nvarchar(50),
@MaKhoa nvarchar(10),
@MaGV nvarchar(10)
as 
update Lop
set TenLop=@TenLop,
MaKhoa=@MaKhoa,
MaGV=@MaGV

where MaLop=@MaLop
GO
/****** Object:  StoredProcedure [dbo].[UpdateSV]    Script Date: 11/24/2021 12:04:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateSV]
@MaSV nvarchar(10),
@HoSV nvarchar(30),
@TenSV nvarchar(50),
@NgaySinh date,
@DiaChi nvarchar(50),
@MaLop nvarchar(10),
@MaKhoa nvarchar(10)
as
Update SinhVien
set TenSV=@TenSV,
HoSV=@HoSV,
NgaySinh=@NgaySinh,
DiaChi=@DiaChi,
MaLop=@MaLop,
MaKhoa=@MaKhoa
where MaSV=@MaSV
GO
