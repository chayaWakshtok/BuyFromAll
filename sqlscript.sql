USE [master]
GO
/****** Object:  Database [buyfromall]    Script Date: 26/07/2020 21:39:38 ******/
CREATE DATABASE [buyfromall]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'buyfromall', FILENAME = N'C:\Users\user\buyfromall.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'buyfromall_log', FILENAME = N'C:\Users\user\buyfromall_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [buyfromall] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [buyfromall].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [buyfromall] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [buyfromall] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [buyfromall] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [buyfromall] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [buyfromall] SET ARITHABORT OFF 
GO
ALTER DATABASE [buyfromall] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [buyfromall] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [buyfromall] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [buyfromall] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [buyfromall] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [buyfromall] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [buyfromall] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [buyfromall] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [buyfromall] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [buyfromall] SET  DISABLE_BROKER 
GO
ALTER DATABASE [buyfromall] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [buyfromall] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [buyfromall] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [buyfromall] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [buyfromall] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [buyfromall] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [buyfromall] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [buyfromall] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [buyfromall] SET  MULTI_USER 
GO
ALTER DATABASE [buyfromall] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [buyfromall] SET DB_CHAINING OFF 
GO
ALTER DATABASE [buyfromall] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [buyfromall] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [buyfromall] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [buyfromall] SET QUERY_STORE = OFF
GO
USE [buyfromall]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [buyfromall]
GO
/****** Object:  Table [dbo].[baskets]    Script Date: 26/07/2020 21:39:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[baskets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemChildId] [int] NULL,
	[Count] [int] NULL,
	[UserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[brands]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[brands](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](45) NOT NULL,
	[Description] [varchar](100) NULL,
	[ImageUrl] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](45) NOT NULL,
	[Description] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[category_features]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category_features](
	[FeatureId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_category_features] PRIMARY KEY CLUSTERED 
(
	[FeatureId] ASC,
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cities]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](50) NULL,
 CONSTRAINT [PK__cities__3214EC078281EBC7] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[colors]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[colors](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ColorName] [varchar](45) NOT NULL,
	[RgbColor] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customers]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](45) NULL,
	[Email] [varchar](45) NULL,
	[Phone] [varchar](45) NULL,
	[Fax] [varchar](45) NULL,
	[Image] [varchar](45) NULL,
	[Description] [varchar](45) NULL,
	[Status] [smallint] NULL,
	[Stars] [int] NULL,
	[CreationDate] [varchar](45) NULL,
	[UserName] [varchar](45) NULL,
	[Password] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customers_sites]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers_sites](
	[CustomerId] [int] NOT NULL,
	[SiteId] [int] NOT NULL,
 CONSTRAINT [PK_customers_sites] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC,
	[SiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[features]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[features](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[images]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[images](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImageSrc] [varchar](max) NULL,
	[ImageUrl] [varchar](200) NULL,
	[ItemChildId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[item_categories]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item_categories](
	[SubCategoryId] [int] NOT NULL,
	[ItemId] [int] NOT NULL,
 CONSTRAINT [PK_item_categories] PRIMARY KEY CLUSTERED 
(
	[SubCategoryId] ASC,
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[item_features]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[item_features](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[FeatureId] [int] NULL,
	[Value] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[items]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[items](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Barcode] [varchar](45) NOT NULL,
	[CustomerId] [int] NULL,
	[SiteId] [int] NULL,
	[BrandId] [int] NULL,
	[ManufacturerId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[items_child]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[items_child](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](45) NOT NULL,
	[Description] [varchar](max) NULL,
	[Stars] [float] NULL,
	[VatId] [int] NULL,
	[Price] [float] NULL,
	[PresentLess] [float] NULL,
	[ColorId] [int] NULL,
	[Count] [int] NULL,
	[Barcode] [varchar](45) NULL,
	[ParentItemId] [int] NULL,
	[ShippingPrice] [float] NULL,
	[Status] [smallint] NULL,
	[ShippingDescription] [varchar](max) NULL,
	[ReturnDescription] [varchar](max) NULL,
	[TimeShipping] [varchar](20) NULL,
	[CreationDate] [datetime2](0) NULL,
	[UnitsStock] [int] NULL,
	[SizeId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[manufacturers]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[manufacturers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[materials]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materials](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](45) NOT NULL,
	[LoaziName] [varchar](45) NULL,
	[Description] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order_items]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_items](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemChildId] [int] NOT NULL,
	[Count] [int] NULL,
	[Price] [float] NULL,
	[Status] [int] NULL,
	[OrderId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ShippingId] [int] NULL,
	[UserId] [int] NOT NULL,
	[TotalPrice] [float] NULL,
	[Status] [int] NULL,
	[Paid] [smallint] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[payments]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[payments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TransactionId] [varchar](45) NULL,
	[OrderId] [int] NULL,
	[Date] [datetime2](0) NULL,
	[Type] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[search]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[search](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DateSearch] [datetime2](0) NOT NULL,
	[UserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[search_features]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[search_features](
	[FeatureId] [int] NOT NULL,
	[SearchId] [int] NOT NULL,
 CONSTRAINT [PK_search_features] PRIMARY KEY CLUSTERED 
(
	[FeatureId] ASC,
	[SearchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[shipping]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[shipping](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](45) NULL,
	[Status] [int] NULL,
	[ShippingDate] [datetime2](0) NULL,
	[CreationDate] [datetime2](0) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sites]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sites](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](45) NULL,
	[Description] [varchar](200) NULL,
	[Website] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sizes]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sizes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Size] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sub_categories]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sub_categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](45) NOT NULL,
	[Description] [varchar](100) NULL,
	[CategoryId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Comment]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Comment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Comment] [nvarchar](100) NULL,
	[Date] [datetime] NULL,
	[Rate] [int] NULL,
	[UserId] [int] NULL,
	[ItemChildId] [int] NULL,
 CONSTRAINT [PK_User_Comment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](45) NULL,
	[Email] [varchar](45) NULL,
	[FirstName] [varchar](45) NULL,
	[LastName] [varchar](45) NULL,
	[Phone] [varchar](12) NULL,
	[Tell] [varchar](12) NULL,
	[Password] [varchar](45) NULL,
	[Street] [varchar](45) NULL,
	[HouseNumber] [varchar](45) NULL,
	[Flat] [int] NULL,
	[Code] [varchar](45) NULL,
	[Fax] [varchar](12) NULL,
	[CityId] [int] NULL,
	[Image] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vat]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vat](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](45) NULL,
	[Description] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[wish_list]    Script Date: 26/07/2020 21:39:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[wish_list](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ItemChildId] [int] NULL,
	[UserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[brands] ON 

INSERT [dbo].[brands] ([Id], [Name], [Description], [ImageUrl]) VALUES (1, N'Apple', N'Apple', N'https://specials-images.forbesimg.com/imageserve/5c13d14731358e5b4339c564/832x832.jpg?background=000000&cropX1=0&cropX2=416&cropY1=0&cropY2=416')
INSERT [dbo].[brands] ([Id], [Name], [Description], [ImageUrl]) VALUES (2, N'	Google', N'	Google', N'https://specials-images.forbesimg.com/imageserve/5b92924ba7ea434b99d5a09b/832x832.jpg?background=000000&cropX1=0&cropX2=416&cropY1=0&cropY2=416')
INSERT [dbo].[brands] ([Id], [Name], [Description], [ImageUrl]) VALUES (3, N'Intel', N'Intel', N'https://specials-images.forbesimg.com/imageserve/5c13d2d431358e5b4339c5d0/832x832.jpg?background=000000&cropX1=0&cropX2=416&cropY1=0&cropY2=416')
SET IDENTITY_INSERT [dbo].[brands] OFF
SET IDENTITY_INSERT [dbo].[categories] ON 

INSERT [dbo].[categories] ([Id], [Name], [Description]) VALUES (1, N'dress', N'dresses')
SET IDENTITY_INSERT [dbo].[categories] OFF
SET IDENTITY_INSERT [dbo].[cities] ON 

INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (1, N'bnei brak', N'israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (2, N'Tel Aviv Jaffa', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (3, N'Safed (Tsefat)', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (4, N'Tel-Hai', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (5, N'Ramla', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (6, N'Peki’in', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (7, N'Hertzeliya', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (8, N'Gush Halav', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (9, N'Neveh Shalom - Wahat al-Salam', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (10, N'Ashkelon', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (11, N'Beit Shean', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (12, N'Cana', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (13, N'Jatt', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (14, N'Rehaniya', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (15, N'Degania', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (16, N'Eilat', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (17, N'Jerusalem', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (18, N'Nazareth', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (19, N'Haifa', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (20, N'Zikhron Ya’akov', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (21, N'Arad', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (22, N'Netanya', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (23, N'Nahariya', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (24, N'Kfar Tavor', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (25, N'Hebron', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (26, N'Kinneret (Moshava)', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (27, N'Holon', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (28, N'Bat Shlomo', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (29, N'Bnei Brak', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (30, N'The Uvda Valley and Eilat Mountains', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (31, N'The Negev Desert', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (32, N'The Lowlands', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (33, N'Abu Snan', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (34, N'Julis', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (35, N'Maghar', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (36, N'Samia', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (37, N'Ein al-Assad', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (38, N'Isfiya', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (39, N'Caesarea (Keysarya)', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (40, N'Be''er Sheva', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (41, N'Sde Boker', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (42, N'Yad Moredechai', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (43, N'Rosh-Pina', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (44, N'Kiryat Shmona', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (45, N'Ein Gedi', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (46, N'Ein-Hod', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (47, N'Kfar Nakhum', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (48, N'Hazor Haglilit', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (49, N'Metula', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (50, N'Harduf', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (51, N'Ashdod', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (52, N'Kfar Kama', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (53, N'Abu Gosh', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (54, N'Jezreel Valley', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (55, N'The Coastal Plain', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (56, N'The Judean Desert', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (57, N'The Jerusalem Hills', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (58, N'Sea of Galilee (Lake Kineret)', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (59, N'Beit Jann', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (60, N'Sajur', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (61, N'Rameh', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (62, N'Daliyat El-Carmel', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (63, N'The Golan Heights', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (64, N'Tiberias', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (65, N'Mitspe Ramon', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (66, N'Acre (Akko)', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (67, N'Katzerin', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (68, N'Nahalal', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (69, N'Kfar Yasif', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (70, N'Hanita', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (71, N'Ma''alot Tarshiha', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (72, N'Bethlehem of the Galilee', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (73, N'Bat Yam', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (74, N'The Hula Valley', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (75, N'Hevel Habsor', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (76, N'The Arava', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (77, N'The Galilee', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (78, N'The Dan Region (Gush Dan)', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (79, N'The Nitzana Region', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (80, N'Yanuh', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (81, N'Yarka', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (82, N'Kisra', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (83, N'Hurfeish', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (84, N'Shefa-''Amr', N'Israel')
INSERT [dbo].[cities] ([Id], [CityName], [Country]) VALUES (85, N'The Dead Sea', N'Israel')
SET IDENTITY_INSERT [dbo].[cities] OFF
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([Id], [UserName], [Email], [FirstName], [LastName], [Phone], [Tell], [Password], [Street], [HouseNumber], [Flat], [Code], [Fax], [CityId], [Image]) VALUES (1, N'chaya', N'c0556777462@gmail.com', N'chaya', N'wax', N'036181376', N'0556777462', N'207322', N'Hirsh', N'15', 3, N'51510', NULL, 29, NULL)
INSERT [dbo].[users] ([Id], [UserName], [Email], [FirstName], [LastName], [Phone], [Tell], [Password], [Street], [HouseNumber], [Flat], [Code], [Fax], [CityId], [Image]) VALUES (2, N'chaya', N'c0556777462@gmail.com', N'chaya', N'wachsstock', NULL, NULL, N'207322868', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[users] OFF
/****** Object:  Index [Item11_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [Item11_idx] ON [dbo].[baskets]
(
	[ItemChildId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UserFK12_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [UserFK12_idx] ON [dbo].[baskets]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Cate1_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [Cate1_idx] ON [dbo].[category_features]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Fea1_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [Fea1_idx] ON [dbo].[category_features]
(
	[FeatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CustomerFK_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [CustomerFK_idx] ON [dbo].[customers_sites]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [SiteFK_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [SiteFK_idx] ON [dbo].[customers_sites]
(
	[SiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ChildFK1_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [ChildFK1_idx] ON [dbo].[images]
(
	[ItemChildId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [item1FK_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [item1FK_idx] ON [dbo].[item_categories]
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Sub1FK_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [Sub1FK_idx] ON [dbo].[item_categories]
(
	[SubCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [FeatureFK33_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [FeatureFK33_idx] ON [dbo].[item_features]
(
	[FeatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ItemFK22_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [ItemFK22_idx] ON [dbo].[item_features]
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [BrandFK_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [BrandFK_idx] ON [dbo].[items]
(
	[BrandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CustomerIdFK_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [CustomerIdFK_idx] ON [dbo].[items]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ManufacturerFK_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [ManufacturerFK_idx] ON [dbo].[items]
(
	[ManufacturerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [SiteFk_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [SiteFk_idx] ON [dbo].[items]
(
	[SiteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ColorFK_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [ColorFK_idx] ON [dbo].[items_child]
(
	[ColorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ParentFK_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [ParentFK_idx] ON [dbo].[items_child]
(
	[ParentItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [SizeFK_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [SizeFK_idx] ON [dbo].[items_child]
(
	[SizeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [VatFK_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [VatFK_idx] ON [dbo].[items_child]
(
	[VatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ItemFK11_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [ItemFK11_idx] ON [dbo].[order_items]
(
	[ItemChildId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [OrderFK_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [OrderFK_idx] ON [dbo].[order_items]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [ShippingFK11_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [ShippingFK11_idx] ON [dbo].[orders]
(
	[ShippingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [userFK1_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [userFK1_idx] ON [dbo].[orders]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [OrderFK111_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [OrderFK111_idx] ON [dbo].[payments]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [User22_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [User22_idx] ON [dbo].[search]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [featureFF1_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [featureFF1_idx] ON [dbo].[search_features]
(
	[FeatureId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [SearchFK1_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [SearchFK1_idx] ON [dbo].[search_features]
(
	[SearchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CategoryFK_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [CategoryFK_idx] ON [dbo].[sub_categories]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [CityFK_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [CityFK_idx] ON [dbo].[users]
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [Child2_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [Child2_idx] ON [dbo].[wish_list]
(
	[ItemChildId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [User22_idx]    Script Date: 26/07/2020 21:39:43 ******/
