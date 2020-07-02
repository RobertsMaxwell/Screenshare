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

namespace Screenshare
{
    public partial class Form1 : Form
    {
        public List<Thread> threadList = new List<Thread>();

        public Form1()
        {
            InitializeComponent();
        }

        private void serverButton_Click(object sender, EventArgs e)
        {
            serverGroupBox.BringToFront();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            clientGroupBox.BringToFront();
        }

        private void startServer_Click(object sender, EventArgs e)
        {
            Server server = new Server(screen);
            Thread thread = new Thread(new ThreadStart(server.StartTCPListener));
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
                thread.Abort();
            }
            threadList = new List<Thread>();
        }
    }
}
