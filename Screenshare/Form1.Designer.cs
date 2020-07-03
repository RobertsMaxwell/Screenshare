namespace Screenshare
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.clientButton = new System.Windows.Forms.Button();
            this.serverButton = new System.Windows.Forms.Button();
            this.clientGroupBox = new System.Windows.Forms.GroupBox();
            this.clientDisconnect = new System.Windows.Forms.Button();
            this.ipAddress = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.startClient = new System.Windows.Forms.Button();
            this.serverGroupBox = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.publicAddressCopy = new System.Windows.Forms.Button();
            this.publicAddress = new System.Windows.Forms.Label();
            this.firewallRule = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.sharingLink = new System.Windows.Forms.Label();
            this.stopServer = new System.Windows.Forms.Button();
            this.connectingLink = new System.Windows.Forms.Label();
            this.startServer = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clientGroupBox.SuspendLayout();
            this.serverGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientButton
            // 
            this.clientButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientButton.Location = new System.Drawing.Point(12, 32);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(90, 36);
            this.clientButton.TabIndex = 0;
            this.clientButton.Text = "Client";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // serverButton
            // 
            this.serverButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.serverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverButton.Location = new System.Drawing.Point(142, 32);
            this.serverButton.Name = "serverButton";
            this.serverButton.Size = new System.Drawing.Size(90, 36);
            this.serverButton.TabIndex = 3;
            this.serverButton.Text = "Server";
            this.serverButton.UseVisualStyleBackColor = true;
            this.serverButton.Click += new System.EventHandler(this.serverButton_Click);
            // 
            // clientGroupBox
            // 
            this.clientGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clientGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientGroupBox.Controls.Add(this.clientDisconnect);
            this.clientGroupBox.Controls.Add(this.ipAddress);
            this.clientGroupBox.Controls.Add(this.ipTextBox);
            this.clientGroupBox.Controls.Add(this.startClient);
            this.clientGroupBox.Location = new System.Drawing.Point(12, 74);
            this.clientGroupBox.Name = "clientGroupBox";
            this.clientGroupBox.Size = new System.Drawing.Size(220, 520);
            this.clientGroupBox.TabIndex = 4;
            this.clientGroupBox.TabStop = false;
            // 
            // clientDisconnect
            // 
            this.clientDisconnect.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clientDisconnect.Location = new System.Drawing.Point(117, 450);
            this.clientDisconnect.Name = "clientDisconnect";
            this.clientDisconnect.Size = new System.Drawing.Size(85, 35);
            this.clientDisconnect.TabIndex = 3;
            this.clientDisconnect.Text = "Disconnect";
            this.clientDisconnect.UseVisualStyleBackColor = true;
            this.clientDisconnect.Click += new System.EventHandler(this.clientDisconnect_Click);
            // 
            // ipAddress
            // 
            this.ipAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddress.Location = new System.Drawing.Point(6, 23);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(104, 16);
            this.ipAddress.TabIndex = 2;
            this.ipAddress.Text = "IP Address:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(6, 42);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(117, 20);
            this.ipTextBox.TabIndex = 1;
            // 
            // startClient
            // 
            this.startClient.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startClient.Location = new System.Drawing.Point(25, 450);
            this.startClient.Name = "startClient";
            this.startClient.Size = new System.Drawing.Size(85, 35);
            this.startClient.TabIndex = 0;
            this.startClient.Text = "Connect";
            this.startClient.UseVisualStyleBackColor = true;
            this.startClient.Click += new System.EventHandler(this.startClient_Click);
            // 
            // serverGroupBox
            // 
            this.serverGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.serverGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.serverGroupBox.Controls.Add(this.status);
            this.serverGroupBox.Controls.Add(this.label3);
            this.serverGroupBox.Controls.Add(this.label2);
            this.serverGroupBox.Controls.Add(this.publicAddressCopy);
            this.serverGroupBox.Controls.Add(this.publicAddress);
            this.serverGroupBox.Controls.Add(this.firewallRule);
            this.serverGroupBox.Controls.Add(this.label1);
            this.serverGroupBox.Controls.Add(this.copyButton);
            this.serverGroupBox.Controls.Add(this.sharingLink);
            this.serverGroupBox.Controls.Add(this.stopServer);
            this.serverGroupBox.Controls.Add(this.connectingLink);
            this.serverGroupBox.Controls.Add(this.startServer);
            this.serverGroupBox.Location = new System.Drawing.Point(12, 74);
            this.serverGroupBox.Name = "serverGroupBox";
            this.serverGroupBox.Size = new System.Drawing.Size(220, 520);
            this.serverGroupBox.TabIndex = 5;
            this.serverGroupBox.TabStop = false;
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Location = new System.Drawing.Point(23, 431);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(178, 16);
            this.status.TabIndex = 12;
            this.status.Text = "Status:";
            this.status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Public:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Local:";
            // 
            // publicAddressCopy
            // 
            this.publicAddressCopy.Location = new System.Drawing.Point(133, 112);
            this.publicAddressCopy.Name = "publicAddressCopy";
            this.publicAddressCopy.Size = new System.Drawing.Size(57, 23);
            this.publicAddressCopy.TabIndex = 9;
            this.publicAddressCopy.Text = "Copy";
            this.publicAddressCopy.UseVisualStyleBackColor = true;
            this.publicAddressCopy.Click += new System.EventHandler(this.publicAddressCopy_Click);
            // 
            // publicAddress
            // 
            this.publicAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicAddress.Location = new System.Drawing.Point(34, 109);
            this.publicAddress.Name = "publicAddress";
            this.publicAddress.Size = new System.Drawing.Size(93, 26);
            this.publicAddress.TabIndex = 8;
            this.publicAddress.Text = "0";
            this.publicAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firewallRule
            // 
            this.firewallRule.Location = new System.Drawing.Point(106, 161);
            this.firewallRule.Name = "firewallRule";
            this.firewallRule.Size = new System.Drawing.Size(85, 23);
            this.firewallRule.TabIndex = 7;
            this.firewallRule.Text = "Create Rule";
            this.firewallRule.UseVisualStyleBackColor = true;
            this.firewallRule.Click += new System.EventHandler(this.firewallRule_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Firewall Rule:";
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(133, 63);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(57, 23);
            this.copyButton.TabIndex = 6;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // sharingLink
            // 
            this.sharingLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharingLink.Location = new System.Drawing.Point(31, 61);
            this.sharingLink.Name = "sharingLink";
            this.sharingLink.Size = new System.Drawing.Size(96, 26);
            this.sharingLink.TabIndex = 5;
            this.sharingLink.Text = "0";
            this.sharingLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopServer
            // 
            this.stopServer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.stopServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopServer.Location = new System.Drawing.Point(116, 450);
            this.stopServer.Name = "stopServer";
            this.stopServer.Size = new System.Drawing.Size(85, 35);
            this.stopServer.TabIndex = 3;
            this.stopServer.Text = "Stop";
            this.stopServer.UseVisualStyleBackColor = true;
            this.stopServer.Click += new System.EventHandler(this.stopServer_Click);
            // 
            // connectingLink
            // 
            this.connectingLink.AutoSize = true;
            this.connectingLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectingLink.Location = new System.Drawing.Point(6, 23);
            this.connectingLink.Name = "connectingLink";
            this.connectingLink.Size = new System.Drawing.Size(132, 16);
            this.connectingLink.TabIndex = 2;
            this.connectingLink.Text = "Connection Address:";
            // 
            // startServer
            // 
            this.startServer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startServer.Location = new System.Drawing.Point(21, 450);
            this.startServer.Name = "startServer";
            this.startServer.Size = new System.Drawing.Size(85, 35);
            this.startServer.TabIndex = 0;
            this.startServer.Text = "Start";
            this.startServer.UseVisualStyleBackColor = true;
            this.startServer.Click += new System.EventHandler(this.startServer_Click);
            // 
            // screen
            // 
            this.screen.Location = new System.Drawing.Point(17, 14);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(976, 582);
            this.screen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.screen.TabIndex = 1;
            this.screen.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.screen);
            this.panel1.Location = new System.Drawing.Point(238, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1005, 608);
            this.panel1.TabIndex = 12;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.serverGroupBox);
            this.Controls.Add(this.clientGroupBox);
            this.Controls.Add(this.serverButton);
            this.Controls.Add(this.clientButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screenshare";
            this.clientGroupBox.ResumeLayout(false);
            this.clientGroupBox.PerformLayout();
            this.serverGroupBox.ResumeLayout(false);
            this.serverGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.Button serverButton;
        private System.Windows.Forms.GroupBox clientGroupBox;
        private System.Windows.Forms.GroupBox serverGroupBox;
        private System.Windows.Forms.Label connectingLink;
        private System.Windows.Forms.Button startServer;
        private System.Windows.Forms.Label ipAddress;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Button startClient;
        private System.Windows.Forms.Button stopServer;
        private System.Windows.Forms.Label sharingLink;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button firewallRule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button publicAddressCopy;
        private System.Windows.Forms.Label publicAddress;
        private System.Windows.Forms.Button clientDisconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox screen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label status;
    }
}

