using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generische_Datentypen.Generic
{
    class Constraint<T, A, C> where T : IDisposable
                              where A : ICloneable
                              where C : new()
    {
        public Constraint(T value)
        {
            T param = value;
            param.Dispose();
        }
    }
}
