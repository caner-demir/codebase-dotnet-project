USE [master]
GO
/****** Object:  Database [Layered]    Script Date: 7/24/2022 7:09:13 PM ******/
CREATE DATABASE Layered
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Layered', FILENAME = N'C:\Users\Caner Demir\Layered.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Layered_log', FILENAME = N'C:\Users\Caner Demir\Layered.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Layered] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Layered].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Layered] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Layered] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Layered] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Layered] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Layered] SET ARITHABORT OFF 
GO
ALTER DATABASE [Layered] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Layered] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Layered] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Layered] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Layered] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Layered] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Layered] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Layered] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Layered] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Layered] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Layered] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Layered] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Layered] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Layered] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Layered] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Layered] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Layered] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Layered] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Layered] SET  MULTI_USER 
GO
ALTER DATABASE [Layered] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Layered] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Layered] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Layered] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Layered] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Layered] SET QUERY_STORE = OFF
GO
USE [Layered]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Layered]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/24/2022 7:09:13 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerProducts]    Script Date: 7/24/2022 7:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerProducts](
	[CustomerId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_CustomerProducts] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC,
	[ProductId] ASC,
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 7/24/2022 7:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 7/24/2022 7:09:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[IsAvailable] [bit] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220721232925_Initial', N'6.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220722153209_Migration2', N'6.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220722153338_Migration3', N'6.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220722160129_Migration4', N'6.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220722161211_Migration5', N'6.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220722181529_Migration6', N'6.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220723221502_Migration7', N'6.0.7')
GO
INSERT [dbo].[CustomerProducts] ([CustomerId], [ProductId], [Date], [Quantity]) VALUES (1, 2, CAST(N'2022-07-23T16:20:24.6219928' AS DateTime2), 15)
INSERT [dbo].[CustomerProducts] ([CustomerId], [ProductId], [Date], [Quantity]) VALUES (1, 2, CAST(N'2022-07-23T16:25:09.8213250' AS DateTime2), 5)
INSERT [dbo].[CustomerProducts] ([CustomerId], [ProductId], [Date], [Quantity]) VALUES (2, 1, CAST(N'2022-07-24T07:18:44.4437617' AS DateTime2), 5)
INSERT [dbo].[CustomerProducts] ([CustomerId], [ProductId], [Date], [Quantity]) VALUES (2, 4, CAST(N'2022-07-24T19:02:54.9730774' AS DateTime2), 1)
INSERT [dbo].[CustomerProducts] ([CustomerId], [ProductId], [Date], [Quantity]) VALUES (3, 3, CAST(N'2022-07-24T19:06:36.5456025' AS DateTime2), 5)
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [Name]) VALUES (1, N'Öykü Özbey')
INSERT [dbo].[Customers] ([Id], [Name]) VALUES (2, N'Toros Kubilay')
INSERT [dbo].[Customers] ([Id], [Name]) VALUES (3, N'Eser Gönül')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [Quantity], [Price], [IsAvailable]) VALUES (1, N'Şampuan', 95, 30, 1)
INSERT [dbo].[Products] ([Id], [Name], [Quantity], [Price], [IsAvailable]) VALUES (2, N'Su', 140, 10, 1)
INSERT [dbo].[Products] ([Id], [Name], [Quantity], [Price], [IsAvailable]) VALUES (3, N'Elma', 45, 10, 1)
INSERT [dbo].[Products] ([Id], [Name], [Quantity], [Price], [IsAvailable]) VALUES (4, N'LCD TV', 9, 8000, 1)
INSERT [dbo].[Products] ([Id], [Name], [Quantity], [Price], [IsAvailable]) VALUES (5, N'Laptop', 15, 12000, 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
/****** Object:  Index [IX_CustomerProducts_ProductId]    Script Date: 7/24/2022 7:09:13 PM ******/
CREATE NONCLUSTERED INDEX [IX_CustomerProducts_ProductId] ON [dbo].[CustomerProducts]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CustomerProducts] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [Date]
GO
ALTER TABLE [dbo].[CustomerProducts] ADD  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Customers] ADD  DEFAULT (N'') FOR [Name]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT (N'') FOR [Name]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [Price]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsAvailable]
GO
ALTER TABLE [dbo].[CustomerProducts]  WITH CHECK ADD  CONSTRAINT [FK_CustomerProducts_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerProducts] CHECK CONSTRAINT [FK_CustomerProducts_Customers_CustomerId]
GO
ALTER TABLE [dbo].[CustomerProducts]  WITH CHECK ADD  CONSTRAINT [FK_CustomerProducts_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerProducts] CHECK CONSTRAINT [FK_CustomerProducts_Products_ProductId]
GO
USE [master]
GO
ALTER DATABASE [Layered] SET  READ_WRITE 
GO
