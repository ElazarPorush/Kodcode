using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public enum GradeLevel
    {
        Freshman,
        Sophomore,
        Junior,
        Senior
    }
    internal class Student
    {
        private string _name {  get; set; }
        private GradeLevel _scores {  get; set; }
        private List<int> _grade  { get; set; }

        public Student() { }
        public Student(string name, GradeLevel scores, List<int> grade)
        {
            _name = name;
            _scores = scores;
            _grade = grade;
        }

        public void DisplayInfo() 
        {
            string Scores = "Null";
            switch (_scores)
            {
                case GradeLevel.Junior:
                    Scores = "Junior";
                    break;
                case GradeLevel.Sophomore:
                    Scores = "Sophomore";
                    break;
                case GradeLevel.Senior:
                    Scores = "Senior";
                    break;
                case GradeLevel.Freshman:
                    Scores = "Freshman";
                    break;
            }
            Console.WriteLine($"Name: {_name}, Scores: {Scores}, Grade: {_grade.Average()}");
        }
    }
}
