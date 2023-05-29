
-- insert into Librarians
INSERT INTO Librarians
	VALUES
		('216678793', 'Thora Read', '265e0a0c036c151896b94453b7aa2123', '0'); --librarian1

-- insert into Books
INSERT INTO Books
	VALUES
		('R5gL6ZaC', 'The Adventures of Tom Sawyer', 'Mark Twain', '1995', 'English', '4.5', '0'),
		('2zbXhPWG', 'The Adventures of Huckleberry Finn', 'Mark Twain', '1999', 'English', '3.8', '0'),
		('G2BB3AXM', 'Alice in Wonderland', 'Lewis Carroll', '1965', 'English', '5', '0'),
		('PgUSzuhd', 'Gulliver’s Travels', 'Jonathan Swift', '1985', 'English', '4.5', '0'),
		('vrZSkybm', 'Robinson Crusoe', 'Daniel Defoe', '1995', 'English', '4', '0'),
		('f8FdKeyX', 'Around the World in Eighty Days', 'Jules Verne', '2000', 'English', '3.9', '0'),
		('vhR6uwAn', 'Moby Dick', 'Herman Melville', '1976', 'English', '4.7', '0'),
		('axMxHwGW', 'Treasure Island', 'RL Stevenson', '1998', 'English', '3', '0'),
		('v6EtfeD3', 'The Three Musketeers', 'Alexander Dumas', '1960', 'English', '4.2', '0'),
		('5kReQmoD', 'Oliver Twist', '	Charles Dickens', '1990', 'English', '4.5', '0'),
		('3hCJV2Xv', 'Black Beauty', 'Anna Sewell', '1980', 'English', '3.5', '0'),
		('rCbp43Rh', 'The Wonderful Wizard of Oz', 'L Frank Baum', '1990', 'English', '5', '0'),
		('SUoFHA92', 'Heidi', '	Johanna Spyri', '1966', 'English', '3', '0'),
		('rT2zgN9W', 'Jungle Book', 'Rudyard Kipling', '1935', 'English', '4.8', '0'),
		('krXedyFz', 'The Story of Doctor Dolittle', 'Hugh Lofting', '1988', 'English', '4.4', '0');

-- insert into Copies
INSERT INTO Copies
	VALUES
	('1', 'R5gL6ZaC', '1'),
	('2', 'R5gL6ZaC', '0'),
	('3', 'R5gL6ZaC', '1'),
	('1', '2zbXhPWG', '1'),
	('2', '2zbXhPWG', '1'),
	('1', 'axMxHwGW', '1'),
	('1', 'rCbp43Rh', '1'),
	('2', 'rCbp43Rh', '1'),
	('3', 'rCbp43Rh', '0'),
	('4', 'rCbp43Rh', '1'),
	('1', 'SUoFHA92', '1'),
	('1', '5kReQmoD', '1'),
	('1', 'vhR6uwAn', '1'),
	('2', 'vhR6uwAn', '0'),
	('3', 'vhR6uwAn', '1');


-- insert into Teachers
INSERT INTO Teachers
	VALUES
		('333156723', 'Nadine Flumberghast', '41c8949aa55b8cb5dbec662f34b62df3', '0'), --teacher1
		('370674343', 'Leah MacGrady', 'ccffb0bb993eeb79059b31e1611ec353', '0'), --teacher2
		('289618258', 'Francis Haney', 'b051062e6e050216fe28cafb8d782af9', '0'),
		('471701305', 'John Morris', 'b2451accf8d8f4b98384928edccc94cb', '0'),
		('444665267', 'Nigel Ratburn', '48e74ee03a8184ec9838d4787167f0fd', '0'),
		('226906345', 'James MacDonald', 'ac299edfc5e694f2bac06b7a6b210904', '0'),
		('270293596', 'Tommy Tibble', '97c922d3dde79a0b32987da82dfa0f49', '0'),
		('334210742', 'Sue Armstrong', 'f21ddcde6955299ea3df37798d3fe2cf', '0'),
		('259197984', 'Fern Walters', '2b055cf57ca3781fa63db6513772ed0e', '0'),
		('329153019', 'Ladonna Compson', '606a8545d8d9d21e6003544f03dc0f95', '0'),
		('259184531', 'Prunell Deegan', 'efe64a9013fa51ea43a6ccd5fea626aa', '0'),
		('201500851', 'Binky Barnes', '95c9b150614067c4a98640ed569a0500', '0'),
		('448229804', 'Mary Alice', '5de386a6138fc8be2b332bb9bd596efe', '0'),
		('215660377', 'Muffy Crosswire', 'e9f3742f4cd3106dfe4621ba39540938', '0'),
		('279401232', 'Francine Frensky', 'c9f742d4e1d0d99b50080f37e0089698', '0'); --100KelevYam


