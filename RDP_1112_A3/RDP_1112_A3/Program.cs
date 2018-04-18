using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDP_1112_A3
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server(1333, 10);

            server.Start();

            while (true)
            {
                if (!server.IsRunning)
                    Environment.Exit(2);
            }
        }
    }
}
