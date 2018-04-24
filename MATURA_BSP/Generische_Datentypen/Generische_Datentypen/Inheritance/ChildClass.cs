using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generische_Datentypen.Inheritance
{
    class ChildClass : BaseClass<int>
    {
        public override void Methode1(int param)
        {
            base.Methode1(param);
        }
    }
}