-- insert into Students
INSERT INTO Students
	VALUES
		('275733109', 'Jane Read', '12', 'The Bookies', '5', '5e5545d38a68148a2d5bd5ec9a89e327', '0'), --student1
		('383306250', 'Dora Winifred', '10', 'The Book Marks', '2', '213ee683360d88249109c2f92789dbc3', '0'), -- student2
		('374857920', 'Buster Baxter', '11', 'Book Besties', '3', '77ac55ee71f97b3173812f6aeccffab2', '0'),
		('323966969', 'Adil Akyuz', '9', 'Sequel Chasers', '10', '2cbf6421343088d12f3b7686a988fd4d', '0'),
		('487451253', 'Phineas Flynn', '12', 'The Bookies', '7', 'ae59761161b5f3a9a2b6bf2f1da27dfc', '0'),
		('209662432', 'Ferbs Fletcher', '9', 'Book Besties', '5', 'ba1da70938663f4dc4fe42b03df375d2', '0'),
		('265571602', 'Candace Flynn', '12', 'The Bookies', '5', 'df80b6b5332e5067cf0b506cf9907f18', '0'),
		('204539542', 'Isabella Garcia', '7', 'Sequel Chasers', '4', 'aa69e441afdf8f24e52e17f455de6b26', '0'),
		('382528055', 'Baljeet Tjinder', '8', 'Book Besties', '3', 'ff13fb4c40a11640f8b1ae9eae2cb2a6', '0'),
		('480945291', 'Vanessa Doofenshmirtz', '8', 'The Bookies', '7', '8377f167cd3e19422cc3b784545fefd6', '0'),
		('407123244', 'Django Brown', '12', 'The Bookies', '2', '06e4ea228d9074e48f35b79fd99f15b2', '0'),
		('436881234', 'Peter Griffin', '11', 'The Book Marks', '3', '728f6b13f3ad20d35321d541a2848e9e', '0'),
		('217392528', 'Mickey McFinnigan', '8', 'Sequel Chasers', '3', '8e5d878d642eb114a8915a152dc0facb', '0'),
		('364876836', 'Carter Pewterschmidt', '10', 'The Book Marks', '8', 'a6951ceaf40b140f4f0b308680992681', '0'),
		('336015350', 'Dylan Flannigan', '12', 'The Bookies', '5', '82027888c5bb8fc395411cb6804a066c', '0');


