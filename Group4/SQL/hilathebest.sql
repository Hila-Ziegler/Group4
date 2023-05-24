--Get Tables

Create Procedure dbo.Get_all_Librarians
AS
Select*from dbo.Librarians


Create Procedure dbo.Get_all_Books
AS
Select*from dbo.Books

Create Procedure dbo.Get_all_Copies
AS
Select*from dbo.Copies


Create Procedure dbo.Get_all_Teachers
AS
Select*from dbo.Teachers

Create Procedure dbo.Get_all_Students
AS
Select*from dbo.Students


Create Procedure dbo.Get_all_BookHistories
AS
Select*from dbo.BookHistory

Create Procedure dbo.Get_all_Events
AS
Select*from dbo.Events


Create Procedure dbo.Get_all_Registrations
AS
Select*from dbo.Registrations

Create Procedure dbo.Get_all_Requests
AS
Select*from dbo.Requests


Create Procedure dbo.Get_all_BookInWaitlist
AS
Select*from dbo.BookInWaitlist

--Create new record


CREATE PROCEDURE dbo.SP_add_Librarians @id VARCHAR(50), @name VARCHAR(50), @password VARCHAR(100), @archive BIT 
AS
INSERT INTO dbo.Librarians
Values (@id, @name, @password, @archive)


CREATE PROCEDURE dbo.SP_add_Books @serialNumber VARCHAR(50), @title VARCHAR(50), @author VARCHAR(50), @publishYear INT ,@language VARCHAR(50) , @rating FLOAT , @arcive BIT  
AS
INSERT INTO dbo.Books
Values (@serialNumber, @title, @author, @publishYear,@language, @rating, @arcive)


CREATE PROCEDURE dbo.SP_add_Copies @copyNumber	INTEGER ,@serialNumber	VARCHAR(50), @status BIT 
AS
INSERT INTO dbo.Copies
Values (@copyNumber	,@serialNumber, @status )


CREATE PROCEDURE dbo.Teachers @id VARCHAR(50), @name VARCHAR(50),@password VARCHAR(100),@archive BIT
AS
INSERT INTO dbo.Teachers
Values (@id , @name ,@password ,@archive )

CREATE PROCEDURE dbo.SP_add_Students @id VARCHAR(50),@name VARCHAR(50),@age	INTEGER,@club VARCHAR(50),@yearlyGoal INTEGER,@password	VARCHAR(100),@archive BIT
AS
INSERT INTO dbo.Students
Values (@id ,@name,@age,@club ,@yearlyGoal,@password,@archive )


CREATE PROCEDURE dbo.SP_add_BookHistory @copyNumber	INTEGER,@serialNumber VARCHAR(50), @id	VARCHAR(50), @startDate	DATETIME,@endDate DATETIME,@rate INTEGER
AS
INSERT INTO dbo.BookHistory
Values (@copyNumber	,@serialNumber , @id, @startDate,@endDate ,@rate )


CREATE PROCEDURE dbo.SP_add_Events 	@guestType	VARCHAR(50),@date DATETIME,	@price	DECIMAL,@guestSpeakerName VARCHAR(50),@maxGuests INTEGER,@currentlyRegistered INTEGER
AS
INSERT INTO dbo.Events
Values (@guestType,@date,@price,@guestSpeakerName ,@maxGuests,@currentlyRegistered)


CREATE PROCEDURE dbo.SP_add_Registrations @id VARCHAR(50),@eventDate DATETIME ,@guestSpeakerName VARCHAR(50),@showedUp	BIT,@review	VARCHAR(50),@rating	INTEGER
AS
INSERT INTO dbo.Registrations
Values (@id ,@eventDate  ,@guestSpeakerName,@showedUp,@review	,@rating)


CREATE PROCEDURE dbo.SP_add_Requests @type	VARCHAR(50),@startDT DATETIME ,@id	VARCHAR(50),@endDT	DATETIME,@status VARCHAR(50),@photoAddress	NVARCHAR(260)
AS
INSERT INTO dbo.Requests
Values (@type,@startDT,@id,@endDT,@status ,@photoAddress)

