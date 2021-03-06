USE [master]
GO
/****** Object:  Database [Bai_Xe_TM]    Script Date: 7/5/2020 11:00:58 PM ******/
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
/****** Object:  Table [dbo].[The_RFID]    Script Date: 7/5/2020 11:00:58 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[TEST]    Script Date: 7/5/2020 11:00:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[TEST]()
RETURNS TABLE
AS
	RETURN (SELECT * FROM The_RFID)
GO
/****** Object:  Table [dbo].[CauHinh_Camera]    Script Date: 7/5/2020 11:00:58 PM ******/
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
/****** Object:  Table [dbo].[ChiTietQuyen]    Script Date: 7/5/2020 11:00:58 PM ******/
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
/****** Object:  Table [dbo].[Cong]    Script Date: 7/5/2020 11:00:58 PM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 7/5/2020 11:00:58 PM ******/
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
/****** Object:  Table [dbo].[LoaiVe]    Script Date: 7/5/2020 11:00:58 PM ******/
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
/****** Object:  Table [dbo].[MayTinh]    Script Date: 7/5/2020 11:00:58 PM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 7/5/2020 11:00:58 PM ******/
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
/****** Object:  Table [dbo].[NhanVien_NhomNguoiDung]    Script Date: 7/5/2020 11:00:58 PM ******/
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
/****** Object:  Table [dbo].[NhomNguoiDung]    Script Date: 7/5/2020 11:00:58 PM ******/
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
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 7/5/2020 11:00:58 PM ******/
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
/****** Object:  Table [dbo].[PhanQuyen_NhomNguoiDung]    Script Date: 7/5/2020 11:00:58 PM ******/
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
/****** Object:  Table [dbo].[TrangThai]    Script Date: 7/5/2020 11:00:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThai](
	[TrangThai] [bit] NULL,
	[Ten] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VeThang]    Script Date: 7/5/2020 11:00:58 PM ******/
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
/****** Object:  Table [dbo].[Xe]    Script Date: 7/5/2020 11:00:58 PM ******/
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
/****** Object:  Table [dbo].[Xe_Ra]    Script Date: 7/5/2020 11:00:58 PM ******/
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
/****** Object:  Table [dbo].[Xe_Vao]    Script Date: 7/5/2020 11:00:58 PM ******/
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
INSERT [dbo].[CauHinh_Camera] ([Hang_Camera], [ChuoiCauHinh]) VALUES (N'Yoosee', N'rtsp://@TAIKHOAN:@MATKHAU@@IP:@CONG/onvif1')
GO
INSERT [dbo].[ChiTietQuyen] ([MaCTQuyen], [TenCTQuyen], [GhiChu]) VALUES (N'MCTQ001', N'Cấm', N'Cấm truy cập')
INSERT [dbo].[ChiTietQuyen] ([MaCTQuyen], [TenCTQuyen], [GhiChu]) VALUES (N'MCTQ002', N'Xem', N'chỉ xem')
INSERT [dbo].[ChiTietQuyen] ([MaCTQuyen], [TenCTQuyen], [GhiChu]) VALUES (N'MCTQ003', N'Sửa', N'chỉ sửa')
INSERT [dbo].[ChiTietQuyen] ([MaCTQuyen], [TenCTQuyen], [GhiChu]) VALUES (N'MCTQ004', N'Thêm', N'chỉ thêm')
INSERT [dbo].[ChiTietQuyen] ([MaCTQuyen], [TenCTQuyen], [GhiChu]) VALUES (N'MCTQ005', N'Sửa và xóa', N'chỉ xóa')
INSERT [dbo].[ChiTietQuyen] ([MaCTQuyen], [TenCTQuyen], [GhiChu]) VALUES (N'MCTQ006', N'Toàn quyền', N'Toàn bộ')
GO
INSERT [dbo].[Cong] ([Ma_Cong], [Ten_Cong], [ChucNang], [TinhTrang], [GhiChu]) VALUES (N'3e1e00e3-2fea-4302-adfc-878f53b40182', N'zz2', N'1111', 0, N'')
INSERT [dbo].[Cong] ([Ma_Cong], [Ten_Cong], [ChucNang], [TinhTrang], [GhiChu]) VALUES (N'565165', NULL, NULL, NULL, NULL)
INSERT [dbo].[Cong] ([Ma_Cong], [Ten_Cong], [ChucNang], [TinhTrang], [GhiChu]) VALUES (N'617a210a-9102-4ffa-b9af-ff1099fbafb3', N'2', N'2222', 0, N'xxx')
INSERT [dbo].[Cong] ([Ma_Cong], [Ten_Cong], [ChucNang], [TinhTrang], [GhiChu]) VALUES (N'90c9c454-5fed-4f0d-866b-e48520abc446', N'2', N'33333', 0, N'')
INSERT [dbo].[Cong] ([Ma_Cong], [Ten_Cong], [ChucNang], [TinhTrang], [GhiChu]) VALUES (N'testsad', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Anh_KH], [GioiTinh], [SDT], [CMND], [SoPhong]) VALUES (N'03140', N'Lê Hoàng Phúc', NULL, N'Nam', N'', N'165464646464', N'JSU55')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Anh_KH], [GioiTinh], [SDT], [CMND], [SoPhong]) VALUES (N'62257', N'2', NULL, N'Nam', N'1111', N'1111', N'1111')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Anh_KH], [GioiTinh], [SDT], [CMND], [SoPhong]) VALUES (N'bf227', N'2qqqq', NULL, N'', N'555', N'5555', N'5555')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Anh_KH], [GioiTinh], [SDT], [CMND], [SoPhong]) VALUES (N'KH001', N'Nguyễn Hoàng Long', NULL, N'Nam', N'035913487', N'6216546465', N'AH-356')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Anh_KH], [GioiTinh], [SDT], [CMND], [SoPhong]) VALUES (N'KH002', N'Trần Hoàng Thi', NULL, N'Nam', N'0359136843', N'369852314', N'KH-953')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [Anh_KH], [GioiTinh], [SDT], [CMND], [SoPhong]) VALUES (N'KH003', N'Lê Hoàng', NULL, N'Nam', N'0359134682', N'362195348', N'AB-853')
GO
INSERT [dbo].[LoaiVe] ([MaLoaiVe], [TenLoaiVe], [Phi]) VALUES (N'VETHANG', N'Vé tháng', N'50000')
GO
INSERT [dbo].[MayTinh] ([Ma_may], [TenMay], [IP_May], [Serial], [TinhTrang], [Ma_Cong], [GhiChu]) VALUES (N'01', N'Máy tính 1', N'192.168.1.15', N'16548916', 1, NULL, NULL)
INSERT [dbo].[MayTinh] ([Ma_may], [TenMay], [IP_May], [Serial], [TinhTrang], [Ma_Cong], [GhiChu]) VALUES (N'ADMIN', N'ADMIN', N'192.168.1.53', N'

S3YHNX0K816997Y



', 1, NULL, NULL)
GO
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [GioiTinh], [SDT], [CMND], [DiaChi], [TinhTrang], [GhiChu]) VALUES (N'227b3a54-8e0b-4414-9331-5fe73f4007af', N'2', N'asdasd', NULL, NULL, NULL, NULL, 1, NULL)
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [GioiTinh], [SDT], [CMND], [DiaChi], [TinhTrang], [GhiChu]) VALUES (N'5d4601a8-99dc-4bc2-ba8d-0fcefaf3f4fa', N'23335', N'zz', N'Nữ', N'zzz', N'zz', N'zzzzzzzzzz', 1, N'zzz')
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [GioiTinh], [SDT], [CMND], [DiaChi], [TinhTrang], [GhiChu]) VALUES (N'NV001', N'123456', N'thinh456', N'Nam', N'0123456789', N'011123', N'adqqqqq', 0, N'123')
INSERT [dbo].[NhanVien] ([MaNV], [MatKhau], [TenNV], [GioiTinh], [SDT], [CMND], [DiaChi], [TinhTrang], [GhiChu]) VALUES (N'NV002', N'123456', N'Hiếu123', N'Nam', N'0123456789', N'011123', N'aasdasd', 1, N'asdasd')
GO
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV001', N'PQ_NND001', N'MCTQ003', N'Đã sửa ngày: 6/19/2020 2:58:20 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV001', N'PQ_NND002', N'MCTQ003', N'Đã sửa ngày: 6/19/2020 2:58:20 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV001', N'PQ_NND003', N'MCTQ003', N'Đã sửa ngày: 6/19/2020 2:58:20 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV001', N'PQ_NND004', N'MCTQ003', N'Đã sửa ngày: 6/19/2020 2:58:20 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV001', N'PQ_NND005', N'MCTQ003', N'Đã sửa ngày: 6/19/2020 2:58:20 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV001', N'PQ_NND006', N'MCTQ003', N'Đã sửa ngày: 6/19/2020 2:58:20 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV001', N'PQ_NND010', N'MCTQ002', N'Đã sửa ngày: 6/19/2020 2:58:20 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV001', N'PQ_NND011', N'MCTQ002', N'Đã sửa ngày: 6/19/2020 2:58:20 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV001', N'PQ_NND012', N'MCTQ002', N'Đã sửa ngày: 6/19/2020 2:58:20 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV001', N'PQ_NND013', N'MCTQ002', N'Đã sửa ngày: 6/19/2020 2:58:20 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV001', N'PQ_NND014', N'MCTQ006', N'Thêm mới ngày : 6/19/2020 2:58:20 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV002', N'PQ_NND001', N'MCTQ006', N'Đã sửa ngày: 6/19/2020 2:58:27 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV002', N'PQ_NND002', N'MCTQ005', N'Đã sửa ngày: 6/19/2020 2:58:27 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV002', N'PQ_NND003', N'MCTQ004', N'Đã sửa ngày: 6/19/2020 2:58:27 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV002', N'PQ_NND004', N'MCTQ003', N'Đã sửa ngày: 6/19/2020 2:58:27 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV002', N'PQ_NND005', N'MCTQ002', N'Đã sửa ngày: 6/19/2020 2:58:27 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV002', N'PQ_NND006', N'MCTQ001', N'Đã sửa ngày: 6/19/2020 2:58:27 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV002', N'PQ_NND010', N'MCTQ004', N'Đã sửa ngày: 6/19/2020 2:58:27 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV002', N'PQ_NND011', N'MCTQ005', N'Đã sửa ngày: 6/19/2020 2:58:27 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV002', N'PQ_NND012', N'MCTQ006', N'Đã sửa ngày: 6/19/2020 2:58:27 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV002', N'PQ_NND013', N'MCTQ006', N'Đã sửa ngày: 6/19/2020 2:58:27 PM')
INSERT [dbo].[NhanVien_NhomNguoiDung] ([MaNV], [PQ_NND], [MaCTQuyen], [GhiChu]) VALUES (N'NV002', N'PQ_NND014', N'MCTQ006', N'Thêm mới ngày : 6/19/2020 2:58:27 PM')
GO
INSERT [dbo].[NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'MN001', N'Hệ thống', NULL)
INSERT [dbo].[NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'MN002', N'Danh mục', NULL)
INSERT [dbo].[NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'MN003', N'Báo cáo', NULL)
GO
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'MQ001', N'Đổi mật khẩu', N'.')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'MQ002', N'Phân quyền nhân viên', N'.')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'MQ003', N'Thông tin công ty', N'.')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'MQ004', N'Sao lưu dữ liệu', N'.')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'MQ005', N'Cấu hình camera', N'.')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'MQ006', N'Cấu hình máy tính', N'.')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'MQ010', N'Khách hàng', N'.')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'MQ011', N'Cong', N'.')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'MQ012', N'Xe', N'.')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'MQ013', N'Vé tháng', N'.')
INSERT [dbo].[PhanQuyen] ([MaQuyen], [TenQuyen], [GhiChu]) VALUES (N'MQ014', N'Nhân Viên', N'.')
GO
INSERT [dbo].[PhanQuyen_NhomNguoiDung] ([PQ_NND], [MaQuyen], [MaNhom], [GhiChu]) VALUES (N'PQ_NND001', N'MQ001', N'MN001', NULL)
INSERT [dbo].[PhanQuyen_NhomNguoiDung] ([PQ_NND], [MaQuyen], [MaNhom], [GhiChu]) VALUES (N'PQ_NND002', N'MQ002', N'MN001', NULL)
INSERT [dbo].[PhanQuyen_NhomNguoiDung] ([PQ_NND], [MaQuyen], [MaNhom], [GhiChu]) VALUES (N'PQ_NND003', N'MQ003', N'MN001', NULL)
INSERT [dbo].[PhanQuyen_NhomNguoiDung] ([PQ_NND], [MaQuyen], [MaNhom], [GhiChu]) VALUES (N'PQ_NND004', N'MQ004', N'MN001', NULL)
INSERT [dbo].[PhanQuyen_NhomNguoiDung] ([PQ_NND], [MaQuyen], [MaNhom], [GhiChu]) VALUES (N'PQ_NND005', N'MQ005', N'MN001', NULL)
INSERT [dbo].[PhanQuyen_NhomNguoiDung] ([PQ_NND], [MaQuyen], [MaNhom], [GhiChu]) VALUES (N'PQ_NND006', N'MQ006', N'MN001', NULL)
INSERT [dbo].[PhanQuyen_NhomNguoiDung] ([PQ_NND], [MaQuyen], [MaNhom], [GhiChu]) VALUES (N'PQ_NND010', N'MQ010', N'MN002', NULL)
INSERT [dbo].[PhanQuyen_NhomNguoiDung] ([PQ_NND], [MaQuyen], [MaNhom], [GhiChu]) VALUES (N'PQ_NND011', N'MQ011', N'MN002', NULL)
INSERT [dbo].[PhanQuyen_NhomNguoiDung] ([PQ_NND], [MaQuyen], [MaNhom], [GhiChu]) VALUES (N'PQ_NND012', N'MQ012', N'MN002', N'0')
INSERT [dbo].[PhanQuyen_NhomNguoiDung] ([PQ_NND], [MaQuyen], [MaNhom], [GhiChu]) VALUES (N'PQ_NND013', N'MQ013', N'MN002', N'.')
INSERT [dbo].[PhanQuyen_NhomNguoiDung] ([PQ_NND], [MaQuyen], [MaNhom], [GhiChu]) VALUES (N'PQ_NND014', N'MQ014', N'MN002', NULL)
GO
INSERT [dbo].[The_RFID] ([MaRFIF], [MaLoaiVe], [NgayTao], [NgayCapNhatCuoi], [TrangThai], [TheDangKi]) VALUES (N'5ffae128', N'VETHANG', CAST(N'2020-06-05T00:00:00.000' AS DateTime), CAST(N'2020-06-08T21:34:32.000' AS DateTime), 1, 1)
INSERT [dbo].[The_RFID] ([MaRFIF], [MaLoaiVe], [NgayTao], [NgayCapNhatCuoi], [TrangThai], [TheDangKi]) VALUES (N'a90620a3', N'VETHANG', CAST(N'2020-06-05T00:00:00.000' AS DateTime), CAST(N'2020-06-05T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[The_RFID] ([MaRFIF], [MaLoaiVe], [NgayTao], [NgayCapNhatCuoi], [TrangThai], [TheDangKi]) VALUES (N'd477682a', N'VETHANG', CAST(N'2020-06-05T00:00:00.000' AS DateTime), CAST(N'2020-06-05T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[The_RFID] ([MaRFIF], [MaLoaiVe], [NgayTao], [NgayCapNhatCuoi], [TrangThai], [TheDangKi]) VALUES (N'e70754a3', N'VETHANG', CAST(N'2020-06-05T00:00:00.000' AS DateTime), CAST(N'2020-06-05T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[The_RFID] ([MaRFIF], [MaLoaiVe], [NgayTao], [NgayCapNhatCuoi], [TrangThai], [TheDangKi]) VALUES (N'eb1ace02', N'VETHANG', CAST(N'2020-06-05T00:00:00.000' AS DateTime), CAST(N'2020-06-05T00:00:00.000' AS DateTime), 1, 0)
GO
INSERT [dbo].[TrangThai] ([TrangThai], [Ten]) VALUES (0, N'Chưa ra')
INSERT [dbo].[TrangThai] ([TrangThai], [Ten]) VALUES (1, N'Đã ra')
GO
INSERT [dbo].[VeThang] ([MaVeThang], [MaRFID], [MaXe], [NgayBD], [NgayKT], [NgayTaoVe], [NhanVien], [MayTinh]) VALUES (N'D477682A-02072020-040731', N'd477682a', N'XE001', CAST(N'2020-07-02' AS Date), CAST(N'2020-08-01' AS Date), CAST(N'2020-07-02T00:00:00.000' AS DateTime), N'NV002', N'ADMIN')
INSERT [dbo].[VeThang] ([MaVeThang], [MaRFID], [MaXe], [NgayBD], [NgayKT], [NgayTaoVe], [NhanVien], [MayTinh]) VALUES (N'D477682A-02112020-041127', N'd477682a', N'XE002', CAST(N'2020-07-02' AS Date), CAST(N'2020-08-01' AS Date), CAST(N'2020-07-02T00:00:00.000' AS DateTime), N'NV002', N'ADMIN')
INSERT [dbo].[VeThang] ([MaVeThang], [MaRFID], [MaXe], [NgayBD], [NgayKT], [NgayTaoVe], [NhanVien], [MayTinh]) VALUES (N'D477682A-02422020-054247', N'd477682a', N'XE003', CAST(N'2020-07-02' AS Date), CAST(N'2020-09-01' AS Date), CAST(N'2020-07-02T00:00:00.000' AS DateTime), N'NV002', N'ADMIN')
INSERT [dbo].[VeThang] ([MaVeThang], [MaRFID], [MaXe], [NgayBD], [NgayKT], [NgayTaoVe], [NhanVien], [MayTinh]) VALUES (N'VT001', N'5ffae128', N'XE001', CAST(N'2020-01-01' AS Date), CAST(N'2021-01-01' AS Date), NULL, NULL, NULL)
INSERT [dbo].[VeThang] ([MaVeThang], [MaRFID], [MaXe], [NgayBD], [NgayKT], [NgayTaoVe], [NhanVien], [MayTinh]) VALUES (N'VT002', N'a90620a3', N'XE002', CAST(N'2020-01-01' AS Date), CAST(N'2021-01-01' AS Date), NULL, NULL, NULL)
INSERT [dbo].[VeThang] ([MaVeThang], [MaRFID], [MaXe], [NgayBD], [NgayKT], [NgayTaoVe], [NhanVien], [MayTinh]) VALUES (N'VT003', N'd477682a', N'XE003', CAST(N'2019-01-01' AS Date), CAST(N'2021-01-01' AS Date), NULL, NULL, NULL)
GO
INSERT [dbo].[Xe] ([MaXe], [HinhAnhXe], [BienXo_Xe], [MauSacXe], [MaKH]) VALUES (N'62F2-2269', 0x, N'62F2-2269', N'Nâu den', N'KH001')
INSERT [dbo].[Xe] ([MaXe], [HinhAnhXe], [BienXo_Xe], [MauSacXe], [MaKH]) VALUES (N'XE001', NULL, NULL, NULL, N'KH001')
INSERT [dbo].[Xe] ([MaXe], [HinhAnhXe], [BienXo_Xe], [MauSacXe], [MaKH]) VALUES (N'XE002', NULL, NULL, NULL, N'KH002')
INSERT [dbo].[Xe] ([MaXe], [HinhAnhXe], [BienXo_Xe], [MauSacXe], [MaKH]) VALUES (N'XE003', NULL, NULL, NULL, N'KH003')
GO
INSERT [dbo].[Xe_Vao] ([Ma_Vao], [MaRFIF], [MaGui], [DC], [HinhBX_Vao], [Hinh_N_Vao], [MayTinh_Vao], [MaNV_Vao], [BienSo_Vao], [TG_Vao], [TrangThai], [GhiChu]) VALUES (N'5ffae128-05432020-104312', N'5ffae128', N'fd033dac9bf819c', 62, N'5ffae128-05432020-104312.jpg', N'5ffae128-05432020-104312x.jpg', NULL, N'NV002', NULL, CAST(N'2020-07-05T22:43:13.697' AS DateTime), 0, NULL)
INSERT [dbo].[Xe_Vao] ([Ma_Vao], [MaRFIF], [MaGui], [DC], [HinhBX_Vao], [Hinh_N_Vao], [MayTinh_Vao], [MaNV_Vao], [BienSo_Vao], [TG_Vao], [TrangThai], [GhiChu]) VALUES (N'd477682a-05422020-104255', N'd477682a', N'897df751c2d4e84', 62, N'd477682a-05422020-104255.jpg', N'd477682a-05422020-104255x.jpg', NULL, N'NV002', NULL, CAST(N'2020-07-05T22:42:57.343' AS DateTime), 0, NULL)
INSERT [dbo].[Xe_Vao] ([Ma_Vao], [MaRFIF], [MaGui], [DC], [HinhBX_Vao], [Hinh_N_Vao], [MayTinh_Vao], [MaNV_Vao], [BienSo_Vao], [TG_Vao], [TrangThai], [GhiChu]) VALUES (N'eb1ace02-05432020-104307', N'eb1ace02', N'6383c213f259587', 62, N'eb1ace02-05432020-104307.jpg', N'eb1ace02-05432020-104307x.jpg', NULL, N'NV002', NULL, CAST(N'2020-07-05T22:43:08.587' AS DateTime), 0, NULL)
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
