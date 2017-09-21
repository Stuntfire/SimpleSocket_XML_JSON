using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlServer
{
    /// <summary>
    /// In the XmlServer Create a class 'Server' with a method 'Start'.
    /// In the start method Listen on port 10002
    /// When a client connect - read from the socket a text string (xml) representing a car and print it out.
    /// Decode the xml-string into a car object and print out the car-object.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            server.Start();
            Console.ReadLine();
        }
    }
}
