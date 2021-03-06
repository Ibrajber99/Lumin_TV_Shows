USE [master]
GO
/****** Object:  Database [LuminShow]    Script Date: 11/30/2020 10:04:57 AM ******/
CREATE DATABASE [LuminShow]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LuminShow', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLSEVER_IBRAJAB\MSSQL\DATA\LuminShow.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LuminShow_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLSEVER_IBRAJAB\MSSQL\DATA\LuminShow_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LuminShow] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LuminShow].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LuminShow] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LuminShow] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LuminShow] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LuminShow] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LuminShow] SET ARITHABORT OFF 
GO
ALTER DATABASE [LuminShow] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LuminShow] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LuminShow] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LuminShow] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LuminShow] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LuminShow] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LuminShow] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LuminShow] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LuminShow] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LuminShow] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LuminShow] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LuminShow] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LuminShow] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LuminShow] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LuminShow] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LuminShow] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LuminShow] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LuminShow] SET RECOVERY FULL 
GO
ALTER DATABASE [LuminShow] SET  MULTI_USER 
GO
ALTER DATABASE [LuminShow] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LuminShow] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LuminShow] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LuminShow] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LuminShow] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'LuminShow', N'ON'
GO
ALTER DATABASE [LuminShow] SET QUERY_STORE = OFF
GO
USE [LuminShow]
GO
/****** Object:  Table [dbo].[Actor]    Script Date: 11/30/2020 10:04:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actor](
	[ActorID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](max) NOT NULL,
	[MiddleName] [varchar](max) NULL,
	[LastName] [varchar](max) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[FullName]  AS (([Actor].[FirstName]+' ')+[Actor].[LastName]),
PRIMARY KEY CLUSTERED 
(
	[ActorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genre]    Script Date: 11/30/2020 10:04:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genre](
	[GenreID] [int] IDENTITY(1,1) NOT NULL,
	[GenreName] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GenreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductionCompany]    Script Date: 11/30/2020 10:04:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductionCompany](
	[PDCompanyID] [int] IDENTITY(1,1) NOT NULL,
	[PDCompanyName] [varchar](max) NOT NULL,
	[Description] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[PDCompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rating]    Script Date: 11/30/2020 10:04:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rating](
	[RatingID] [int] IDENTITY(1,1) NOT NULL,
	[RatingDescription] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RatingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Show]    Script Date: 11/30/2020 10:04:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Show](
	[ShowID] [int] IDENTITY(1,1) NOT NULL,
	[ShowName] [varchar](max) NOT NULL,
	[ReleaseDate] [date] NOT NULL,
	[NumOfSeasons] [int] NULL,
	[PDCompanyID] [int] NOT NULL,
	[GenreID] [int] NULL,
	[RatingID] [int] NULL,
	[PlatformID] [int] NOT NULL,
	[ShowDescription] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ShowID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShowToActor]    Script Date: 11/30/2020 10:04:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShowToActor](
	[ShowToActorID] [int] IDENTITY(1,1) NOT NULL,
	[showID] [int] NOT NULL,
	[ActorID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ShowToActorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StreamingPlatform]    Script Date: 11/30/2020 10:04:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StreamingPlatform](
	[PlatformID] [int] IDENTITY(1,1) NOT NULL,
	[PlatformName] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PlatformID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogin]    Script Date: 11/30/2020 10:04:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogin](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](max) NOT NULL,
	[UserPassword] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Actor] ON 

INSERT [dbo].[Actor] ([ActorID], [FirstName], [MiddleName], [LastName], [DateOfBirth]) VALUES (4, N'Lena ', N'', N'Headeys', CAST(N'1973-10-03' AS Date))
INSERT [dbo].[Actor] ([ActorID], [FirstName], [MiddleName], [LastName], [DateOfBirth]) VALUES (5, N'Emilia', N'', N'Clarke', CAST(N'1986-10-23' AS Date))
INSERT [dbo].[Actor] ([ActorID], [FirstName], [MiddleName], [LastName], [DateOfBirth]) VALUES (6, N'Robert', N'Dawney', N'Junior', CAST(N'1986-05-06' AS Date))
INSERT [dbo].[Actor] ([ActorID], [FirstName], [MiddleName], [LastName], [DateOfBirth]) VALUES (7, N'Bryan ', N'', N'Cranston', CAST(N'1965-03-07' AS Date))
INSERT [dbo].[Actor] ([ActorID], [FirstName], [MiddleName], [LastName], [DateOfBirth]) VALUES (8, N'Cillian ', N'', N'Murphy', CAST(N'1976-05-25' AS Date))
INSERT [dbo].[Actor] ([ActorID], [FirstName], [MiddleName], [LastName], [DateOfBirth]) VALUES (9, N'Paul ', N'', N'Anderson ', CAST(N'1980-10-03' AS Date))
INSERT [dbo].[Actor] ([ActorID], [FirstName], [MiddleName], [LastName], [DateOfBirth]) VALUES (10, N'Helen ', N'', N'McCrory', CAST(N'1968-08-17' AS Date))
INSERT [dbo].[Actor] ([ActorID], [FirstName], [MiddleName], [LastName], [DateOfBirth]) VALUES (11, N'Sophie ', N'', N'Rundle', CAST(N'1973-10-03' AS Date))
INSERT [dbo].[Actor] ([ActorID], [FirstName], [MiddleName], [LastName], [DateOfBirth]) VALUES (12, N'Henry ', N'', N'Cavill', CAST(N'1983-05-05' AS Date))
INSERT [dbo].[Actor] ([ActorID], [FirstName], [MiddleName], [LastName], [DateOfBirth]) VALUES (13, N'Freya', N'', N'Allan ', CAST(N'1995-06-22' AS Date))
INSERT [dbo].[Actor] ([ActorID], [FirstName], [MiddleName], [LastName], [DateOfBirth]) VALUES (14, N'Yasen ', N'', N'Atour', CAST(N'1987-10-18' AS Date))
INSERT [dbo].[Actor] ([ActorID], [FirstName], [MiddleName], [LastName], [DateOfBirth]) VALUES (15, N'Basil ', N'', N'Eidenbenz', CAST(N'1985-12-26' AS Date))
SET IDENTITY_INSERT [dbo].[Actor] OFF
SET IDENTITY_INSERT [dbo].[Genre] ON 

INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (1, N'COMEDY')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (2, N'SCI-FI')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (3, N'HORROR')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (4, N'ROMANCE')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (5, N'ACTION')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (6, N'THRILLER')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (7, N'DRAMA')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (8, N'MYSTERY')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (9, N'CRIME')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (10, N'ANIMATION')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (11, N'ADEVENTURE')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (12, N'FANTASY')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (13, N'COMEDY-ROMANCE')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (14, N'ACTION-COMDEY')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (15, N'SUPERHERO')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (16, N'DOCUMENTRY')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (17, N'BIO-GRAPHY')
INSERT [dbo].[Genre] ([GenreID], [GenreName]) VALUES (18, N'SPORTS')
SET IDENTITY_INSERT [dbo].[Genre] OFF
SET IDENTITY_INSERT [dbo].[ProductionCompany] ON 

INSERT [dbo].[ProductionCompany] ([PDCompanyID], [PDCompanyName], [Description]) VALUES (2, N'Walt Disney Television', N'Walt Disney Television is a subsidiary that oversees television assets owned and operated by The Walt Disney Company.')
INSERT [dbo].[ProductionCompany] ([PDCompanyID], [PDCompanyName], [Description]) VALUES (4, N'HBO', N'Home Box Office is an American pay television network owned by WarnerMedia Studios & Networks and the flagship property of parent subsidiary Home Box Office, Inc.')
INSERT [dbo].[ProductionCompany] ([PDCompanyID], [PDCompanyName], [Description]) VALUES (6, N'Fox ', N'Forx production is a cinema production company owned by Deisney corporations')
INSERT [dbo].[ProductionCompany] ([PDCompanyID], [PDCompanyName], [Description]) VALUES (7, N'Netlfix', N'Netflix, Inc. is an American over-the-top content platform and production company headquartered in Los Gatos, California. Netflix was founded in 1997 by Reed Hastings and Marc Randolph in Scotts Valley, California.')
SET IDENTITY_INSERT [dbo].[ProductionCompany] OFF
SET IDENTITY_INSERT [dbo].[Rating] ON 

INSERT [dbo].[Rating] ([RatingID], [RatingDescription]) VALUES (1, N'TV-Y appropriate for ages 2-6')
INSERT [dbo].[Rating] ([RatingID], [RatingDescription]) VALUES (2, N'TV-Y7 appropriate for children age 7 and up')
INSERT [dbo].[Rating] ([RatingID], [RatingDescription]) VALUES (3, N'TV-G appropriate for all ages')
INSERT [dbo].[Rating] ([RatingID], [RatingDescription]) VALUES (4, N'TV-PG Parental guidance is recommended')
INSERT [dbo].[Rating] ([RatingID], [RatingDescription]) VALUES (5, N'TV-14 appropriate for children under 14 years of age')
INSERT [dbo].[Rating] ([RatingID], [RatingDescription]) VALUES (6, N'TV-MA Mature content +17 years of age')
SET IDENTITY_INSERT [dbo].[Rating] OFF
SET IDENTITY_INSERT [dbo].[Show] ON 

INSERT [dbo].[Show] ([ShowID], [ShowName], [ReleaseDate], [NumOfSeasons], [PDCompanyID], [GenreID], [RatingID], [PlatformID], [ShowDescription]) VALUES (27, N'Vikings', CAST(N'2010-12-27' AS Date), 1, 2, 7, 6, 1, N'Ragnar Lothbrok, a legendary Norse hero, is a mere farmer who rises up to become a fearless warrior and commander of the Viking tribes with the support of his equally ferocious family.')
INSERT [dbo].[Show] ([ShowID], [ShowName], [ReleaseDate], [NumOfSeasons], [PDCompanyID], [GenreID], [RatingID], [PlatformID], [ShowDescription]) VALUES (28, N'Game of thrones', CAST(N'2010-12-27' AS Date), 1, 4, 7, 6, 5, N'Good Show')
INSERT [dbo].[Show] ([ShowID], [ShowName], [ReleaseDate], [NumOfSeasons], [PDCompanyID], [GenreID], [RatingID], [PlatformID], [ShowDescription]) VALUES (30, N'Breaking bad', CAST(N'2010-12-27' AS Date), 1, 4, 8, 6, 5, N'Good show')
INSERT [dbo].[Show] ([ShowID], [ShowName], [ReleaseDate], [NumOfSeasons], [PDCompanyID], [GenreID], [RatingID], [PlatformID], [ShowDescription]) VALUES (32, N'Peaky Blinders', CAST(N'2013-12-27' AS Date), 5, 7, 9, 6, 2, N'A gangster family epic set in 1900s England, centering on a gang who sew razor blades in the peaks of their caps, and their fierce boss Tommy Shelby.')
INSERT [dbo].[Show] ([ShowID], [ShowName], [ReleaseDate], [NumOfSeasons], [PDCompanyID], [GenreID], [RatingID], [PlatformID], [ShowDescription]) VALUES (33, N'The Witcher', CAST(N'2019-12-20' AS Date), 2, 7, 12, 6, 2, N'Geralt of Rivia, a solitary monster hunter, struggles to find his place in a world where people often prove more wicked than beasts.')
SET IDENTITY_INSERT [dbo].[Show] OFF
SET IDENTITY_INSERT [dbo].[ShowToActor] ON 

INSERT [dbo].[ShowToActor] ([ShowToActorID], [showID], [ActorID]) VALUES (59, 28, 5)
INSERT [dbo].[ShowToActor] ([ShowToActorID], [showID], [ActorID]) VALUES (60, 28, 6)
INSERT [dbo].[ShowToActor] ([ShowToActorID], [showID], [ActorID]) VALUES (61, 28, 4)
INSERT [dbo].[ShowToActor] ([ShowToActorID], [showID], [ActorID]) VALUES (67, 27, 4)
INSERT [dbo].[ShowToActor] ([ShowToActorID], [showID], [ActorID]) VALUES (72, 27, 6)
INSERT [dbo].[ShowToActor] ([ShowToActorID], [showID], [ActorID]) VALUES (73, 30, 7)
INSERT [dbo].[ShowToActor] ([ShowToActorID], [showID], [ActorID]) VALUES (74, 32, 11)
INSERT [dbo].[ShowToActor] ([ShowToActorID], [showID], [ActorID]) VALUES (75, 32, 10)
INSERT [dbo].[ShowToActor] ([ShowToActorID], [showID], [ActorID]) VALUES (76, 32, 9)
INSERT [dbo].[ShowToActor] ([ShowToActorID], [showID], [ActorID]) VALUES (77, 32, 8)
INSERT [dbo].[ShowToActor] ([ShowToActorID], [showID], [ActorID]) VALUES (78, 33, 15)
INSERT [dbo].[ShowToActor] ([ShowToActorID], [showID], [ActorID]) VALUES (79, 33, 14)
INSERT [dbo].[ShowToActor] ([ShowToActorID], [showID], [ActorID]) VALUES (80, 33, 13)
INSERT [dbo].[ShowToActor] ([ShowToActorID], [showID], [ActorID]) VALUES (81, 33, 12)
INSERT [dbo].[ShowToActor] ([ShowToActorID], [showID], [ActorID]) VALUES (82, 32, 6)
SET IDENTITY_INSERT [dbo].[ShowToActor] OFF
SET IDENTITY_INSERT [dbo].[StreamingPlatform] ON 

INSERT [dbo].[StreamingPlatform] ([PlatformID], [PlatformName]) VALUES (1, N'PRIME')
INSERT [dbo].[StreamingPlatform] ([PlatformID], [PlatformName]) VALUES (2, N'NETFLIX')
INSERT [dbo].[StreamingPlatform] ([PlatformID], [PlatformName]) VALUES (3, N'Hulu')
INSERT [dbo].[StreamingPlatform] ([PlatformID], [PlatformName]) VALUES (4, N'Disney+')
INSERT [dbo].[StreamingPlatform] ([PlatformID], [PlatformName]) VALUES (5, N'HBO')
INSERT [dbo].[StreamingPlatform] ([PlatformID], [PlatformName]) VALUES (6, N'ShowTime')
INSERT [dbo].[StreamingPlatform] ([PlatformID], [PlatformName]) VALUES (7, N'ESPN')
SET IDENTITY_INSERT [dbo].[StreamingPlatform] OFF
SET IDENTITY_INSERT [dbo].[UserLogin] ON 

INSERT [dbo].[UserLogin] ([UserID], [UserName], [UserPassword]) VALUES (1, N'ibrahimJaber', N'15318925279822216311935472531217920720121861961522542381281161032297515919818418418072')
INSERT [dbo].[UserLogin] ([UserID], [UserName], [UserPassword]) VALUES (2, N'Lonna', N'5910522022317418939346393101182164103177494813413580255205752948681472081181974358')
INSERT [dbo].[UserLogin] ([UserID], [UserName], [UserPassword]) VALUES (3, N'Lumin', N'891487126187117422521931298924620411618024517185152621889179202245169193115202207197')
INSERT [dbo].[UserLogin] ([UserID], [UserName], [UserPassword]) VALUES (4, N'TESTING', N'9323127336720010821022420011311421541231239471437113969771256215721316810614617885')
INSERT [dbo].[UserLogin] ([UserID], [UserName], [UserPassword]) VALUES (5, N'ibra', N'891487126187117422521931298924620411618024517185152621889179202245169193115202207197')
SET IDENTITY_INSERT [dbo].[UserLogin] OFF
ALTER TABLE [dbo].[Show]  WITH CHECK ADD FOREIGN KEY([GenreID])
REFERENCES [dbo].[Genre] ([GenreID])
GO
ALTER TABLE [dbo].[Show]  WITH CHECK ADD FOREIGN KEY([PDCompanyID])
REFERENCES [dbo].[ProductionCompany] ([PDCompanyID])
GO
ALTER TABLE [dbo].[Show]  WITH CHECK ADD FOREIGN KEY([PlatformID])
REFERENCES [dbo].[StreamingPlatform] ([PlatformID])
GO
ALTER TABLE [dbo].[Show]  WITH CHECK ADD FOREIGN KEY([RatingID])
REFERENCES [dbo].[Rating] ([RatingID])
GO
ALTER TABLE [dbo].[ShowToActor]  WITH CHECK ADD FOREIGN KEY([ActorID])
REFERENCES [dbo].[Actor] ([ActorID])
GO
ALTER TABLE [dbo].[ShowToActor]  WITH CHECK ADD FOREIGN KEY([showID])
REFERENCES [dbo].[Show] ([ShowID])
GO
/****** Object:  StoredProcedure [dbo].[CountActorPlayedShows]    Script Date: 11/30/2020 10:04:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[CountActorPlayedShows] @actorId INT
	AS
	BEGIN
		SELECT COUNT(Show.ShowID) AS showCount FROM ShowToActor
		RIGHT JOIN Show ON show.showID = ShowToActor.ShowID
		WHERE ShowToActor.ActorID IN
		(
			SELECT ActorID FROM Actor 
			WHERE ActorID = @actorId
		)
	END
GO
/****** Object:  StoredProcedure [dbo].[DeleteActor]    Script Date: 11/30/2020 10:04:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[DeleteActor] @actorID INT
	AS
	BEGIN
		 DELETE FROM showToActor WHERE ActorID = ActorId
	END
	BEGIN
		DELETE FROM Actor WHERE ActorID = @actorID
	END
GO
/****** Object:  StoredProcedure [dbo].[DeleteShow]    Script Date: 11/30/2020 10:04:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[DeleteShow] @showId INT
	AS
	BEGIN
		DELETE FROM showToActor WHERE ShowID = @showId
	END
	BEGIN
		DELETE FROM SHow WHERE ShowID = @showId
	END
GO
/****** Object:  StoredProcedure [dbo].[GetActorPlayedShows]    Script Date: 11/30/2020 10:04:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[GetActorPlayedShows] @actorId INT
	AS
	BEGIN
		SELECT show.ShowId,show.ShowName FROM ShowToActor
		RIGHT JOIN Show ON show.showID = ShowToActor.ShowID
		WHERE ShowToActor.ActorID IN
		(
			SELECT ActorID FROM Actor 
			WHERE ActorID = @actorId
		)
	END
GO
USE [master]
GO
ALTER DATABASE [LuminShow] SET  READ_WRITE 
GO
