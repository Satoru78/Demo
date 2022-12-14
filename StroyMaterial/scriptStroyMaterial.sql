USE [master]
GO
/****** Object:  Database [StroyMaterials]    Script Date: 22.09.2022 12:38:07 ******/
CREATE DATABASE [StroyMaterials]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StroyMaterials', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVERR\MSSQL\DATA\StroyMaterials.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StroyMaterials_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVERR\MSSQL\DATA\StroyMaterials_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [StroyMaterials] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StroyMaterials].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StroyMaterials] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StroyMaterials] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StroyMaterials] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StroyMaterials] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StroyMaterials] SET ARITHABORT OFF 
GO
ALTER DATABASE [StroyMaterials] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StroyMaterials] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StroyMaterials] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StroyMaterials] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StroyMaterials] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StroyMaterials] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StroyMaterials] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StroyMaterials] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StroyMaterials] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StroyMaterials] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StroyMaterials] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StroyMaterials] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StroyMaterials] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StroyMaterials] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StroyMaterials] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StroyMaterials] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StroyMaterials] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StroyMaterials] SET RECOVERY FULL 
GO
ALTER DATABASE [StroyMaterials] SET  MULTI_USER 
GO
ALTER DATABASE [StroyMaterials] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StroyMaterials] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StroyMaterials] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StroyMaterials] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StroyMaterials] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StroyMaterials] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'StroyMaterials', N'ON'
GO
ALTER DATABASE [StroyMaterials] SET QUERY_STORE = OFF
GO
USE [StroyMaterials]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 22.09.2022 12:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[ID] [int] NOT NULL,
	[OrderCompound] [nvarchar](50) NOT NULL,
	[DateOfOrder] [date] NOT NULL,
	[DateOfDelivery] [date] NOT NULL,
	[PointOfIssue] [nvarchar](50) NOT NULL,
	[ClientName] [nvarchar](50) NULL,
	[Code] [int] NOT NULL,
	[IDOrderStatus] [int] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderProduct]    Script Date: 22.09.2022 12:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderProduct](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDOrder] [int] NOT NULL,
	[IDProduct] [int] NOT NULL,
 CONSTRAINT [PK_OrderProduct] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderStatus]    Script Date: 22.09.2022 12:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderStatus](
	[ID] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_OrderStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 22.09.2022 12:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID] [int] NOT NULL,
	[ArticulNumber] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Unit] [nchar](10) NOT NULL,
	[Count] [money] NOT NULL,
	[Discount] [int] NOT NULL,
	[Manufacturer] [nvarchar](50) NOT NULL,
	[Supplier] [nvarchar](50) NOT NULL,
	[IDProductCategory] [int] NOT NULL,
	[QuantityInStock] [int] NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[Image] [nvarchar](1000) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategory]    Script Date: 22.09.2022 12:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategory](
	[ID] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 22.09.2022 12:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Code] [nchar](1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 22.09.2022 12:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDRole] [nchar](1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Patronymic] [nvarchar](50) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_OrderStatus] FOREIGN KEY([IDOrderStatus])
REFERENCES [dbo].[OrderStatus] ([ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_OrderStatus]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderProduct_Order] FOREIGN KEY([IDOrder])
REFERENCES [dbo].[Order] ([ID])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK_OrderProduct_Order]
GO
ALTER TABLE [dbo].[OrderProduct]  WITH CHECK ADD  CONSTRAINT [FK_OrderProduct_Product] FOREIGN KEY([IDProduct])
REFERENCES [dbo].[Product] ([ID])
GO
ALTER TABLE [dbo].[OrderProduct] CHECK CONSTRAINT [FK_OrderProduct_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_ProductCategory] FOREIGN KEY([IDProductCategory])
REFERENCES [dbo].[ProductCategory] ([ID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_ProductCategory]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([IDRole])
REFERENCES [dbo].[Role] ([Code])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
ALTER DATABASE [StroyMaterials] SET  READ_WRITE 
GO
