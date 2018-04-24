using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generische_Datentypen.Generic
{
    static class GenerischeMethode
    {
        static public T DoSomething<T>(T value) where T : new()
        {
            return default(T);
        }
    }
}
