using System;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;

namespace Screenshare
{
    class Server
    {
        static TcpClient client;
        static Screen displayScreen = Screen.PrimaryScreen;

        public static int TEST_PORT = 49152;
        public static int framesPerSecond = 30;
        public static bool sendInformation = true;

        public static void StartTCPListener()
        {
            //create/start server
            TcpListener server = null;
            server = new TcpListener(TEST_PORT);
            server.Start();
            Console.WriteLine("Listening...");
            client = server.AcceptTcpClient();
            Console.WriteLine("Connected!");

            while (sendInformation)
            {
                try
                {
                    client.GetStream().Flush();
                    Thread thread = new Thread(new ThreadStart(SendImageToClient));
                    thread.Start();
                    Thread.Sleep(1000 / framesPerSecond);
                } catch(Exception e)
                {
                    Console.WriteLine($"Error Message: {e.Message}");
                }
            }
            client.GetStream().Close();
            client.Close();
            Thread.CurrentThread.Abort();
        }

        private static void SendImageToClient()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                GetScreenImage().Save(ms, ImageFormat.Jpeg);
                byte[] screenInformation = ms.ToArray();

                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(client.GetStream(), screenInformation);
                Thread.CurrentThread.Abort();
            }
        }

        public static Image GetScreenImage()
        {
            try
            {
                Rectangle capture = displayScreen.Bounds;
                Bitmap bmp = new Bitmap(capture.Width, capture.Height, PixelFormat.Format16bppRgb555);
                Graphics gfx = gfx = Graphics.FromImage(bmp);
                
                //populate bmp
                gfx.CopyFromScreen(new Point(capture.Left, capture.Top), new Point(capture.X, capture.Y), capture.Size);
                return bmp;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
