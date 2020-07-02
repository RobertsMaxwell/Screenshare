using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            foreach(var screen in Screen.AllScreens)
            {
                monitorList.Items.Add(screen.DeviceName);
            }
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
            Server.StartTCPListener();
        }

        private void startClient_Click(object sender, EventArgs e)
        {
            Client.InitiateTCPConnect();
            Client.TEST_ADDRESS = ipTextBox.Text.Trim();
        }

    }
}
