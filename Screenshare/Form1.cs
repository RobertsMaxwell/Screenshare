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
using NetFwTypeLib;

namespace Screenshare
{
    public partial class Form : System.Windows.Forms.Form
    {
        public List<Thread> threadList = new List<Thread>();
        Server server;
        bool active = false;

        public Form()
        {
            InitializeComponent();

            serverGroupBox.Visible = false;
            clientGroupBox.Visible = false;
            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            Console.WriteLine(externalip);
            sharingLink.Text = externalip;//GetLocalAddress();
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
            if (!active)
            {
                server = new Server(screen);
                Thread thread = new Thread(new ThreadStart(server.StartTCPListener));
                thread.Start();
                threadList.Add(thread);
                active = true;
            }
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
            server.CloseServer();
            foreach (Thread thread in threadList)
            {
                thread.Abort();
            }
            MessageBox.Show("All threads closed.", "Success", MessageBoxButtons.OK);
            threadList = new List<Thread>();
            active = false;
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

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetLocalAddress());
        }

        private void firewallRule_Click(object sender, EventArgs e)
        {
            INetFwPolicy2 policy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            INetFwRule rule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwRule"));
            
            try
            {
                rule.Name = "Dynamic Firewall Creation";
                rule.Protocol = (int)ProtocolType.Tcp;
                rule.LocalPorts = Server.PORT.ToString();
                rule.Enabled = true;
                policy.Rules.Add(rule);
                MessageBox.Show("Succesfuly created Firewall Rule", "Success", MessageBoxButtons.OK);
            }
            catch(Exception err)
            {
                MessageBox.Show($"Couldn't create new Firewall rule\nError Message: {err.Message}", "Error", MessageBoxButtons.OK);
            }
            
        }
    }
}