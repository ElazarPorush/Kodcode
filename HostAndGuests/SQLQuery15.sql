--create tables
create table Categories(CotegoryId int primary key identity,
NameCategory varchar(30)
);

create table Guests(GuestId int primary key identity,
NameGuest varchar(30)
);

create table Orders(OrderId int primary key identity,
Meal varchar(30),
IdGuest int foreign key references Guests(GuestId),
IdCategory int foreign key references Categories(CotegoryId)
);


--drop tables?
--drop table Categories
--drop table Guests
--drop table Orders


--add category

--Declare variable
declare @CategoryName varchar(20) = 'Desart';
--search category
if not exists(select NameCategory from Categories where NameCategory = @CategoryName)
	begin
		--add category
		insert into Categories values (@CategoryName)
		select NameCategory from Categories
	end
else
	begin
		select NameCategory from Categories
	end


--get the categories (search by char)
declare @tmp varchar(30) = 'e';
select NameCategory from Categories
where NameCategory like '%' + @tmp + '%'

--get the guests (search by char)
declare @tmp2 varchar(30) = 'e';
select NameGuest from Guests
where NameGuest like '%' + @tmp2 + '%'

--add guest

--Declare variable
declare @GuestName varchar(30) = 'yhakov';
--search guest
if not exists(select NameGuest from Guests where NameGuest = @GuestName)
	begin
		--add guest
		insert into Guests values (@GuestName)
		select NameGuest from Guests
	end
else
	begin
		select NameGuest from Guests
	end


--add meal

--declare variables
declare @id_Category int, @id_Guest int;
declare @Meal varchar(30)='poteto', @name varchar(30) = 'yahkov', @Category_name varchar(30) = 'Fish';

--select id of guest and category
SELECT @id_Guest = (select GuestId FROM Guests where NameGuest = @name)
SELECT @id_Category = (select CotegoryId FROM Categories where NameCategory = @Category_name)

--insert if exists
if (@Category_name is not null and @name is not null)
	begin
		--insert new meal
		insert into Orders values(@Meal, @id_Guest, @id_Category); 
	end


--get orders' meals + the number of times that ordered

--declare variable
declare @id int;
declare @category varchar(30) = 'Fish'; 
--get category id 
select @id = (select CotegoryId from Categories where NameCategory = @category)
--get orders
select Meal, count(*) as number from Orders where IdCategory = @id
group by Meal


--Chosen's meals of Guest

--declare variable
declare @NameGuest varchar(30) = 'Moshe';
declare @NameCategory varchar(30) = 'Fish';
--get Chosen's meals
select Orders.Meal as Meal, count(Orders.Meal) as number from Orders
join Categories on Categories.CotegoryId = Orders.IdCategory
join Guests on Guests.GuestId = Orders.IdGuest
where @NameCategory = Categories.NameCategory and @NameGuest = Guests.NameGuest
group by Meal


--Non chosen's meals of guest

--declare variable
declare @NameGuest2 varchar(30) = 'Moshe';
declare @NameCategory2 varchar(30) = 'Fish';
--get non Chosen's meals
select Orders.Meal as Meal, count(Orders.Meal) as counter from Orders
join Categories on Categories.CotegoryId = Orders.IdCategory
join Guests on Guests.GuestId = Orders.IdGuest
where @NameCategory2 = Categories.NameCategory and @NameGuest2 = Guests.NameGuest
group by Meal


--print tables
select * from Categories;
select * from Guests;
select * from Orders;
delete from Categories where NameCategory = 'Cookes';