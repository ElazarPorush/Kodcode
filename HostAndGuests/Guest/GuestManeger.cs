using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guest
{
    internal class GuestManeger
    {
        public static List<string> GetGuests()
        {
            string sql = "Select * from Guests";
            SqlDataReader reader = DBConection.RunSQLAllResult(sql);

            List<string> guests = new List<string>();

            for (int i = 0; reader.Read(); i++)
            {
                guests.Add(reader.GetString(1));
            }
            reader.Close();
            return guests;
        }

        public static List<string> SearchGuests(string textSearch)
        {
            string sql = "select NameGuest from Guests\r\nwhere NameGuest like '%' + @tmp2 + '%'";
            string[] parameters = { "@tmp2" };
            string[] values = { textSearch };
            SqlDataReader reader = DBConection.RunSQLAllResult(sql, parameters, values);
            List<string> guests = new List<string>();

            for (int i = 0; reader.Read(); i++)
            {
                guests.Add(reader.GetString(0));
            }
            reader.Close();
            return guests;
        }

        public static List<string> AddGuests(string textSearch)
        {
            string sql = "if not exists(select NameGuest from Guests where NameGuest = @GuestName)\r\n\tbegin\r\n\t\t--add guest\r\n\t\tinsert into Guests values (@GuestName)\r\n\t\tselect NameGuest from Guests\r\n\tend\r\nelse\r\n\tbegin\r\n\t\tselect NameGuest from Guests\r\n\tend";
            string[] parameters = { "@GuestName" };
            string[] values = { textSearch };
            SqlDataReader reader = DBConection.RunSQLAllResult(sql, parameters, values);
            List<string> guests = new List<string>();

            for (int i = 0; reader.Read(); i++)
            {
                guests.Add(reader.GetString(0));
            }
            reader.Close();
            return guests;
        }
        public static List<string> DeleteGuest(string textSearch)
        {
            string sql = "declare @id int;\r\nselect @id = (select GuestId from Guests where NameGuest = @NameGuest3)\r\ndelete from Orders where IdGuest = @id\r\ndelete from Guests where NameGuest = @NameGuest3";
            string[] parameters = { "@NameGuest3" };
            string[] values = { textSearch };
            DBConection.RunSQLNoQuery(sql, parameters, values);
            return GetGuests();
        }

        public static DataTable PrintGuestsMeals(string lblCategory, string nameGuest)
        {
            string sql = "select Orders.Meal as Meal, count(Orders.Meal) as counter from Orders\r\njoin Categories on Categories.CotegoryId = Orders.IdCategory\r\njoin Guests on Guests.GuestId = Orders.IdGuest\r\nwhere @NameCategory2 = Categories.NameCategory and @NameGuest2 != Guests.NameGuest\r\ngroup by Meal";
            string[] parameters = { "@NameCategory2", "@NameGuest2" };
            string[] values = { lblCategory, nameGuest };
            DataTable adapter = DBConection.RunSQLTableResult(sql, parameters, values);
            return adapter;
        }
        public static List<string> GetCategories()
        {
            string sql = "Select * from Categories";
            SqlDataReader reader = DBConection.RunSQLAllResult(sql);

            List<string> categories = new List<string>();

            for (int i = 0; reader.Read(); i++)
            {
                categories.Add(reader.GetString(1));
            }
            reader.Close();
            return categories;
        }

        public static DataTable PrintMyMeals(string lblCategory, string nameGuest)
        {
            string sql = "select Orders.Meal as Meal, count(Orders.Meal) as number from Orders\r\njoin Categories on Categories.CotegoryId = Orders.IdCategory\r\njoin Guests on Guests.GuestId = Orders.IdGuest\r\nwhere @NameCategory = Categories.NameCategory and @NameGuest = Guests.NameGuest\r\ngroup by Meal";
            string[] parameters = { "@NameCategory", "@NameGuest" };
            string[] values = { lblCategory, nameGuest };
            DataTable adapter = DBConection.RunSQLTableResult(sql, parameters, values);
            return adapter;
        }

        public static void AddMeals(string lblCategory, string nameGuest, string meal)
        {
            string sql = "\r\ndeclare @id_Category int, @id_Guest int;\r\n--select id of guest and category\r\nSELECT @id_Guest = (select GuestId FROM Guests where NameGuest = @name)\r\nSELECT @id_Category = (select CotegoryId FROM Categories where NameCategory = @Category_name)\r\n\r\n--insert if exists\r\nif (@Category_name is not null and @name is not null)\r\n\tbegin\r\n\t\t--insert new meal\r\n\t\tinsert into Orders values(@Meal, @id_Guest, @id_Category); \r\n\tend";
            string[] parameters = { "@Category_name", "@name", "@Meal" };
            string[] values = { lblCategory, nameGuest, meal };
            DBConection.RunSQLNoQuery(sql, parameters, values);
        }

        }
}
