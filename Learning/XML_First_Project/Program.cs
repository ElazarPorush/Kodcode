// See https://aka.ms/new-console-template for more information
using System.Xml;

namespace XML_First_Project
{
    public class Program
    {
        public static XmlDocument Main()
        {
            Console.WriteLine("Hello, World!");
            //1. Read the xml file from file system
            //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string pathName = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..") + "\\XMLFile1.xml";
            Console.WriteLine("Path:" + pathName);
            if (File.Exists(pathName))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(pathName);
                return xmlDoc; 

                ////2. Search for Employee 2
                //XmlNode? xmlNode = xmlDoc.SelectSingleNode("/Employees/Employee[@id='2']");
                //if (xmlNode != null && xmlNode.Attributes != null)
                //{
                //    foreach (XmlAttribute attribute in xmlNode.Attributes)
                //    {
                //        Console.WriteLine(attribute.Name + " " + attribute.Value);
                //    }
                //}

                //Console.WriteLine();

                ////3. Search for all Employees\
                //XmlNodeList? xmlNodeList = xmlDoc.SelectNodes("/Employees/Employee");
                //if (xmlNodeList != null)
                //{
                //    foreach (XmlNode employeeNode in xmlNodeList)
                //    {
                //        if (employeeNode.Attributes != null)
                //        {
                //            foreach (XmlAttribute attribute in employeeNode.Attributes)
                //            {
                //                Console.WriteLine(attribute.Name + " " + attribute.Value);
                //            }
                //        }
                //        Console.WriteLine();
                //    }
                //}

                //XmlNodeList?  xmlNodeTagName = xmlDoc.GetElementsByTagName("*");
                //if (xmlNodeTagName != null)
                //{
                //    foreach (XmlNode employeeNode in xmlNodeTagName)
                //    {
                //        if (employeeNode.Attributes != null)
                //        {
                //            foreach (XmlAttribute attribute in employeeNode.Attributes)
                //            {

                //                Console.WriteLine(attribute.Name + ": " + attribute.Value);
                //            }
                //        }
                //        Console.WriteLine();
                //    }

                //}

                //4. Insert new Employee
            }
            else
            {
                Console.WriteLine("File not Found");
            }
            return null;
        }
    }
}