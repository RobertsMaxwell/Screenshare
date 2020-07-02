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
using System.Collections;

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
                        GetScreenImage().Save(ms, ImageFormat.Png);
                        byte[] screenInformation = ms.ToArray();
                        //information length, information offset
                        List<byte> screenInformationHeader = new List<byte>( new byte[] { 0 } );
                        foreach(byte bt in BitConverter.GetBytes(screenInformation.Length))
                        {
                            screenInformationHeader.Add(bt);
                        }
                        screenInformationHeader[0] = (byte)screenInformationHeader.Count;

                        client.GetStream().Write(screenInformationHeader.ToArray(), 0, screenInformationHeader.Count);
                        client.GetStream().Write(screenInformation, 0, screenInformation.Length);
                        Thread.Sleep(5000);
                        client.GetStream().Close();
                    }
                    Thread.Sleep(3000);
                    break;
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
                Bitmap bmp = new Bitmap(capture.Width, capture.Height, PixelFormat.Format16bppRgb555);
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
