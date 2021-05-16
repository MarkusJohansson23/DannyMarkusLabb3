USE [master]
GO
/****** Object:  Database [everyloop]    Script Date: 2021-05-16 18:33:47 ******/
CREATE DATABASE [everyloop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'everyloop', FILENAME = N'C:\Users\Markus\everyloop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'everyloop_log', FILENAME = N'C:\Users\Markus\everyloop_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [everyloop] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [everyloop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [everyloop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [everyloop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [everyloop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [everyloop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [everyloop] SET ARITHABORT OFF 
GO
ALTER DATABASE [everyloop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [everyloop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [everyloop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [everyloop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [everyloop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [everyloop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [everyloop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [everyloop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [everyloop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [everyloop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [everyloop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [everyloop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [everyloop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [everyloop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [everyloop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [everyloop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [everyloop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [everyloop] SET RECOVERY FULL 
GO
ALTER DATABASE [everyloop] SET  MULTI_USER 
GO
ALTER DATABASE [everyloop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [everyloop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [everyloop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [everyloop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [everyloop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [everyloop] SET QUERY_STORE = OFF
GO
USE [everyloop]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [everyloop]
GO
/****** Object:  Schema [company]    Script Date: 2021-05-16 18:33:48 ******/
CREATE SCHEMA [company]
GO
/****** Object:  Schema [music]    Script Date: 2021-05-16 18:33:48 ******/
CREATE SCHEMA [music]
GO
/****** Object:  Table [company].[categories]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [company].[categories](
	[Id] [int] NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
	[Description] [nvarchar](100) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [company].[customers]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [company].[customers](
	[Id] [nvarchar](10) NOT NULL,
	[CompanyName] [nvarchar](100) NOT NULL,
	[ContactName] [nvarchar](50) NULL,
	[ContactTitle] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[Region] [nvarchar](50) NULL,
	[PostalCode] [nvarchar](20) NULL,
	[Country] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [company].[employee_territory]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [company].[employee_territory](
	[Id] [nvarchar](7) NOT NULL,
	[EmployeeId] [int] NULL,
	[TerritoryId] [int] NULL,
 CONSTRAINT [PK_EmployeeTerritory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [company].[employees]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [company].[employees](
	[Id] [int] NOT NULL,
	[LastName] [nvarchar](20) NULL,
	[FirstName] [nvarchar](20) NULL,
	[Title] [nvarchar](50) NULL,
	[TitleOfCourtesy] [nvarchar](10) NULL,
	[BirthDate] [nvarchar](10) NULL,
	[HireDate] [nvarchar](10) NULL,
	[Address] [nvarchar](50) NULL,
	[City] [nvarchar](20) NULL,
	[Region] [nvarchar](13) NULL,
	[PostalCode] [nvarchar](20) NULL,
	[Country] [nvarchar](10) NULL,
	[HomePhone] [nvarchar](50) NULL,
	[Extension] [nvarchar](10) NULL,
	[Notes] [nvarchar](500) NULL,
	[ReportsTo] [int] NULL,
	[PhotoPath] [nvarchar](100) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [company].[order_details]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [company].[order_details](
	[Id] [nvarchar](10) NOT NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NULL,
	[UnitPrice] [float] NULL,
	[Quantity] [int] NULL,
	[Discount] [float] NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [company].[orders]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [company].[orders](
	[Id] [int] NOT NULL,
	[CustomerId] [nvarchar](10) NULL,
	[EmployeeId] [int] NULL,
	[OrderDate] [nvarchar](10) NULL,
	[RequiredDate] [nvarchar](10) NULL,
	[ShippedDate] [nvarchar](10) NULL,
	[ShipVia] [int] NULL,
	[Freight] [float] NULL,
	[ShipName] [nvarchar](100) NULL,
	[ShipAddress] [nvarchar](100) NULL,
	[ShipCity] [nvarchar](50) NULL,
	[ShipRegion] [nvarchar](50) NULL,
	[ShipPostalCode] [nvarchar](20) NULL,
	[ShipCountry] [nvarchar](50) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [company].[products]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [company].[products](
	[Id] [int] NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[SupplierId] [int] NULL,
	[CategoryId] [int] NULL,
	[QuantityPerUnit] [nvarchar](50) NULL,
	[UnitPrice] [float] NULL,
	[UnitsInStock] [int] NULL,
	[UnitsOnOrder] [int] NULL,
	[ReorderLevel] [int] NULL,
	[Discontinued] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [company].[regions]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [company].[regions](
	[Id] [int] NOT NULL,
	[RegionDescription] [nvarchar](20) NULL,
 CONSTRAINT [PK_Regions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [company].[suppliers]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [company].[suppliers](
	[Id] [int] NOT NULL,
	[CompanyName] [nvarchar](100) NULL,
	[ContactName] [nvarchar](50) NULL,
	[ContactTitle] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
	[City] [nvarchar](50) NULL,
	[Region] [nvarchar](50) NULL,
	[PostalCode] [nvarchar](20) NULL,
	[Country] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[HomePage] [nvarchar](100) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [company].[territories]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [company].[territories](
	[Id] [int] NOT NULL,
	[TerritoryDescription] [nvarchar](50) NULL,
	[RegionId] [int] NULL,
 CONSTRAINT [PK_Territories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Airports]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Airports](
	[IATA] [nvarchar](10) NOT NULL,
	[ICAO] [nvarchar](10) NULL,
	[Airport name] [nvarchar](200) NULL,
	[Location served] [nvarchar](200) NULL,
	[Time] [nvarchar](20) NULL,
	[DST] [nvarchar](20) NULL,
 CONSTRAINT [PK_airports] PRIMARY KEY CLUSTERED 
(
	[IATA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colors](
	[Name] [nvarchar](20) NOT NULL,
	[Code] [nvarchar](7) NULL,
	[Red] [int] NULL,
	[Green] [int] NULL,
	[Blue] [int] NULL,
 CONSTRAINT [PK_colors] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Country] [nvarchar](100) NOT NULL,
	[Region] [nvarchar](50) NULL,
	[Population] [int] NULL,
	[Area (sq# mi#)] [int] NULL,
	[Pop# Density (per sq# mi#)] [nvarchar](20) NULL,
	[Coastline (coast/area ratio)] [nvarchar](20) NULL,
	[Net migration] [nvarchar](20) NULL,
	[Infant mortality (per 1000 births)] [nvarchar](20) NULL,
	[GDP ($ per capita)] [int] NULL,
	[Literacy (%)] [nvarchar](10) NULL,
	[Phones (per 1000)] [nvarchar](20) NULL,
	[Arable (%)] [nvarchar](10) NULL,
	[Crops (%)] [nvarchar](10) NULL,
	[Other (%)] [nvarchar](10) NULL,
	[Climate] [int] NULL,
	[Birthrate] [nvarchar](10) NULL,
	[Deathrate] [nvarchar](10) NULL,
	[Agriculture] [nvarchar](10) NULL,
	[Industry] [nvarchar](10) NULL,
	[Service] [nvarchar](10) NULL,
 CONSTRAINT [PK_CountryData] PRIMARY KEY CLUSTERED 
(
	[Country] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Elements]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Elements](
	[Number] [int] NOT NULL,
	[Symbol] [nvarchar](10) NULL,
	[Name] [nvarchar](50) NULL,
	[Period] [int] NULL,
	[Group] [int] NULL,
	[Mass] [float] NULL,
	[Radius] [int] NULL,
	[Valenceel] [int] NULL,
	[Stableisotopes] [int] NULL,
	[Meltingpoint] [float] NULL,
	[Boilingpoint] [float] NULL,
	[Density] [float] NULL,
 CONSTRAINT [PK_elements] PRIMARY KEY CLUSTERED 
(
	[Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GameOfThrones]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GameOfThrones](
	[Episode] [int] NOT NULL,
	[EpisodeInSeason] [int] NULL,
	[Season] [int] NULL,
	[Title] [nvarchar](max) NULL,
	[Directed by] [nvarchar](max) NULL,
	[Written by] [nvarchar](max) NULL,
	[Original air date] [datetime2](7) NULL,
	[U.S. viewers(millions)] [float] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MoonMissions]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MoonMissions](
	[Spacecraft] [nvarchar](100) NOT NULL,
	[Launch date] [datetime2](7) NULL,
	[Carrier rocket] [nvarchar](max) NULL,
	[Operator] [nvarchar](max) NULL,
	[Mission type] [nvarchar](max) NULL,
	[Outcome] [nvarchar](max) NULL,
	[Comment] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TallyTable]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TallyTable](
	[n] [bigint] NOT NULL,
 CONSTRAINT [PK_TallyTable] PRIMARY KEY CLUSTERED 
(
	[n] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Types]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Types](
	[Integer] [int] NULL,
	[Float] [float] NULL,
	[String] [nvarchar](max) NULL,
	[DateTime] [datetime2](7) NULL,
	[Bool] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [nvarchar](12) NOT NULL,
	[UserName] [nvarchar](6) NULL,
	[Password] [nvarchar](100) NULL,
	[FirstName] [nvarchar](20) NULL,
	[LastName] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
	[Phone] [nvarchar](20) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [music].[albums]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [music].[albums](
	[AlbumId] [int] NOT NULL,
	[Title] [nvarchar](160) NOT NULL,
	[ArtistId] [int] NOT NULL,
 CONSTRAINT [PK_albums] PRIMARY KEY CLUSTERED 
(
	[AlbumId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [music].[artists]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [music].[artists](
	[ArtistId] [int] NOT NULL,
	[Name] [nvarchar](120) NULL,
 CONSTRAINT [PK_artists] PRIMARY KEY CLUSTERED 
(
	[ArtistId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [music].[genres]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [music].[genres](
	[GenreId] [int] NOT NULL,
	[Name] [nvarchar](120) NULL,
 CONSTRAINT [PK_genres] PRIMARY KEY CLUSTERED 
(
	[GenreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [music].[media_types]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [music].[media_types](
	[MediaTypeId] [int] NOT NULL,
	[Name] [nvarchar](120) NULL,
 CONSTRAINT [PK_media_types] PRIMARY KEY CLUSTERED 
(
	[MediaTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [music].[playlist_track]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [music].[playlist_track](
	[PlaylistId] [int] NOT NULL,
	[TrackId] [int] NOT NULL,
 CONSTRAINT [PK_playlist_tracks_id] PRIMARY KEY CLUSTERED 
(
	[PlaylistId] ASC,
	[TrackId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [music].[playlists]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [music].[playlists](
	[PlaylistId] [int] NOT NULL,
	[Name] [nvarchar](120) NULL,
 CONSTRAINT [PK_playlists] PRIMARY KEY CLUSTERED 
(
	[PlaylistId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [music].[tracks]    Script Date: 2021-05-16 18:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [music].[tracks](
	[TrackId] [int] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[AlbumId] [int] NULL,
	[MediaTypeId] [int] NOT NULL,
	[GenreId] [int] NULL,
	[Composer] [nvarchar](220) NULL,
	[Milliseconds] [int] NOT NULL,
	[Bytes] [int] NULL,
	[UnitPrice] [float] NOT NULL,
 CONSTRAINT [PK_tracks] PRIMARY KEY CLUSTERED 
(
	[TrackId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [company].[employee_territory]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeTerritory_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [company].[employees] ([Id])
GO
ALTER TABLE [company].[employee_territory] CHECK CONSTRAINT [FK_EmployeeTerritory_Employees]
GO
ALTER TABLE [company].[employee_territory]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeTerritory_Territories] FOREIGN KEY([TerritoryId])
REFERENCES [company].[territories] ([Id])
GO
ALTER TABLE [company].[employee_territory] CHECK CONSTRAINT [FK_EmployeeTerritory_Territories]
GO
ALTER TABLE [company].[order_details]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderId])
REFERENCES [company].[orders] ([Id])
GO
ALTER TABLE [company].[order_details] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [company].[order_details]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductId])
REFERENCES [company].[products] ([Id])
GO
ALTER TABLE [company].[order_details] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [company].[orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerId])
REFERENCES [company].[customers] ([Id])
GO
ALTER TABLE [company].[orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [company].[orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [company].[employees] ([Id])
GO
ALTER TABLE [company].[orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
ALTER TABLE [company].[products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryId])
REFERENCES [company].[categories] ([Id])
GO
ALTER TABLE [company].[products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [company].[products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SupplierId])
REFERENCES [company].[suppliers] ([Id])
GO
ALTER TABLE [company].[products] CHECK CONSTRAINT [FK_Products_Suppliers]
GO
ALTER TABLE [company].[territories]  WITH CHECK ADD  CONSTRAINT [FK_Territories_Regions] FOREIGN KEY([RegionId])
REFERENCES [company].[regions] ([Id])
GO
ALTER TABLE [company].[territories] CHECK CONSTRAINT [FK_Territories_Regions]
GO
ALTER TABLE [music].[albums]  WITH CHECK ADD  CONSTRAINT [FK_albums_artists] FOREIGN KEY([ArtistId])
REFERENCES [music].[artists] ([ArtistId])
GO
ALTER TABLE [music].[albums] CHECK CONSTRAINT [FK_albums_artists]
GO
ALTER TABLE [music].[playlist_track]  WITH CHECK ADD  CONSTRAINT [FK_playlist_track_playlists] FOREIGN KEY([PlaylistId])
REFERENCES [music].[playlists] ([PlaylistId])
GO
ALTER TABLE [music].[playlist_track] CHECK CONSTRAINT [FK_playlist_track_playlists]
GO
ALTER TABLE [music].[playlist_track]  WITH CHECK ADD  CONSTRAINT [FK_playlist_track_tracks] FOREIGN KEY([TrackId])
REFERENCES [music].[tracks] ([TrackId])
GO
ALTER TABLE [music].[playlist_track] CHECK CONSTRAINT [FK_playlist_track_tracks]
GO
ALTER TABLE [music].[tracks]  WITH CHECK ADD  CONSTRAINT [FK_tracks_albums] FOREIGN KEY([AlbumId])
REFERENCES [music].[albums] ([AlbumId])
GO
ALTER TABLE [music].[tracks] CHECK CONSTRAINT [FK_tracks_albums]
GO
ALTER TABLE [music].[tracks]  WITH CHECK ADD  CONSTRAINT [FK_tracks_genres] FOREIGN KEY([GenreId])
REFERENCES [music].[genres] ([GenreId])
GO
ALTER TABLE [music].[tracks] CHECK CONSTRAINT [FK_tracks_genres]
GO
ALTER TABLE [music].[tracks]  WITH CHECK ADD  CONSTRAINT [FK_tracks_media_types] FOREIGN KEY([MediaTypeId])
REFERENCES [music].[media_types] ([MediaTypeId])
GO
ALTER TABLE [music].[tracks] CHECK CONSTRAINT [FK_tracks_media_types]
GO
USE [master]
GO
ALTER DATABASE [everyloop] SET  READ_WRITE 
GO
