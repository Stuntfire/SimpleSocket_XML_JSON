﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server newServer = new Server();
            newServer.Start();

            Console.ReadLine();
        }
    }
}
