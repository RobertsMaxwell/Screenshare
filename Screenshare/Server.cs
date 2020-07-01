using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

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

                    using (MemoryStream ms = new MemoryStream())
                    {
                        GetScreenImage().Save(ms, ImageFormat.Jpeg);
                        byte[] screenInformation = ms.ToArray();

                        //information length, information offset
                        byte[] screenInformationHeader = new byte[] {(byte)screenInformation.Length, 0};
                        screenInformationHeader[1] = (byte)screenInformationHeader.Length;

                        client.GetStream().Write(screenInformation, screenInformationHeader[1], screenInformation.Length);
                    }

                } catch(Exception e)
                {
                    Console.WriteLine($"Error Message: {e.Message}");
                }
            }
        }

        public static Image GetScreenImage()
        {
            try
            {
                Rectangle capture = Screen.PrimaryScreen.Bounds;
                Bitmap bmp = new Bitmap(capture.Width, capture.Height, PixelFormat.Format16bppGrayScale);
                Graphics gfx = gfx = Graphics.FromImage(bmp);

                //populate bmp
                gfx.CopyFromScreen(new Point(capture.Left, capture.Top), new Point(0, 0), capture.Size);
                return bmp;

                //convert bmp to byte array then populate filestream
                /*using (MemoryStream ms = new MemoryStream())
                {
                    using (FileStream fs = new FileStream(Path.Combine(Path.GetTempPath(), "image.jpg"), FileMode.Create))
                    {
                        bmp.Save(ms, ImageFormat.Jpeg);
                        byte[] bytes = ms.ToArray();
                        fs.Write(bytes, 0, bytes.Length);
                    }
                }*/
            }
            catch (Exception)
            {
                throw new Exception("Error Capturing Screen");
            }
        }
    }
}
