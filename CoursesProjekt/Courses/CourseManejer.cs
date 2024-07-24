using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    internal class CourseManejer
    {
        public static List<string> GetCourses()
        {
            string sql = "Select * from Courses";
            SqlDataReader reader = DBConection.RunSQLAllResult(sql);

            List<string> Courses = new List<string>();

            for (int i = 0; reader.Read(); i++)
            {
                Courses.Add(reader.GetString(1));
            }
            reader.Close();
            return Courses;
        }
        public static List<string> SearchCourses(string textSearch)
        {
            string sql = "select CourseName from Courses\r\nwhere CourseName like '%' + @tmp2 + '%'";
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

            public static void AddCourse(string nameCourse, string dateOfBegin, string days, string hours, string price)
        {
            string sql = "if not exists(select CourseName from Courses where CourseName = @CourseName)\r\n\tbegin\r\n\t\t--add course\r\n\t\tinsert into Courses values (@CourseName, @DateOfStart, @DaysOnWeek, @HoursOnDay, @CoursePrice)\r\n\tend";
            string[] parameters = { "@CourseName", "@DateOfStart", "@DaysOnWeek", "@HoursOnDay", "@CoursePrice" };
            string[] values = { nameCourse, dateOfBegin, days, hours, price };
            DBConection.RunSQLNoQuery(sql, parameters, values);
        }

        public static List<string> DeleteCourse(string nameCourse)
        {
            string sql = "declare @CourseCode int;\r\nselect @CourseCode = (select CourseId from Courses where CourseName = @CourseNamee) \r\ndelete from StudentSubjects where IdCourse = @CourseCode\r\ndelete from Payments where IdCourse = @CourseCode\r\ndelete from Subjects where IdCourse = @CourseCode\r\ndelete from Courses where CourseId = @CourseCode";
            string[] parameters = { "@CourseNamee" };
            string[] values = { nameCourse };
            DBConection.RunSQLNoQuery(sql, parameters, values);
            return GetCourses();
        }

        public static DataTable PrintSubjects(string lblCourse)
        {
            string sql = "declare @CourseCode2 int;\r\nselect @CourseCode2 = (select CourseId from Courses where CourseName = @CourseName2);\r\nselect SubjectName, NumberOfHours, TeacherName, HourPrice from Subjects where IdCourse = @CourseCode2;";
            string[] parameters = { "@CourseName2" };
            string[] values = { lblCourse };
            DataTable adapter = DBConection.RunSQLTableResult(sql, parameters, values);
            return adapter;
        }

        public static void DeleteSubject(string namesubject)
        {
            string sql = "declare @SubjectCode int;\r\nselect @SubjectCode = (select SubjectId from Subjects where SubjectName = @SubjectName1);\r\ndelete from StudentSubjects where IdSubject = @SubjectCode;\r\ndelete from Subjects where SubjectId = @SubjectCode;";
            string[] parameters = { "@SubjectName1" };
            string[] values = { namesubject };
            DBConection.RunSQLNoQuery(sql, parameters, values);
        }

        public static void AddSubject(string nameCourse, string nameSubject, string hours, string teacher, string price)
        {
            string sql = "declare @CoursCode int;\r\nselect @CoursCode = (select CourseId from Courses where CourseName = @CourseName1);\r\ninsert into Subjects values (@SubjectName, @NumberOfHours, @TeacherName, @HourPrice, @CoursCode)";
            string[] parameters = { "@CourseName1", "@SubjectName", "@NumberOfHours", "@TeacherName", "@HourPrice" };
            string[] values = { nameCourse, nameSubject, hours, teacher, price };
            DBConection.RunSQLNoQuery(sql, parameters, values);
        }
    }
}
