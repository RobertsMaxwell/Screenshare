using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Windows.Forms;

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

                if (result.AsyncWaitHandle.WaitOne(1000))
                {
                    NetworkStream st = connection.GetStream();

                    //wait for server to write info
                    Thread.Sleep(1000);
                    byte[] header = new byte[2];
                    st.Read(header, 0, 2);
                    int informationSize = header[0];
                    int informationOffset = header[1];

                    byte[] information = new byte[informationSize];
                    st.Read(information, informationOffset, informationSize);
                    FileStream fs = new FileStream(Path.Combine(Path.GetTempPath(), "image.jpg"), FileMode.Create);
                    fs.Write(information, 0, information.Length);
                    fs.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
