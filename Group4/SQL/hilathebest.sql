--Get Tables

Create PROCEDURE dbo.Get_all_Librarians
AS
SELECT * FROM dbo.Librarians

Create PROCEDURE dbo.Get_all_Books
AS
SELECT * FROM dbo.Books

Create PROCEDURE dbo.Get_all_Copies
AS
SELECT * FROM dbo.Copies

Create PROCEDURE dbo.Get_all_Teachers
AS
SELECT * FROM dbo.Teachers

Create PROCEDURE dbo.Get_all_Students
AS
SELECT * FROM dbo.Students

Create PROCEDURE dbo.Get_all_BookHistories
AS
SELECT * FROM dbo.BookHistory

Create PROCEDURE dbo.Get_all_Events
AS
SELECT * FROM dbo.Events

Create PROCEDURE dbo.Get_all_Registrations
AS
SELECT * FROM dbo.Registrations

Create PROCEDURE dbo.Get_all_Requests
AS
SELECT * FROM dbo.Requests

Create PROCEDURE dbo.Get_all_BookInWaitlist
AS
SELECT * FROM dbo.BookInWaitlist

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

CREATE PROCEDURE dbo.SP_add_Teachers @id VARCHAR(50), @name VARCHAR(50),@password VARCHAR(100),@archive BIT
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
--DROP PROCEDURE dbo.SP_add_Events
CREATE PROCEDURE dbo.SP_add_Events 	@guestType	VARCHAR(50),@date DATETIME,	@price	DECIMAL,@guestSpeakerName VARCHAR(50),@status VARCHAR(50), @maxGuests INTEGER,@currentlyRegistered INTEGER, @number INTEGER
AS
INSERT INTO dbo.Events
Values (@guestType, @date, @price, @guestSpeakerName, @status, @maxGuests, @currentlyRegistered, @number)
--DROP PROCEDURE dbo.SP_add_Registrations
CREATE PROCEDURE dbo.SP_add_Registrations @id VARCHAR(50),@showedUp	BIT,@review	VARCHAR(50),@rating	INTEGER,@number INTEGER, @oldDate VARCHAR(50)
AS
INSERT INTO dbo.Registrations
Values (@id ,@showedUp,@review	,@rating, @number,@oldDate)
--Drop Procedure dbo.SP_add_Requests
CREATE PROCEDURE dbo.SP_add_Requests @type	VARCHAR(50),@startDT DATETIME ,@sid	VARCHAR(50), @lid VARCHAR(50),@endDT	DATETIME,@status VARCHAR(50), @serialNum VARCHAR(50), @copyNum INTEGER
AS
INSERT INTO dbo.Requests
Values (@type,@startDT,@sid,@lid,@endDT,@status, @serialNum, @copyNum)

