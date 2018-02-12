using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rechnung.config
{
    class Unternehmen
    {
        public string Firmenname { get; set; }
        public string Anschrift_Straße { get; set; }
        public string Anschrift_Hausnummer { get; set; }
        public string Anschrift_PLZ { get; set; }
        public string Anschrift_Stadtname { get; set; }
        public string Telefon { get; set; }
        public string FAX { get; set; }
        public string EMail { get; set; }
        public string Website { get; set; }

        public string UID { get; set; }
        public string Firmenbuchnummer { get; set; }

        public Unternehmen()
        {

        }
    }
}
