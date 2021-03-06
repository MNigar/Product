USE [master]
GO
/****** Object:  Database [ProductContext]    Script Date: 5/22/2021 12:19:35 PM ******/
CREATE DATABASE [ProductContext]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProductContext', FILENAME = N'D:\sql\MSSQL15.ADMIN\MSSQL\DATA\ProductContext.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProductContext_log', FILENAME = N'D:\sql\MSSQL15.ADMIN\MSSQL\DATA\ProductContext_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProductContext] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProductContext].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProductContext] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProductContext] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProductContext] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProductContext] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProductContext] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProductContext] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProductContext] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProductContext] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProductContext] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProductContext] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProductContext] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProductContext] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProductContext] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProductContext] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProductContext] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProductContext] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProductContext] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProductContext] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProductContext] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProductContext] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProductContext] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ProductContext] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProductContext] SET RECOVERY FULL 
GO
ALTER DATABASE [ProductContext] SET  MULTI_USER 
GO
ALTER DATABASE [ProductContext] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProductContext] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProductContext] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProductContext] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProductContext] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProductContext', N'ON'
GO
ALTER DATABASE [ProductContext] SET QUERY_STORE = OFF
GO
USE [ProductContext]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/22/2021 12:19:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 5/22/2021 12:19:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 5/22/2021 12:19:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Author] [nvarchar](max) NULL,
	[CategoryId] [uniqueidentifier] NOT NULL,
	[PageCount] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[UserId] [uniqueidentifier] NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[ModifyUserId] [uniqueidentifier] NULL,
	[UpdatedDate] [datetime2](7) NULL,
	[PublishingHouse] [nvarchar](max) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubHeaders]    Script Date: 5/22/2021 12:19:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubHeaders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_SubHeaders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 5/22/2021 12:19:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210516130129_addedd', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210517072133_nullable', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210518121448_created date', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210518192837_added fields', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210519065030_Added migration', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210521062125_Added new field', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210521124905_Added Subheader', N'2.1.14-servicing-32113')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210521135614_data annotaionss', N'2.1.14-servicing-32113')
