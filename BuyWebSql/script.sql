USE [master]
GO
/****** Object:  Database [BuyFromAllDB]    Script Date: 30/08/2020 19:04:54 ******/
CREATE DATABASE [BuyFromAllDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BuyFromAllDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BuyFromAllDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BuyFromAllDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BuyFromAllDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BuyFromAllDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BuyFromAllDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BuyFromAllDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BuyFromAllDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BuyFromAllDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BuyFromAllDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BuyFromAllDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET RECOVERY FULL 
GO
ALTER DATABASE [BuyFromAllDB] SET  MULTI_USER 
GO
ALTER DATABASE [BuyFromAllDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BuyFromAllDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BuyFromAllDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BuyFromAllDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BuyFromAllDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BuyFromAllDB', N'ON'
GO
ALTER DATABASE [BuyFromAllDB] SET QUERY_STORE = OFF
GO
USE [BuyFromAllDB]
GO
/****** Object:  Table [dbo].[collaborationData]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[collaborationData](
	[image] [nvarchar](max) NULL,
	[name] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[access] [nvarchar](50) NULL,
	[accessclass] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_collaborationData] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[contact]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contact](
	[address] [nvarchar](max) NULL,
	[call] [nvarchar](50) NULL,
	[info] [nvarchar](max) NULL,
	[mail] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[invoice_status]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[invoice_status](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_invoice_status] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[invoiceData]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[invoiceData](
	[position] [int] NULL,
	[invoiceId] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[date] [datetime] NOT NULL,
	[price] [decimal](18, 0) NULL,
	[payment] [nvarchar](50) NULL,
	[status_id] [int] NULL,
 CONSTRAINT [PK_invoiceData] PRIMARY KEY CLUSTERED 
(
	[invoiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[availablity] [bit] NULL,
	[brand] [nvarchar](50) NULL,
	[category_id] [int] NULL,
	[color] [nvarchar](50) NULL,
	[description] [nvarchar](max) NULL,
	[discount_price] [decimal](18, 0) NULL,
	[image] [nvarchar](50) NULL,
	[name] [nvarchar](50) NULL,
	[popular] [bit] NULL,
	[price] [decimal](18, 0) NULL,
	[product_code] [nvarchar](50) NULL,
	[quantity] [int] NULL,
	[rating] [decimal](18, 0) NULL,
	[status] [int] NULL,
	[type] [nvarchar](50) NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product_category]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[category_type_id] [int] NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product_category_type]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_category_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_category_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product_feature]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_feature](
	[name] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
 CONSTRAINT [PK_feature] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product_image_gallery]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_image_gallery](
	[name] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
 CONSTRAINT [PK_product_image_gallery] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product_review]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_review](
	[category] [nvarchar](50) NULL,
	[description] [nvarchar](max) NULL,
	[id] [nchar](10) NOT NULL,
	[name] [nvarchar](50) NULL,
	[rating] [decimal](18, 0) NULL,
	[type] [nvarchar](50) NULL,
	[user_rating_id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_product_review] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product_tag]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_tag](
	[name] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
 CONSTRAINT [PK_tag] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product_user_rating]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_user_rating](
	[comment] [nvarchar](max) NULL,
	[date] [nvarchar](50) NULL,
	[designation] [nvarchar](50) NULL,
	[img] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[user_id] [int] NULL,
 CONSTRAINT [PK_user_product_rating] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[team]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[team](
	[description] [nvarchar](max) NULL,
	[designation] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[image] [nvarchar](max) NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_team] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[testimonial]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[testimonial](
	[description] [nvarchar](max) NULL,
	[designation] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[image] [nvarchar](max) NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_testimonial] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transaction_scope]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transaction_scope](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_transaction_scope] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transaction_status]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transaction_status](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[color] [nvarchar](50) NULL,
 CONSTRAINT [PK_transaction_status] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transaction_type]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transaction_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[color] [nvarchar](50) NULL,
 CONSTRAINT [PK_transaction_type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transcationTable]    Script Date: 30/08/2020 19:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transcationTable](
	[date] [datetime] NULL,
	[type_id] [int] NULL,
	[companyName] [nvarchar](50) NULL,
	[amount] [decimal](18, 0) NULL,
	[status_id] [int] NULL,
	[scope_id] [int] NULL,
	[transid] [nvarchar](50) NULL,
	[account] [nvarchar](50) NULL,
	[debit] [decimal](18, 0) NULL,
	[balance] [decimal](18, 0) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_transcationTable] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[invoiceData]  WITH CHECK ADD  CONSTRAINT [FK_invoiceData_invoice_status] FOREIGN KEY([status_id])
REFERENCES [dbo].[invoice_status] ([id])
GO
ALTER TABLE [dbo].[invoiceData] CHECK CONSTRAINT [FK_invoiceData_invoice_status]
GO
ALTER TABLE [dbo].[product_category]  WITH CHECK ADD  CONSTRAINT [FK_category_category_type] FOREIGN KEY([category_type_id])
REFERENCES [dbo].[product_category_type] ([id])
GO
ALTER TABLE [dbo].[product_category] CHECK CONSTRAINT [FK_category_category_type]
GO
ALTER TABLE [dbo].[product_image_gallery]  WITH CHECK ADD  CONSTRAINT [FK_product_image_gallery_product] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([id])
GO
ALTER TABLE [dbo].[product_image_gallery] CHECK CONSTRAINT [FK_product_image_gallery_product]
GO
ALTER TABLE [dbo].[product_review]  WITH CHECK ADD  CONSTRAINT [FK_product_review_user_product_rating] FOREIGN KEY([user_rating_id])
REFERENCES [dbo].[product_user_rating] ([id])
GO
ALTER TABLE [dbo].[product_review] CHECK CONSTRAINT [FK_product_review_user_product_rating]
GO
ALTER TABLE [dbo].[product_tag]  WITH CHECK ADD  CONSTRAINT [FK_tag_product] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([id])
GO
ALTER TABLE [dbo].[product_tag] CHECK CONSTRAINT [FK_tag_product]
GO
ALTER TABLE [dbo].[transcationTable]  WITH CHECK ADD  CONSTRAINT [FK_transcationTable_transaction_scope] FOREIGN KEY([scope_id])
REFERENCES [dbo].[transaction_scope] ([id])
GO
ALTER TABLE [dbo].[transcationTable] CHECK CONSTRAINT [FK_transcationTable_transaction_scope]
GO
ALTER TABLE [dbo].[transcationTable]  WITH CHECK ADD  CONSTRAINT [FK_transcationTable_transaction_status] FOREIGN KEY([status_id])
REFERENCES [dbo].[transaction_status] ([id])
GO
ALTER TABLE [dbo].[transcationTable] CHECK CONSTRAINT [FK_transcationTable_transaction_status]
GO
ALTER TABLE [dbo].[transcationTable]  WITH CHECK ADD  CONSTRAINT [FK_transcationTable_transaction_type] FOREIGN KEY([type_id])
REFERENCES [dbo].[transaction_type] ([id])
GO
ALTER TABLE [dbo].[transcationTable] CHECK CONSTRAINT [FK_transcationTable_transaction_type]
GO
USE [master]
GO
ALTER DATABASE [BuyFromAllDB] SET  READ_WRITE 
GO
