using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ModelLib;

namespace XmlServer
{
    /// <summary>
    /// In the XmlServer Create a class 'Server' with a method 'Start'.
    /// In the start method Listen on port 10002
    /// When a client connect - read from the socket a text string (xml) representing a car and print it out.
    /// Decode the xml-string into a car object and print out the car-object.
    /// </summary>
    
    public class Server
    {
        public void Start()
        {
            TcpListener serverListener = new TcpListener(IPAddress.Loopback, 10002);
            serverListener.Start();
            Console.WriteLine("Server startet ...");

            while (true)
            {
                TcpClient client = serverListener.AcceptTcpClient();
                NetworkStream connectToClientStream = client.GetStream();
                StreamReader xmLfromClientReader = new StreamReader(connectToClientStream);

                Console.WriteLine($"Printer xml-string modtaget fra Client: {xmLfromClientReader}");

                XmlSerializer xs = new XmlSerializer(typeof(Car));
                Car tempCar = (Car)xs.Deserialize(xmLfromClientReader);
                Console.WriteLine(tempCar);
            }
        }
    }
}
