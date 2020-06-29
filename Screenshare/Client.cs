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
            try
            {
                var connection = new TcpClient();
                var result = connection.BeginConnect(IPAddress.Parse(TEST_ADDRESS), TEST_PORT, null, connection);
                /*StreamWriter sw = new StreamWriter(connection.GetStream());
                sw.WriteLine("HellO!");*/
                if (result.AsyncWaitHandle.WaitOne(10000))
                {
                    StreamWriter sw = new StreamWriter(connection.GetStream());
                    sw.WriteLine("Hello!");
                }
                Thread.Sleep(100000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
