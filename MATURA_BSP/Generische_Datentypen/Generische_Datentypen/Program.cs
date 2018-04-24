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


            //Klasse vor dem Generic machen
            Generic.Stack stack1 = new Generic.Stack(5);
            //Nachteil man kann jeden Datentyp in diesen Stack speichern -> man kann zur Laufzeit nicht wissen was man jetzt für einen Datentyp bekommt
            stack1.Push(3);
            stack1.Push("nicht so gut");
            int data = (int)stack1.Pop();

            //Klasse nach dem Generic machen
            Generic.GenericStack<string> stack2 = new Generic.GenericStack<string>(3);
            stack2.Push("kevin");
            string data2 = stack2.Pop();

            //Generische Methode
            Generic.GenerischeMethode.DoSomething<int>(25);
            Generic.GenerischeMethode.DoSomething(25);


            //Kovarianz
            Kovarianz.Do.DoSomething(new Kovarianz.KovarianzClass<Kovarianz.ChildClass1>()); //ohne dem out bei dem Interface InterfaceA würde dass nicht gehen

            Console.ReadLine();
        }
    }
}
