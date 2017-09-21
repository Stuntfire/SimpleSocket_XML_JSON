using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLib;
using System.Net.Sockets;
using System.IO;
using Newtonsoft.Json;

namespace JsonClient
{
    /// <summary>
    /// In the JsonClient Create a class 'Client' with a method 'Start'.
    /// In the start method make an object of the car class e.g. 'Tesla, Green, JsonCar4'
    /// Connect to the server port 10003
    /// When connected - Serialize the car object to a json-string , which is printet/sent to the socket.
    /// </summary>
    class ClientJSON
    {
        public void Start()
        {
            Car jsonCar = new Car()
            {
                Model = "Tesla",
                Color = "Blue",
                RegNumber = "JSON Car 23"
            };

            Console.WriteLine($"Client active ... " +
                              $"\n... trying to send a Car Object converted to a JSON-string to the Server: " +
                              $"\n{jsonCar}");

            using (TcpClient clientSide = new TcpClient("localhost", 8))

            using (NetworkStream clientNetworkStream = clientSide.GetStream())

            using (StreamWriter clientStreamWriter = new StreamWriter(clientNetworkStream))
            {
                String jsonString = JsonConvert.SerializeObject(jsonCar);
                clientStreamWriter.Write(jsonString);
            }
        }
    }
}
