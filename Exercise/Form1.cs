using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise
{
    public partial class Form1 : Form
    {
        List<Car> carList = new List<Car>();
        List<Student> studentlist = new List<Student>();
        List<Employee> employeeslist = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car tmp = new Car();
            switch (txtAddCar.Text)
            {
                case "red":
                    tmp = new Car(Color.Red);
                    break;
                case "blue":
                    tmp = new Car(Color.Blue);
                    break;
                case "green":
                    tmp = new Car(Color.Green);
                    break;
                
            }
            carList.Add(tmp);
            foreach (Car car in carList)
            {
                car.DisplayColor();
            }
            Console.WriteLine();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student s1 = new Student("Moshe", GradeLevel.Sophomore, new List<int> {94, 12, 34 } );
            studentlist.Add(s1);
            Student s2 = new Student("Eli", GradeLevel.Junior, new List<int> { 76, 68, 87 });
            studentlist.Add(s2);
            Student s3 = new Student("Elazar", GradeLevel.Senior, new List<int> { 100, 98, 100 });
            studentlist.Add(s3);

            foreach (Student st in studentlist)
            {
                st.DisplayInfo();
            }

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee("Nahman", Department.Marketing);
            Employee e2 = new Employee("Moty", Department.HR);
            Employee e3 = new Employee("Yahkov", Department.Engineering);
            employeeslist.Add(e1);
            employeeslist.Add(e2);
            employeeslist.Add(e3);
            Company company = new Company(employeeslist);
            company.DisplayAllEmployees();
        }
    }
}
