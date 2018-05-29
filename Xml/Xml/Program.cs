using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using System.Xml;

namespace Xml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlReader.Create("file.xml"));

            XmlNodeList nodes = doc.SelectNodes(@"//Person");

            foreach (XmlNode item in nodes)
            {
                XmlAttribute id = item.Attributes["id"];
                XmlNode idNode = item.SelectSingleNode(@".//@id");
                XmlNode vorname = item.SelectSingleNode(@".//Vorname");
                XmlNode nachname = item.SelectSingleNode(@".//Nachname");
                XmlNode alter = item.SelectSingleNode(@".//Alter");
                XmlNodeList kinder = item.SelectNodes(@".//Kinder");

                Console.WriteLine(id.InnerText + " " + vorname.InnerText + " " + nachname.InnerText + " " + alter.InnerText);
                if (kinder.Count > 0)
                    Console.WriteLine("\tKinder: ");
                foreach (XmlNode kind in kinder)
                {
                    XmlNode name = kind.SelectSingleNode(@".//Name");
                    Console.WriteLine("\t\t" + name.InnerText);
                }
            }
        }
    }
}