CREATE PROCEDURE dbo.SP_add_BookInWaitlist @startDate DATETIME ,@id VARCHAR(50), @serialNumber VARCHAR(50) 
AS
INSERT INTO dbo.BookInWaitlist
Values (@startDate ,@id , @serialNumber)

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
serialNumber=@serialNumber, title=@title, author=@author, language=@language, rating=@rating ,archive=@arcive, publishYear=@publishYear
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
--DROP PROCEDURE dbo.SP_Update_BookHistory
CREATE PROCEDURE dbo.SP_Update_BookHistory @copyNumber	INTEGER,@serialNumber VARCHAR(50), @id	VARCHAR(50), @startDate	DATETIME,@endDate DATETIME,@rate INTEGER
AS
Update dbo.BookHistory
SET
endDate=@endDate, rate=@rate
WHERE copyNumber=@copyNumber AND serialNumber=@serialNumber AND id=@id AND startDate=@startDate
--DROP PROCEDURE dbo.SP_Update_Event
CREATE PROCEDURE dbo.SP_Update_Event @guestType	VARCHAR(50),@date DATETIME,	@price	DECIMAL,@guestSpeakerName VARCHAR(50),@status VARCHAR(50), @maxGuests INTEGER,@currentlyRegistered INTEGER, @number INTEGER
AS
Update dbo.Events
SET
price=@price, guestType=@guestType, maxGuests=@maxGuests, currentlyRegistered=@currentlyRegistered, status =@status, date=@date, guestSpeakerName=@guestSpeakerName
WHERE number= @number
--DROP PROCEDURE dbo.SP_Update_Registration
CREATE PROCEDURE dbo.SP_Update_Registration @id VARCHAR(50),@showedUp	BIT,@review	VARCHAR(50),@rating	INTEGER,@number INTEGER ,@oldDate VARCHAR(50)
AS
Update dbo.Registrations
SET
showedUp=@showedUp, review=@review, rating=@rating, oldDate=@oldDate
WHERE number=@number AND id=@id --מפתח ראשי של רישום הוא גם ת.ז של סטודנט
--DROP PROCEDURE dbo.SP_Update_Request
CREATE PROCEDURE dbo.SP_Update_Request @type VARCHAR(50),@startDT DATETIME ,@sid	VARCHAR(50),@lid VARCHAR(50),@endDT	DATETIME,@status VARCHAR(50), @serialNum VARCHAR(50), @copyNum INTEGER
AS
Update dbo.Requests
SET
type=@type, endDT=@endDT, status=@status, serialNumber=@serialNum, copyNumber=@copyNum
WHERE startDT=@startDT AND sid=@sid AND lid=@lid

--Delete record
--DROP PROCEDURE dbo.SP_delete_Event
CREATE PROCEDURE dbo.SP_delete_Event @guestSpeakerName	VARCHAR(50),@date DATETIME
AS
DELETE FROM dbo.Events
WHERE @guestSpeakerName=@guestSpeakerName AND date=@date



--DROP PROCEDURE dbo.SP_delete_Books
CREATE PROCEDURE dbo.SP_delete_Books
AS
DELETE FROM dbo.Books
WHERE serialNumber IS NOT NULL
--DROP PROCEDURE dbo.SP_delete_Copies
CREATE PROCEDURE dbo.SP_delete_Copies
AS
DELETE FROM dbo.Copies
WHERE serialNumber IS NOT NULL
--DROP PROCEDURE dbo.SP_delete_Librarians
CREATE PROCEDURE dbo.SP_delete_Librarians
AS
DELETE FROM dbo.Librarians
WHERE id IS NOT NULL
--DROP PROCEDURE dbo.SP_delete_Teachers
CREATE PROCEDURE dbo.SP_delete_Teachers
AS
DELETE FROM dbo.Teachers
WHERE id IS NOT NULL
--DROP PROCEDURE dbo.SP_delete_Students
CREATE PROCEDURE dbo.SP_delete_Students
AS
DELETE FROM dbo.Students
WHERE id IS NOT NULL
--DROP PROCEDURE dbo.SP_delete_BookHistory
CREATE PROCEDURE dbo.SP_delete_BookHistory
AS
DELETE FROM dbo.BookHistory
WHERE id IS NOT NULL




--DROP PROCEDURE dbo.SP_delete_Events
CREATE PROCEDURE dbo.SP_delete_Events
AS
DELETE FROM dbo.Events
WHERE date IS NOT NULL
--DROP PROCEDURE dbo.SP_delete_Registrations
CREATE PROCEDURE dbo.SP_delete_Registrations
AS
DELETE FROM dbo.Registrations
WHERE id IS NOT NULL

--DROP PROCEDURE dbo.SP_delete_Requests
CREATE PROCEDURE dbo.SP_delete_Requests
AS
DELETE FROM dbo.Requests
WHERE id IS NOT NULL
--DROP PROCEDURE dbo.SP_delete_BookInWaitlist
CREATE PROCEDURE dbo.SP_delete_BookInWaitlist
AS
DELETE FROM dbo.BookInWaitlist
WHERE id IS NOT NULL
