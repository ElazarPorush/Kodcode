using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class StudentManejer
    {
        public static List<string> GetStudent()
        {
            string sql = "Select * from Students";
            SqlDataReader reader = DBConection.RunSQLAllResult(sql);

            List<string> students = new List<string>();

            for (int i = 0; reader.Read(); i++)
            {
                students.Add(reader.GetString(1));
            }
            reader.Close();
            return students;
        }

        public static List<string> SearchStudents(string textSearch)
        {
            string sql = "select StudentName from Students\r\nwhere StudentName like '%' + @tmp2 + '%'";
            string[] parameters = { "@tmp2" };
            string[] values = { textSearch };
            SqlDataReader reader = DBConection.RunSQLAllResult(sql, parameters, values);
            List<string> courses = new List<string>();

            for (int i = 0; reader.Read(); i++)
            {
                courses.Add(reader.GetString(0));
            }
            reader.Close();
            return courses;
        }

        public static List<string> AddStudent(string textSearch)
        {
            string sql = "if not exists(select StudentName from Students where StudentName = @StudentName)\r\n\tbegin\r\n\t\tinsert into Students values (@StudentName)\r\n\tend";
            string[] parameters = { "@StudentName" };
            string[] values = { textSearch };
            DBConection.RunSQLNoQuery(sql, parameters, values);
            return GetStudent();
        }
        public static DataTable PrintCourses()
        {
            string sql = "select CourseName, DateOfStart, DaysOnWeek, HoursOnDay, CoursePrice from Courses";
            DataTable adapter = DBConection.RunSQLTableResult(sql);
            return adapter;
        }
    }
}
