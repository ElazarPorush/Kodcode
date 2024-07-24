using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClock
{
    internal class EmployeeManeger
    {
        private static string _loginSQL = "declare @fullName varchar(20)='', @Code int, @Answer varchar(250),\r\n@passwords varchar(12);\r\n\r\nIF EXISTS( SELECT * FROM Employ WHERE Id= @id)\r\n\tbegin\r\n\t\tSELECT @Code = (select Code FROM Employ where Id=@id)\r\n\tend\r\nelse\r\n\tbegin\r\n\t\tINSERT INTO Employ VALUES (@fullName, @id);\r\n\t\tselect @Code=@@IDENTITY;\r\n\tend\r\n\r\n\r\n\r\n\r\nif exists (select * from Passwords where userId = @Code)\r\n\tbegin\r\n\t\tif exists (select * from Passwords where passwordEmploy = @Passwords\r\n\t\tAND isActivate=1)\r\n\t\t\tbegin\r\n\t\t\t\tif exists (select passwordEmploy from Passwords where passwordEmploy = @Passwords\r\n\t\t\t\tAND isActivate=1 AND dateOfExpiry >= GETDATE())\r\n\t\t\t\t\tbegin\r\n\t\t\t\t\t\t--שעת כניסה ושעת יציאה\r\n\t\t\t\t\t\tif exists (select * FROM Time_Clock where userId = @Code\r\n\t\t\t\t\t\tAND ExitTime is null)\r\n\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\t\tupdate Time_Clock set ExitTime = GETDATE() where userId = @code AND ExitTime is null;\r\n\t\t\t\t\t\t\t\tselect @Answer = 'Exit time is:' + CONVERT (nvarchar, getdate(), 121);\r\n\t\t\t\t\t\t\tend\r\n\t\t\t\t\t\telse\r\n\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\t\tinsert into Time_Clock values (@Code, GETDATE(), null);\r\n\t\t\t\t\t\t\t\tselect @Answer = 'Entery time is: ' + CONVERT (nvarchar, getdate(), 121);\r\n\t\t\t\t\t\t\tend\r\n\t\t\t\t\tend\r\n\t\t\t\telse\r\n\t\t\t\t\tbegin\r\n\t\t\t\t\t\tselect @Answer = 'Please update your password';\r\n\t\t\t\t\tend\r\n\t\t\tend\r\n\t\telse\r\n\t\t\tbegin\r\n\t\t\t\tselect @Answer = 'Incorrect password'\r\n\t\t\tend\r\n\tend\r\nelse\r\n\tbegin\r\n\t\tinsert into Passwords values (@Passwords, dateadd(day, 180, getdate()), 1, @Code);\r\n\t\tselect @Answer = 'you created a new worker and password';\r\n\tend\r\n\r\nselect @Answer;\r\n";
        private static string _changePasswordSQL = "declare @Answer2 varchar(250),\r\n@Code int,\r\n@fullName varchar (30) = '';\r\n\r\nIF EXISTS( SELECT * FROM Employ where Id = @id)\r\n\tbegin\r\n\t\tSELECT @Code = (select Code FROM Employ where Id=@id)\r\n\tend\r\nelse\r\n\tbegin\r\n\t\tINSERT INTO Employ VALUES (@fullName, @id);\r\n\t\tselect @Code=@@IDENTITY;\r\n\tend\r\n\r\nif exists (select * from Passwords where userId = @Code)\r\n\tbegin\r\n\t\tif exists (select * from Passwords where passwordEmploy = @oldPassword AND isActivate = 1)\r\n\t\t\tbegin\r\n\t\t\t\tif (@newPassword1 = @newPassword2)\r\n\t\t\t\t\tbegin\r\n\t\t\t\t\t\tupdate Passwords set isActivate = 0 where userId = @Code\r\n\t\t\t\t\t\tinsert into Passwords values (@newPassword1, dateadd(day, 180, getdate()), 1, @Code);\r\n\t\t\t\t\t\tselect @Answer2 = 'New password update!'\r\n\t\t\t\t\tend\r\n\t\t\t\telse\r\n\t\t\t\t\tbegin\r\n\t\t\t\t\t\tselect @Answer2 = 'The conforme password is not match!'\r\n\t\t\t\t\tend\r\n\t\t\tend\r\n\t\telse\r\n\t\t\tbegin\r\n\t\t\t\tselect @Answer2 = 'The Password is not corect, please try again'\r\n\t\t\tend\r\n\tend\r\nelse\r\n\tbegin\r\n\t\tinsert into Passwords values (@newPassword1, dateadd(day, 180, getdate()), 1, @Code);\r\n\t\tselect @Answer2 = 'Password id not found'\r\n\tend\r\n\r\nselect @Answer2 as Answer";
       
        public static string Login(string id, string password)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB
            string[] parameters = { "@id", "@Password" };
            string[] values = { id, password };
            SqlDataReader res = DBConection.RunSQLAllResult(_loginSQL, parameters, values);
            // 3. Return response
            return res.ToString();
        }
        public static string ChangePassword(string id, string oldPass, string newPass, string confirmPass)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB
            string[] parameters = { "@id", "@oldPassword", "@newPassword1", "@newPassword2" };
            string[] values = { id, oldPass, newPass, confirmPass };
            SqlDataReader res = DBConection.RunSQLAllResult(_changePasswordSQL, parameters, values);
            // 3. Return response
            return res.ToString();
        }

    }

}
