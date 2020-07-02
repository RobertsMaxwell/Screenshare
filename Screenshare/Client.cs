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
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;

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

                    BinaryFormatter bf = new BinaryFormatter();
                    byte[] information = (byte[])bf.Deserialize(connection.GetStream());

                    using (MemoryStream ms = new MemoryStream(information))
                    {
                        Form mainForm = Application.OpenForms["Form1"];
                        Image img = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
