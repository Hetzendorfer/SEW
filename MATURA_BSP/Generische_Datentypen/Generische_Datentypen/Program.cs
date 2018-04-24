using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generische_Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.Dictionary<int, string> dictionary = new Dictionary<int, string>();
            System.Collections.Generic.HashSet<int> hashSet = new HashSet<int>();
            System.Collections.Generic.List<int> list = new List<int>();
            System.Collections.Generic.Queue<string> queue = new Queue<string>();
            System.Collections.Generic.Stack<int> stack = new Stack<int>();


            Collection.Test.TestEigeneCollection();

            Console.ReadLine();
        }
    }
}
