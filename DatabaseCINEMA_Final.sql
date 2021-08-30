--create database QLRP4
--create database QLRP8
go
Use QLRP8
GO

SET DATEFORMAT DMY
GO

--drop database QLRP

CREATE TABLE NhanVien
(
	id VARCHAR(50) PRIMARY KEY,
	HoTen NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL,
	DiaChi NVARCHAR(100),
	SDT VARCHAR(100),
	CMND INT NOT NULL Unique
)
GO

CREATE TABLE TaiKhoan
(
	idTK NVARCHAR(100) PRIMARY KEY,
	UserName NVARCHAR(100) NOT NULL,
	Pass VARCHAR(1000) NOT NULL,
	LoaiTK INT NOT NULL DEFAULT 2, -- 1:admin || 2:staff
	idNV VARCHAR(50) NOT NULL,

	FOREIGN KEY (idNV) REFERENCES dbo.NhanVien(ID)
)
GO

CREATE TABLE LoaiManHinh
(
	id VARCHAR(50) PRIMARY KEY,
	TenMH NVARCHAR(100) --2D || 3D || IMax
)
GO

CREATE TABLE PhongChieu
(
	id VARCHAR(50) PRIMARY KEY,
	TenPhong NVARCHAR(100) NOT NULL,
	idManHinh VARCHAR(50),
	SoChoNgoi INT NOT NULL,
	TinhTrang INT NOT NULL DEFAULT 1, -- 0:không hoạt động || 1:đang hoạt động
	SoHangGhe int not null,
	SoGheMotHang int not null,

	FOREIGN KEY (idManHinh) REFERENCES dbo.LoaiManHinh(id)
)
GO

CREATE TABLE TheLoai
(
	id VARCHAR(50) PRIMARY KEY,
	TenTheLoai NVARCHAR(100) NOT NULL,
	MoTa NVARCHAR(100)
)
GO

CREATE TABLE Phim
(
	id varchar(50) PRIMARY KEY,
	TenPhim nvarchar(100) NOT NULL,
	MoTa nvarchar(1000) NULL,
	ThoiLuong float NOT NULL,
	NgayKhoiChieu date NOT NULL,
	NgayKetThuc date NOT NULL,
	SanXuat nvarchar(50) NOT NULL,
	DaoDien nvarchar(100) NULL,
	NamSX int NOT NULL,
	ApPhich image,
	idTheLoai VARCHAR(50)
	FOREIGN KEY (idTheLoai) REFERENCES dbo.TheLoai(id)
)
GO

CREATE TABLE DinhDangPhim --Phim có hỗ trợ màn hình 3D hay IMax không?
(
	id varchar(50) NOT NULL primary key,
	idPhim VARCHAR(50) NOT NULL,
	idPhongChieu VARCHAR(50) NOT NULL,

	FOREIGN KEY (idPhim) REFERENCES dbo.Phim(id),
	FOREIGN KEY (idPhongChieu) REFERENCES dbo.PhongChieu(id),
)
GO




CREATE TABLE LichChieu
(
	id VARCHAR(50) PRIMARY KEY,
	ThoiGianChieu DATETIME NOT NULL,
	idDinhDang VARCHAR(50) NOT NULL,
	GiaVe INT NULL,
	TrangThai INT NOT NULL DEFAULT '0', --0: Chưa tạo vé cho lịch chiếu || 1: Đã tạo vé

	FOREIGN KEY (idDinhDang) REFERENCES dbo.DinhDangPhim(id),

	--CONSTRAINT PK_LichChieu PRIMARY KEY(ngayChieu,gioChieu,idPhong) --Vì cùng 1 thời điểm có thể có nhiều phòng cùng hoạt động nên khóa chính phải là cả 3 cái
)
GO

CREATE TABLE Ve
(
	id int identity(1,1) PRIMARY KEY,
	idLichChieu VARCHAR(50),
	MaGheNgoi VARCHAR(50),
	TrangThai INT NOT NULL DEFAULT '0', --0: 'Chưa Bán' || 1: 'Đã Bán'
	TienBanVe FLOAT NOT NULL DEFAULT 0, 
	FOREIGN KEY (idLichChieu) REFERENCES dbo.LichChieu(id),
)
GO

--Insert Dữ Liệu
INSERT [dbo].[TheLoai] ([id], [TenTheLoai], [MoTa]) VALUES (N'TL01', N'Hành Động', NULL)
INSERT [dbo].[TheLoai] ([id], [TenTheLoai], [MoTa]) VALUES (N'TL02', N'Hoạt Hình', NULL)
INSERT [dbo].[TheLoai] ([id], [TenTheLoai], [MoTa]) VALUES (N'TL03', N'Hài', NULL)
INSERT [dbo].[TheLoai] ([id], [TenTheLoai], [MoTa]) VALUES (N'TL04', N'Viễn Tưởng', NULL)
INSERT [dbo].[TheLoai] ([id], [TenTheLoai], [MoTa]) VALUES (N'TL05', N'Phiêu lưu', NULL)
INSERT [dbo].[TheLoai] ([id], [TenTheLoai], [MoTa]) VALUES (N'TL06', N'Gia đình', NULL)
INSERT [dbo].[TheLoai] ([id], [TenTheLoai], [MoTa]) VALUES (N'TL07', N'Tình Cảm', NULL)
INSERT [dbo].[TheLoai] ([id], [TenTheLoai], [MoTa]) VALUES (N'TL08', N'Tâm Lý', NULL)