-- insert into BookHistory
INSERT INTO BookHistory
	VALUES
	('1', 'R5gL6ZaC', '336015350',CONVERT(datetime, '15/09/2022 10:21:51', 103), CONVERT(datetime, '16/09/2022 10:21:51', 103), '5'),
	('2', 'R5gL6ZaC', '209662432',CONVERT(datetime,'16/04/2020 11:18:27', 103),'',''),
	('3', 'R5gL6ZaC', '480945291',CONVERT(datetime, '07/05/2022 10:26:04',103), CONVERT(datetime, '07/06/2022 11:26:04',103), '4'),
	('1', '2zbXhPWG', '209662432',CONVERT(datetime, '11/05/2022 10:28:58', 103), CONVERT(datetime, '12/05/2022 10:28:58', 103), '3'),
	('2', '2zbXhPWG', '204539542',CONVERT(datetime, '11/06/2022 10:38:58', 103), CONVERT(datetime, '18/06/2022 10:38:58', 103), '4'),
	('1', 'axMxHwGW', '275733109',CONVERT(datetime, '09/01/2021 08:05:43', 103), CONVERT(datetime, '11/01/2021 09:05:43', 103), '4'),
	('1', 'rCbp43Rh', '383306250',CONVERT(datetime, '22/03/2022 08:28:38', 103), CONVERT(datetime, '24/03/2022 08:28:38', 103), '5'),
	('2', 'rCbp43Rh', '336015350',CONVERT(datetime, '23/04/2022 09:14:24', 103), CONVERT(datetime, '21/05/2022 09:14:24', 103), '3'),
	('3', 'rCbp43Rh', '323966969',CONVERT(datetime, '15/02/2022 10:15:32', 103),'',''),
	('4', 'rCbp43Rh', '382528055',CONVERT(datetime, '11/06/2022 13:26:55', 103), CONVERT(datetime, '17/06/2022 13:26:55', 103), '2'),
	('1', 'SUoFHA92', '336015350',CONVERT(datetime, '12/03/2022 12:27:57', 103), CONVERT(datetime, '16/03/2022 12:27:57', 103), '3'),
	('1', 'R5gL6ZaC', '383306250',CONVERT(datetime, '08/05/2022 11:24:01', 103), CONVERT(datetime, '10/05/2022 11:24:01', 103), ''),
	('1', 'vhR6uwAn', '217392528',CONVERT(datetime, '01/01/2022 14:25:04', 103), CONVERT(datetime, '23/01/2022 14:25:04', 103), ''),
	('2', 'vhR6uwAn', '382528055',CONVERT(datetime, '11/05/2022 10:35:16', 103),'',''),
	('3', 'vhR6uwAn', '204539542',CONVERT(datetime, '17/09/2022 08:37:19', 103),CONVERT(datetime, '18/09/2022 08:37:19', 103), '4');


-- insert into Events
INSERT INTO Events
	VALUES
	('Author', CONVERT(datetime, '18/09/2022 11:00:00', 103), '5001.6', 'Barbara Cartland','Open' ,'50', '40'),
	('Publisher', CONVERT(datetime, '18/10/2022 12:00:00', 103), '8000.00', 'Agatha Christie','Open' , '100', '50'),
	('Author', CONVERT(datetime, '10/05/2022 11:00:00', 103), '4003.47', 'Danielle Steel','Open' ,'50', '50'),
	('Actor', CONVERT(datetime, '08/06/2022 15:00:00', 103), '4567.88', 'Tom Hanks', 'Open' , '60', '60'),
	('Author', CONVERT(datetime, '18/06/2022 15:00:00', 103), '999.88', 'Michael Caine', 'Open', '50', '35'),
	('Actor', CONVERT(datetime, '17/04/2022 11:00:00', 103), '10000.13', 'Leonardo DiCaprio', 'Open', '50', '27'),
	('Actor', CONVERT(datetime, '18/03/2022 14:00:00', 103), '5001.34', 'Al Pacino', 'Open', '25', '25'),
	('Author', CONVERT(datetime, '13/09/2022 10:00:00', 103), '34543.78', 'William Shakespeare', 'Open', '50', '45'),
	('Author', CONVERT(datetime, '10/04/2022 11:00:00', 103), '345.56', 'Dustin Hoffman', 'Open', '70', '70'),
	('Publisher', CONVERT(datetime, '09/09/2022 11:00:00', 103), '234.77', 'Denzel Washington', 'Open', '50', '50'),
	('Author', CONVERT(datetime, '03/02/2022 09:00:00', 103), '9812.12', 'Clint Eastwood', 'Open', '50', '40'),
	('Publisher', CONVERT(datetime, '10/01/2022 10:00:00', 103), '333.44', 'Robert De Niro', 'Open', '50', '44'),
	('Author', CONVERT(datetime, '25/02/2022 11:00:00', 103), '6567.77', 'Samuel Jackson', 'Open', '100', '100'),
	('Author', CONVERT(datetime, '22/03/2022 10:00:00', 103), '555.55', 'Vin Diesel', 'Open', '100', '80'),
	('Actor', CONVERT(datetime, '11/06/2022 11:00:00', 103), '7876.66', 'Ben Kingsley', 'Open', '100', '88'),
	('Author', CONVERT(datetime, '23/05/2022 11:00:00', 103), '1000.00', 'Edward Norton', 'Open', '50', '40');

