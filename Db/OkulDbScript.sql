USE [master]
GO
/****** Object:  Database [OkulDb]    Script Date: 27.03.2024 14:33:17 ******/
CREATE DATABASE [OkulDb] ON  PRIMARY 
( NAME = N'OkulDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\OkulDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OkulDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\OkulDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OkulDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OkulDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OkulDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OkulDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OkulDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OkulDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [OkulDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OkulDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OkulDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OkulDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OkulDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OkulDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OkulDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OkulDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OkulDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OkulDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OkulDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OkulDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OkulDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OkulDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OkulDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OkulDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OkulDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OkulDb] SET RECOVERY FULL 
GO
ALTER DATABASE [OkulDb] SET  MULTI_USER 
GO
ALTER DATABASE [OkulDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OkulDb] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'OkulDb', N'ON'
GO
USE [OkulDb]
GO
/****** Object:  Table [dbo].[Adresler]    Script Date: 27.03.2024 14:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adresler](
	[AdresID] [int] IDENTITY(1,1) NOT NULL,
	[Sehir] [varchar](50) NULL,
	[Ilce] [varchar](50) NULL,
	[CaddeSokak] [varchar](50) NULL,
	[KapiNo] [varchar](50) NULL,
	[OgrenciId] [int] NULL,
 CONSTRAINT [PK_Adresler] PRIMARY KEY CLUSTERED 
(
	[AdresID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Branslar]    Script Date: 27.03.2024 14:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Branslar](
	[BransID] [int] IDENTITY(1,1) NOT NULL,
	[Brans] [nvarchar](20) NOT NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Branslar] PRIMARY KEY CLUSTERED 
(
	[BransID] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenciler]    Script Date: 27.03.2024 14:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenciler](
	[OgrenciID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [char](20) NULL,
	[Soyad] [varchar](50) NULL,
	[Sehir] [nvarchar](50) NULL,
	[Cinsiyet] [bit] NULL,
	[TcNo] [varchar](11) NULL,
	[Gsm] [varchar](15) NULL,
	[DogumTarihi] [date] NULL,
	[SinifID] [int] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Ogrenciler] PRIMARY KEY CLUSTERED 
(
	[OgrenciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogretmenler]    Script Date: 27.03.2024 14:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogretmenler](
	[OgretmenID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [char](20) NULL,
	[Soyad] [varchar](50) NULL,
	[Sehir] [nvarchar](50) NULL,
	[Cinsiyet] [bit] NULL,
	[TcNo] [varchar](11) NULL,
	[Gsm] [varchar](15) NULL,
	[DogumTarihi] [date] NULL,
	[BransId] [int] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Ogretmenler] PRIMARY KEY CLUSTERED 
(
	[OgretmenID] DESC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siniflar]    Script Date: 27.03.2024 14:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siniflar](
	[SinifId] [int] IDENTITY(1,1) NOT NULL,
	[SinifAdi] [varchar](50) NOT NULL,
	[Kapasite] [smallint] NULL,
 CONSTRAINT [PK_Siniflar] PRIMARY KEY CLUSTERED 
(
	[SinifId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yoklama]    Script Date: 27.03.2024 14:33:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yoklama](
	[YoklamaId] [int] IDENTITY(1,1) NOT NULL,
	[YoklamaTarihi] [datetime] NOT NULL,
	[OgrenciId] [int] NOT NULL,
	[SinifID] [int] NOT NULL,
	[BransId] [int] NOT NULL,
	[OgretmenId] [int] NOT NULL,
	[Katilim] [bit] NULL,
 CONSTRAINT [PK_Yoklama] PRIMARY KEY CLUSTERED 
(
	[YoklamaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Branslar] ON 
GO
INSERT [dbo].[Branslar] ([BransID], [Brans], [CreateDate]) VALUES (10, N'Kimya', CAST(N'2024-03-26T17:50:33.907' AS DateTime))
GO
INSERT [dbo].[Branslar] ([BransID], [Brans], [CreateDate]) VALUES (9, N'Edebiyat', CAST(N'2024-03-26T17:50:28.703' AS DateTime))
GO
INSERT [dbo].[Branslar] ([BransID], [Brans], [CreateDate]) VALUES (8, N'Muzik', CAST(N'2024-03-26T17:50:25.923' AS DateTime))
GO
INSERT [dbo].[Branslar] ([BransID], [Brans], [CreateDate]) VALUES (7, N'Fizik', CAST(N'2024-03-26T17:50:23.723' AS DateTime))
GO
INSERT [dbo].[Branslar] ([BransID], [Brans], [CreateDate]) VALUES (6, N'Matematik', CAST(N'2024-03-26T17:50:21.513' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Branslar] OFF
GO
SET IDENTITY_INSERT [dbo].[Ogrenciler] ON 
GO
INSERT [dbo].[Ogrenciler] ([OgrenciID], [Ad], [Soyad], [Sehir], [Cinsiyet], [TcNo], [Gsm], [DogumTarihi], [SinifID], [CreateDate]) VALUES (1, N'Ali                 ', N'?????', N'يلماز', 0, N'12345678901', NULL, NULL, 1, CAST(N'2024-03-26T16:34:34.813' AS DateTime))
GO
INSERT [dbo].[Ogrenciler] ([OgrenciID], [Ad], [Soyad], [Sehir], [Cinsiyet], [TcNo], [Gsm], [DogumTarihi], [SinifID], [CreateDate]) VALUES (2, N'Veli 1234567890     ', N'12345678901234567890123456789012345678901234567890', N'Йылмаз', 1, NULL, NULL, NULL, 2, CAST(N'2024-03-26T16:38:07.347' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Ogrenciler] OFF
GO
SET IDENTITY_INSERT [dbo].[Ogretmenler] ON 
GO
INSERT [dbo].[Ogretmenler] ([OgretmenID], [Ad], [Soyad], [Sehir], [Cinsiyet], [TcNo], [Gsm], [DogumTarihi], [BransId], [CreateDate]) VALUES (2, N'Ali                 ', N'Yilmaz', N'Van', 0, N'123123', NULL, NULL, 7, NULL)
GO
INSERT [dbo].[Ogretmenler] ([OgretmenID], [Ad], [Soyad], [Sehir], [Cinsiyet], [TcNo], [Gsm], [DogumTarihi], [BransId], [CreateDate]) VALUES (1, N'Ayse                ', N'Kaya', N'Istanbul', 1, N'123123', N'532 444 55 66', CAST(N'2015-01-01' AS Date), 7, CAST(N'2024-03-26T17:06:30.777' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Ogretmenler] OFF
GO
SET IDENTITY_INSERT [dbo].[Siniflar] ON 
GO
INSERT [dbo].[Siniflar] ([SinifId], [SinifAdi], [Kapasite]) VALUES (1, N'10A', 40)
GO
INSERT [dbo].[Siniflar] ([SinifId], [SinifAdi], [Kapasite]) VALUES (2, N'10B', 35)
GO
INSERT [dbo].[Siniflar] ([SinifId], [SinifAdi], [Kapasite]) VALUES (3, N'10C', 30)
GO
SET IDENTITY_INSERT [dbo].[Siniflar] OFF
GO
SET IDENTITY_INSERT [dbo].[Yoklama] ON 
GO
INSERT [dbo].[Yoklama] ([YoklamaId], [YoklamaTarihi], [OgrenciId], [SinifID], [BransId], [OgretmenId], [Katilim]) VALUES (1, CAST(N'2023-10-10T00:00:00.000' AS DateTime), 1, 1, 6, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[Yoklama] OFF
GO
/****** Object:  Index [IX_Yoklama]    Script Date: 27.03.2024 14:33:17 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Yoklama] ON [dbo].[Yoklama]
(
	[YoklamaTarihi] ASC,
	[OgrenciId] ASC,
	[BransId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Branslar] ADD  CONSTRAINT [KayitOlusmaTarihi]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Ogrenciler] ADD  CONSTRAINT [DF_Ogrenciler_CreateDate]  DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Yoklama] ADD  CONSTRAINT [DF_Yoklama_Katilim]  DEFAULT ((0)) FOR [Katilim]
GO
ALTER TABLE [dbo].[Adresler]  WITH CHECK ADD  CONSTRAINT [FK_Adresler_Ogrenciler] FOREIGN KEY([OgrenciId])
REFERENCES [dbo].[Ogrenciler] ([OgrenciID])
GO
ALTER TABLE [dbo].[Adresler] CHECK CONSTRAINT [FK_Adresler_Ogrenciler]
GO
ALTER TABLE [dbo].[Ogrenciler]  WITH CHECK ADD  CONSTRAINT [FK_Ogrenciler_Siniflar] FOREIGN KEY([SinifID])
REFERENCES [dbo].[Siniflar] ([SinifId])
GO
ALTER TABLE [dbo].[Ogrenciler] CHECK CONSTRAINT [FK_Ogrenciler_Siniflar]
GO
ALTER TABLE [dbo].[Ogretmenler]  WITH CHECK ADD  CONSTRAINT [FK_Ogretmenler_Branslar1] FOREIGN KEY([BransId])
REFERENCES [dbo].[Branslar] ([BransID])
GO
ALTER TABLE [dbo].[Ogretmenler] CHECK CONSTRAINT [FK_Ogretmenler_Branslar1]
GO
ALTER TABLE [dbo].[Yoklama]  WITH CHECK ADD  CONSTRAINT [FK_Yoklama_Branslar] FOREIGN KEY([BransId])
REFERENCES [dbo].[Branslar] ([BransID])
GO
ALTER TABLE [dbo].[Yoklama] CHECK CONSTRAINT [FK_Yoklama_Branslar]
GO
ALTER TABLE [dbo].[Yoklama]  WITH CHECK ADD  CONSTRAINT [FK_Yoklama_Ogrenciler] FOREIGN KEY([OgrenciId])
REFERENCES [dbo].[Ogrenciler] ([OgrenciID])
GO
ALTER TABLE [dbo].[Yoklama] CHECK CONSTRAINT [FK_Yoklama_Ogrenciler]
GO
ALTER TABLE [dbo].[Yoklama]  WITH CHECK ADD  CONSTRAINT [FK_Yoklama_Ogretmenler] FOREIGN KEY([OgretmenId])
REFERENCES [dbo].[Ogretmenler] ([OgretmenID])
GO
ALTER TABLE [dbo].[Yoklama] CHECK CONSTRAINT [FK_Yoklama_Ogretmenler]
GO
ALTER TABLE [dbo].[Yoklama]  WITH CHECK ADD  CONSTRAINT [FK_Yoklama_Siniflar] FOREIGN KEY([SinifID])
REFERENCES [dbo].[Siniflar] ([SinifId])
GO
ALTER TABLE [dbo].[Yoklama] CHECK CONSTRAINT [FK_Yoklama_Siniflar]
GO
USE [master]
GO
ALTER DATABASE [OkulDb] SET  READ_WRITE 
GO