INSERT [dbo].[NhanVien] ([id], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND]) VALUES (N'NV01', N'Hồ Hoàng Thiện', CAST(N'2001-04-12' AS Date), N'Quang Nam', 0334298720, 12345679)
INSERT [dbo].[NhanVien] ([id], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND]) VALUES (N'NV02', N'Đinh Gia Bảo', CAST(N'2001-06-28' AS Date), N'Quang Nam', 0915181914, 14725836)
INSERT [dbo].[NhanVien] ([id], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND]) VALUES (N'NV03', N'Trần Công Việt', CAST(N'2001-07-30' AS Date), N'Quang Nam', 0944753329, 14725834)
INSERT [dbo].[NhanVien] ([id], [HoTen], [NgaySinh], [DiaChi], [SDT], [CMND]) VALUES (N'NV04', N'Phạm Thành Nguyên', CAST(N'2001-06-10' AS Date), N'Quang Nam', 0935169835, 1473546)

INSERT [dbo].[TaiKhoan] ([idTK],[UserName], [Pass], [LoaiTK], [idNV]) VALUES (N'TK01',N'giabao', N'69182287156182195871422361642961127715939811', 1, N'NV02')-- use: giabao mk: 2807
INSERT [dbo].[TaiKhoan] ([idTK],[UserName], [Pass], [LoaiTK], [idNV]) VALUES (N'TK02',N'hoangthien', N'533893221840251173278134251573850274152', 1, N'NV01')-- use: hoangthien mk: 1204
INSERT [dbo].[TaiKhoan] ([idTK],[UserName], [Pass], [LoaiTK], [idNV]) VALUES (N'TK03',N'tranviet', N'15181154318371333413871758412760126541', 1, N'NV03')-- use: tranviet mk: 0710
INSERT [dbo].[TaiKhoan] ([idTK],[UserName], [Pass], [LoaiTK], [idNV]) VALUES (N'TK04',N'thanhnguyen', N'8526170144002881981232691802317221458181186', 1, N'NV04')-- use: nguyen mk: 1309
INSERT [dbo].[TaiKhoan] ([idTK],[UserName], [Pass], [LoaiTK], [idNV]) VALUES (N'TK05',N'banve', N'5880226946129124504917780228912551022921', 2, N'NV01')-- use: banve mk: 1234


INSERT [dbo].[LoaiManHinh] ([id], [TenMH]) VALUES (N'MH01', N'2D')
INSERT [dbo].[LoaiManHinh] ([id], [TenMH]) VALUES (N'MH02', N'3D')
INSERT [dbo].[LoaiManHinh] ([id], [TenMH]) VALUES (N'MH03', N'IMAX')
INSERT [dbo].[LoaiManHinh] ([id], [TenMH]) VALUES (N'MH04', N'4D')
INSERT [dbo].[LoaiManHinh] ([id], [TenMH]) VALUES (N'MH05', N'5D')

INSERT [dbo].[PhongChieu] ([id], [TenPhong], [idManHinh], [SoChoNgoi], [TinhTrang], [SoHangGhe], [SoGheMotHang]) VALUES (N'PC01', N'CINEMA 01', N'MH01', 140, 1, 10, 14)
INSERT [dbo].[PhongChieu] ([id], [TenPhong], [idManHinh], [SoChoNgoi], [TinhTrang], [SoHangGhe], [SoGheMotHang]) VALUES (N'PC02', N'CINEMA 02', N'MH02', 140, 1, 10, 14)
INSERT [dbo].[PhongChieu] ([id], [TenPhong], [idManHinh], [SoChoNgoi], [TinhTrang], [SoHangGhe], [SoGheMotHang]) VALUES (N'PC03', N'CINEMA 03', N'MH03', 140, 1, 10, 14)
INSERT [dbo].[PhongChieu] ([id], [TenPhong], [idManHinh], [SoChoNgoi], [TinhTrang], [SoHangGhe], [SoGheMotHang]) VALUES (N'PC04', N'CINEMA 04', N'MH04', 140, 1, 10, 14)

