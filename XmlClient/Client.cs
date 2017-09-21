using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ModelLib;

namespace XmlClient
{
    /// <summary>
    /// In the XmlClient Create a class 'Client' with a method 'Start'.
    /// In the start method make an object of the car class e.g. 'Tesla, Blue, XMLCar23'
    /// Connect to the server port 10002
    /// When connected - Serialize the car object to a xml-string , which is printet/sent to the socket.
    /// Run the server and the client - and see the result.
    /// Commit and push your server-solution to a Git-Repository.
    /// </summary>
    class Client
    {
        public void Start()
        {
            Car xmlCar = new Car(){
                Model = "Tesla",
                Color = "Blue",
                RegNumber = "XMLCar23"
            };

            using (TcpClient clientSide = new TcpClient("localhost", 8))

            using (NetworkStream clientNetworkStream = clientSide.GetStream())

            using (StreamWriter clientStreamWriter = new StreamWriter(clientNetworkStream))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Car));

                xs.Serialize(clientStreamWriter, xmlCar);

                //clientStreamWriter.WriteLine(xs);
                //clientStreamWriter.Flush();
            }
        }
    }
}
