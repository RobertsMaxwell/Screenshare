using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Screenshare
{
    public partial class Form : System.Windows.Forms.Form
    {
        public List<Thread> threadList = new List<Thread>();

        public Form()
        {
            InitializeComponent();

            serverGroupBox.Visible = false;
            clientGroupBox.Visible = false;
            sharingLink.Text = GetLocalAddress();
        }

        private void serverButton_Click(object sender, EventArgs e)
        {
            if (!serverGroupBox.Visible)
            {
                clientGroupBox.Visible = false;             
                serverGroupBox.BringToFront();
                serverGroupBox.Visible = true;

            }
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            if (!clientGroupBox.Visible)
            {
                serverGroupBox.Visible = false; 
                clientGroupBox.BringToFront();
                clientGroupBox.Visible = true;
            }
        }

        private void startServer_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Server.StartTCPListener));
            thread.Start();
            threadList.Add(thread);
        }

        private void startClient_Click(object sender, EventArgs e)
        {
            Client client = new Client(ipTextBox.Text.Trim(), screen);
            Thread thread = new Thread(new ThreadStart(client.InitiateTCPConnect));
            thread.Start();
            threadList.Add(thread);
        }

        private void stopServer_Click(object sender, EventArgs e)
        {
            foreach (Thread thread in threadList)
            {
                Console.WriteLine("INSIDE");
                thread.Abort();
            }
        }

        public string GetLocalAddress()
        {
            var host = Dns.GetHostName();

            foreach (IPAddress add in Dns.GetHostAddresses(host))
            {
                if (add.AddressFamily == AddressFamily.InterNetwork)
                {
                    return add.ToString();
                }
            }
            return "Error";
        }

        private void copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetLocalAddress());
        }
    }
}