-- insert into Registrations
INSERT INTO Registrations
	VALUES
	('275733109', CONVERT(datetime, '18/09/2022 11:00:00', 103), 'Barbara Cartland', '1', 'i enjoyed it', '5'),
	('383306250', CONVERT(datetime, '18/09/2022 11:00:00', 103), 'Barbara Cartland', '1', '', ''),
	('275733109', CONVERT(datetime, '18/10/2022 12:00:00', 103), 'Agatha Christie', '1', '', '3'),
	('265571602', CONVERT(datetime, '18/10/2022 12:00:00', 103), 'Agatha Christie', '1', '', ''),
	('480945291', CONVERT(datetime, '18/10/2022 12:00:00', 103), 'Agatha Christie', '0', '', ''),
	('275733109', CONVERT(datetime, '08/06/2022 15:00:00', 103), 'Tom Hanks', '1', '', '5'),
	('265571602', CONVERT(datetime, '08/06/2022 15:00:00', 103), 'Tom Hanks', '1', 'it was fun', '4'),
	('336015350', CONVERT(datetime, '08/06/2022 15:00:00', 103), 'Tom Hanks', '1', 'i enjoyed it', '4'),
	('275733109', CONVERT(datetime, '25/02/2022 11:00:00', 103), 'Samuel Jackson', '0', '', ''),
	('275733109', CONVERT(datetime, '22/03/2022 10:00:00', 103), 'Vin Diesel', '1', 'i enjoyed it', '5'),
	('480945291', CONVERT(datetime, '22/03/2022 10:00:00', 103), 'Vin Diesel', '0', '', ''),
	('275733109', CONVERT(datetime, '11/06/2022 11:00:00', 103), 'Ben Kingsley', '1', 'i didnt like it', '1'),
	('336015350', CONVERT(datetime, '11/06/2022 11:00:00', 103), 'Ben Kingsley', '0', '', ''),
	('275733109', CONVERT(datetime, '13/09/2022 10:00:00', 103), 'William Shakespeare', '1', 'i enjoyed it', '5'),
	('217392528', CONVERT(datetime, '13/09/2022 10:00:00', 103), 'William Shakespeare', '1', 'boring', '2');



