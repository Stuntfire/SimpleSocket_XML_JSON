using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client newClient = new Client();
            newClient.Start();

            Console.ReadLine();
        }
    }
}
