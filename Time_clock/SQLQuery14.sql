SELECT * FROM Employ
SELECT * FROM Passwords
SELECT * FROM Time_Clock

declare @id varchar (10) = '4654',
@oldPassword varchar(12) = '464564',
@newPassword1 varchar(12) = '111',
@newPassword2 varchar(12) = '111';

declare @Answer2 varchar(250),
@Code int,
@fullName varchar (30) = '';

IF EXISTS( SELECT * FROM Employ where Id = @id)
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
		if exists (select * from Passwords where passwordEmploy = @oldPassword AND isActivate = 1)
			begin
				if (@newPassword1 = @newPassword2)
					begin
						update Passwords set isActivate = 0 where userId = @Code
						insert into Passwords values (@newPassword1, dateadd(day, 180, getdate()), 1, @Code);
						select @Answer2 = 'New password update!'
					end
				else
					begin
						select @Answer2 = 'The conforme password is not match!'
					end
			end
		else
			begin
				select @Answer2 = 'The Password is not corect, please try again'
			end
	end
else
	begin
		insert into Passwords values (@newPassword1, dateadd(day, 180, getdate()), 1, @Code);
		select @Answer2 = 'Password id not found'
	end

select @Answer2 as Answer