-- insert into Requests
INSERT INTO Requests
	VALUES
	('Time Extention', CONVERT(datetime, '14/09/2022 10:10:40', 103), '275733109', '216678793', CONVERT(datetime, '16/09/2022 14:10:30', 103), 'Approved', ''),
	('Time Extention', CONVERT(datetime, '15/09/2022 15:10:35', 103), '336015350', '216678793', CONVERT(datetime, '17/09/2022 15:10:35', 103), 'Declined', ''),
	('Time Extention', CONVERT(datetime, '11/11/2022 13:21:41', 103), '275733109', '216678793', '', 'In process', ''),
	('Time Extention', CONVERT(datetime, '11/12/2022 12:11:10', 103), '336015350', '216678793', '', 'In process', ''),
	('Time Extention', CONVERT(datetime, '18/09/2022 14:14:23', 103), '204539542', '216678793', '', 'In process', ''),
	('Alternative Book', CONVERT(datetime, '17/10/2022 11:11:40', 103), '275733109', '216678793', CONVERT(datetime, '23/10/2022 11:11:40', 103), 'Declined', 'C:\Documents\Requests\Summer2022.pdf'),
	('Time Extention', CONVERT(datetime, '22/12/2022 09:10:33', 103), '275733109', '216678793', '', 'In process', ''),
	('Time Extention', CONVERT(datetime, '28/01/2022 09:34:12', 103), '336015350', '216678793', '', 'In process', ''),
	('Alternative Book', CONVERT(datetime, '22/03/2022 11:10:10', 103), '275733109', '216678793', '', 'In process', 'C:\Documents\Newsletters\Summer2018.pdf'),
	('Time Extention', CONVERT(datetime, '29/03/2022 14:10:47', 103), '204539542', '216678793', CONVERT(datetime, '03/04/2022 11:11:35', 103), 'Approved', ''),
	('Time Extention', CONVERT(datetime, '19/10/2022 10:10:40', 103), '336015350', '216678793', '', 'In process', ''),
	('Time Extention', CONVERT(datetime, '23/05/2022 14:33:23', 103), '275733109', '216678793', '', 'In process', ''),
	('Time Extention', CONVERT(datetime, '20/03/2022 11:45:45', 103), '336015350', '216678793', '', 'In process', ''),
	('Time Extention', CONVERT(datetime, '23/12/2022 08:10:00', 103), '204539542', '216678793', '', 'In process', ''),
	('Alternative Book', CONVERT(datetime, '12/12/2022 11:05:32', 103), '217392528', '216678793', CONVERT(datetime, '12/12/2022 18:05:32', 103), 'Approved', ''),
	('Time Extention', CONVERT(datetime, '02/02/2022 12:45:13', 103), '480945291', '216678793', '', 'In process', '');


-- insert into BookInWaitlist
INSERT INTO BookInWaitlist
	VALUES
	(CONVERT(datetime, '10/09/2022 10:10:40', 103), '275733109', 'R5gL6ZaC'),
	(CONVERT(datetime, '14/10/2022 10:10:40', 103), '383306250', 'R5gL6ZaC'),
	(CONVERT(datetime, '14/11/2022 10:10:40', 103), '383306250', '2zbXhPWG'),
	(CONVERT(datetime, '27/09/2022 10:10:40', 103), '374857920', 'R5gL6ZaC'),
	(CONVERT(datetime, '17/10/2022 10:10:40', 103), '323966969', 'G2BB3AXM'),
	(CONVERT(datetime, '14/09/2022 10:10:40', 103), '323966969', 'PgUSzuhd'),
	(CONVERT(datetime, '14/09/2022 10:10:40', 103), '323966969', 'R5gL6ZaC'),
	(CONVERT(datetime, '14/09/2022 10:10:40', 103), '204539542', 'R5gL6ZaC'),
	(CONVERT(datetime, '14/09/2022 10:10:40', 103), '204539542', 'vrZSkybm'),
	(CONVERT(datetime, '14/09/2022 10:10:40', 103), '407123244', 'R5gL6ZaC'),
	(CONVERT(datetime, '14/09/2022 10:10:40', 103), '407123244', 'vrZSkybm'),
	(CONVERT(datetime, '14/09/2022 10:10:40', 103), '336015350', 'R5gL6ZaC'),
	(CONVERT(datetime, '14/09/2022 10:10:40', 103), '265571602', 'vrZSkybm'),
	(CONVERT(datetime, '14/09/2022 10:10:40', 103), '265571602', 'R5gL6ZaC'),
	(CONVERT(datetime, '14/09/2022 10:10:40', 103), '265571602', '5kReQmoD'),
	(CONVERT(datetime, '14/09/2022 10:10:40', 103), '217392528', 'R5gL6ZaC');
