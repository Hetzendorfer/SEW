using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Async_Await
{
    class Webserver<T> where T : new()
    {

        public void MethodA(string s)
        {

        }

        public void MEthodB() { }
    }

    class A
    {
        public A(string s) { }
    }
    class B
    {
        void C()
        {
            A a = new A("a");
        }
    }
}
