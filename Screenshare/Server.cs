using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Screenshare
{
    class Server
    {
        public static IPAddress TEST_ADDRESS = IPAddress.Parse("192.168.1.103");
        public static int TEST_PORT = 49152;

        public static void StartTCPListener()
        {
            TcpListener server = null;

            server = new TcpListener(TEST_PORT);
            server.Start();

            while (true)
            {
                try
                {
                    Console.WriteLine("Listening...");
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    //wait for client to write info
                    Thread.Sleep(1000);  
                    StreamReader sr = new StreamReader(client.GetStream());
                    Console.WriteLine(sr.ReadToEndAsync().Result);
                    break;
                } catch(Exception e)
                {
                    Console.WriteLine($"Error Message: {e.Message}");
                }
            }
        }
    }
}
