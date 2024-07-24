CREATE TABLE Rooms(room_id INT PRIMARY KEY IDENTITY,
roomName varchar(15),
weekdayPrice float,
saturdayPrice float
);

CREATE TABLE Minyanim(minyan_id INT PRIMARY KEY IDENTITY,
hour Time,
isSaturday BIT,
roomId INT FOREIGN KEY REFERENCES Rooms(room_id)
);

CREATE TABLE Person(member_id INT PRIMARY KEY IDENTITY,
fullName varchar(30)
);

CREATE TABLE Link_Table(Code INT PRIMARY KEY IDENTITY,
idPerson INT FOREIGN KEY REFERENCES Person(member_id),
idMinyan INT FOREIGN KEY REFERENCES Minyanim(minyan_id)
);

--drop table Rooms
--drop table Minyanim
--drop table Person
--drop table Link_Table

insert into Rooms values('Room A', 32.5, 12.6), ('Room B', 40, 20), ('Room C', 12.9, 5), ('Room D', 25.8, 17);

insert into Minyanim values ('06:00', 0, 1),	('07:00', 0, 2),	('08:00', 0, 3),	('09:00', 0, 4),
('10:00', 0, 1),	('11:00', 0, 2),	('12:00', 0, 3),	('13:00', 0, 4),
('14:00', 0, 1),	('15:00', 0, 2),	('16:00', 0, 3),	('17:00', 0, 4),	
('18:00', 0, 1),	('19:00', 0, 2),	('20:00', 0, 3),    ('21:00', 0, 4),
('22:00', 0, 1),	('23:00', 0, 2),	('00:00', 0, 3),
('06:00', 1, 1),	('07:00', 1, 2),	('08:00', 0, 3),	('09:00', 0, 4),	
('10:00', 1, 1),	('11:00', 1, 2),	('12:00', 0, 3),	('13:00', 0, 4),	
('14:00', 1, 1),	('15:00', 1, 2),	('16:00', 0, 3),	('17:00', 0, 4),	
('18:00', 1, 1),	('19:00', 1, 2),	('20:00', 0, 3),    ('21:00', 0, 4);

insert into Person values ('Moshe Zucmir'), ('Eliau Yahv'),('Persy Jexson'),
('ELi Fishman'),('Elazar Porush'),('Harry Potter'),('Yahkov Levi'),
('Israel Balanga'),('Nahman Shalom'),('Jacoby Henson'),('Darnell Walsh'),('Averi Melton'),
('Haiden Gonzales'),('Rose Nash'),('Keshawn Cervantes'),('Kristian Bradley'),
('Ayaan Adams'),('Lukas Daniels'),('Carly Singh'),('Diya Ramirez'),('Chana Hicks');

insert into Link_Table values (1, 3),(1, 20),(2, 1),(2, 17),(3, 2),(3, 18),(4, 15),(4, 4),(5, 4),(5, 19),(6, 34),(6, 1),(7, 3),
(7, 35),(8, 20),(8, 8),(9, 7),(9, 14),(9, 33),(10, 32),(10, 12),(11, 29),(11, 30),
(12, 34),(12, 29),(12, 12),(13, 23),(13, 27),(13, 11),(14, 28);

--declare @MemberId int = 1
--declare @MinyanId int = 3

--select Rooms.weekdayPrice + Rooms.saturdayPrice from Rooms right join Minyanim
--on Rooms.room_id = Minyanim.roomId
--AND Minyanim.minyan_id = @MinyanId

--select Rooms.weekdayPrice + Rooms.saturdayPrice from Rooms right join Minyanim
--on Rooms.room_id = Minyanim.roomId
--AND Minyanim.minyan_id in (1, 2)

--select Rooms.weekdayPrice + Rooms.saturdayPrice from Rooms right join Minyanim
--on Rooms.room_id = Minyanim.roomId
--AND Minyanim.minyan_id in 
--	(select minyan_id from Link_Table
--	where idPerson = @MemberId )






declare @full_name varchar(30)='Moshe Zucmir', @code int;

select @code = (select member_id from  Person where fullName = @full_name);


select sum (case when Minyanim.isSaturday = 1 then Rooms.saturdayPrice else Rooms.weekdayPrice end) as personForMonths
from Link_Table 
left join  Minyanim on Link_Table.idMinyan = Minyanim.minyan_id
left join Rooms on Rooms.room_id = Minyanim.roomId where idPerson = @code

select Minyanim.minyan_id, sum(case when Minyanim.isSaturday = 1 then Rooms.saturdayPrice else Rooms.weekdayPrice end) as minianFormonths
from Minyanim 
left join Link_Table on Link_Table.idMinyan = Minyanim.minyan_id
left join Person on Person.member_id = Link_Table.idPerson
left join  Rooms on Minyanim.roomId = Rooms.room_id 
where Person.member_id is not null
group by Minyanim.minyan_id;

select * from Rooms
select * from Minyanim
select * from Person
select * from Link_Table
