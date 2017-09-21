using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ModelLib;

namespace PlainServer
{
    /// <summary>
    /// In the start method
    /// Listen on port 10001
    /// When a client connect - read from the socket a text string representing a car and print it out.
    /// Extra: decode the string into a car object and print out the car-object.
    /// </summary>
    public class Server
    {
        public void Start()
        {
            TcpListener listener = new TcpListener(IPAddress.Loopback, 7); //bruger port 7 fordi port 10001 ikke virker.
            listener.Start();
            Console.WriteLine("Server startet...");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream ns = client.GetStream();
                StreamReader readFromClient = new StreamReader(ns);
                StreamWriter writeToClient = new StreamWriter(ns);
                String incomingTextString = readFromClient.ReadLine();
                Console.WriteLine($"Client sendte: {incomingTextString}");

                //var incomingCar = incomingTextString.Cast<Car>();
                //Console.WriteLine($"Printer et Car Object: {incomingCar}");
                Console.WriteLine($"Printer et Car Object: {incomingTextString.Cast<Car>()}");
            }

        }
    }
}
