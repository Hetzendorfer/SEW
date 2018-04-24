using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generische_Datentypen.Collection
{
    static class Test
    {
        static public void TestEigeneCollection()
        {
            EigeneCollection<string> eigeneCollection = new EigeneCollection<string>();
            eigeneCollection.Add("Kevin");
            eigeneCollection.Add("Hetzendorfer");
            eigeneCollection.Add("Muammer");
            eigeneCollection.Add("Keskin");
            eigeneCollection.Add("Bernhard");
            eigeneCollection.Add("Traschl");
            eigeneCollection.Add("Nico");
            eigeneCollection.Add("Windtner");

            foreach (string item in eigeneCollection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
