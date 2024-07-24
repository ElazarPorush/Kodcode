using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public enum Department
    {
        HR,
        Engineering,
        Marketing
    }
    internal class Employee
    {
        private string _name {  get; set; }
        private Department _department {  get; set; }

        public Employee() { }
        public Employee(string name, Department department)
        {
            _name = name;
            _department = department;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {_name}, Department: {_department}");
        }
    }

    internal class Company 
    {
        private List<Employee> _employees {  get; set; }
        public Company() { }
        public Company(List<Employee> employees) 
        { 
            _employees = employees;
        }
        public void DisplayAllEmployees() 
        {
            foreach (Employee employee in _employees)
            {
                employee.DisplayInfo();
            }
        }
    }
}
