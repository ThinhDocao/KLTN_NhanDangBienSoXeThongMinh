USE [master]
GO
/****** Object:  Database [Bai_Xe_TM]    Script Date: 7/12/2020 9:43:32 PM ******/
CREATE DATABASE [Bai_Xe_TM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bai_Xe_TM', FILENAME = N'E:\SQL\Bai_Xe_TM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Bai_Xe_TM_log', FILENAME = N'E:\SQL\Bai_Xe_TM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Bai_Xe_TM] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bai_Xe_TM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Bai_Xe_TM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET ARITHABORT OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Bai_Xe_TM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Bai_Xe_TM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Bai_Xe_TM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Bai_Xe_TM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET RECOVERY FULL 
GO
ALTER DATABASE [Bai_Xe_TM] SET  MULTI_USER 
GO
ALTER DATABASE [Bai_Xe_TM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Bai_Xe_TM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Bai_Xe_TM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Bai_Xe_TM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Bai_Xe_TM] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Bai_Xe_TM', N'ON'
GO
ALTER DATABASE [Bai_Xe_TM] SET QUERY_STORE = OFF
GO
USE [Bai_Xe_TM]
GO
/****** Object:  Table [dbo].[The_RFID]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[The_RFID](
	[MaRFIF] [varchar](15) NOT NULL,
	[MaLoaiVe] [varchar](10) NULL,
	[NgayTao] [datetime] NULL,
	[NgayCapNhatCuoi] [datetime] NULL,
	[TrangThai] [bit] NULL,
	[TheDangKi] [bit] NULL,
 CONSTRAINT [PK_The_RFID] PRIMARY KEY CLUSTERED 
(
	[MaRFIF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[TEST]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[TEST]()
RETURNS TABLE
AS
	RETURN (SELECT * FROM The_RFID)
GO
/****** Object:  Table [dbo].[CauHinh_Camera]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauHinh_Camera](
	[Hang_Camera] [varchar](50) NOT NULL,
	[ChuoiCauHinh] [varchar](max) NULL,
 CONSTRAINT [PK_CauHinh_Camera] PRIMARY KEY CLUSTERED 
(
	[Hang_Camera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietQuyen]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietQuyen](
	[MaCTQuyen] [varchar](15) NOT NULL,
	[TenCTQuyen] [nvarchar](max) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChiTietQuyen] PRIMARY KEY CLUSTERED 
(
	[MaCTQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cong]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cong](
	[Ma_Cong] [varchar](50) NOT NULL,
	[Ten_Cong] [nvarchar](50) NULL,
	[ChucNang] [nvarchar](50) NULL,
	[TinhTrang] [bit] NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_Cong] PRIMARY KEY CLUSTERED 
(
	[Ma_Cong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](150) NOT NULL,
	[Anh_KH] [image] NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[SDT] [varchar](20) NOT NULL,
	[CMND] [varchar](20) NOT NULL,
	[SoPhong] [varchar](10) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiVe]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiVe](
	[MaLoaiVe] [varchar](10) NOT NULL,
	[TenLoaiVe] [nvarchar](50) NULL,
	[Phi] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiVe] PRIMARY KEY CLUSTERED 
(
	[MaLoaiVe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MayTinh]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MayTinh](
	[Ma_may] [varchar](50) NOT NULL,
	[TenMay] [varchar](50) NULL,
	[IP_May] [varchar](20) NULL,
	[Serial] [varchar](50) NULL,
	[TinhTrang] [bit] NULL,
	[Ma_Cong] [varchar](50) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_MayTinh] PRIMARY KEY CLUSTERED 
(
	[Ma_may] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[TenNV] [nvarchar](150) NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[SDT] [varchar](20) NULL,
	[CMND] [varchar](20) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[TinhTrang] [bit] NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien_NhomNguoiDung]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien_NhomNguoiDung](
	[MaNV] [varchar](50) NOT NULL,
	[PQ_NND] [varchar](15) NOT NULL,
	[MaCTQuyen] [varchar](15) NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_NhanVien_NhomNguoiDung_1] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[PQ_NND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomNguoiDung]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomNguoiDung](
	[MaNhom] [varchar](15) NOT NULL,
	[TenNhom] [nvarchar](max) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_NhomNguoiDung] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[MaQuyen] [varchar](15) NOT NULL,
	[TenQuyen] [nvarchar](max) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen_NhomNguoiDung]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen_NhomNguoiDung](
	[PQ_NND] [varchar](15) NOT NULL,
	[MaQuyen] [varchar](15) NOT NULL,
	[MaNhom] [varchar](15) NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_PhanQuyen_NhomNguoiDung_1] PRIMARY KEY CLUSTERED 
(
	[PQ_NND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrangThai]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThai](
	[TrangThai] [bit] NULL,
	[Ten] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VeThang]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VeThang](
	[MaVeThang] [varchar](50) NOT NULL,
	[MaRFID] [varchar](15) NULL,
	[MaXe] [varchar](10) NULL,
	[NgayBD] [date] NULL,
	[NgayKT] [date] NULL,
	[NgayTaoVe] [datetime] NULL,
	[NhanVien] [varchar](50) NULL,
	[MayTinh] [varchar](50) NULL,
 CONSTRAINT [PK_VeThang] PRIMARY KEY CLUSTERED 
(
	[MaVeThang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[MaXe] [varchar](10) NOT NULL,
	[HinhAnhXe] [image] NULL,
	[BienXo_Xe] [varchar](15) NULL,
	[MauSacXe] [nvarchar](50) NULL,
	[MaKH] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[MaXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe_Ra]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe_Ra](
	[Ma_Ra] [varchar](50) NOT NULL,
	[Ma_Vao] [varchar](50) NULL,
	[HinhBX_Ra] [varchar](50) NULL,
	[Hinh_Ng_Ra] [varchar](50) NULL,
	[BienSo_Ra] [varchar](15) NULL,
	[MayTinh_Ra] [varchar](50) NULL,
	[MaNV_Ra] [varchar](50) NULL,
	[TG_Ra] [datetime] NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_Xe_Ra] PRIMARY KEY CLUSTERED 
(
	[Ma_Ra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Xe_Vao]    Script Date: 7/12/2020 9:43:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe_Vao](
	[Ma_Vao] [varchar](50) NOT NULL,
	[MaRFIF] [varchar](15) NULL,
	[MaGui] [varchar](20) NULL,
	[DC] [tinyint] NULL,
	[HinhBX_Vao] [varchar](50) NULL,
	[Hinh_N_Vao] [varchar](50) NULL,
	[MayTinh_Vao] [varchar](50) NULL,
	[MaNV_Vao] [varchar](50) NULL,
	[BienSo_Vao] [varchar](15) NULL,
	[TG_Vao] [datetime] NULL,
	[TrangThai] [bit] NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [PK_Xe_Vao] PRIMARY KEY CLUSTERED 
(
	[Ma_Vao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CauHinh_Camera] ([Hang_Camera], [ChuoiCauHinh]) VALUES (N'IP_DienThoai', N'http://@IP:@CONG/video')
INSERT [dbo].[CauHinh_Camera] ([Hang_Camera], [ChuoiCauHinh]) VALUES (N'IP_Hikvision', N'rtsp://@TAIKHOAN:@MATKHAU@@IP:@CONG/Streaming/Channels/101/?transportmode=multicast.')
INSERT [dbo].[CauHinh_Camera] ([Hang_Camera], [ChuoiCauHinh]) VALUES (N'Yoosee', N'rtsp://@TAIKHOAN:@MATKHAU@@IP:@CONG/onvif1')
GO
INSERT [dbo].[Cong] ([Ma_Cong], [Ten_Cong], [ChucNang], [TinhTrang], [GhiChu]) VALUES (N'565165', NULL, NULL, NULL, NULL)
INSERT [dbo].[Cong] ([Ma_Cong], [Ten_Cong], [ChucNang], [TinhTrang], [GhiChu]) VALUES (N'testsad', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Anh_KH], [GioiTinh], [SDT], [CMND], [SoPhong]) VALUES (N'KH001', N'Nguyễn Hoàng Long', NULL, N'Nam', N'035913487', N'6216546465', N'AH-356')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Anh_KH], [GioiTinh], [SDT], [CMND], [SoPhong]) VALUES (N'KH002', N'Trần Hoàng Thi', NULL, N'Nam', N'0359136843', N'369852314', N'KH-953')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Anh_KH], [GioiTinh], [SDT], [CMND], [SoPhong]) VALUES (N'KH003', N'Lê Hoàng', NULL, N'Nam', N'0359134682', N'362195348', N'AB-853')
GO
INSERT [dbo].[LoaiVe] ([MaLoaiVe], [TenLoaiVe], [Phi]) VALUES (N'VETHANG', N'Vé tháng', N'50000')
GO
INSERT [dbo].[MayTinh] ([Ma_may], [TenMay], [IP_May], [Serial], [TinhTrang], [Ma_Cong], [GhiChu]) VALUES (N'01', N'Máy tính 1', NULL, NULL, 1, NULL, NULL)
INSERT [dbo].[MayTinh] ([Ma_may], [TenMay], [IP_May], [Serial], [TinhTrang], [Ma_Cong], [GhiChu]) VALUES (N'ADMIN', N'ADMIN', N'192.168.1.5', N'
S3YHNX0K816997Y

', 0, NULL, NULL)
INSERT [dbo].[MayTinh] ([Ma_may], [TenMay], [IP_May], [Serial], [TinhTrang], [Ma_Cong], [GhiChu]) VALUES (N'LEHIEU', N'LEHIEU', N'192.168.1.6', N'FJ65N441510205EBS', 1, NULL, NULL)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [GioiTinh], [SDT], [CMND], [DiaChi], [TinhTrang], [GhiChu]) VALUES (N'NV002', N'ED60895320F961669C8CA512A9ADFEB5', N'Lê Hiếu', N'Nam', N'0358166699', NULL, NULL, 1, NULL)
GO
INSERT [dbo].[The_RFID] ([MaRFIF], [MaLoaiVe], [NgayTao], [NgayCapNhatCuoi], [TrangThai], [TheDangKi]) VALUES (N'5ffae128', N'VETHANG', CAST(N'2020-06-05T00:00:00.000' AS DateTime), CAST(N'2020-06-08T21:34:32.000' AS DateTime), 1, 1)
INSERT [dbo].[The_RFID] ([MaRFIF], [MaLoaiVe], [NgayTao], [NgayCapNhatCuoi], [TrangThai], [TheDangKi]) VALUES (N'a90620a3', N'VETHANG', CAST(N'2020-06-05T00:00:00.000' AS DateTime), CAST(N'2020-06-05T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[The_RFID] ([MaRFIF], [MaLoaiVe], [NgayTao], [NgayCapNhatCuoi], [TrangThai], [TheDangKi]) VALUES (N'd477682a', N'VETHANG', CAST(N'2020-06-05T00:00:00.000' AS DateTime), CAST(N'2020-06-05T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[The_RFID] ([MaRFIF], [MaLoaiVe], [NgayTao], [NgayCapNhatCuoi], [TrangThai], [TheDangKi]) VALUES (N'e70754a3', N'VETHANG', CAST(N'2020-06-05T00:00:00.000' AS DateTime), CAST(N'2020-06-05T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[The_RFID] ([MaRFIF], [MaLoaiVe], [NgayTao], [NgayCapNhatCuoi], [TrangThai], [TheDangKi]) VALUES (N'eb1ace02', N'VETHANG', CAST(N'2020-06-05T00:00:00.000' AS DateTime), CAST(N'2020-06-05T00:00:00.000' AS DateTime), 1, 0)
GO
INSERT [dbo].[TrangThai] ([TrangThai], [Ten]) VALUES (1, N'Đã ra')
INSERT [dbo].[TrangThai] ([TrangThai], [Ten]) VALUES (0, N'Chưa ra')
GO
INSERT [dbo].[VeThang] ([MaVeThang], [MaRFID], [MaXe], [NgayBD], [NgayKT], [NgayTaoVe], [NhanVien], [MayTinh]) VALUES (N'VT001', N'5ffae128', N'XE001', CAST(N'2020-01-01' AS Date), CAST(N'2021-01-01' AS Date), NULL, NULL, NULL)
INSERT [dbo].[VeThang] ([MaVeThang], [MaRFID], [MaXe], [NgayBD], [NgayKT], [NgayTaoVe], [NhanVien], [MayTinh]) VALUES (N'VT002', N'a90620a3', N'XE002', CAST(N'2020-01-01' AS Date), CAST(N'2021-01-01' AS Date), NULL, NULL, NULL)
INSERT [dbo].[VeThang] ([MaVeThang], [MaRFID], [MaXe], [NgayBD], [NgayKT], [NgayTaoVe], [NhanVien], [MayTinh]) VALUES (N'VT003', N'd477682a', N'XE003', CAST(N'2019-01-01' AS Date), CAST(N'2021-01-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Xe] ([MaXe], [HinhAnhXe], [BienXo_Xe], [MauSacXe], [MaKH]) VALUES (N'XE001', NULL, NULL, NULL, N'KH001')
INSERT [dbo].[Xe] ([MaXe], [HinhAnhXe], [BienXo_Xe], [MauSacXe], [MaKH]) VALUES (N'XE002', NULL, NULL, NULL, N'KH002')
INSERT [dbo].[Xe] ([MaXe], [HinhAnhXe], [BienXo_Xe], [MauSacXe], [MaKH]) VALUES (N'XE003', NULL, NULL, NULL, N'KH003')
GO
INSERT [dbo].[Xe_Ra] ([Ma_Ra], [Ma_Vao], [HinhBX_Ra], [Hinh_Ng_Ra], [BienSo_Ra], [MayTinh_Ra], [MaNV_Ra], [TG_Ra], [GhiChu]) VALUES (N'5ffae128-12282020-082818', N'5ffae128-12282020-082818', N'5ffae128-12282020-082823.jpg', N'5ffae128-12282020-082823x.jpg', N'62P1-58690', NULL, N'NV002', CAST(N'2020-07-12T20:28:24.317' AS DateTime), NULL)
INSERT [dbo].[Xe_Ra] ([Ma_Ra], [Ma_Vao], [HinhBX_Ra], [Hinh_Ng_Ra], [BienSo_Ra], [MayTinh_Ra], [MaNV_Ra], [TG_Ra], [GhiChu]) VALUES (N'd477682a-12272020-082743', N'd477682a-12272020-082743', N'd477682a-12272020-082750.jpg', N'd477682a-12272020-082750x.jpg', N'62P1-58690', NULL, N'NV002', CAST(N'2020-07-12T20:27:50.990' AS DateTime), NULL)
INSERT [dbo].[Xe_Ra] ([Ma_Ra], [Ma_Vao], [HinhBX_Ra], [Hinh_Ng_Ra], [BienSo_Ra], [MayTinh_Ra], [MaNV_Ra], [TG_Ra], [GhiChu]) VALUES (N'eb1ace02-12282020-082829', N'eb1ace02-12282020-082829', N'eb1ace02-12282020-082833.jpg', N'eb1ace02-12282020-082833x.jpg', N'62P1-58690', NULL, N'NV002', CAST(N'2020-07-12T20:28:34.043' AS DateTime), NULL)
INSERT [dbo].[Xe_Ra] ([Ma_Ra], [Ma_Vao], [HinhBX_Ra], [Hinh_Ng_Ra], [BienSo_Ra], [MayTinh_Ra], [MaNV_Ra], [TG_Ra], [GhiChu]) VALUES (N'eb1ace02-12412020-084113', N'eb1ace02-12412020-084113', N'eb1ace02-12412020-084121.jpg', N'eb1ace02-12412020-084121x.jpg', N'62P1-58690', NULL, N'NV002', CAST(N'2020-07-12T20:41:22.010' AS DateTime), NULL)
GO
INSERT [dbo].[Xe_Vao] ([Ma_Vao], [MaRFIF], [MaGui], [DC], [HinhBX_Vao], [Hinh_N_Vao], [MayTinh_Vao], [MaNV_Vao], [BienSo_Vao], [TG_Vao], [TrangThai], [GhiChu]) VALUES (N'5ffae128-12282020-082818', N'5ffae128', N'867854f1cff8eea', 62, N'5ffae128-12282020-082818.jpg', N'5ffae128-12282020-082818x.jpg', N'ADMIN', N'NV002', N'62P1-58690', CAST(N'2020-07-12T20:28:18.920' AS DateTime), 1, NULL)
INSERT [dbo].[Xe_Vao] ([Ma_Vao], [MaRFIF], [MaGui], [DC], [HinhBX_Vao], [Hinh_N_Vao], [MayTinh_Vao], [MaNV_Vao], [BienSo_Vao], [TG_Vao], [TrangThai], [GhiChu]) VALUES (N'd477682a-12272020-082743', N'd477682a', N'aeef840580dfbdf', 62, N'd477682a-12272020-082743.jpg', N'd477682a-12272020-082743x.jpg', N'ADMIN', N'NV002', N'62P1-58690', CAST(N'2020-07-12T20:27:44.917' AS DateTime), 1, NULL)
INSERT [dbo].[Xe_Vao] ([Ma_Vao], [MaRFIF], [MaGui], [DC], [HinhBX_Vao], [Hinh_N_Vao], [MayTinh_Vao], [MaNV_Vao], [BienSo_Vao], [TG_Vao], [TrangThai], [GhiChu]) VALUES (N'eb1ace02-12242020-092433', N'eb1ace02', N'57fd42f62208c36', 62, N'eb1ace02-12242020-092433.jpg', N'eb1ace02-12242020-092433x.jpg', N'ADMIN', N'NV002', N'62P1-58690', CAST(N'2020-07-12T21:24:34.497' AS DateTime), 0, NULL)
INSERT [dbo].[Xe_Vao] ([Ma_Vao], [MaRFIF], [MaGui], [DC], [HinhBX_Vao], [Hinh_N_Vao], [MayTinh_Vao], [MaNV_Vao], [BienSo_Vao], [TG_Vao], [TrangThai], [GhiChu]) VALUES (N'eb1ace02-12282020-082829', N'eb1ace02', N'221df078186166f', 62, N'eb1ace02-12282020-082829.jpg', N'eb1ace02-12282020-082829x.jpg', N'ADMIN', N'NV002', N'62P1-58690', CAST(N'2020-07-12T20:28:30.020' AS DateTime), 1, NULL)
INSERT [dbo].[Xe_Vao] ([Ma_Vao], [MaRFIF], [MaGui], [DC], [HinhBX_Vao], [Hinh_N_Vao], [MayTinh_Vao], [MaNV_Vao], [BienSo_Vao], [TG_Vao], [TrangThai], [GhiChu]) VALUES (N'eb1ace02-12412020-084113', N'eb1ace02', N'3dee102fb32f1a2', 62, N'eb1ace02-12412020-084113.jpg', N'eb1ace02-12412020-084113x.jpg', NULL, N'NV002', N'62P1-58690', CAST(N'2020-07-12T20:41:14.797' AS DateTime), 1, NULL)
GO
ALTER TABLE [dbo].[MayTinh]  WITH CHECK ADD  CONSTRAINT [FK_MayTinh_Cong] FOREIGN KEY([Ma_Cong])
REFERENCES [dbo].[Cong] ([Ma_Cong])
GO
ALTER TABLE [dbo].[MayTinh] CHECK CONSTRAINT [FK_MayTinh_Cong]
GO
ALTER TABLE [dbo].[NhanVien_NhomNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_NhomNguoiDung_ChiTietQuyen] FOREIGN KEY([MaCTQuyen])
REFERENCES [dbo].[ChiTietQuyen] ([MaCTQuyen])
GO
ALTER TABLE [dbo].[NhanVien_NhomNguoiDung] CHECK CONSTRAINT [FK_NhanVien_NhomNguoiDung_ChiTietQuyen]
GO
ALTER TABLE [dbo].[NhanVien_NhomNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_NhomNguoiDung_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NhanVien_NhomNguoiDung] CHECK CONSTRAINT [FK_NhanVien_NhomNguoiDung_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien_NhomNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_NhomNguoiDung_PhanQuyen_NhomNguoiDung] FOREIGN KEY([PQ_NND])
REFERENCES [dbo].[PhanQuyen_NhomNguoiDung] ([PQ_NND])
GO
ALTER TABLE [dbo].[NhanVien_NhomNguoiDung] CHECK CONSTRAINT [FK_NhanVien_NhomNguoiDung_PhanQuyen_NhomNguoiDung]
GO
ALTER TABLE [dbo].[PhanQuyen_NhomNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_NhomNguoiDung_NhomNguoiDung] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NhomNguoiDung] ([MaNhom])
GO
ALTER TABLE [dbo].[PhanQuyen_NhomNguoiDung] CHECK CONSTRAINT [FK_PhanQuyen_NhomNguoiDung_NhomNguoiDung]
GO
ALTER TABLE [dbo].[PhanQuyen_NhomNguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_PhanQuyen_NhomNguoiDung_PhanQuyen] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[PhanQuyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[PhanQuyen_NhomNguoiDung] CHECK CONSTRAINT [FK_PhanQuyen_NhomNguoiDung_PhanQuyen]
GO
ALTER TABLE [dbo].[The_RFID]  WITH CHECK ADD  CONSTRAINT [FK_The_RFID_LoaiVe] FOREIGN KEY([MaLoaiVe])
REFERENCES [dbo].[LoaiVe] ([MaLoaiVe])
GO
ALTER TABLE [dbo].[The_RFID] CHECK CONSTRAINT [FK_The_RFID_LoaiVe]
GO
ALTER TABLE [dbo].[VeThang]  WITH CHECK ADD  CONSTRAINT [FK_VeThang_NhanVien] FOREIGN KEY([NhanVien])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[VeThang] CHECK CONSTRAINT [FK_VeThang_NhanVien]
GO
ALTER TABLE [dbo].[VeThang]  WITH CHECK ADD  CONSTRAINT [FK_VeThang_The_RFID] FOREIGN KEY([MaRFID])
REFERENCES [dbo].[The_RFID] ([MaRFIF])
GO
ALTER TABLE [dbo].[VeThang] CHECK CONSTRAINT [FK_VeThang_The_RFID]
GO
ALTER TABLE [dbo].[VeThang]  WITH CHECK ADD  CONSTRAINT [FK_VeThang_Xe] FOREIGN KEY([MaXe])
REFERENCES [dbo].[Xe] ([MaXe])
GO
ALTER TABLE [dbo].[VeThang] CHECK CONSTRAINT [FK_VeThang_Xe]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [FK_Xe_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [FK_Xe_KhachHang]
GO
ALTER TABLE [dbo].[Xe_Ra]  WITH CHECK ADD  CONSTRAINT [FK_Xe_Ra_MayTinh] FOREIGN KEY([MayTinh_Ra])
REFERENCES [dbo].[MayTinh] ([Ma_may])
GO
ALTER TABLE [dbo].[Xe_Ra] CHECK CONSTRAINT [FK_Xe_Ra_MayTinh]
GO
ALTER TABLE [dbo].[Xe_Ra]  WITH CHECK ADD  CONSTRAINT [FK_Xe_Ra_NhanVien] FOREIGN KEY([MaNV_Ra])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Xe_Ra] CHECK CONSTRAINT [FK_Xe_Ra_NhanVien]
GO
ALTER TABLE [dbo].[Xe_Ra]  WITH CHECK ADD  CONSTRAINT [FK_Xe_Ra_Xe_Vao] FOREIGN KEY([Ma_Vao])
REFERENCES [dbo].[Xe_Vao] ([Ma_Vao])
GO
ALTER TABLE [dbo].[Xe_Ra] CHECK CONSTRAINT [FK_Xe_Ra_Xe_Vao]
GO
ALTER TABLE [dbo].[Xe_Vao]  WITH CHECK ADD  CONSTRAINT [FK_Xe_Vao_NhanVien] FOREIGN KEY([MaNV_Vao])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Xe_Vao] CHECK CONSTRAINT [FK_Xe_Vao_NhanVien]
GO
ALTER TABLE [dbo].[Xe_Vao]  WITH CHECK ADD  CONSTRAINT [FK_Xe_Vao_The_RFID] FOREIGN KEY([MaRFIF])
REFERENCES [dbo].[The_RFID] ([MaRFIF])
GO
ALTER TABLE [dbo].[Xe_Vao] CHECK CONSTRAINT [FK_Xe_Vao_The_RFID]
GO
USE [master]
GO
ALTER DATABASE [Bai_Xe_TM] SET  READ_WRITE 
GO
