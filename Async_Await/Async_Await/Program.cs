using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task<string> task = Task<string>.Run(() =>
            //{
            //    System.Threading.Thread.Sleep(3000);
            //    return DateTime.Now.ToLongDateString();
            //});
            //Console.WriteLine("Ich warte .....");
            //Console.WriteLine("{0}", task.Result);
            //Console.ReadLine();

            Start();
            Console.WriteLine("Ende Main ...");
            Console.ReadLine();
        }

        static async void Start()
        {
            await DoSomethingAsync(1);
            Console.WriteLine("Nach Aufruf von SoSomethingAsync(1) ...");
        }

        static void DoSomething(int id)
        {
            Console.WriteLine("Operation {0} startet ...", id);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Operation {0} ist beendet ...", id);
        }

        static Task DoSomethingAsync(int id)
        {
            Task task = Task.Run(() =>
            {
                Console.WriteLine("Operation {0} startet ...", id);
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Operation {0} ist beendet ...", id);
            });
            return task;
        }
    }
}