INSERT [dbo].[Categories] ([Id], [Name], [Status], [Image]) VALUES (N'5aa66755-324f-4c9e-b466-4430e048be4b', N'Science', 0, N'20210522081244_hand-drawn-science-education-background_23-2148494536.jpg')
INSERT [dbo].[Categories] ([Id], [Name], [Status], [Image]) VALUES (N'83416276-d81b-467e-a51d-57ab00ab2ecf', N'detective', 1, N'20210521121924_images.jpg')
INSERT [dbo].[Categories] ([Id], [Name], [Status], [Image]) VALUES (N'eda738bc-0b56-49c2-8526-60e7b8ad652d', N'Detective', 0, N'20210522081041_20210519154837_21l-310f06.jpg')
INSERT [dbo].[Categories] ([Id], [Name], [Status], [Image]) VALUES (N'6bef23bb-32f8-4d42-8428-894c973c5e1d', N'Classics', 0, N'20210522081125__20210519161210_classic_literature_512x382.png')
INSERT [dbo].[Categories] ([Id], [Name], [Status], [Image]) VALUES (N'72f3a409-41f8-4d15-b927-e0b1f8eba182', N'Nigar', 1, N'20210522102527_book_open_pages_215165.jpg')
INSERT [dbo].[Categories] ([Id], [Name], [Status], [Image]) VALUES (N'53481c26-0a66-4c9e-874c-f00333e44e05', N'bedii', 1, NULL)
INSERT [dbo].[Products] ([Id], [Name], [Author], [CategoryId], [PageCount], [Image], [Status], [UserId], [CreatedDate], [Description], [ModifyUserId], [UpdatedDate], [PublishingHouse]) VALUES (N'd0c1aa74-0fad-449e-9420-1f221b2fb80f', N'The Last Flight', N'Julie Clark', N'5aa66755-324f-4c9e-b466-4430e048be4b', N'288', N'20210522083132_9781728234229_p0_v3_s600x595.jpg', 0, N'0fa25e1f-2c3e-49e0-be94-08d91c98e35c', CAST(N'2021-05-22T08:35:16.0670397' AS DateTime2), N'"Thoroughly absorbing—not only because of its tantalizing plot and deft pacing, but also because of its unexpected poignancy and its satisfying, if bittersweet, resolution. The characters get under your skin." - THE NEW YORK TIMES BOOK REVIEWj', NULL, NULL, N'Sourcebooks')
INSERT [dbo].[Products] ([Id], [Name], [Author], [CategoryId], [PageCount], [Image], [Status], [UserId], [CreatedDate], [Description], [ModifyUserId], [UpdatedDate], [PublishingHouse]) VALUES (N'7255c476-921d-4d7a-bfaf-7e70643cf1f4', N'eser2', N'yazici2', N'83416276-d81b-467e-a51d-57ab00ab2ecf', N'1234', N'20210521134308_631730201ed1a5b20ddd491f50.jpeg', 1, N'0fa25e1f-2c3e-49e0-be94-08d91c98e35c', CAST(N'2021-05-21T13:43:08.5848852' AS DateTime2), N'kujtrhytgevfrcdx', NULL, NULL, NULL)
INSERT [dbo].[Products] ([Id], [Name], [Author], [CategoryId], [PageCount], [Image], [Status], [UserId], [CreatedDate], [Description], [ModifyUserId], [UpdatedDate], [PublishingHouse]) VALUES (N'b7159240-9af7-4615-9d22-c4ba792d148e', N'Nigar', N'yazici1', N'5aa66755-324f-4c9e-b466-4430e048be4b', N'sss', N'20210522121718_631730201ed1a5b20ddd491f50.jpeg', 3, N'0fa25e1f-2c3e-49e0-be94-08d91c98e35c', CAST(N'2021-05-22T12:17:18.1438178' AS DateTime2), N'ffff', NULL, NULL, N'fff')
INSERT [dbo].[Products] ([Id], [Name], [Author], [CategoryId], [PageCount], [Image], [Status], [UserId], [CreatedDate], [Description], [ModifyUserId], [UpdatedDate], [PublishingHouse]) VALUES (N'b771a3eb-d11f-4b7a-af6a-ccd31ab089ff', N'sss', N'sss', N'5aa66755-324f-4c9e-b466-4430e048be4b', N'sss', N'20210522115120__20210518103003_631730201ed1a5b20ddd491f50.jpeg', 3, N'0fa25e1f-2c3e-49e0-be94-08d91c98e35c', CAST(N'2021-05-22T11:51:20.8585215' AS DateTime2), N'sss', NULL, NULL, N'sss')
INSERT [dbo].[Products] ([Id], [Name], [Author], [CategoryId], [PageCount], [Image], [Status], [UserId], [CreatedDate], [Description], [ModifyUserId], [UpdatedDate], [PublishingHouse]) VALUES (N'17a6f671-434a-4d50-9c7b-cfc319740f9e', N'The First Day of Spring', N'Nancy Tucker', N'5aa66755-324f-4c9e-b466-4430e048be4b', N'352', N'20210522081925_9780593191569_p0_v2_s550x406.jpg', 0, N'0fa25e1f-2c3e-49e0-be94-08d91c98e35c', CAST(N'2021-05-22T08:19:25.1174093' AS DateTime2), N'British author Tucker (The Time in Between: A Memoir of Hunger and Hope) makes a spectacular fiction debut with this gripping novel about childhood pain and healing. Eight-year-old Chrissie Banks’s father rarely comes home, while her mother dislikes her. Chrissie lies, steals, brags, and bullies other children in her working-class neighborhood to get the food anssd attention she craves. ', N'0fa25e1f-2c3e-49e0-be94-08d91c98e35c', CAST(N'2021-05-22T09:23:52.2102230' AS DateTime2), N'Penguin Publishing Group')
INSERT [dbo].[Products] ([Id], [Name], [Author], [CategoryId], [PageCount], [Image], [Status], [UserId], [CreatedDate], [Description], [ModifyUserId], [UpdatedDate], [PublishingHouse]) VALUES (N'7087a0af-8356-4b74-8801-d3ff38791177', N'eser1', N'yazici1', N'53481c26-0a66-4c9e-874c-f00333e44e05', N'1234', N'20210521134241_images.jpg', 1, N'0fa25e1f-2c3e-49e0-be94-08d91c98e35c', CAST(N'2021-05-21T13:42:42.0014436' AS DateTime2), N'jthrtgrghrbgthrnhbgv', NULL, NULL, NULL)
INSERT [dbo].[Products] ([Id], [Name], [Author], [CategoryId], [PageCount], [Image], [Status], [UserId], [CreatedDate], [Description], [ModifyUserId], [UpdatedDate], [PublishingHouse]) VALUES (N'8c426a47-97b6-4631-8d53-f707d515bae7', N'Unsettled Ground', N'Claire Fuller ', N'eda738bc-0b56-49c2-8526-60e7b8ad652d', N'330', N'20210522083516_20210520154551_9781951142483.jpg', 2, N'0fa25e1f-2c3e-49e0-be94-08d91c98e35c', CAST(N'2021-05-22T08:35:16.0670397' AS DateTime2), N'At fifty-one years old, twins Jeanie and Julius still live with their mother, Dot, in rural isolation in the English co,kkuntryside. The cottage they have shared their entire lives is their only protection against the modernizing ttworld around them. Inside its walls, they make music, and in its garden, they grow everything they need to survive. To an outsider, it looks like poverty; to them, it is home.', N'0fa25e1f-2c3e-49e0-be94-08d91c98e35c', CAST(N'2021-05-22T09:49:18.6312598' AS DateTime2), N'Tin House Books')
SET IDENTITY_INSERT [dbo].[SubHeaders] ON 

INSERT [dbo].[SubHeaders] ([Id], [Image]) VALUES (1, N'20210522075629_thumb-1920-26102.jpg')
SET IDENTITY_INSERT [dbo].[SubHeaders] OFF
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Email], [Password], [Status]) VALUES (N'0fa25e1f-2c3e-49e0-be94-08d91c98e35c', N'Nigar', N'Mammadova', N'nigarmammadova4t@gmail.com', N'AEfsXAbLLj5ChjMuSNQWiI4l25VU4P6IlyTmR2Ea36fQfERGkxgIAAK/9OF+rLe1lg==', 0)
INSERT [dbo].[Users] ([Id], [Name], [Surname], [Email], [Password], [Status]) VALUES (N'74c07d7f-8d4e-4c49-13d0-08d91d4dc62d', N'admin', N'admin', N'admin@gmail.com', N'AJLaG0ga5H4Hn/AiuAPz1dRbMhtRnHjphWf0tNy0eIo2Zq5deEX4upiYVCOkN7c50A==', 0)
/****** Object:  Index [IX_Products_CategoryId]    Script Date: 5/22/2021 12:19:35 PM ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId] ON [dbo].[Products]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_UserId]    Script Date: 5/22/2021 12:19:35 PM ******/
CREATE NONCLUSTERED INDEX [IX_Products_UserId] ON [dbo].[Products]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [ProductContext] SET  READ_WRITE 
GO
