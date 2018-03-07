using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaktion;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Geld meinGeld = new Geld(100);
            Geld deinGeld = new Geld(500);

            Geld test = 500;
            decimal val = (decimal)test;

            meinGeld = meinGeld + deinGeld;
            Console.WriteLine(meinGeld.Menge);
            Console.ReadLine();
        }
    }
}
