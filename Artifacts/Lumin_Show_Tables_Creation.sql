CREATE DATABASE LuminShow;
USE LuminShow
GO
IF OBJECT_ID('UserLogin') IS NULL
	BEGIN
		CREATE TABLE UserLogin 
		(
			UserID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
			UserName VARCHAR(MAX) NOT NULL,
			UserPassword VARCHAR(MAX) NOT NULL
		)
	END;


IF OBJECT_ID('StreamingPlatform') IS NULL
	BEGIN
		CREATE TABLE StreamingPlatform 
		(
			PlatformID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
			PlatformName VARCHAR(MAX) NOT NULL
		)
	END;


IF OBJECT_ID('ProductionCompany') IS NULL
	BEGIN
		CREATE TABLE ProductionCompany
		(
			PDCompanyID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
			PDCompanyName VARCHAR(MAX) NOT NULL,
			Description VARCHAR(MAX)
		)
	END;


IF OBJECT_ID('Genre') IS NULL
	BEGIN
		CREATE TABLE Genre
		(
			GenreID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
			GenreName VARCHAR(MAX) NOT NULL
		)
	END;


IF OBJECT_ID('Rating') IS NULL
	BEGIN
		CREATE TABLE Rating
		(
			RatingID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
			RatingDescription VARCHAR(MAX) NOT NULL
		)
	END;



IF OBJECT_ID('Actor') IS NULL
	BEGIN
		CREATE TABLE Actor
		(
			ActorID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
			FirstName VARCHAR(MAX) NOT NULL,
			MiddleName VARCHAR(MAX),
			LastName VARCHAR(MAX) NOT NULL,
			DateOfBirth DATE NOT NULL
		)
	END;



IF OBJECT_ID('Show') IS NULL
	BEGIN
		CREATE TABLE Show
		(
			ShowID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
			ShowName VARCHAR(MAX) NOT NULL,
			ReleaseDate DATE NOT NULL,
			ShowDescription VARCHAR(MAX),
			NumOfSeasons INT,
			PDCompanyID INT NOT NULL,
			GenreID INT,
			RatingID INT,
			PlatformID INT NOT NULL,
			FOREIGN KEY (PDCompanyID) REFERENCES ProductionCompany(PDCompanyID),
			FOREIGN KEY (GenreID) REFERENCES Genre(GenreID),
			FOREIGN KEY (RatingID) REFERENCES Rating(RatingID),
			FOREIGN KEY (PlatformID) REFERENCES StreamingPlatform(PlatformID)
		)
	END;


IF OBJECT_ID('Show_To_Actor') IS NULL
	BEGIN
		CREATE TABLE ShowToActor
		(
			ShowToActorID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
			showID INT NOT NULL,
			ActorID INT NOT NULL,
			FOREIGN KEY (showID) REFERENCES Show(ShowID),
			FOREIGN KEY (ActorID) REFERENCES Actor(ActorID)

		)
	END;



USE LuminShow
GO
CREATE OR ALTER PROCEDURE dbo.DeleteShow @showId INT
	AS
	BEGIN
		DELETE FROM showToActor WHERE ShowID = @showId
	END
	BEGIN
		DELETE FROM Show WHERE ShowID = @showId
	END

USE LuminShow
GO
CREATE OR ALTER PROCEDURE dbo.CountActorPlayedShows @actorId INT
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


USE LuminShow
GO
CREATE OR ALTER PROCEDURE dbo.GetActorPlayedShows @actorId INT
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


USE LuminShow
GO
CREATE OR ALTER PROCEDURE dbo.DeleteActor @actorID INT
	AS
	BEGIN
		 DELETE FROM showToActor WHERE ActorID = ActorId
	END
	BEGIN
		DELETE FROM Actor WHERE ActorID = @actorID
	END


