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
            TcpListener serverListener = new TcpListener(IPAddress.Loopback, 8);
            serverListener.Start();
            Console.WriteLine("Server startet ...");

            while (true)
            {
                using (TcpClient client = serverListener.AcceptTcpClient())
                using (NetworkStream connectToClientStream = client.GetStream())
                using (StreamReader xmLfromClientReader = new StreamReader(connectToClientStream))
                {
                    String incomingString = xmLfromClientReader.ReadLine();

                    //new XmlSerializer(typeof(Car).IsSerializable(Console.Out, incomingString));

                    Console.WriteLine($"Printer xml-string modtaget fra Client: \n{xmLfromClientReader.ReadToEnd()} \n{incomingString}");

                    XmlSerializer xs = new XmlSerializer(typeof(Car));
                    Car tempCar = (Car)xs.Deserialize(xmLfromClientReader);
                    Console.WriteLine($"{tempCar.Model} {tempCar.Color} {tempCar.RegNumber}");
                }

            }
        }
    }
}
