declare @LastName varchar(20) = 'Davolio'

select employeeID, Title, firstName, lastName, HireDate
from Employees
where lastname = @LastName

