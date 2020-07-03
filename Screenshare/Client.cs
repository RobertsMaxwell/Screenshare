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
    class Client
    {
        public static int PORT = 49152;
        public string address;
        public PictureBox display;
        public TcpClient connection;

        public Client(string address, PictureBox display)
        {
            this.address = address;
            this.display = display;
        }

        public void InitiateTCPConnect()
        {
            try
            {
                connection = new TcpClient();
                var result = connection.BeginConnect(IPAddress.Parse(address), PORT, null, connection);

                if (result.AsyncWaitHandle.WaitOne(1000))
                {
                    while (connection.Connected)
                    {
                        NetworkStream st = connection.GetStream();

                        BinaryFormatter bf = new BinaryFormatter();
                        byte[] information = (byte[])bf.Deserialize(connection.GetStream());


                        if (information.Length > 0)
                        {
                            using (MemoryStream ms = new MemoryStream(information))
                            {
                                Image img = Image.FromStream(ms);
                                display.Image = img;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cannot find server", "Error", MessageBoxButtons.OK);
                }
                Thread.CurrentThread.Abort();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
            }
        }

        public void Disconnect()
        {
            connection.Close();
        }
    }
}
