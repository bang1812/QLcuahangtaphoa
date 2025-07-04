USE [master]
GO
/****** Object:  Database [QuanLyTapHoa]    Script Date: 12/2/2023 6:42:15 PM ******/
CREATE DATABASE [QuanLyTapHoa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyTapHoa', FILENAME = N'D:\file_download\SQL server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyTapHoa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyTapHoa_log', FILENAME = N'D:\file_download\SQL server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyTapHoa_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLyTapHoa] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyTapHoa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyTapHoa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyTapHoa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyTapHoa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyTapHoa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyTapHoa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyTapHoa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyTapHoa] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyTapHoa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyTapHoa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyTapHoa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyTapHoa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyTapHoa] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyTapHoa] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyTapHoa] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLyTapHoa] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLyTapHoa]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 12/2/2023 6:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[SoHD] [nvarchar](50) NULL,
	[MaHang] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 12/2/2023 6:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHang] [nvarchar](50) NOT NULL,
	[MaLoai] [nvarchar](50) NOT NULL,
	[TenHang] [nvarchar](50) NOT NULL,
	[DonVi] [nvarchar](50) NOT NULL,
	[DonGia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/2/2023 6:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[SoHD] [nvarchar](50) NOT NULL,
	[NgayBan] [nvarchar](50) NOT NULL,
	[MaKH] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[TongTien] [float] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/2/2023 6:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[DienThoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiHang]    Script Date: 12/2/2023 6:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHang](
	[MaLoai] [nvarchar](50) NOT NULL,
	[TenLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiHang] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/2/2023 6:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[Quyen] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CTHD] ON 