CREATE PROCEDURE dbo.SP_add_BookInWaitlist @startDate DATETIME ,@id VARCHAR(50), @name VARCHAR(50), @serialNumber VARCHAR(50) 
AS
INSERT INTO dbo.BookInWaitlist
Values (@startDate ,@id , @name , @serialNumber)




--Update records

CREATE PROCEDURE dbo.SP_Update_Librarian @id VARCHAR(50), @name VARCHAR(50), @password VARCHAR(100), @archive BIT
AS
Update dbo.Librarians
SET
name=@name, password=@password, archive = @archive
WHERE id=@id

CREATE PROCEDURE dbo.SP_Update_Book @serialNumber VARCHAR(50), @title VARCHAR(50), @author VARCHAR(50), @publishYear INT ,@language VARCHAR(50) , @rating FLOAT , @arcive BIT
AS
Update dbo.Books
SET
serialNumber=@serialNumber, title=@title, author=@author, language=@language, rating=@rating ,archive=@arcive
WHERE serialNumber=@serialNumber

CREATE PROCEDURE dbo.SP_Update_Copy @copyNumber	INTEGER ,@serialNumber	VARCHAR(50), @status BIT 
AS
Update dbo.Copies
SET
status=@status
WHERE copyNumber=@copyNumber AND serialNumber=@serialNumber

CREATE PROCEDURE dbo.SP_Update_Teacher @id VARCHAR(50), @name VARCHAR(50),@password VARCHAR(100),@archive BIT
AS
Update dbo.Teachers
SET
name=@name, password=@password, archive=@archive
WHERE id=@id

CREATE PROCEDURE dbo.SP_Update_Student @id VARCHAR(50),@name VARCHAR(50),@age	INTEGER,@club VARCHAR(50),@yearlyGoal INTEGER,@password	VARCHAR(100),@archive BIT
AS
Update dbo.Students
SET
name=@name, age=@age, club=@club, yearlyGoal=@yearlyGoal, password=@password, archive=@archive
WHERE id=@id

CREATE PROCEDURE dbo.SP_Update_BookHistory @copyNumber	INTEGER,@serialNumber VARCHAR(50), @id	VARCHAR(50), @startDate	DATETIME,@endDate DATETIME,@rate INTEGER
AS
Update dbo.BookHistory
SET
startDate=@startDate, endDate=@endDate, rate=@rate
WHERE copyNumber=@copyNumber AND serialNumber=@serialNumber AND id=@id

CREATE PROCEDURE dbo.SP_Update_Event @guestType	VARCHAR(50),@date DATETIME,	@price	DECIMAL,@guestSpeakerName VARCHAR(50),@maxGuests INTEGER,@currentlyRegistered INTEGER
AS
Update dbo.Events
SET
price=@price, guestType=@guestType, maxGuests=@maxGuests, currentlyRegistered=@currentlyRegistered
WHERE date=@date AND guestSpeakerName=@guestSpeakerName

CREATE PROCEDURE dbo.SP_Update_Registration @id VARCHAR(50),@eventDate DATETIME ,@guestSpeakerName VARCHAR(50),@showedUp	BIT,@review	VARCHAR(50),@rating	INTEGER
AS
Update dbo.Registrations
SET
showedUp=@showedUp, review=@review, rating=@rating
WHERE id=@id AND eventDate=@eventDate AND guestSpeakerName=@guestSpeakerName

CREATE PROCEDURE dbo.SP_Update_Request @type VARCHAR(50),@startDT DATETIME ,@id	VARCHAR(50),@endDT	DATETIME,@status VARCHAR(50),@photoAddress	NVARCHAR(260)
AS
Update dbo.Requests
SET
type=@type, endDT=@endDT, status=@status, photoAddress=@photoAddress 
WHERE startDT=@startDT AND id=@id


--Delete record


CREATE PROCEDURE dbo.SP_delete_worker @id integer
AS
Delete from  dbo.Workers
WHERE workerId=@id