CREATE NONCLUSTERED INDEX [User22_idx] ON [dbo].[wish_list]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[baskets] ADD  DEFAULT (NULL) FOR [ItemChildId]
GO
ALTER TABLE [dbo].[baskets] ADD  DEFAULT (NULL) FOR [Count]
GO
ALTER TABLE [dbo].[baskets] ADD  DEFAULT (NULL) FOR [UserId]
GO
ALTER TABLE [dbo].[brands] ADD  DEFAULT (NULL) FOR [Description]
GO
ALTER TABLE [dbo].[categories] ADD  DEFAULT (NULL) FOR [Description]
GO
ALTER TABLE [dbo].[category_features] ADD  CONSTRAINT [DF__category___Featu__607251E5]  DEFAULT (NULL) FOR [FeatureId]
GO
ALTER TABLE [dbo].[category_features] ADD  CONSTRAINT [DF__category___Categ__6166761E]  DEFAULT (NULL) FOR [CategoryId]
GO
ALTER TABLE [dbo].[cities] ADD  CONSTRAINT [DF__cities__Country__239E4DCF]  DEFAULT (NULL) FOR [Country]
GO
ALTER TABLE [dbo].[colors] ADD  DEFAULT (NULL) FOR [RgbColor]
GO
ALTER TABLE [dbo].[customers] ADD  DEFAULT (NULL) FOR [Name]
GO
ALTER TABLE [dbo].[customers] ADD  DEFAULT (NULL) FOR [Email]
GO
ALTER TABLE [dbo].[customers] ADD  DEFAULT (NULL) FOR [Phone]
GO
ALTER TABLE [dbo].[customers] ADD  DEFAULT (NULL) FOR [Fax]
GO
ALTER TABLE [dbo].[customers] ADD  DEFAULT (NULL) FOR [Image]
GO
ALTER TABLE [dbo].[customers] ADD  DEFAULT (NULL) FOR [Description]
GO
ALTER TABLE [dbo].[customers] ADD  DEFAULT (NULL) FOR [Status]
GO
ALTER TABLE [dbo].[customers] ADD  DEFAULT (NULL) FOR [Stars]
GO
ALTER TABLE [dbo].[customers] ADD  DEFAULT (NULL) FOR [CreationDate]
GO
ALTER TABLE [dbo].[customers] ADD  DEFAULT (NULL) FOR [UserName]
GO
ALTER TABLE [dbo].[customers] ADD  DEFAULT (NULL) FOR [Password]
GO
ALTER TABLE [dbo].[customers_sites] ADD  CONSTRAINT [DF__customers__Custo__5AB9788F]  DEFAULT (NULL) FOR [CustomerId]
GO
ALTER TABLE [dbo].[customers_sites] ADD  CONSTRAINT [DF__customers__SiteI__5BAD9CC8]  DEFAULT (NULL) FOR [SiteId]
GO
ALTER TABLE [dbo].[images] ADD  DEFAULT (NULL) FOR [ImageUrl]
GO
ALTER TABLE [dbo].[images] ADD  DEFAULT (NULL) FOR [ItemChildId]
GO
ALTER TABLE [dbo].[item_features] ADD  DEFAULT (NULL) FOR [ItemId]
GO
ALTER TABLE [dbo].[item_features] ADD  DEFAULT (NULL) FOR [FeatureId]
GO
ALTER TABLE [dbo].[item_features] ADD  DEFAULT (NULL) FOR [Value]
GO
ALTER TABLE [dbo].[items] ADD  DEFAULT (NULL) FOR [CustomerId]
GO
ALTER TABLE [dbo].[items] ADD  DEFAULT (NULL) FOR [SiteId]
GO
ALTER TABLE [dbo].[items] ADD  DEFAULT (NULL) FOR [BrandId]
GO
ALTER TABLE [dbo].[items] ADD  DEFAULT (NULL) FOR [ManufacturerId]
GO
ALTER TABLE [dbo].[items_child] ADD  DEFAULT ('0') FOR [Stars]
GO
ALTER TABLE [dbo].[items_child] ADD  DEFAULT (NULL) FOR [VatId]
GO
ALTER TABLE [dbo].[items_child] ADD  DEFAULT (NULL) FOR [Price]
GO
ALTER TABLE [dbo].[items_child] ADD  DEFAULT (NULL) FOR [PresentLess]
GO
ALTER TABLE [dbo].[items_child] ADD  DEFAULT (NULL) FOR [ColorId]
GO
ALTER TABLE [dbo].[items_child] ADD  DEFAULT (NULL) FOR [Count]
GO
ALTER TABLE [dbo].[items_child] ADD  DEFAULT (NULL) FOR [Barcode]
GO
ALTER TABLE [dbo].[items_child] ADD  DEFAULT (NULL) FOR [ParentItemId]
GO
ALTER TABLE [dbo].[items_child] ADD  DEFAULT (NULL) FOR [ShippingPrice]
GO
ALTER TABLE [dbo].[items_child] ADD  DEFAULT (NULL) FOR [Status]
GO
ALTER TABLE [dbo].[items_child] ADD  DEFAULT (NULL) FOR [TimeShipping]
GO
ALTER TABLE [dbo].[items_child] ADD  DEFAULT (NULL) FOR [CreationDate]
GO
ALTER TABLE [dbo].[items_child] ADD  DEFAULT (NULL) FOR [UnitsStock]
GO
ALTER TABLE [dbo].[items_child] ADD  DEFAULT (NULL) FOR [SizeId]
GO
ALTER TABLE [dbo].[materials] ADD  DEFAULT (NULL) FOR [LoaziName]
GO
ALTER TABLE [dbo].[materials] ADD  DEFAULT (NULL) FOR [Description]
GO
ALTER TABLE [dbo].[order_items] ADD  DEFAULT ('1') FOR [Count]
GO
ALTER TABLE [dbo].[order_items] ADD  DEFAULT (NULL) FOR [Price]
GO
ALTER TABLE [dbo].[order_items] ADD  DEFAULT (NULL) FOR [Status]
GO
ALTER TABLE [dbo].[order_items] ADD  DEFAULT (NULL) FOR [OrderId]
GO
ALTER TABLE [dbo].[orders] ADD  DEFAULT (NULL) FOR [ShippingId]
GO
ALTER TABLE [dbo].[orders] ADD  DEFAULT (NULL) FOR [TotalPrice]
GO
ALTER TABLE [dbo].[orders] ADD  DEFAULT (NULL) FOR [Status]
GO
ALTER TABLE [dbo].[orders] ADD  DEFAULT (NULL) FOR [Paid]
GO
ALTER TABLE [dbo].[payments] ADD  DEFAULT (NULL) FOR [TransactionId]
GO
ALTER TABLE [dbo].[payments] ADD  DEFAULT (NULL) FOR [OrderId]
GO
ALTER TABLE [dbo].[payments] ADD  DEFAULT (NULL) FOR [Date]
GO
ALTER TABLE [dbo].[payments] ADD  DEFAULT (NULL) FOR [Type]
GO
ALTER TABLE [dbo].[search] ADD  DEFAULT (NULL) FOR [UserId]
GO
ALTER TABLE [dbo].[search_features] ADD  CONSTRAINT [DF__search_fe__Featu__114A936A]  DEFAULT (NULL) FOR [FeatureId]
GO
ALTER TABLE [dbo].[search_features] ADD  CONSTRAINT [DF__search_fe__Searc__123EB7A3]  DEFAULT (NULL) FOR [SearchId]
GO
ALTER TABLE [dbo].[shipping] ADD  DEFAULT (NULL) FOR [Description]
GO
ALTER TABLE [dbo].[shipping] ADD  DEFAULT ('1') FOR [Status]
GO
ALTER TABLE [dbo].[shipping] ADD  DEFAULT (NULL) FOR [ShippingDate]
GO
ALTER TABLE [dbo].[shipping] ADD  DEFAULT (NULL) FOR [CreationDate]
GO
ALTER TABLE [dbo].[sites] ADD  DEFAULT (NULL) FOR [Name]
GO
ALTER TABLE [dbo].[sites] ADD  DEFAULT (NULL) FOR [Description]
GO
ALTER TABLE [dbo].[sites] ADD  DEFAULT (NULL) FOR [Website]
GO
ALTER TABLE [dbo].[sub_categories] ADD  DEFAULT (NULL) FOR [Description]
GO
ALTER TABLE [dbo].[sub_categories] ADD  DEFAULT (NULL) FOR [CategoryId]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (NULL) FOR [UserName]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (NULL) FOR [Email]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (NULL) FOR [FirstName]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (NULL) FOR [LastName]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (NULL) FOR [Phone]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (NULL) FOR [Tell]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (NULL) FOR [Password]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (NULL) FOR [Street]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (NULL) FOR [HouseNumber]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (NULL) FOR [Flat]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (NULL) FOR [Code]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (NULL) FOR [Fax]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (NULL) FOR [CityId]
GO
ALTER TABLE [dbo].[vat] ADD  DEFAULT (NULL) FOR [Name]
GO
ALTER TABLE [dbo].[vat] ADD  DEFAULT (NULL) FOR [Description]
GO
ALTER TABLE [dbo].[wish_list] ADD  DEFAULT (NULL) FOR [ItemChildId]
GO
ALTER TABLE [dbo].[wish_list] ADD  DEFAULT (NULL) FOR [UserId]
GO
ALTER TABLE [dbo].[baskets]  WITH CHECK ADD  CONSTRAINT [Item11] FOREIGN KEY([ItemChildId])
REFERENCES [dbo].[items_child] ([Id])
GO
ALTER TABLE [dbo].[baskets] CHECK CONSTRAINT [Item11]
GO
ALTER TABLE [dbo].[baskets]  WITH CHECK ADD  CONSTRAINT [UserFK12] FOREIGN KEY([UserId])
REFERENCES [dbo].[users] ([Id])
GO
ALTER TABLE [dbo].[baskets] CHECK CONSTRAINT [UserFK12]
GO
ALTER TABLE [dbo].[category_features]  WITH CHECK ADD  CONSTRAINT [Cate1] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[categories] ([Id])
GO
ALTER TABLE [dbo].[category_features] CHECK CONSTRAINT [Cate1]
GO
ALTER TABLE [dbo].[category_features]  WITH CHECK ADD  CONSTRAINT [Fea1] FOREIGN KEY([FeatureId])
REFERENCES [dbo].[features] ([Id])
GO
ALTER TABLE [dbo].[category_features] CHECK CONSTRAINT [Fea1]
GO
ALTER TABLE [dbo].[customers_sites]  WITH CHECK ADD  CONSTRAINT [CustomerFK] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[customers] ([Id])
GO
ALTER TABLE [dbo].[customers_sites] CHECK CONSTRAINT [CustomerFK]
GO
ALTER TABLE [dbo].[customers_sites]  WITH CHECK ADD  CONSTRAINT [SiteFK] FOREIGN KEY([SiteId])
REFERENCES [dbo].[sites] ([Id])
GO
ALTER TABLE [dbo].[customers_sites] CHECK CONSTRAINT [SiteFK]
GO
ALTER TABLE [dbo].[images]  WITH CHECK ADD  CONSTRAINT [ChildFK1] FOREIGN KEY([ItemChildId])
REFERENCES [dbo].[items_child] ([Id])
GO
ALTER TABLE [dbo].[images] CHECK CONSTRAINT [ChildFK1]
GO
ALTER TABLE [dbo].[item_categories]  WITH CHECK ADD  CONSTRAINT [item1FK] FOREIGN KEY([ItemId])
REFERENCES [dbo].[items] ([Id])
GO
ALTER TABLE [dbo].[item_categories] CHECK CONSTRAINT [item1FK]
GO
ALTER TABLE [dbo].[item_categories]  WITH CHECK ADD  CONSTRAINT [Sub1FK] FOREIGN KEY([SubCategoryId])
REFERENCES [dbo].[sub_categories] ([Id])
GO
ALTER TABLE [dbo].[item_categories] CHECK CONSTRAINT [Sub1FK]
GO
ALTER TABLE [dbo].[item_features]  WITH CHECK ADD  CONSTRAINT [FeatureFK33] FOREIGN KEY([FeatureId])
REFERENCES [dbo].[features] ([Id])
GO
ALTER TABLE [dbo].[item_features] CHECK CONSTRAINT [FeatureFK33]
GO
ALTER TABLE [dbo].[item_features]  WITH CHECK ADD  CONSTRAINT [ItemFK22] FOREIGN KEY([ItemId])
REFERENCES [dbo].[items] ([Id])
GO
ALTER TABLE [dbo].[item_features] CHECK CONSTRAINT [ItemFK22]
GO
ALTER TABLE [dbo].[items]  WITH CHECK ADD  CONSTRAINT [BrandFK] FOREIGN KEY([BrandId])
REFERENCES [dbo].[brands] ([Id])
GO
ALTER TABLE [dbo].[items] CHECK CONSTRAINT [BrandFK]
GO
ALTER TABLE [dbo].[items]  WITH CHECK ADD  CONSTRAINT [CustomerIdFK] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[customers] ([Id])
GO
ALTER TABLE [dbo].[items] CHECK CONSTRAINT [CustomerIdFK]
GO
ALTER TABLE [dbo].[items]  WITH CHECK ADD  CONSTRAINT [ManufacturerFK] FOREIGN KEY([ManufacturerId])
REFERENCES [dbo].[manufacturers] ([Id])
GO
ALTER TABLE [dbo].[items] CHECK CONSTRAINT [ManufacturerFK]
GO
ALTER TABLE [dbo].[items]  WITH CHECK ADD  CONSTRAINT [SiteFk1] FOREIGN KEY([SiteId])
REFERENCES [dbo].[sites] ([Id])
GO
ALTER TABLE [dbo].[items] CHECK CONSTRAINT [SiteFk1]
GO
ALTER TABLE [dbo].[items_child]  WITH CHECK ADD  CONSTRAINT [ColorFK] FOREIGN KEY([ColorId])
REFERENCES [dbo].[colors] ([Id])
GO
ALTER TABLE [dbo].[items_child] CHECK CONSTRAINT [ColorFK]
GO
ALTER TABLE [dbo].[items_child]  WITH CHECK ADD  CONSTRAINT [ParentFK] FOREIGN KEY([ParentItemId])
REFERENCES [dbo].[items] ([Id])
GO
ALTER TABLE [dbo].[items_child] CHECK CONSTRAINT [ParentFK]
GO
ALTER TABLE [dbo].[items_child]  WITH CHECK ADD  CONSTRAINT [SizeFK] FOREIGN KEY([SizeId])
REFERENCES [dbo].[sizes] ([Id])
GO
ALTER TABLE [dbo].[items_child] CHECK CONSTRAINT [SizeFK]
GO
ALTER TABLE [dbo].[items_child]  WITH CHECK ADD  CONSTRAINT [VatFK] FOREIGN KEY([VatId])
REFERENCES [dbo].[vat] ([Id])
GO
ALTER TABLE [dbo].[items_child] CHECK CONSTRAINT [VatFK]
GO
ALTER TABLE [dbo].[order_items]  WITH CHECK ADD  CONSTRAINT [ItemFK11] FOREIGN KEY([ItemChildId])
REFERENCES [dbo].[items_child] ([Id])
GO
ALTER TABLE [dbo].[order_items] CHECK CONSTRAINT [ItemFK11]
GO
ALTER TABLE [dbo].[order_items]  WITH CHECK ADD  CONSTRAINT [OrderFK] FOREIGN KEY([OrderId])
REFERENCES [dbo].[orders] ([Id])
GO
ALTER TABLE [dbo].[order_items] CHECK CONSTRAINT [OrderFK]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [ShippingFK11] FOREIGN KEY([ShippingId])
REFERENCES [dbo].[shipping] ([Id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [ShippingFK11]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [userFK1] FOREIGN KEY([UserId])
REFERENCES [dbo].[users] ([Id])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [userFK1]
GO
ALTER TABLE [dbo].[payments]  WITH CHECK ADD  CONSTRAINT [OrderFK111] FOREIGN KEY([OrderId])
REFERENCES [dbo].[orders] ([Id])
GO
ALTER TABLE [dbo].[payments] CHECK CONSTRAINT [OrderFK111]
GO
ALTER TABLE [dbo].[search]  WITH CHECK ADD  CONSTRAINT [User23] FOREIGN KEY([UserId])
REFERENCES [dbo].[users] ([Id])
GO
ALTER TABLE [dbo].[search] CHECK CONSTRAINT [User23]
GO
ALTER TABLE [dbo].[search_features]  WITH CHECK ADD  CONSTRAINT [featureFF1] FOREIGN KEY([FeatureId])
REFERENCES [dbo].[features] ([Id])
GO
ALTER TABLE [dbo].[search_features] CHECK CONSTRAINT [featureFF1]
GO
ALTER TABLE [dbo].[search_features]  WITH CHECK ADD  CONSTRAINT [SearchFK1] FOREIGN KEY([SearchId])
REFERENCES [dbo].[search] ([Id])
GO
ALTER TABLE [dbo].[search_features] CHECK CONSTRAINT [SearchFK1]
GO
ALTER TABLE [dbo].[sub_categories]  WITH CHECK ADD  CONSTRAINT [CategoryFK] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[categories] ([Id])
GO
ALTER TABLE [dbo].[sub_categories] CHECK CONSTRAINT [CategoryFK]
GO
ALTER TABLE [dbo].[User_Comment]  WITH CHECK ADD  CONSTRAINT [FK_User_Comment_User_Comment] FOREIGN KEY([ItemChildId])
REFERENCES [dbo].[items_child] ([Id])
GO
ALTER TABLE [dbo].[User_Comment] CHECK CONSTRAINT [FK_User_Comment_User_Comment]
GO
ALTER TABLE [dbo].[User_Comment]  WITH CHECK ADD  CONSTRAINT [FK_User_Comment_users] FOREIGN KEY([UserId])
REFERENCES [dbo].[users] ([Id])
GO
ALTER TABLE [dbo].[User_Comment] CHECK CONSTRAINT [FK_User_Comment_users]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [CityFK] FOREIGN KEY([CityId])
REFERENCES [dbo].[cities] ([Id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [CityFK]
GO
ALTER TABLE [dbo].[wish_list]  WITH CHECK ADD  CONSTRAINT [Child2] FOREIGN KEY([ItemChildId])
REFERENCES [dbo].[items_child] ([Id])
GO
ALTER TABLE [dbo].[wish_list] CHECK CONSTRAINT [Child2]
GO
ALTER TABLE [dbo].[wish_list]  WITH CHECK ADD  CONSTRAINT [User22] FOREIGN KEY([UserId])
REFERENCES [dbo].[users] ([Id])
GO
ALTER TABLE [dbo].[wish_list] CHECK CONSTRAINT [User22]
GO
USE [master]
GO
ALTER DATABASE [buyfromall] SET  READ_WRITE 
GO
