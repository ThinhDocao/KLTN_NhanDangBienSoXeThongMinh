USE [master]
GO
/****** Object:  Database [Bai_Xe_TM]    Script Date: 7/10/2020 10:17:30 PM ******/
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
/****** Object:  Table [dbo].[The_RFID]    Script Date: 7/10/2020 10:17:30 PM ******/
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
/****** Object:  UserDefinedFunction [dbo].[TEST]    Script Date: 7/10/2020 10:17:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[TEST]()
RETURNS TABLE
AS
	RETURN (SELECT * FROM The_RFID)
GO
/****** Object:  Table [dbo].[CauHinh_Camera]    Script Date: 7/10/2020 10:17:30 PM ******/
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
/****** Object:  Table [dbo].[ChiTietQuyen]    Script Date: 7/10/2020 10:17:30 PM ******/
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
/****** Object:  Table [dbo].[Cong]    Script Date: 7/10/2020 10:17:30 PM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 7/10/2020 10:17:30 PM ******/
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
/****** Object:  Table [dbo].[LoaiVe]    Script Date: 7/10/2020 10:17:30 PM ******/
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
/****** Object:  Table [dbo].[MayTinh]    Script Date: 7/10/2020 10:17:30 PM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 7/10/2020 10:17:30 PM ******/
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
/****** Object:  Table [dbo].[NhanVien_NhomNguoiDung]    Script Date: 7/10/2020 10:17:30 PM ******/
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
/****** Object:  Table [dbo].[NhomNguoiDung]    Script Date: 7/10/2020 10:17:30 PM ******/
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
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 7/10/2020 10:17:30 PM ******/
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
/****** Object:  Table [dbo].[PhanQuyen_NhomNguoiDung]    Script Date: 7/10/2020 10:17:30 PM ******/
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
/****** Object:  Table [dbo].[TrangThai]    Script Date: 7/10/2020 10:17:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThai](
	[TrangThai] [bit] NULL,
	[Ten] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VeThang]    Script Date: 7/10/2020 10:17:30 PM ******/
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
/****** Object:  Table [dbo].[Xe]    Script Date: 7/10/2020 10:17:30 PM ******/
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
/****** Object:  Table [dbo].[Xe_Ra]    Script Date: 7/10/2020 10:17:30 PM ******/
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
/****** Object:  Table [dbo].[Xe_Vao]    Script Date: 7/10/2020 10:17:30 PM ******/
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
