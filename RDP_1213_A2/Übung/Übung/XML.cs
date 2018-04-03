using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Übung.data;
using System.Xml.Linq;

namespace Übung
{
    class XML
    {
        static public List<Patient> ReadFromFile(string filename)
        {
            List<Patient> patienten = new List<Patient>();

            XDocument doc = XDocument.Load(filename);

            List<XElement> patientenXml = doc.Descendants("Name").ToList();
            string s = "";
            foreach (XElement patient in patientenXml)
            {
                XAttribute id = patient.Attribute("ID");
                XElement nachname = patient.Element("Nachname");
                XElement vorname = patient.Element("Vorname");
                XElement sv= patient.Element("SV");

                Patient p = new Patient(Convert.ToInt64(id.Value), nachname.Value, vorname.Value, sv.Value);
                p.Behandlungen = ReadBehandlung(patient.Element("Behandlungen"));
                patienten.Add(p);
            }
            

            return patienten;
        }

        static private List<Behandlung> ReadBehandlung(XElement node)
        {
            List<Behandlung> behandlungen = new List<Behandlung>();

            List<XElement> behandlungenXml = node.Descendants("Behandlung").ToList();

            foreach (XElement item in behandlungenXml)
            {
                XElement bezeichnung = item.Element("Bezeichnung");
                XElement dauer = item.Element("Dauer");
                XElement datum = item.Element("Datum");

                behandlungen.Add(new Behandlung(bezeichnung.Value, Convert.ToInt32(dauer.Value), DateTime.Parse(datum.Value)));
            }

            return behandlungen;
        }
    }
}
