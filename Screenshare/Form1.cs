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
        public Form1()
        {
            InitializeComponent();
        }

        public void Start()
        {
            if(dropDownMenu.Text == "Server")
            {
                Server.StartTCPListener();
            }
            else if(dropDownMenu.Text == "Client")
            {
                Client.InitiateTCPConnect();
            }
            else
            {
                MessageBox.Show("Select either Server or Client");
            }
        }
    }
}