INSERT [dbo].[CTHD] ([STT], [SoHD], [MaHang], [SoLuong], [DonGia]) VALUES (12, N'HDTT2', N'BK04', 3, 15000)
INSERT [dbo].[CTHD] ([STT], [SoHD], [MaHang], [SoLuong], [DonGia]) VALUES (13, N'HDTT3', N'BK02', 3, 15000)
INSERT [dbo].[CTHD] ([STT], [SoHD], [MaHang], [SoLuong], [DonGia]) VALUES (14, N'HDTT4', N'BK04', 4, 15000)
INSERT [dbo].[CTHD] ([STT], [SoHD], [MaHang], [SoLuong], [DonGia]) VALUES (15, N'', N'BK04', 3, 15000)
INSERT [dbo].[CTHD] ([STT], [SoHD], [MaHang], [SoLuong], [DonGia]) VALUES (16, N'HDTT5', N'TP02', 4, 10000)
SET IDENTITY_INSERT [dbo].[CTHD] OFF
GO
INSERT [dbo].[HangHoa] ([MaHang], [MaLoai], [TenHang], [DonVi], [DonGia]) VALUES (N'BK01', N'TP', N'Bánh kem', N'chiếc', N'150000')
INSERT [dbo].[HangHoa] ([MaHang], [MaLoai], [TenHang], [DonVi], [DonGia]) VALUES (N'BK02', N'BK', N'Kẹo sữa', N'gói', N'15000')
INSERT [dbo].[HangHoa] ([MaHang], [MaLoai], [TenHang], [DonVi], [DonGia]) VALUES (N'BK04', N'BK', N'Chip chip', N'gói', N'15000')
INSERT [dbo].[HangHoa] ([MaHang], [MaLoai], [TenHang], [DonVi], [DonGia]) VALUES (N'D02', N'DDD', N'điện tử', N'chiếc', N'650000')
INSERT [dbo].[HangHoa] ([MaHang], [MaLoai], [TenHang], [DonVi], [DonGia]) VALUES (N'DT01', N'DT', N'Điện thoại ', N'chiếc', N'2500000')
INSERT [dbo].[HangHoa] ([MaHang], [MaLoai], [TenHang], [DonVi], [DonGia]) VALUES (N'LTP', N'DT', N'Laptop Asus', N'chiếc', N'3500000')
INSERT [dbo].[HangHoa] ([MaHang], [MaLoai], [TenHang], [DonVi], [DonGia]) VALUES (N'TL', N'DDD', N'Tủ lạnh Panasonic', N'chiếc', N'1500000')
INSERT [dbo].[HangHoa] ([MaHang], [MaLoai], [TenHang], [DonVi], [DonGia]) VALUES (N'TP02', N'TP', N'Mỳ', N'gói', N'10000')
INSERT [dbo].[HangHoa] ([MaHang], [MaLoai], [TenHang], [DonVi], [DonGia]) VALUES (N'TP03', N'TP', N'Miến', N'gói', N'20000')
GO
INSERT [dbo].[HoaDon] ([SoHD], [NgayBan], [MaKH], [MaNV], [TongTien]) VALUES (N'', N'12/2/2023 6:40:07 PM', N'KHTT01', N'NV01', 45000)
INSERT [dbo].[HoaDon] ([SoHD], [NgayBan], [MaKH], [MaNV], [TongTien]) VALUES (N'HDDL1', N'11/27/2023 11:07:57 AM', N'KHDL01', N'NV01', 70450000)
INSERT [dbo].[HoaDon] ([SoHD], [NgayBan], [MaKH], [MaNV], [TongTien]) VALUES (N'HDDL2', N'11/27/2023 11:08:00 AM', N'KHDL01', N'NV01', 70450000)
INSERT [dbo].[HoaDon] ([SoHD], [NgayBan], [MaKH], [MaNV], [TongTien]) VALUES (N'HDDL3', N'11/27/2023 11:08:01 AM', N'KHDL01', N'NV01', 70450000)
INSERT [dbo].[HoaDon] ([SoHD], [NgayBan], [MaKH], [MaNV], [TongTien]) VALUES (N'HDDL4', N'11/27/2023 11:08:03 AM', N'KHDL01', N'NV01', 70450000)
INSERT [dbo].[HoaDon] ([SoHD], [NgayBan], [MaKH], [MaNV], [TongTien]) VALUES (N'HDDL5', N'11/27/2023 11:08:03 AM', N'KHDL01', N'NV01', 70450000)
INSERT [dbo].[HoaDon] ([SoHD], [NgayBan], [MaKH], [MaNV], [TongTien]) VALUES (N'HDDL7', N'11/29/2023 10:44:43 PM', N'KHDL01', N'NV01', 0)
INSERT [dbo].[HoaDon] ([SoHD], [NgayBan], [MaKH], [MaNV], [TongTien]) VALUES (N'HDDL8', N'11/29/2023 10:45:04 PM', N'KHDL01', N'NV01', 0)
INSERT [dbo].[HoaDon] ([SoHD], [NgayBan], [MaKH], [MaNV], [TongTien]) VALUES (N'HDTT1', N'11/28/2023 8:42:08 PM', N'KHTT02', N'NV01', 0)
INSERT [dbo].[HoaDon] ([SoHD], [NgayBan], [MaKH], [MaNV], [TongTien]) VALUES (N'HDTT2', N'11/30/2023 8:50:45 AM', N'KHTT01', N'NV01', 45000)
INSERT [dbo].[HoaDon] ([SoHD], [NgayBan], [MaKH], [MaNV], [TongTien]) VALUES (N'HDTT3', N'11/30/2023 8:53:09 AM', N'KHTT02', N'NV02', 45000)
INSERT [dbo].[HoaDon] ([SoHD], [NgayBan], [MaKH], [MaNV], [TongTien]) VALUES (N'HDTT4', N'11/30/2023 9:05:59 AM', N'KHTT02', N'NV02', 60000)
INSERT [dbo].[HoaDon] ([SoHD], [NgayBan], [MaKH], [MaNV], [TongTien]) VALUES (N'HDTT5', N'12/2/2023 6:40:48 PM', N'KHTT02', N'NV01', 40000)
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [Email], [DienThoai]) VALUES (N'KHDL01', N'Vũ Hồng Quân', N'Thanh Hóa', N'quan@gmail.com', N'01457895')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [Email], [DienThoai]) VALUES (N'KHDL02', N' Nguyễn Thị Hương', N'Nam Định', N'huong@gmail.com', N'0147896325')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [Email], [DienThoai]) VALUES (N'KHDL03', N'Lương Việt Hoàng', N'Bắc Giang', N'lvh@gmail.com', N'456789')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [Email], [DienThoai]) VALUES (N'KHTT01', N'Nguyễn Minh Văn', N'Hà Nam', N'van@gmail.com', N'01579854')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [Email], [DienThoai]) VALUES (N'KHTT02', N'Vũ Hồng Quân', N'Thanh Hóa', N'quan@gmail.com', N'015478')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [DiaChi], [Email], [DienThoai]) VALUES (N'KHTT03', N'Đặng Tiến Thành', N'Hà Tây', N'Thanh@gmail.com', N'01245978')
GO
INSERT [dbo].[LoaiHang] ([MaLoai], [TenLoai]) VALUES (N'BK', N'Bánh kẹo')
INSERT [dbo].[LoaiHang] ([MaLoai], [TenLoai]) VALUES (N'DC', N'Đồ chơi')
INSERT [dbo].[LoaiHang] ([MaLoai], [TenLoai]) VALUES (N'DDD', N'Điện dân dụng')
INSERT [dbo].[LoaiHang] ([MaLoai], [TenLoai]) VALUES (N'DT', N'Điện tử')
INSERT [dbo].[LoaiHang] ([MaLoai], [TenLoai]) VALUES (N'TP', N'Thực phẩm')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [DiaChi], [MatKhau], [Quyen]) VALUES (N'NV01', N'Đặng Tiến Thành', N'Hà Tây', N'123', N'ep')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [DiaChi], [MatKhau], [Quyen]) VALUES (N'NV02', N'Vũ Hồng Quân', N'Thanh Hóa', N'admin', N'admin')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [DiaChi], [MatKhau], [Quyen]) VALUES (N'NV03', N'Lương Việt Hoàng', N'Bắc Giang', N'admin', N'admin')
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HangHoa] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_HangHoa]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HoaDon] FOREIGN KEY([SoHD])
REFERENCES [dbo].[HoaDon] ([SoHD])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_HoaDon]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_LoaiHang1] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiHang] ([MaLoai])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_LoaiHang1]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
/****** Object:  StoredProcedure [dbo].[_checkRoles]    Script Date: 12/2/2023 6:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[_checkRoles]
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM RoleAccess WHERE roles = 'admin')
        SELECT 1 AS Result;
    ELSE
        SELECT 0 AS Result;
END
GO
/****** Object:  StoredProcedure [dbo].[CheckLogin]    Script Date: 12/2/2023 6:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CheckLogin]
    @Username VARCHAR(50),
    @Password VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM NhanVien WHERE MaNV = @Username AND MatKhau = @Password)
        SELECT 1 AS Result;
    ELSE
        SELECT 0 AS Result;
END
GO
/****** Object:  StoredProcedure [dbo].[CheckRole]    Script Date: 12/2/2023 6:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CheckRole]
    @Username VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
	SELECT Quyen FROM NhanVien WHERE MaNV = @Username
END
GO
/****** Object:  StoredProcedure [dbo].[CheckRoles]    Script Date: 12/2/2023 6:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CheckRoles]
    @Roles VARCHAR(50),
    @Password VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM RoleAccess WHERE roles = 'admin')
        SELECT 1 AS Result;
    ELSE
        SELECT 0 AS Result;
END
GO
/****** Object:  StoredProcedure [dbo].[getHangHoaData]    Script Date: 12/2/2023 6:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getHangHoaData]
AS
BEGIN
   -- Câu lệnh SELECT để lấy dữ liệu từ các bảng
   SELECT 
      HangHoa.MaHang,
	  LoaiHang.TenLoai,
	  HangHoa.TenHang,
	  HangHoa.DonGia,
	  HangHoa.DonVi

   FROM 
      HangHoa
 
   INNER JOIN LoaiHang ON HangHoa.MaLoai = LoaiHang.MaLoai
END
GO
/****** Object:  StoredProcedure [dbo].[getHoaDonData]    Script Date: 12/2/2023 6:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getHoaDonData]
AS
BEGIN
   -- Câu lệnh SELECT để lấy dữ liệu từ các bảng
   SELECT 
      HoaDon.SoHD,
	  KhachHang.TenKH,
	  HangHoa.TenHang,
	  CTHD.SoLuong,
	  CTHD.DonGia,
	  HoaDon.MaNV
   FROM 
      HoaDon
 
   INNER JOIN CTHD ON CTHD.SoHD = HoaDon.SoHD
   INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH
   INNER JOIN HangHoa ON CTHD.MaHang = HangHoa.MaHang
END
GO
/****** Object:  StoredProcedure [dbo].[SavePermission]    Script Date: 12/2/2023 6:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SavePermission]
    @Username VARCHAR(50),
    @Permission VARCHAR(50),
    @DateTime DATETIME
AS
BEGIN
    INSERT INTO AccessPermission (Username, Permission, DateTime)
    VALUES (@Username, @Permission, @DateTime)
END
GO
/****** Object:  StoredProcedure [dbo].[ThanhTien]    Script Date: 12/2/2023 6:42:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[ThanhTien] 
@SoHD VARCHAR(50)
as
Begin
Select sum(CTHD.SoLuong*CTHD.DonGia) as Result from CTHD  where CTHD.SoHD = @SoHD group by CTHD.SoHD
End
GO
USE [master]
GO
ALTER DATABASE [QuanLyTapHoa] SET  READ_WRITE 
GO
