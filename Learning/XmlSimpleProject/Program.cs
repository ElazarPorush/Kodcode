using System.Xml;

namespace XmlExempleProject
{
    public class Program
    {
        public Program() { }

        public static void Main(string[] args)
        {
            string pathString = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..") + "\\Cars.xml");
            XmlDocument xmlDoc;

            if (File.Exists(pathString))
            {
                xmlDoc = new XmlDocument();
                xmlDoc.Load(pathString);
            }
            else
            {
                xmlDoc = new XmlDocument();
                XmlNode carsNode = xmlDoc.CreateElement("Cars");
                xmlDoc.AppendChild(carsNode);
                xmlDoc.Save(pathString);
            }

            //xmlDoc.Save(carsNode);
        }
    }
}