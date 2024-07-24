using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_First_Project
{
    internal class Employee
    {
        public XmlDocument XmlDocument { get; set; }
        public Employee(XmlDocument xmlDocument)
        {
            XmlDocument = xmlDocument;
        }
        public void GetallEmployees(XmlNodeList? xmlNodeList = null)
        {
            if (xmlNodeList == null)
            {
                xmlNodeList = XmlDocument.SelectNodes("/Employees/Employee");
            }
            foreach (XmlNode Childern in xmlNodeList)
            {
                if (Childern.Attributes != null)
                {
                    // Check all attributes
                    foreach (XmlAttribute attribute in Childern.Attributes)
                    {
                        Console.WriteLine(attribute.Name + ": " + attribute.Value);
                    }
                }
                if (Childern != null)
                {
                    GetallEmployees(Childern.ChildNodes);
                }
            }
            
        }

        public void GetOneEmployeeById(string id) {
            XmlNode? employee = XmlDocument.SelectSingleNode($"/Employees/Employee[id={id}]");
            if (employee == null) { return; }
            if (employee.Attributes != null) { 
                foreach (XmlAttribute attribute in employee.Attributes)
                {
                    Console.WriteLine(attribute.Name + ": " + attribute.Value);
                }
                if (employee.ChildNodes != null) { 
                    GetallEmployees(employee.ChildNodes);
                }
            } 
        }

    }
}