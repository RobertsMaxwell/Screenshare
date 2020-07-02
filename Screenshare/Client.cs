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
                    Thread.Sleep(5000);

                    BinaryFormatter bf = new BinaryFormatter();
                    byte[] information = (byte[])bf.Deserialize(connection.GetStream());

                   /* byte headerLength = new byte[1];
                    st.Read(headerLength, 0, 1);
                    int headerSize = headerLength[0];
                    byte[] informationLength = new byte[headerSize - 1];
                    st.Read(informationLength, 0, informationLength.Length);
                    int informationSize = BitConverter.ToInt32(informationLength, 0);

                    byte[] information = new byte[informationSize];

                    st.Read(information, 0, informationSize);*/

                    using (FileStream fs = new FileStream(Path.Combine(Path.GetTempPath(), "image.jpg"), FileMode.Create))
                    {
                        for (int i = 0; i < information.Length; i++)
                        {
                            fs.Write(new byte[] { information[i] }, 0, 1);
                        }
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
