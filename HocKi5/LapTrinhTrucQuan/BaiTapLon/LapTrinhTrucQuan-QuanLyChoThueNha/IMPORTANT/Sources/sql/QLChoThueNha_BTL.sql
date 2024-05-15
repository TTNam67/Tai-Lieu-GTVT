﻿USE QLChoThueNha_BTL
GO
CREATE DATABASE [QLChoThueNha_BTL]
GO

ALTER DATABASE [QLChoThueNha_BTL] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLChoThueNha_BTL].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLChoThueNha_BTL] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET  MULTI_USER 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLChoThueNha_BTL] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLChoThueNha_BTL] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLChoThueNha_BTL] SET QUERY_STORE = OFF
GO
USE [QLChoThueNha_BTL]
GO
/****** Object:  Table [dbo].[CoQuan]    Script Date: 11/18/2023 2:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoQuan](
	[MaCQ] [nvarchar](10) NOT NULL,
	[TenCQ] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMucNha]    Script Date: 11/18/2023 2:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucNha](
	[MaNha] [nvarchar](10) NOT NULL,
	[TenChuNha] [nvarchar](50) NOT NULL,
	[DienThoai] [nvarchar](10) NOT NULL,
	[MaLoai] [nvarchar](10) NULL,
	[MaDTSD] [nvarchar](10) NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[DonGiaThue] [money] NOT NULL,
	[TinhTrang] [nvarchar](10) NULL,
	[DaThue] [int] NOT NULL,
	[GhiChu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoiTuongSudung]    Script Date: 11/18/2023 2:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoiTuongSudung](
	[MaDTSD] [nvarchar](10) NOT NULL,
	[TenDTSD] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDTSD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HinhThucThanhToan]    Script Date: 11/18/2023 2:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HinhThucThanhToan](
	[MaHinhThucTT] [nvarchar](10) NOT NULL,
	[TenHinhThucTT] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHinhThucTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachThue]    Script Date: 11/18/2023 2:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachThue](
	[MaKhach] [nvarchar](10) NOT NULL,
	[TenKhach] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [int] NOT NULL,
	[SoCMND] [varchar](20) NOT NULL,
	[DiaChiThuongTru] [nvarchar](100) NOT NULL,
	[MaNghe] [nvarchar](10) NULL,
	[MaCQ] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiNha]    Script Date: 11/18/2023 2:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNha](
	[MaLoai] [nvarchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MucDichSuDung]    Script Date: 11/18/2023 2:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MucDichSuDung](
	[MaMucDichSD] [nvarchar](10) NOT NULL,
	[TenMucDichSD] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMucDichSD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NgheNghiep]    Script Date: 11/18/2023 2:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NgheNghiep](
	[MaNghe] [nvarchar](10) NOT NULL,
	[TenNghe] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNghe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nha_TaiSan]    Script Date: 11/18/2023 2:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nha_TaiSan](
	[MaNha] [nvarchar](10) NOT NULL,
	[MaTaiSan] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[GiaTri] [money] NULL,
	[TinhTrang] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNha] ASC,
	[MaTaiSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/18/2023 2:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Username] [nvarchar](30) NOT NULL,
	[_Password] [nvarchar](30) NOT NULL,
	[DisplayName] [nvarchar](50) NOT NULL,
	[PhanQuyen] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiSan]    Script Date: 11/18/2023 2:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiSan](
	[MaTaiSan] [nvarchar](10) NOT NULL,
	[TenTaiSan] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTaiSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThueNha]    Script Date: 11/18/2023 2:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThueNha](
	[MaSoThue] [nvarchar](10) NOT NULL,
	[MaKhach] [nvarchar](10) NULL,
	[MaNha] [nvarchar](10) NULL,
	[MaMucDichSD] [nvarchar](10) NULL,
	[NgayBD] [datetime] NULL,
	[NgayKT] [datetime] NULL,
	[TienDatCoc] [money] NULL,
	[MaHinhThucTT] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSoThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThuTienNha]    Script Date: 11/18/2023 2:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuTienNha](
	[MaSoThu] [nvarchar](10) NOT NULL,
	[MaSoThue] [nvarchar](10) NULL,
	[Thang] [nvarchar](20) NULL,
	[Nam] [nvarchar](20) NULL,
	[TongTien] [money] NULL,
	[NguoiThu] [nvarchar](20) NULL,
	[NgayThu] [datetime] NULL,
	[GhiChu] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSoThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraNha]    Script Date: 11/18/2023 2:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraNha](
	[MaSoThue] [nvarchar](10) NOT NULL,
	[NgayTra] [datetime] NULL,
	[TongTien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSoThue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraNha_MatTaiSan]    Script Date: 11/18/2023 2:19:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraNha_MatTaiSan](
	[MaSoThue] [nvarchar](10) NOT NULL,
	[MaTaiSan] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[GiaTri] [money] NULL,
	[ThanhTien] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSoThue] ASC,
	[MaTaiSan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CoQuan] ([MaCQ], [TenCQ]) VALUES (N'CQ001', N'Trường Đại học Giao Thông Vận Tải')
INSERT [dbo].[CoQuan] ([MaCQ], [TenCQ]) VALUES (N'CQ002', N'Công ty Under The Hood')
INSERT [dbo].[CoQuan] ([MaCQ], [TenCQ]) VALUES (N'CQ003', N'Trường Đại học Sư phạm Hà Nội')
INSERT [dbo].[CoQuan] ([MaCQ], [TenCQ]) VALUES (N'CQ004', N'Trường Đại học Ngoại Thương')
INSERT [dbo].[CoQuan] ([MaCQ], [TenCQ]) VALUES (N'CQ005', N'Văn phòng Piltover')
INSERT [dbo].[CoQuan] ([MaCQ], [TenCQ]) VALUES (N'CQ006', N'Tập đoàn Renata Glasc')
INSERT [dbo].[CoQuan] ([MaCQ], [TenCQ]) VALUES (N'CQ007', N'Công ty FE Credit')
INSERT [dbo].[CoQuan] ([MaCQ], [TenCQ]) VALUES (N'CQ008', N'Trường Đại học Thủ Đô')
GO
INSERT [dbo].[DanhMucNha] ([MaNha], [TenChuNha], [DienThoai], [MaLoai], [MaDTSD], [DiaChi], [DonGiaThue], [TinhTrang], [DaThue], [GhiChu]) VALUES (N'MN001', N'Nguyễn Văn Nam', N'0956148236', N'ML003', N'DTSD001', N'11/100 Trung Kính, Cầu Giấy, Hà Nội', 3500000.0000, N'Cũ', 0, N'Đã được tu sửa, bảo trì')
INSERT [dbo].[DanhMucNha] ([MaNha], [TenChuNha], [DienThoai], [MaLoai], [MaDTSD], [DiaChi], [DonGiaThue], [TinhTrang], [DaThue], [GhiChu]) VALUES (N'MN002', N'Ngô Thị Thuý Hằng', N'0359621478', N'ML001', N'DTSD004', N'90/1194 Đường Láng, Láng Thượng, Đống Đa, Hà Nội', 75000000.0000, N'Mới', 0, NULL)
INSERT [dbo].[DanhMucNha] ([MaNha], [TenChuNha], [DienThoai], [MaLoai], [MaDTSD], [DiaChi], [DonGiaThue], [TinhTrang], [DaThue], [GhiChu]) VALUES (N'MN003', N'Mai Văn Giang', N'0372030046', N'ML003', N'DTSD001', N'36 Dịch Vọng Hậu, P. Dịch Vọng Hậu, Quận Cầu Giấy, Hà Nội', 4000000.0000, N'Cũ', 1, N'Đã được tu sửa, bảo trì')
INSERT [dbo].[DanhMucNha] ([MaNha], [TenChuNha], [DienThoai], [MaLoai], [MaDTSD], [DiaChi], [DonGiaThue], [TinhTrang], [DaThue], [GhiChu]) VALUES (N'MN004', N'Nguyễn Văn Nam', N'0956148236', N'ML002', N'DTSD003', N'2 Trung Hoà, P. Trung Hoà, Quận Cầu Giấy, Hà Nội', 20000000.0000, N'Mới', 0, NULL)
INSERT [dbo].[DanhMucNha] ([MaNha], [TenChuNha], [DienThoai], [MaLoai], [MaDTSD], [DiaChi], [DonGiaThue], [TinhTrang], [DaThue], [GhiChu]) VALUES (N'MN005', N'Nguyễn Thanh Toàn', N'0564782134', N'ML002', N'DTSD003', N'71 P. Đặng Văn Ngữ, Trung Tự, Đống Đa, Hà Nội', 25000000.0000, N'Mới', 1, NULL)
INSERT [dbo].[DanhMucNha] ([MaNha], [TenChuNha], [DienThoai], [MaLoai], [MaDTSD], [DiaChi], [DonGiaThue], [TinhTrang], [DaThue], [GhiChu]) VALUES (N'MN006', N'Đặng Thu Hoài', N'0256781504', N'ML003', N'DTSD002', N'Số 1C3 Phố, P. Hoàng Ngọc Phách, Láng Hạ, Đống Đa, Hà Nội, Việt Nam', 4300000.0000, N'Mới', 0, NULL)
INSERT [dbo].[DanhMucNha] ([MaNha], [TenChuNha], [DienThoai], [MaLoai], [MaDTSD], [DiaChi], [DonGiaThue], [TinhTrang], [DaThue], [GhiChu]) VALUES (N'MN007', N'Lê Đức Anh', N'0359686979', N'ML001', N'DTSD004', N'8 Ng. 67 P. Thái Thịnh, Thịnh Quang, Đống Đa, Hà Nội, Việt Nam', 60000000.0000, N'Cũ', 0, N'Đã được tu sửa, bảo trì')
GO
INSERT [dbo].[DoiTuongSudung] ([MaDTSD], [TenDTSD]) VALUES (N'DTSD001', N'Sinh viên')
INSERT [dbo].[DoiTuongSudung] ([MaDTSD], [TenDTSD]) VALUES (N'DTSD002', N'Người đi làm')
INSERT [dbo].[DoiTuongSudung] ([MaDTSD], [TenDTSD]) VALUES (N'DTSD003', N'Hộ gia đình')
INSERT [dbo].[DoiTuongSudung] ([MaDTSD], [TenDTSD]) VALUES (N'DTSD004', N'Văn phòng')
GO
INSERT [dbo].[HinhThucThanhToan] ([MaHinhThucTT], [TenHinhThucTT]) VALUES (N'HTTT001', N'1 năm')
INSERT [dbo].[HinhThucThanhToan] ([MaHinhThucTT], [TenHinhThucTT]) VALUES (N'HTTT002', N'1 tháng')
INSERT [dbo].[HinhThucThanhToan] ([MaHinhThucTT], [TenHinhThucTT]) VALUES (N'HTTT003', N'3 tháng')
GO
INSERT [dbo].[KhachThue] ([MaKhach], [TenKhach], [NgaySinh], [GioiTinh], [SoCMND], [DiaChiThuongTru], [MaNghe], [MaCQ]) VALUES (N'KH001', N'Hà Vĩnh Linh', CAST(N'2003-11-28' AS Date), 1, N'037203004851', N'Tam Điệp, Ninh Bình', N'NN001', N'CQ003')
INSERT [dbo].[KhachThue] ([MaKhach], [TenKhach], [NgaySinh], [GioiTinh], [SoCMND], [DiaChiThuongTru], [MaNghe], [MaCQ]) VALUES (N'KH002', N'Trần Thu Hiền', CAST(N'1993-10-05' AS Date), 0, N'075614862356', N'Thường Tín, Hà Nội', N'NN004', NULL)
INSERT [dbo].[KhachThue] ([MaKhach], [TenKhach], [NgaySinh], [GioiTinh], [SoCMND], [DiaChiThuongTru], [MaNghe], [MaCQ]) VALUES (N'KH003', N'Nguyễn Hoàng Long', CAST(N'1972-02-01' AS Date), 1, N'076859412345', N'Từ Sơn, Bắc Ninh', N'NN003', N'CQ002')
INSERT [dbo].[KhachThue] ([MaKhach], [TenKhach], [NgaySinh], [GioiTinh], [SoCMND], [DiaChiThuongTru], [MaNghe], [MaCQ]) VALUES (N'KH004', N'Đinh Ngọc Nam', CAST(N'2004-07-24' AS Date), 1, N'023468719853', N'Lục Ngạn, Bắc Giang', N'NN001', N'CQ008')
INSERT [dbo].[KhachThue] ([MaKhach], [TenKhach], [NgaySinh], [GioiTinh], [SoCMND], [DiaChiThuongTru], [MaNghe], [MaCQ]) VALUES (N'KH005', N'Nguyễn Thanh Tâm', CAST(N'1990-01-18' AS Date), 0, N'045612387952', N'Thanh Sơn, Phú Thọ', N'NN003', N'CQ007')
INSERT [dbo].[KhachThue] ([MaKhach], [TenKhach], [NgaySinh], [GioiTinh], [SoCMND], [DiaChiThuongTru], [MaNghe], [MaCQ]) VALUES (N'KH006', N'Mai Thị Hoàn', CAST(N'2004-12-28' AS Date), 0, N'085123454976', N'Ba Vì, Hà Nội', N'NN001', N'CQ004')
INSERT [dbo].[KhachThue] ([MaKhach], [TenKhach], [NgaySinh], [GioiTinh], [SoCMND], [DiaChiThuongTru], [MaNghe], [MaCQ]) VALUES (N'KH007', N'Nguyễn Đức Trung', CAST(N'2002-07-07' AS Date), 1, N'061348951367', N'Gia Lộc, Hải Dương', N'NN001', N'CQ001')
INSERT [dbo].[KhachThue] ([MaKhach], [TenKhach], [NgaySinh], [GioiTinh], [SoCMND], [DiaChiThuongTru], [MaNghe], [MaCQ]) VALUES (N'KH008', N'Lương Hoàng Duy', CAST(N'1995-04-26' AS Date), 1, N'073415926482', N'Xuân Trường, Nam Định', N'NN003', N'CQ005')
INSERT [dbo].[KhachThue] ([MaKhach], [TenKhach], [NgaySinh], [GioiTinh], [SoCMND], [DiaChiThuongTru], [MaNghe], [MaCQ]) VALUES (N'KH009', N'Lê Quỳnh Trang', CAST(N'1991-10-01' AS Date), 0, N'093245162358', N'Duy Tiên, Hà Nam', N'NN004', NULL)
INSERT [dbo].[KhachThue] ([MaKhach], [TenKhach], [NgaySinh], [GioiTinh], [SoCMND], [DiaChiThuongTru], [MaNghe], [MaCQ]) VALUES (N'KH010', N'Phan Thị Minh', CAST(N'1999-10-01' AS Date), 0, N'057821463154', N'Tiên Lãng, Hải Phòng', N'NN003', N'CQ006')
GO
INSERT [dbo].[LoaiNha] ([MaLoai], [TenLoai]) VALUES (N'ML001', N'Nhà phố nguyên căn')
INSERT [dbo].[LoaiNha] ([MaLoai], [TenLoai]) VALUES (N'ML002', N'Nhà 3 tầng')
INSERT [dbo].[LoaiNha] ([MaLoai], [TenLoai]) VALUES (N'ML003', N'Nhà cấp 4')
GO
INSERT [dbo].[MucDichSuDung] ([MaMucDichSD], [TenMucDichSD]) VALUES (N'MDSD001', N'Nhà ở')
INSERT [dbo].[MucDichSuDung] ([MaMucDichSD], [TenMucDichSD]) VALUES (N'MDSD002', N'Văn phòng')
INSERT [dbo].[MucDichSuDung] ([MaMucDichSD], [TenMucDichSD]) VALUES (N'MDSD003', N'Cửa hàng')
GO
INSERT [dbo].[NgheNghiep] ([MaNghe], [TenNghe]) VALUES (N'NN001', N'Sinh viên')
INSERT [dbo].[NgheNghiep] ([MaNghe], [TenNghe]) VALUES (N'NN002', N'Giáo viên')
INSERT [dbo].[NgheNghiep] ([MaNghe], [TenNghe]) VALUES (N'NN003', N'Nhân viên văn phòng')
INSERT [dbo].[NgheNghiep] ([MaNghe], [TenNghe]) VALUES (N'NN004', N'Kinh doanh')
GO
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN001', N'TS001', 1, 2000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN001', N'TS003', 1, 750000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN001', N'TS004', 1, 8500000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN001', N'TS005', 1, 3000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN002', N'TS002', 2, 20000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN002', N'TS004', 5, 50000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN002', N'TS006', 2, 15000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN002', N'TS009', 3, 4500000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN003', N'TS001', 1, 1200000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN003', N'TS003', 1, 800000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN003', N'TS005', 1, 3000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN003', N'TS006', 1, 4000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN003', N'TS009', 1, 7500000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN004', N'TS001', 2, 3000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN004', N'TS003', 2, 1500000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN004', N'TS004', 2, 20000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN004', N'TS005', 2, 8000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN004', N'TS006', 1, 7500000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN004', N'TS008', 1, 2500000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN004', N'TS009', 2, 2000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN004', N'TS010', 1, 6000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN005', N'TS001', 2, 2500000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN005', N'TS002', 1, 7500000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN005', N'TS003', 2, 2000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN005', N'TS004', 2, 15000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN005', N'TS005', 2, 6500000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN005', N'TS006', 1, 4000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN005', N'TS007', 1, 5000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN005', N'TS010', 1, 5000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN006', N'TS001', 1, 1800000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN006', N'TS004', 1, 7500000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN006', N'TS005', 1, 3000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN006', N'TS006', 1, 5000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN007', N'TS002', 1, 7500000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN007', N'TS003', 2, 1500000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN007', N'TS004', 3, 20000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN007', N'TS005', 2, 8000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN007', N'TS006', 1, 7500000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN007', N'TS009', 2, 2000000.0000, NULL)
INSERT [dbo].[Nha_TaiSan] ([MaNha], [MaTaiSan], [SoLuong], [GiaTri], [TinhTrang]) VALUES (N'MN007', N'TS010', 1, 6000000.0000, NULL)
GO
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan]) VALUES (N'TS001', N'Giường')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan]) VALUES (N'TS002', N'Bàn ghế')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan]) VALUES (N'TS003', N'Tủ quần áo')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan]) VALUES (N'TS004', N'Điều hoà')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan]) VALUES (N'TS005', N'Nóng lạnh')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan]) VALUES (N'TS006', N'Tủ lạnh')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan]) VALUES (N'TS007', N'Máy giặt')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan]) VALUES (N'TS008', N'Hút mùi')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan]) VALUES (N'TS009', N'Tủ giày')
INSERT [dbo].[TaiSan] ([MaTaiSan], [TenTaiSan]) VALUES (N'TS010', N'Ti vi')
GO
INSERT [dbo].[ThueNha] ([MaSoThue], [MaKhach], [MaNha], [MaMucDichSD], [NgayBD], [NgayKT], [TienDatCoc], [MaHinhThucTT]) VALUES (N'MT001', N'KH008', N'MN002', N'MDSD002', CAST(N'2021-10-12T00:00:00.000' AS DateTime), CAST(N'2022-10-12T00:00:00.000' AS DateTime), 75000000.0000, N'HTTT002')
INSERT [dbo].[ThueNha] ([MaSoThue], [MaKhach], [MaNha], [MaMucDichSD], [NgayBD], [NgayKT], [TienDatCoc], [MaHinhThucTT]) VALUES (N'MT002', N'KH003', N'MN005', N'MDSD001', CAST(N'2023-06-25T00:00:00.000' AS DateTime), CAST(N'2023-12-25T00:00:00.000' AS DateTime), 25000000.0000, N'HTTT002')
INSERT [dbo].[ThueNha] ([MaSoThue], [MaKhach], [MaNha], [MaMucDichSD], [NgayBD], [NgayKT], [TienDatCoc], [MaHinhThucTT]) VALUES (N'MT003', N'KH001', N'MN001', N'MDSD001', CAST(N'2023-05-05T00:00:00.000' AS DateTime), CAST(N'2024-05-05T00:00:00.000' AS DateTime), 3500000.0000, N'HTTT001')
INSERT [dbo].[ThueNha] ([MaSoThue], [MaKhach], [MaNha], [MaMucDichSD], [NgayBD], [NgayKT], [TienDatCoc], [MaHinhThucTT]) VALUES (N'MT004', N'KH010', N'MN004', N'MDSD001', CAST(N'2022-08-15T00:00:00.000' AS DateTime), CAST(N'2023-02-15T00:00:00.000' AS DateTime), 20000000.0000, N'HTTT002')
INSERT [dbo].[ThueNha] ([MaSoThue], [MaKhach], [MaNha], [MaMucDichSD], [NgayBD], [NgayKT], [TienDatCoc], [MaHinhThucTT]) VALUES (N'MT005', N'KH009', N'MN007', N'MDSD003', CAST(N'2023-10-01T00:00:00.000' AS DateTime), CAST(N'2024-10-01T00:00:00.000' AS DateTime), 60000000.0000, N'HTTT003')
INSERT [dbo].[ThueNha] ([MaSoThue], [MaKhach], [MaNha], [MaMucDichSD], [NgayBD], [NgayKT], [TienDatCoc], [MaHinhThucTT]) VALUES (N'MT006', N'KH004', N'MN003', N'MDSD001', CAST(N'2023-08-07T00:00:00.000' AS DateTime), CAST(N'2024-08-07T00:00:00.000' AS DateTime), 4000000.0000, N'HTTT001')
INSERT [dbo].[ThueNha] ([MaSoThue], [MaKhach], [MaNha], [MaMucDichSD], [NgayBD], [NgayKT], [TienDatCoc], [MaHinhThucTT]) VALUES (N'MT007', N'KH005', N'MN005', N'MDSD001', CAST(N'2021-06-10T00:00:00.000' AS DateTime), CAST(N'2021-12-10T00:00:00.000' AS DateTime), 25000000.0000, N'HTTT002')
INSERT [dbo].[ThueNha] ([MaSoThue], [MaKhach], [MaNha], [MaMucDichSD], [NgayBD], [NgayKT], [TienDatCoc], [MaHinhThucTT]) VALUES (N'MT008', N'KH007', N'MN006', N'MDSD001', CAST(N'2023-09-25T00:00:00.000' AS DateTime), CAST(N'2024-03-25T00:00:00.000' AS DateTime), 4300000.0000, N'HTTT002')
INSERT [dbo].[ThueNha] ([MaSoThue], [MaKhach], [MaNha], [MaMucDichSD], [NgayBD], [NgayKT], [TienDatCoc], [MaHinhThucTT]) VALUES (N'MT009', N'KH002', N'MN007', N'MDSD003', CAST(N'2022-12-01T00:00:00.000' AS DateTime), CAST(N'2024-12-01T00:00:00.000' AS DateTime), 60000000.0000, N'HTTT003')
INSERT [dbo].[ThueNha] ([MaSoThue], [MaKhach], [MaNha], [MaMucDichSD], [NgayBD], [NgayKT], [TienDatCoc], [MaHinhThucTT]) VALUES (N'MT010', N'KH006', N'MN001', N'MDSD001', CAST(N'2022-03-20T00:00:00.000' AS DateTime), CAST(N'2023-03-20T00:00:00.000' AS DateTime), 3500000.0000, N'HTTT002')
GO
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST001', N'MT007', N'7', N'2021', 28500000.0000, N'Nguyễn Thanh Toàn', CAST(N'2021-07-05T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST002', N'MT007', N'9', N'2021', 29200000.0000, N'Nguyễn Thanh Toàn', CAST(N'2021-09-04T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST003', N'MT007', N'10', N'2021', 28000000.0000, N'Nguyễn Thanh Toàn', CAST(N'2021-10-05T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST004', N'MT001', N'10', N'2021', 80000000.0000, N'Ngô Thị Thuý Hằng', CAST(N'2021-10-30T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST005', N'MT001', N'12', N'2021', 83500000.0000, N'Ngô Thị Thuý Hằng', CAST(N'2021-12-29T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST006', N'MT001', N'1', N'2022', 82800000.0000, N'Ngô Thị Thuý Hằng', CAST(N'2022-01-31T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST007', N'MT001', N'2', N'2022', 86000000.0000, N'Ngô Thị Thuý Hằng', CAST(N'2022-02-27T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST008', N'MT010', N'4', N'2022', 4250000.0000, N'Nguyễn Văn Nam', CAST(N'2022-05-03T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST009', N'MT010', N'5', N'2022', 4100000.0000, N'Nguyễn Văn Nam', CAST(N'2022-06-03T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST010', N'MT001', N'5', N'2022', 79300000.0000, N'Ngô Thị Thuý Hằng', CAST(N'2022-05-29T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST011', N'MT010', N'6', N'2022', 4500000.0000, N'Nguyễn Văn Nam', CAST(N'2022-07-02T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST012', N'MT004', N'9', N'2022', 23500000.0000, N'Nguyễn Văn Nam', CAST(N'2022-09-29T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST013', N'MT004', N'10', N'2022', 25000000.0000, N'Nguyễn Văn Nam', CAST(N'2022-10-30T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST014', N'MT004', N'12', N'2022', 24800000.0000, N'Nguyễn Văn Nam', CAST(N'2022-12-29T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST015', N'MT009', N'12,1,2', N'2022,2023', 200000000.0000, N'Lê Đức Anh', CAST(N'2022-02-26T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST016', N'MT004', N'1', N'2023', 24000000.0000, N'Nguyễn Văn Nam', CAST(N'2023-01-30T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST018', N'MT009', N'3,4,5', N'2023', 195000000.0000, N'Lê Đức Anh', CAST(N'2023-05-30T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST020', N'MT003', N'12 tháng', N'2023,2024', 52500000.0000, N'Nguyễn Văn Nam', CAST(N'2023-05-05T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST021', N'MT009', N'6,7,8', N'2023', 210000000.0000, N'Lê Đức Anh', CAST(N'2023-08-29T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST023', N'MT002', N'7', N'2023', 28000000.0000, N'Nguyễn Thanh Toàn', CAST(N'2023-08-03T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST025', N'MT006', N'12 tháng', N'2023,2024', 55000000.0000, N'Mai Văn Giang', CAST(N'2023-08-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST026', N'MT002', N'10', N'2023', 27500000.0000, N'Nguyễn Thanh Toàn', CAST(N'2023-11-02T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST029', N'MT008', N'10', N'2023', 4600000.0000, N'Đặng Thu Hoài', CAST(N'2023-10-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[ThuTienNha] ([MaSoThu], [MaSoThue], [Thang], [Nam], [TongTien], [NguoiThu], [NgayThu], [GhiChu]) VALUES (N'MST030', N'MT005', N'10,11,12', N'2023', 215000000.0000, N'Lê Đức Anh', CAST(N'2023-10-01T00:00:00.000' AS DateTime), NULL)
GO
INSERT [dbo].[TraNha] ([MaSoThue], [NgayTra], [TongTien]) VALUES (N'MT001', CAST(N'2022-10-12T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TraNha] ([MaSoThue], [NgayTra], [TongTien]) VALUES (N'MT002', CAST(N'2023-12-23T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TraNha] ([MaSoThue], [NgayTra], [TongTien]) VALUES (N'MT003', CAST(N'2024-05-05T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TraNha] ([MaSoThue], [NgayTra], [TongTien]) VALUES (N'MT004', CAST(N'2023-02-15T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TraNha] ([MaSoThue], [NgayTra], [TongTien]) VALUES (N'MT005', CAST(N'2024-10-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TraNha] ([MaSoThue], [NgayTra], [TongTien]) VALUES (N'MT006', CAST(N'2024-08-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TraNha] ([MaSoThue], [NgayTra], [TongTien]) VALUES (N'MT007', CAST(N'2021-12-10T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TraNha] ([MaSoThue], [NgayTra], [TongTien]) VALUES (N'MT008', CAST(N'2024-03-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TraNha] ([MaSoThue], [NgayTra], [TongTien]) VALUES (N'MT009', CAST(N'2024-12-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[TraNha] ([MaSoThue], [NgayTra], [TongTien]) VALUES (N'MT010', CAST(N'2023-03-20T00:00:00.000' AS DateTime), NULL)
GO
INSERT [dbo].[TraNha_MatTaiSan] ([MaSoThue], [MaTaiSan], [SoLuong], [GiaTri], [ThanhTien]) VALUES (N'MT001', N'TS004', 2, 10000000.0000, NULL)
INSERT [dbo].[TraNha_MatTaiSan] ([MaSoThue], [MaTaiSan], [SoLuong], [GiaTri], [ThanhTien]) VALUES (N'MT004', N'TS010', 1, 6000000.0000, NULL)
INSERT [dbo].[TraNha_MatTaiSan] ([MaSoThue], [MaTaiSan], [SoLuong], [GiaTri], [ThanhTien]) VALUES (N'MT007', N'TS007', 1, 5000000.0000, NULL)
INSERT [dbo].[TraNha_MatTaiSan] ([MaSoThue], [MaTaiSan], [SoLuong], [GiaTri], [ThanhTien]) VALUES (N'MT010', N'TS005', 1, 3000000.0000, NULL)
GO
ALTER TABLE [dbo].[KhachThue] ADD  DEFAULT (getdate()) FOR [NgaySinh]
GO
ALTER TABLE [dbo].[ThueNha] ADD  DEFAULT (getdate()) FOR [NgayBD]
GO
ALTER TABLE [dbo].[ThueNha] ADD  DEFAULT (getdate()) FOR [NgayKT]
GO
ALTER TABLE [dbo].[ThuTienNha] ADD  DEFAULT (getdate()) FOR [NgayThu]
GO
ALTER TABLE [dbo].[TraNha] ADD  DEFAULT (getdate()) FOR [NgayTra]
GO
ALTER TABLE [dbo].[DanhMucNha]  WITH CHECK ADD FOREIGN KEY([MaDTSD])
REFERENCES [dbo].[DoiTuongSudung] ([MaDTSD])
GO
ALTER TABLE [dbo].[DanhMucNha]  WITH CHECK ADD FOREIGN KEY([MaDTSD])
REFERENCES [dbo].[DoiTuongSudung] ([MaDTSD])
GO
ALTER TABLE [dbo].[KhachThue]  WITH CHECK ADD  CONSTRAINT [fk_coquan] FOREIGN KEY([MaCQ])
REFERENCES [dbo].[CoQuan] ([MaCQ])
GO
ALTER TABLE [dbo].[KhachThue] CHECK CONSTRAINT [fk_coquan]
GO
ALTER TABLE [dbo].[KhachThue]  WITH CHECK ADD  CONSTRAINT [fk_nghe] FOREIGN KEY([MaNghe])
REFERENCES [dbo].[NgheNghiep] ([MaNghe])
GO
ALTER TABLE [dbo].[KhachThue] CHECK CONSTRAINT [fk_nghe]
GO
ALTER TABLE [dbo].[Nha_TaiSan]  WITH CHECK ADD FOREIGN KEY([MaNha])
REFERENCES [dbo].[DanhMucNha] ([MaNha])
GO
ALTER TABLE [dbo].[Nha_TaiSan]  WITH CHECK ADD FOREIGN KEY([MaTaiSan])
REFERENCES [dbo].[TaiSan] ([MaTaiSan])
GO
ALTER TABLE [dbo].[Nha_TaiSan]  WITH CHECK ADD  CONSTRAINT [fk_nha_mataisan] FOREIGN KEY([MaTaiSan])
REFERENCES [dbo].[TaiSan] ([MaTaiSan])
GO
ALTER TABLE [dbo].[Nha_TaiSan] CHECK CONSTRAINT [fk_nha_mataisan]
GO
ALTER TABLE [dbo].[ThueNha]  WITH CHECK ADD FOREIGN KEY([MaHinhThucTT])
REFERENCES [dbo].[HinhThucThanhToan] ([MaHinhThucTT])
GO
ALTER TABLE [dbo].[ThueNha]  WITH CHECK ADD FOREIGN KEY([MaKhach])
REFERENCES [dbo].[KhachThue] ([MaKhach])
GO
ALTER TABLE [dbo].[ThueNha]  WITH CHECK ADD FOREIGN KEY([MaNha])
REFERENCES [dbo].[DanhMucNha] ([MaNha])
GO
ALTER TABLE [dbo].[ThuTienNha]  WITH CHECK ADD FOREIGN KEY([MaSoThue])
REFERENCES [dbo].[ThueNha] ([MaSoThue])
GO
ALTER TABLE [dbo].[TraNha]  WITH CHECK ADD  CONSTRAINT [fk_tranha_mst] FOREIGN KEY([MaSoThue])
REFERENCES [dbo].[ThueNha] ([MaSoThue])
GO
ALTER TABLE [dbo].[TraNha] CHECK CONSTRAINT [fk_tranha_mst]
GO
ALTER TABLE [dbo].[TraNha_MatTaiSan]  WITH CHECK ADD FOREIGN KEY([MaSoThue])
REFERENCES [dbo].[ThueNha] ([MaSoThue])
GO
ALTER TABLE [dbo].[TraNha_MatTaiSan]  WITH CHECK ADD FOREIGN KEY([MaTaiSan])
REFERENCES [dbo].[TaiSan] ([MaTaiSan])
GO
ALTER TABLE [dbo].[TraNha_MatTaiSan]  WITH CHECK ADD  CONSTRAINT [fk_tranha_mattaisan_mst] FOREIGN KEY([MaSoThue])
REFERENCES [dbo].[TraNha] ([MaSoThue])
GO
ALTER TABLE [dbo].[TraNha_MatTaiSan] CHECK CONSTRAINT [fk_tranha_mattaisan_mst]
GO
USE [master]
GO
ALTER DATABASE [QLChoThueNha_BTL] SET  READ_WRITE 
GO