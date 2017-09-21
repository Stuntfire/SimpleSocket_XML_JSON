using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ModelLib;
using Newtonsoft.Json;

namespace JsonServer
{
    /// <summary>
    /// In the JsonServer Create a class 'Server' with a method 'Start'.
    /// In the start method Listen on port 10003
    /// When a client connect - read from the socket a text string (json) representing a car and print it out.
    /// Decode the json-string into a car object and 
    /// print out the car-object.(use Newtonsoft:JsonConvert)
    /// </summary>
    public class ServerJSON
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
                using (StreamReader jsonfromClient = new StreamReader(connectToClientStream))
                {
                    String incomingString = jsonfromClient.ReadLine();

                    Car jsonCar = JsonConvert.DeserializeObject<Car>(incomingString);

                    Console.WriteLine($"Whuuhuu! I recieved at message from Client ... \nModel: {jsonCar.Model} \tColor: {jsonCar.Color} \tLicenseNo: {jsonCar.RegNumber}");
                }
            }
        }
    }
}

