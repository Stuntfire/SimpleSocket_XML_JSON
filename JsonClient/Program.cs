﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientJSON client = new ClientJSON();
            client.Start();
            Console.ReadLine();
        }
    }
}
