--יצירת טבלאות
create Table Cars(Car_id INT PRIMARY KEY IDENTITY,
	License_number varchar(9),
	Model varchar(20),
	Color varchar(10),
	Price int,
	Image varchar(100) --בהנחה שתמונה הכוונה לקישור
);

create Table Races(Race_id INT PRIMARY KEY IDENTITY,
	RaceName varchar(20),
	RaceLocation varchar(20) --מקום כמו פתח תקווה, ירושלים וכו
);

create Table Cars_in_Races(Code INT PRIMARY KEY IDENTITY,
	idCar INT FOREIGN KEY REFERENCES Cars(Car_id),
	idRace INT FOREIGN KEY REFERENCES Races(Race_id),
	Rank int, --מקום 1, מקום 2 וכו
);

--drop table Cars
--drop table Races
--drop table Cars_in_Races


--הכנסת נתונים
insert into Cars values
('123456789', 'Toyota', 'Blue', 200000, 'gtgdhjfuygujfjrserdygkhv'),
('135790123', 'Phorche', 'Green', 700550, 'otgdhjfdfgdfgygujfjrserdygkhv'),
('123567528', 'Lamburgini', 'Black', 1200000, 'ptgdhjrserdygkhv'),
('879878632', 'BMW', 'Blue', 890000, 'bhhjukfjrserdygkhv'),
('098765444', 'Suzuki', 'Yellow', 190000, 'ltgdhjfuygujfjrserdygkhv');

insert into Races values 
('Vrooom', 'Jerusalem'),
('Meuw', 'New York'),
('The Race', 'Shykago'),
('Meuw', 'Shykago'),
('Meuw', 'Jerusalem'),
('Vrooom', 'New York'),
('Vrooom', 'Shykago'),
('The Race', 'New York'),
('The Race', 'Jerusalem'),
('Meuw', 'New Jerzi'),
('Jerusalem', 'New Jerzi'),
('The Race', 'New Jerzi');

insert into Cars_in_Races (idCar, idRace, Rank) values
(1, 1, 3),
(1, 3, 3),
(2, 2, 2),
(2, 3, 1),
(3, 2, 1),
(4, 1, 1),
(4, 2, 3),
(5, 1, 2),
(5, 2, 4),
(5, 3, 2),
(1, 4, 1),
(2, 5, 1),
(3, 6, 1),
(4, 7, 1),
(5, 8, 1),
(2, 9, 1),
(3, 10, 1),
(3, 11, 1),
(4, 12, 1);


--פקודות
select * from Races
	where RaceLocation = 'New York'

select * from Cars
	where License_number = '123567528'

select TOP 10 Races.RaceName, Races.RaceLocation, Cars.Car_id
from Races left join Cars_in_Races
on Races.Race_id = Cars_in_Races.idCar
left join Cars on Cars_in_Races.idCar = Cars.Car_id
where Cars_in_Races.Rank = 1

select top 1 Cars_in_Races.