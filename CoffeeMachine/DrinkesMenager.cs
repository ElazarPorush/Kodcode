using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CoffeeMachine
{
    internal class DrinkesMenager
    {
        private XmlDocument _xmlDocument { get; set; }
        public DrinkesMenager(XmlDocument doc)
        {
            _xmlDocument = doc;
        }

        public List<List<string>> GetDrinkes(XmlDocument drinkesNodes = null)
        {
            List<List<string>> allDrinkes = new List<List<string>>();
            XmlNodeList drinkesNode = _xmlDocument.SelectNodes("/Drinkes/Drink");
            if (drinkesNode != null) {
                foreach (XmlNode drink in drinkesNode)
                {
                    List<string> drinkeslist = new List<string>();
                    if (drink.Attributes != null)
                    {

                        foreach (XmlNode attribute in drink.ChildNodes)
                        {
                            drinkeslist.Add(attribute.InnerText);
                        }
                        allDrinkes.Add(drinkeslist);

                    }
                }
            }
            return allDrinkes;
        }

        private XmlNode getRoot()
        {
            return _xmlDocument.GetElementsByTagName("Drinkes")[0];
        }

        public void AddDrink(List<string> drinkes)
        {
            XmlElement drinkElement = _xmlDocument.CreateElement("Drink");
            List<string> tagsName = new List<string>()
            {"name", "shuger", "coffee", "milk", "cackahu", "price" };
            for (int i = 0; i < tagsName.Count; i++) {
                XmlElement child = _xmlDocument.CreateElement(tagsName[i]);
                child.InnerText = drinkes[i];
                drinkElement.AppendChild(child);
            }
            getRoot().AppendChild(drinkElement);
        }

        public void Save()
        {
            MainProject.Save(_xmlDocument);
        }

        public void UpdateDrink(List<string> drinkes)
        {
            XmlNodeList drinkesList = _xmlDocument.GetElementsByTagName("name");
            if (drinkesList == null) { return; }
            foreach (XmlNode drink in drinkesList) {
                if (drink.InnerText == drinkes[0])
                {
                    int i = 0;
                    foreach (XmlNode child in drink.ParentNode)
                    {
                        child.InnerText = drinkes[i++];
                    }

                }
            }
        }

        public void Delete(string name) { 
            XmlNode drink = _xmlDocument.SelectSingleNode($"/Drinkes/Drink[name='{name}']");
            drink.ParentNode.RemoveChild(drink);
        }
    }
}
