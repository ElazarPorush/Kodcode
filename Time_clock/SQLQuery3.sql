CREATE TABLE Employ(Code INT PRIMARY KEY IDENTITY,
full_name VARCHAR(30),
Id VARCHAR(10) UNIQUE NOT NULL
);

CREATE TABLE Passwords(Code INT PRIMARY KEY IDENTITY,
passwordEmploy VARCHAR(12),
dateOfExpiry DATE,
userId INT FOREIGN KEY REFERENCES Employ(Code),
isActivate BIT
);

CREATE TABLE Time_Clock(Code INT PRIMARY KEY IDENTITY,
EnterTime DATETIME,
ExitTime DATETIME,
userId INT FOREIGN KEY REFERENCES Employ(Code),
);

--drop table Employ
--drop table Passwords
--drop table Time_Clock

SELECT * FROM Employ
SELECT * FROM Passwords
SELECT * FROM Time_Clock

declare @id VARCHAR(10)='3';

declare @fullName varchar(20)='', @Code int, @Answer varchar(250),
@passwords varchar(12);

IF EXISTS( SELECT * FROM Employ WHERE Id= @id)
	begin
		SELECT @Code = (select Code FROM Employ where Id=@id)
	end
else
	begin
		INSERT INTO Employ VALUES (@fullName, @id);
		select @Code=@@IDENTITY;
	end



if exists (select * from Passwords where userId = @Code)
	begin
		if exists (select * from Passwords where passwordEmploy = @Passwords
		AND isActivate=1)
			begin
				if exists (select passwordEmploy from Passwords where passwordEmploy = @Passwords
				AND isActivate=1 AND dateOfExpiry >= GETDATE())
					begin
						--שעת כניסה ושעת יציאה
						if exists (select * FROM Time_Clock where userId = @Code
						AND ExitTime is null)
							begin
								update Time_Clock set ExitTime = GETDATE() where userId = @code AND ExitTime is null;
								select @Answer = 'Exit time is:' + CONVERT (nvarchar, getdate(), 121);
							end
						else
							begin
								insert into Time_Clock values (@Code, GETDATE(), null);
								select @Answer = 'Entery time is: ' + CONVERT (nvarchar, getdate(), 121);
							end
					end
				else
					begin
						select @Answer = 'Please update your password';
					end
			end
		else
			begin
				select @Answer = 'Incorrect password'
			end
	end
else
	begin
		insert into Passwords values (@Passwords, dateadd(day, 180, getdate()), 1, @Code);
		select @Answer = 'you created a new worker and password';
	end

select @Answer;

