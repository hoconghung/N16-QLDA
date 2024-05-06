USE [master]
GO
/****** Object:  Database [NoiThatDatabase]    Script Date: 11/29/2023 1:16:07 AM ******/
CREATE DATABASE [NoiThatDatabase]
GO

USE [NoiThatDatabase]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 11/29/2023 1:16:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[TaiKhoan] [varchar](100) NOT NULL,
	[RoleID] [int] NOT NULL,
	[CreateDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 11/29/2023 1:16:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaCTDH] [int] IDENTITY(1,1) NOT NULL,
	[MaDH] [int] NOT NULL,
	[MaSP] [int] NOT NULL,
	[TongTien] [int] NOT NULL,
	[Ngaygiao] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCTDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMucSP]    Script Date: 11/29/2023 1:16:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucSP](
	[MaDM] [int] IDENTITY(1,1) NOT NULL,
	[TenDM] [nvarchar](200) NOT NULL,
	[AnhDM] [nvarchar](max) NULL,
	[MoTaDM] [nvarchar](500) NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 11/29/2023 1:16:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDH] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [int] NOT NULL,
	[NgayTao] [date] NOT NULL,
	[TrangThaiHuyDon] [bit] NOT NULL,
	[ThanhToan] [bit] NOT NULL,
	[NgayThanhToan] [date] NOT NULL,
	[Note] [nvarchar](max) NULL,
	[TongTien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/29/2023 1:16:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](200) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[AvatarKH] [nvarchar](max) NULL,
	[Diachi] [nvarchar](500) NULL,
	[Ngaysinh] [date] NOT NULL,
	[Phone] [int] NOT NULL,
	[Email] [nvarchar](200) NOT NULL,
	[Password] [varchar](26) NOT NULL,
	[CreateDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanLyShipper]    Script Date: 11/29/2023 1:16:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLyShipper](
	[MaShipper] [int] IDENTITY(1,1) NOT NULL,
	[MaDH] [int] NOT NULL,
	[TenShipper] [nvarchar](100) NOT NULL,
	[NgayLayHang] [date] NOT NULL,
	[Phone] [int] NOT NULL,
	[TenCongty] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaShipper] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleAccount]    Script Date: 11/29/2023 1:16:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleAccount](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](12) NOT NULL,
	[Mota] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 11/29/2023 1:16:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[MaDM] [int] NULL,
	[TenSP] [nvarchar](200) NOT NULL,
	[AnhSP] [nvarchar](max) NOT NULL,
	[VideoSP] [nvarchar](max) NULL,
	[GiaSP] [int] NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[BestSeller] [bit] NOT NULL,
	[CreateDate] [date] NOT NULL,
	[NgaySua] [date] NOT NULL,
	[MotaSP] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinTuc]    Script Date: 11/29/2023 1:16:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinTuc](
	[MaTT] [int] IDENTITY(1,1) NOT NULL,
	[TenTT] [nvarchar](200) NOT NULL,
	[AnhTT] [nvarchar](max) NOT NULL,
	[Motangan] [nvarchar](200) NOT NULL,
	[Motadai] [nvarchar](max) NOT NULL,
	[Tacgia] [nvarchar](100) NOT NULL,
	[CreateDate] [date] NOT NULL,
	[LoaiTin] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrangThaiDH]    Script Date: 11/29/2023 1:16:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThaiDH](
	[MaTTDH] [int] IDENTITY(1,1) NOT NULL,
	[MaDH] [int] NOT NULL,
	[TrangThai] [nvarchar](200) NOT NULL,
	[Mota] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTTDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([AccountID], [TaiKhoan], [RoleID], [CreateDate]) VALUES (2, N'admin@admin.com', 1, CAST(N'2023-11-29' AS Date))
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[DanhMucSP] ON 

INSERT [dbo].[DanhMucSP] ([MaDM], [TenDM], [AnhDM], [MoTaDM], [TrangThai]) VALUES (1, N'Bàn Gỗ', N'https://cdn-icons-png.flaticon.com/128/1663/1663908.png', NULL, 1)
INSERT [dbo].[DanhMucSP] ([MaDM], [TenDM], [AnhDM], [MoTaDM], [TrangThai]) VALUES (2, N'Ghế Gỗ', N'https://cdn-icons-png.flaticon.com/128/2944/2944106.png', NULL, 1)
INSERT [dbo].[DanhMucSP] ([MaDM], [TenDM], [AnhDM], [MoTaDM], [TrangThai]) VALUES (3, N'Giường', N'https://cdn-icons-png.flaticon.com/128/563/563978.png', NULL, 1)
INSERT [dbo].[DanhMucSP] ([MaDM], [TenDM], [AnhDM], [MoTaDM], [TrangThai]) VALUES (4, N'Tủ đồ', N'https://cdn-icons-png.flaticon.com/128/395/395653.png', NULL, 1)
INSERT [dbo].[DanhMucSP] ([MaDM], [TenDM], [AnhDM], [MoTaDM], [TrangThai]) VALUES (5, N'Kệ để đồ', N'https://cdn-icons-png.flaticon.com/128/1750/1750866.png', NULL, 1)
INSERT [dbo].[DanhMucSP] ([MaDM], [TenDM], [AnhDM], [MoTaDM], [TrangThai]) VALUES (6, N'Kệ treo đồ', N'https://cdn-icons-png.flaticon.com/128/7155/7155381.png', NULL, 1)
SET IDENTITY_INSERT [dbo].[DanhMucSP] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [GioiTinh], [AvatarKH], [Diachi], [Ngaysinh], [Phone], [Email], [Password], [CreateDate]) VALUES (2, N'Admin', N'Nam', NULL, N'Hà Nội', CAST(N'2023-11-29' AS Date), 3242342, N'admin@admin.com', N'123456', CAST(N'2023-11-29' AS Date))
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[RoleAccount] ON 

INSERT [dbo].[RoleAccount] ([RoleID], [RoleName], [Mota]) VALUES (1, N'Admin', N'Quản Lý')
INSERT [dbo].[RoleAccount] ([RoleID], [RoleName], [Mota]) VALUES (2, N'Staff', N'Nhân Viên')
INSERT [dbo].[RoleAccount] ([RoleID], [RoleName], [Mota]) VALUES (3, N'User', N'Người dùng')
SET IDENTITY_INSERT [dbo].[RoleAccount] OFF
GO
USE [master]
GO
ALTER DATABASE [NoiThatDatabase] SET  READ_WRITE 
GO
