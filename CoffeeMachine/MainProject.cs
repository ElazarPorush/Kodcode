// See https://aka.ms/new-console-template for more information
using System.IO;
using System;
using System.Xml;


namespace CoffeeMachine {
    internal class MainProject
    {
        private static string pathName = Path.Combine(Directory.GetCurrentDirectory(), @"..\..") + "\\Drinkes.xml";
        public MainProject() { }
        public static XmlDocument Main()
        {
            Console.WriteLine("Hello, World!");
            //1. Read the xml file from file system
            //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("Path:" + pathName);
            if (File.Exists(pathName))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(pathName);
                return xmlDoc;

            }
            else
            {
                Console.WriteLine("File not Found");
            }
            return null;
        }

        public static void Save(XmlDocument xmlDocument) {
            xmlDocument.Save(pathName);
        }           
    }
}
