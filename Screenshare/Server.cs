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
        public PictureBox display;
        public Label status;
        public int framesPerSecond;
        TcpListener server = null;

        public Server(PictureBox display, Label statusLabel, int fps = 30)
        {
            this.display = display;
            status = statusLabel;
            framesPerSecond = fps;
        }

        static TcpClient client;
        static Screen displayScreen = Screen.PrimaryScreen;
        public static int PORT = 49152;

        public void StartTCPListener()
        {
            //create/start server
            server = new TcpListener(PORT);
            server.Start();
            status.Text = "Status: Listening...";
            try
            {
                client = server.AcceptTcpClient();
                status.Text = "Status: Connecting...";
            }
            catch
            {
                return;
            }
            status.Text = "Status: Connected!";

            while (true)
            {
                try
                {
                    client.GetStream().Flush();
                    Thread thread = new Thread(new ThreadStart(SendImageToClient));
                    thread.Start();
                    Image img = GetScreenImage();
                    display.Image = img;
                    Thread.Sleep(1000 / framesPerSecond);
                } catch(Exception e)
                {
                    status.Text = "Status: Down";
                    display.Image = null;
                    MessageBox.Show("Disconnected", "Information", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        public void CloseServer()
        {
            if (server != null)
            {
                status.Text = "Status: Down";
                server.Stop();
            }
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
