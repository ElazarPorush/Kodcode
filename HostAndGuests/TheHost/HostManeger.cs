using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHost
{
    internal class HostManeger
    {
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

        public static List<string> SearchCategories(string textSearch)
        {
            string sql = "\r\nselect NameCategory from Categories\r\nwhere NameCategory like '%' + @tmp + '%'\r\n";
            string[] parameters = { "@tmp" };
            string[] values = { textSearch };
            SqlDataReader reader = DBConection.RunSQLAllResult(sql, parameters, values);
            List<string> categories = new List<string>();

            for (int i = 0; reader.Read(); i++)
            {
                categories.Add(reader.GetString(0));
            }
            reader.Close();
            return categories;
        }

        public static List<string> AddCategories(string textSearch)
        {
            string sql = "if not exists(select NameCategory from Categories where NameCategory = @CategoryName)\r\n\tbegin\r\n\t\t--add category\r\n\t\tinsert into Categories values (@CategoryName)\r\n\t\tselect NameCategory from Categories\r\n\tend\r\nelse\r\n\tbegin\r\n\t\tselect NameCategory from Categories\r\n\tend";
            string[] parameters = { "@CategoryName" };
            string[] values = { textSearch };
            SqlDataReader reader = DBConection.RunSQLAllResult(sql, parameters, values);
            List<string> categories = new List<string>();

            for (int i = 0; reader.Read(); i++)
            {
                categories.Add(reader.GetString(0));
            }
            reader.Close();
            return categories;
        }

        public static List<string> DeleteCategory(string textSearch)
        {
            string sql = "declare @id int;\r\nselect @id = (select CotegoryId from Categories where NameCategory = @NameCategory3)\r\ndelete from Orders where IdCategory = @id\r\ndelete from Categories where NameCategory = @NameCategory3";
            string[] parameters = { "@NameCategory3" };
            string[] values = { textSearch };
            DBConection.RunSQLNoQuery(sql, parameters, values);
            List<string> categories = new List<string>();
            return GetCategories();
        }



        public static DataTable PrintMeals(string lblCategory)
        {
            string sql = "declare @id int;\r\n--get category id \r\nselect @id = (select CotegoryId from Categories where NameCategory = @category)\r\n--get orders\r\nselect Meal, count(*) as counter from Orders where IdCategory = @id\r\ngroup by Meal";
            string[] parameters = { "@category" };
            string[] values = { lblCategory };
            DataTable adapter = DBConection.RunSQLTableResult(sql, parameters, values);
            return adapter;
        }



    }
}
