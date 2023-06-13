use SADM_4

CREATE TABLE dbo.Librarians (
	id			VARCHAR(50) NOT NULL, 
	name		VARCHAR(50) NOT NULL,
	password	VARCHAR(100) NOT NULL,
	archive			BIT		NOT NULL,
	CONSTRAINT PK_Librarian PRIMARY KEY (id)
)

CREATE TABLE dbo.Books (
	serialNumber	VARCHAR(50) NOT NULL,
	title			VARCHAR(50) NOT NULL,
	author			VARCHAR(50)	NOT NULL,
	publishYear		INTEGER		NOT NULL, 
	language		VARCHAR(50)	NOT NULL,
	rating			FLOAT,
	archive			BIT			NOT NULL,			
	CONSTRAINT PK_Book PRIMARY KEY (serialNumber)
)

CREATE TABLE dbo.Copies (
	copyNumber		INTEGER NOT NULL,
	serialNumber	VARCHAR(50) NOT NULL, 
	status			BIT NOT NULL,
	deleted			BIT NOT NULL
	CONSTRAINT FK_Copy_To_Book FOREIGN KEY (serialNumber) 
		REFERENCES Books(serialNumber), -- CHECK WITH LIEL IF FOREIGN KEYS ARE ALLOWED
	CONSTRAINT PK_Copy PRIMARY KEY (copyNumber, serialNumber) 
)


CREATE TABLE dbo.Teachers (
	id			VARCHAR(50)	NOT NULL, 
	name		VARCHAR(50)	NOT NULL,
	password	VARCHAR(100)	NOT NULL,
	archive		BIT				NOT NULL,
	CONSTRAINT PK_Teacher PRIMARY KEY (id)
)


CREATE TABLE dbo.Students (
	id			VARCHAR(50) NOT NULL,
	name		VARCHAR(50) NOT NULL,
	age			INTEGER,
	club		VARCHAR(50),
	yearlyGoal	INTEGER,
	password	VARCHAR(100) NOT NULL,
	archive		BIT			NOT NULL,
	CONSTRAINT PK_Student PRIMARY KEY (id)
)


CREATE TABLE dbo.BookHistory (
	copyNumber		INTEGER NOT NULL,
	serialNumber	VARCHAR(50) NOT NULL, 
	id				VARCHAR(50) NOT NULL, 
	startDate		DATETIME		NOT NULL,
	endDate			DATETIME,
	rate			INTEGER,
	CONSTRAINT PK_BookHistory PRIMARY KEY (copyNumber, serialNumber, id, startDate),
	CONSTRAINT FK_BookHistory_To_Copy FOREIGN KEY (copyNumber, serialNumber)
		REFERENCES Copies (copyNumber, serialNumber),
	CONSTRAINT FK_BookHistory_To_Student FOREIGN KEY (id)
		REFERENCES Students (id)
)

--DROP TABLE dbo.Events
CREATE TABLE dbo.Events (
	guestType			VARCHAR(50),	
	date				DATETIME NOT NULL,
	price				DECIMAL,  --Is this the right data type to use collaborating with c#?
	guestSpeakerName	VARCHAR(50) NOT NULL,
	status				VARCHAR(50),
	maxGuests			INTEGER,
	currentlyRegistered	INTEGER,
	number				INTEGER NOT NULL,
	CONSTRAINT PK_Event PRIMARY KEY (number)
)

--DROP TABLE dbo.Registrations
CREATE TABLE dbo.Registrations (
	id					VARCHAR(50) NOT NULL,
	showedUp			BIT,
	review				VARCHAR(50),
	rating				INTEGER, 
	number				INTEGER NOT NULL,
	oldDate				VARCHAR(50),
	CONSTRAINT PK_Registration PRIMARY KEY (id, number),
	CONSTRAINT FK_Registration_To_Event FOREIGN KEY (number)
		REFERENCES Events (number),
	CONSTRAINT FK_Registration_To_Student FOREIGN KEY (id)
		REFERENCES Students (id)
)

--DROP TABLE dbo.Requests
CREATE TABLE dbo.Requests (
	type			VARCHAR(50),
	startDT			DATETIME NOT NULL,
	sid				VARCHAR(50) NOT NULL,
	lid				VARCHAR(50) NOT NULL,
	endDT			DATETIME,
	status			VARCHAR(50),
	photoAddress	NVARCHAR(260), --CHECK THIS DATA TYPE WITH LIEL
	serialNumber	VARCHAR(50),
	copyNumber		INTEGER,

	CONSTRAINT PK_Request PRIMARY KEY (startDT, sid, lid),
	CONSTRAINT FK_Request_To_Student FOREIGN KEY (sid)
		REFERENCES Students (id),
	CONSTRAINT FK_Request_To_Librarian FOREIGN KEY (lid)
		REFERENCES Librarians (id)
)


CREATE TABLE dbo.BookInWaitlist (
	startDate	DATETIME,
	id		VARCHAR(50) NOT NULL,
	serialNumber	VARCHAR(50) NOT NULL,
	CONSTRAINT PK_BookInWaitlist PRIMARY KEY (id, serialNumber),
	CONSTRAINT FK_BookInWaitlist_To_Student FOREIGN KEY (id)
		REFERENCES Students (id),
	CONSTRAINT FK_BookInWaitlist_To_Book FOREIGN KEY (serialNumber)
		REFERENCES Books (serialNumber)
)

