// See https://aka.ms/new-console-template for more information
using System.Xml;
using XML_First_Project;

XmlDocument xmlDocument = XML_First_Project.Program.Main();
Employee employee = new Employee(xmlDocument);
//employee.GetallEmployees();
//employee.GetOneEmployeeById("2");


XmlNode? nl = xmlDocument.SelectSingleNode("/Employees");
XmlDocument xd2 = new XmlDocument();
xd2.LoadXml("<Employee><ID>20</ID><FirstName>Clair</FirstName><LastName>Doner</LastName><Salary>13000</Salary></Employee>");
XmlNode n = xmlDocument.ImportNode(xd2.FirstChild, true);
nl.AppendChild(n);
xmlDocument.Save(Console.Out);
employee.GetallEmployees();