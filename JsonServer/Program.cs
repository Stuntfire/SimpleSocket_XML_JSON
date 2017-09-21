using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerJSON server = new ServerJSON();
            server.Start();
            Console.ReadLine();
        }
    }
}