INSERT [dbo].[Phim] ([id], [TenPhim], [MoTa], [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX],[idTheLoai]) VALUES (N'P01', N'Avengers: Cuộc Chiến Vô Cực', N'Avengers: Infinity War', 150, CAST(N'2021-08-01' AS Date), CAST(N'2021-09-01' AS Date), N'Mỹ', N'Anthony Russo,  Joe Russo', 2018,N'TL04')
INSERT [dbo].[Phim] ([id], [TenPhim], [MoTa], [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX],[idTheLoai]) VALUES (N'P02', N'Lật Mặt: 3 Chàng Khuyết', N'Lat Mat 3 Chang Khuyet', 100, CAST(N'2021-08-01' AS Date), CAST(N'2021-09-01' AS Date), N'Việt Nam', N'Lý Hải', 2018,N'TL01')
INSERT [dbo].[Phim] ([id], [TenPhim], [MoTa], [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX],[idTheLoai]) VALUES (N'P03', N'100 Ngày Bên Em', N'Beside you 100 days', 100, CAST(N'2021-08-01' AS Date), CAST(N'2021-09-01' AS Date), N'Việt Nam', N'Vũ Ngọc Phượng', 2018,N'TL07')
INSERT [dbo].[Phim] ([id], [TenPhim], [MoTa], [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX],[idTheLoai]) VALUES (N'P04', N'Ngỗng Vịt Phiêu Lưu Ký', N'Duck Duck Goose', 91, CAST(N'2021-08-01' AS Date), CAST(N'2021-09-01' AS Date), N'Mỹ', N'Christopher Jenkins', 2018,N'TL02')
INSERT [dbo].[Phim] ([id], [TenPhim], [MoTa], [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX],[idTheLoai]) VALUES (N'P05', N'Xmens', N'Xmens', 91, CAST(N'2021-08-01' AS Date), CAST(N'2021-09-01' AS Date), N'Mỹ', N'Simon Kinberg, Matthew Vaughn', 2012, N'TL04')
INSERT [dbo].[Phim] ([id], [TenPhim], [MoTa], [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX],[idTheLoai]) VALUES (N'P06', N'Doraemon', N'Doraemon Cartoon', 91, CAST(N'2021-08-01' AS Date), CAST(N'2021-09-01' AS Date), N'Nhật Bản', N'Fujiko Fujio', 2012, N'TL02')
INSERT [dbo].[Phim] ([id], [TenPhim], [MoTa], [ThoiLuong], [NgayKhoiChieu], [NgayKetThuc], [SanXuat], [DaoDien], [NamSX],[idTheLoai]) VALUES (N'P07', N'KungFu Panda', N'KungFu Panda', 123, CAST(N'2021-08-01' AS Date), CAST(N'2021-09-01' AS Date), N'Trung Quốc', N'Mark Osborne, John Stevenson', 2012, N'TL02')

INSERT [dbo].[DinhDangPhim] ([id], [idPhim], [idPhongChieu]) VALUES (N'DD01', N'P01', N'PC01')
INSERT [dbo].[DinhDangPhim] ([id], [idPhim], [idPhongChieu]) VALUES (N'DD02', N'P02', N'PC03')
INSERT [dbo].[DinhDangPhim] ([id], [idPhim], [idPhongChieu]) VALUES (N'DD03', N'P03', N'PC01')
INSERT [dbo].[DinhDangPhim] ([id], [idPhim], [idPhongChieu]) VALUES (N'DD04', N'P04', N'PC02')
INSERT [dbo].[DinhDangPhim] ([id], [idPhim], [idPhongChieu]) VALUES (N'DD05', N'P05', N'PC04')
INSERT [dbo].[DinhDangPhim] ([id], [idPhim], [idPhongChieu]) VALUES (N'DD06', N'P06', N'PC01')
INSERT [dbo].[DinhDangPhim] ([id], [idPhim], [idPhongChieu]) VALUES (N'DD07', N'P07', N'PC02')

INSERT [dbo].[LichChieu] ([id], [ThoiGianChieu], [idDinhDang], [GiaVe], [TrangThai]) VALUES (N'LC01', CAST(N'2021-08-20T09:00:00.000' AS DateTime), N'DD01', 70000, 0)
INSERT [dbo].[LichChieu] ([id], [ThoiGianChieu], [idDinhDang], [GiaVe], [TrangThai]) VALUES (N'LC02', CAST(N'2021-08-20T09:00:00.000' AS DateTime), N'DD05', 85000, 0)
INSERT [dbo].[LichChieu] ([id], [ThoiGianChieu], [idDinhDang], [GiaVe], [TrangThai]) VALUES (N'LC03', CAST(N'2021-08-21T09:00:00.000' AS DateTime), N'DD02', 70000, 0)
INSERT [dbo].[LichChieu] ([id], [ThoiGianChieu], [idDinhDang], [GiaVe], [TrangThai]) VALUES (N'LC04', CAST(N'2021-08-21T11:00:00.000' AS DateTime), N'DD03', 85000, 0)
INSERT [dbo].[LichChieu] ([id], [ThoiGianChieu], [idDinhDang], [GiaVe], [TrangThai]) VALUES (N'LC05', CAST(N'2021-08-20T08:10:00.000' AS DateTime), N'DD04', 85000, 0)
INSERT [dbo].[LichChieu] ([id], [ThoiGianChieu], [idDinhDang], [GiaVe], [TrangThai]) VALUES (N'LC06', CAST(N'2021-08-22T09:20:00.000' AS DateTime), N'DD05', 85000, 0)
GO


