using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Screenshare
{
    class Server
    {
        public static IPAddress TEST_ADDRESS = IPAddress.Parse("192.168.1.127");
        public static int TEST_PORT = 49152;

        public static void StartTCPListener()
        {
            TcpListener server = null;

            try
            {
                server = new TcpListener(TEST_ADDRESS, TEST_PORT);
                server.Start();

                TcpClient client = server.AcceptTcpClient();

                NetworkStream stream = client.GetStream();

                using (StreamReader sr = new StreamReader(stream))
                {
                    Console.WriteLine(sr);
                }
            }
            catch (SocketException)
            {
                Console.WriteLine("Test Fail");
            }
            finally
            {
                server.Stop();
            }
            string filler = Console.ReadLine();
        }
    }
}
