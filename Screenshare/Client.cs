using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace Screenshare
{
    static class Client
    {
        public static string TEST_ADDRESS = "192.168.1.127";
        public static int TEST_PORT = 49152;

        public static void InitiateTCPConnect()
        {
            var connection = new TcpClient();
            connection.Connect(new IPEndPoint(IPAddress.Parse(TEST_ADDRESS), TEST_PORT));
            StreamWriter writer = new StreamWriter(connection.GetStream());
            writer.WriteLine("Hello");
        }
    }
}
