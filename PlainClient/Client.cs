using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLib;
using System.Net.Sockets;
using System.IO;

namespace PlainClient
{
    /// <summary>
    /// Link til opgaven: http://pele-easj.dk/2017e-tek/exercises/ch2-SocketXMLandJson.htm
    /// In the PlainClient Create a class 'Client' with a method 'Start'.
    /// In the start method make an object of the car class e.g. 'Tesla, red, EL23400'
    /// Connect to the server port 10001
    /// When connected - print to the socket the car object in plain text e.g. using the ToString-method(i.e.Not as XML NOR Json)
    /// Commit and push your server-solution to a Git-Repository.
    /// </summary>
    public class Client
    {
        public Client()
        {

        }
        public void Start()
        {
            Car newCar = new Car("Tesla", "red", "EL23400");

            Console.WriteLine($"Client active ... " +
                              $"\nsending a Car Object to the Server: " +
                              $"\n{newCar}");

            TcpClient clientSide = new TcpClient("localhost", 7);

            NetworkStream ns = clientSide.GetStream();

            StreamWriter writeToServer = new StreamWriter(ns);

            writeToServer.WriteLine(newCar);
            writeToServer.Flush();
        }
    }
}
