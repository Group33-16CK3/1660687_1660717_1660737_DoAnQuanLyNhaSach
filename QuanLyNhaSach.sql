USE [QuanLyNhaSach]
GO
/****** Object:  Table [dbo].[BAOCAOCONGNO]    Script Date: 1/6/2019 11:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAOCONGNO](
	[MaBaoCao] [nchar](10) NOT NULL,
	[MaKhachHang] [nchar](10) NULL,
	[NgayPhatSinh] [date] NULL,
	[NoDau] [int] NULL,
	[PhatSinh] [nvarchar](50) NULL,
	[NoCuoi] [int] NULL,
 CONSTRAINT [PK_BAOCAOCONGNO] PRIMARY KEY CLUSTERED 
(
	[MaBaoCao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BAOCAOTON]    Script Date: 1/6/2019 11:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAOTON](
	[MaBaoCao] [nchar](10) NULL,
	[MaSach] [nchar](10) NULL,
	[NgayPhatSinh] [date] NULL,
	[TonDau] [int] NULL,
	[PhatSinh] [nvarchar](50) NULL,
	[TonCuoi] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 1/6/2019 11:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[MaHoaDon] [nchar](10) NULL,
	[MaSach] [nchar](10) NULL,
	[SoLuongMua] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEU]    Script Date: 1/6/2019 11:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEU](
	[MaPhieuNhap] [nchar](10) NULL,
	[MaSach] [nchar](10) NULL,
	[SoLuongNhap] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 1/6/2019 11:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHoaDon] [nchar](10) NOT NULL,
	[NgayLapHoaDon] [date] NULL,
	[MaKhachHang] [nchar](10) NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 1/6/2019 11:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKhachHang] [nchar](10) NOT NULL,
	[HoTenKhachHang] [nvarchar](50) NULL,
	[DienThoai] [varchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[TienNo] [int] NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 1/6/2019 11:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[MaNguoiDung] [nchar](10) NOT NULL,
	[Username] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[PhanQuyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 1/6/2019 11:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPhieuNhap] [nchar](10) NOT NULL,
	[NgayNhap] [date] NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUTHU]    Script Date: 1/6/2019 11:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHU](
	[MaPhieuThu] [nchar](10) NOT NULL,
	[NgayThu] [date] NULL,
	[SoTienThu] [int] NULL,
	[MaKhachHang] [nchar](10) NULL,
 CONSTRAINT [PK_PHIEUTHU] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SACH]    Script Date: 1/6/2019 11:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SACH](
	[MaSach] [nchar](10) NOT NULL,
	[TenSach] [nvarchar](50) NULL,
	[GiaBan] [int] NULL,
	[SoLuongTon] [int] NULL,
	[TacGia] [nvarchar](50) NULL,
	[MaTheLoai] [nchar](10) NULL,
 CONSTRAINT [PK_SACH] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 1/6/2019 11:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[MaThamSo] [nchar](10) NOT NULL,
	[SoLuongNhapItNhat] [int] NULL,
	[LuongTonItNhat] [int] NULL,
	[NoKhongQua] [int] NULL,
	[LuongTonSauKhiBan] [int] NULL,
	[DieuKienThu] [int] NULL,
 CONSTRAINT [PK_THAMSO] PRIMARY KEY CLUSTERED 
(
	[MaThamSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[THELOAI]    Script Date: 1/6/2019 11:14:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THELOAI](
	[MaTheLoai] [nchar](10) NOT NULL,
	[TenTheLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_THELOAI] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[BAOCAOCONGNO] ([MaBaoCao], [MaKhachHang], [NgayPhatSinh], [NoDau], [PhatSinh], [NoCuoi]) VALUES (N'1         ', N'1         ', CAST(0x183F0B00 AS Date), 0, N'Hóa đơn bán sách', 120000)
INSERT [dbo].[BAOCAOTON] ([MaBaoCao], [MaSach], [NgayPhatSinh], [TonDau], [PhatSinh], [TonCuoi]) VALUES (N'1         ', N'1         ', CAST(0x083F0B00 AS Date), 290, N'Phiếu Nhập Sách', 490)
INSERT [dbo].[BAOCAOTON] ([MaBaoCao], [MaSach], [NgayPhatSinh], [TonDau], [PhatSinh], [TonCuoi]) VALUES (N'2         ', N'3         ', CAST(0x103E0B00 AS Date), 290, N'Phieu Nhap Sach', 490)
INSERT [dbo].[CHITIETHOADON] ([MaHoaDon], [MaSach], [SoLuongMua]) VALUES (N'1         ', N'1         ', 20)
INSERT [dbo].[CHITIETHOADON] ([MaHoaDon], [MaSach], [SoLuongMua]) VALUES (N'2         ', N'3         ', 40)
INSERT [dbo].[CHITIETPHIEU] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'1         ', N'1         ', 100)
INSERT [dbo].[CHITIETPHIEU] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'1         ', N'2         ', 400)
INSERT [dbo].[CHITIETPHIEU] ([MaPhieuNhap], [MaSach], [SoLuongNhap]) VALUES (N'2         ', N'3         ', 300)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (N'1         ', CAST(0x043F0B00 AS Date), N'1         ')
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLapHoaDon], [MaKhachHang]) VALUES (N'2         ', CAST(0x103E0B00 AS Date), N'3         ')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DienThoai], [DiaChi], [Email], [TienNo]) VALUES (N'1         ', N'Trầm Lê Anh Tuân', N'0393599967', N'135B Trần Hưng Đạo', N'tramleanhtuan1111@gmail.com', 50000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DienThoai], [DiaChi], [Email], [TienNo]) VALUES (N'2         ', N'a', N'a', N'a', N'a', 50000)
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [HoTenKhachHang], [DienThoai], [DiaChi], [Email], [TienNo]) VALUES (N'3         ', N'Bui Khanh Viet', N'3475874358', N'a', N'a', 60000)
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [Username], [Password], [PhanQuyen]) VALUES (N'1         ', N'tlatuan', N'123456', N'admin')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap]) VALUES (N'1         ', CAST(0xE63E0B00 AS Date))
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap]) VALUES (N'2         ', CAST(0xF13D0B00 AS Date))
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap]) VALUES (N'3         ', CAST(0x103E0B00 AS Date))
INSERT [dbo].[PHIEUTHU] ([MaPhieuThu], [NgayThu], [SoTienThu], [MaKhachHang]) VALUES (N'1         ', CAST(0x043F0B00 AS Date), 50000, N'1         ')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [GiaBan], [SoLuongTon], [TacGia], [MaTheLoai]) VALUES (N'1         ', N'A', 50000, 20, N'Nguyễn Văn A', N'1         ')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [GiaBan], [SoLuongTon], [TacGia], [MaTheLoai]) VALUES (N'2         ', N'B', 50000, 20, N'Nguyen Van C', N'2         ')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [GiaBan], [SoLuongTon], [TacGia], [MaTheLoai]) VALUES (N'3         ', N'C', 50000, 20, N'Nguyen Van D', N'3         ')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [GiaBan], [SoLuongTon], [TacGia], [MaTheLoai]) VALUES (N'4         ', N'D', 50000, 200, N'Tram Le Anh Tuan', N'1         ')
INSERT [dbo].[SACH] ([MaSach], [TenSach], [GiaBan], [SoLuongTon], [TacGia], [MaTheLoai]) VALUES (N'5         ', N'G', 59000, 30, N'Bui Khanh Viet', N'2         ')
INSERT [dbo].[THAMSO] ([MaThamSo], [SoLuongNhapItNhat], [LuongTonItNhat], [NoKhongQua], [LuongTonSauKhiBan], [DieuKienThu]) VALUES (N'1         ', 150, 300, 20000, 20, 1)
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (N'1         ', N'Truyện')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (N'2         ', N'Tiểu Thuyết')
INSERT [dbo].[THELOAI] ([MaTheLoai], [TenTheLoai]) VALUES (N'3         ', N'Trinh Thám ')
