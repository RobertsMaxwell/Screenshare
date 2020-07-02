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
        public PictureBox MainScreen
        {
            get 
            {
                return screen;
            }

            set
            {
                screen = value;
            }
        }

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
            Thread thread = new Thread(new ThreadStart(Server.StartTCPListener));
            thread.Start();
        }

        private void startClient_Click(object sender, EventArgs e)
        {
            Client client = new Client(ipTextBox.Text.Trim(), screen);
            Thread thread = new Thread(new ThreadStart(client.InitiateTCPConnect));
            thread.Start();
        }

    }
}
