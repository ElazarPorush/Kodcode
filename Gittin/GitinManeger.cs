using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Gittin
{
    internal class GitinManeger
    {
        private XmlDocument _xmlDocument { get; set; }
        public GitinManeger(XmlDocument doc)
        {
            _xmlDocument = doc;
        }

        public string AddResult(List<string> queries)
        {
            string day;
            string dayMonth;
            string month;
            string ifThirty = "";
            string year = "";
            if (queries[0] == "ראשון")
            {
                day = "באחד בשבת ";
            }
            else
            {
                day = $"ב{queries[0]} בשבת ";
            }
            List<string> dayMonthList = new List<string>()
            {
                "יום אחד לירח ", "שני ימים לירח ", "שלשה ימים לירח ", "ארבעה ימים לירח ",
                "חמשה ימים לירח ", "ששה ימים לירח ", "שבעה ימים לירח ", "שמנה ימים לירח ",
                "תשעה ימים לירח ", "עשרה ימים לירח ", "אחד עשר יום לירח ", "שנים עשר יום לירח ",
                "שלשה עשר יום לירח ", "ארבעה עשר יום לירח ", "חמשה עשר יום לירח ", "ששה עשר יום לירח ",
                "שבעה עשר יום לירח ", "שמנה עשר יום לירח ", "תשעה עשר יום לירח ", "עשרים יום לירח ",
                "אחד ועשרים יום לירח ", "שנים ועשרים יום לירח ", "שלשה ועשרים יום לירח ", "ארבעה ועשרים יום לירח ",
                "חמשה ועשרים יום לירח ", "ששה ועשרים יום לירח ","שבעה ועשרים יום לירח ","שמנה ועשרים יום לירח ",
                "תשעה ועשרים יום לירח ","יום שלושים ימים לירח ",
            };
            dayMonth = dayMonthList[int.Parse(queries[1]) - 1];
            month = queries[2] + " ";
            if (queries[1] == "30")
            {
                List<string> monthList = new List<string>() { "תשרי", "מרחשון", "כסלו", "טבת", "שבט", "אדר", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיון", "תמוז", "אב", "אלול" };
                for (int i = 0; i < monthList.Count; i++)
                {
                    if (monthList[i] == queries[2])
                    {
                        if (queries[2] == "אדר")
                        {
                            ifThirty = "שהוא ראש חודש ניסן ";
                            break;
                        }
                        if (queries[2] == "אלול")
                        {
                            ifThirty = "שהוא ראש חודש תשרי ";
                            break;
                        }
                        ifThirty = $"שהוא ראש חודש {monthList[i + 1]} ";
                        break;
                    }
                }
            }

            List<string> yearList = new List<string>() { "תשפ'ד", "תשפ'ה", "תשפ'ו", "תשפ'ז", "תשפ'ח", "תשפ'ט", "תש'ץ", "תשצ'א", "תשצ'ב", "תשצ'ג" };
            List<string> numberYearList = new List<string>() { "שנת חמשת אלפים ושבע מאות שמונים וארבע לבריאת העולם",
                "שנת חמשת אלפים ושבע מאות שמונים וחמש לבריאת העולם",
                "שנת חמשת אלפים ושבע מאות שמונים ושש לבריאת העולם",
                "שנת חמשת אלפים ושבע מאות שמונים ושבע לבריאת העולם",
                "שנת חמשת אלפים ושבע מאות שמונים ושמנה לבריאת העולם",
                "שנת חמשת אלפים ושבע מאות שמונים ותשע לבריאת העולם",
                "שנת חמשת אלפים ושבע מאות תשעים לבריאת העולם",
                "שנת חמשת אלפים ושבע מאות תשעים ואחד לבריאת העולם",
                "שנת חמשת אלפים ושבע מאות תשעים ושניים לבריאת העולם",
                "שנת חמשת אלפים ושבע מאות תשעים ושלש לבריאת העולם" };
            for (int i = 0; i < yearList.Count; i++)
            {
                if (yearList[i] == queries[3])
                {
                    year = numberYearList[i];
                    break;
                }
            }
            return day + dayMonth + month + ifThirty + year;
        }

        private XmlNode getRoot()
        {
            return _xmlDocument.GetElementsByTagName("Queries")[0];
        }

        public string AddQuery(List<string> queries)
        {
            XmlElement queryElement = _xmlDocument.CreateElement("Query");
            List<string> tagsName = new List<string>()
            {"Day", "DayMonth", "Month", "Year", "Result" };
            for (int i = 0; i < tagsName.Count - 1; i++)
            {
                XmlElement child = _xmlDocument.CreateElement(tagsName[i]);
                child.InnerText = queries[i];
                queryElement.AppendChild(child);
            }
            XmlElement result = _xmlDocument.CreateElement(tagsName[tagsName.Count - 1]);
            string resultstr = AddResult(queries);
            result.InnerText = resultstr;
            queryElement.AppendChild(result);
            getRoot().AppendChild(queryElement);
            return resultstr;
        }
        public void Save()
        {
            MainProject.Save(_xmlDocument);
        }


    }
}
