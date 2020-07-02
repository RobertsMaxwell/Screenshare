namespace Screenshare
{
    partial class Form1
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
            this.clientButton = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.PictureBox();
            this.serverButton = new System.Windows.Forms.Button();
            this.clientGroupBox = new System.Windows.Forms.GroupBox();
            this.ipAddress = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.startClient = new System.Windows.Forms.Button();
            this.serverGroupBox = new System.Windows.Forms.GroupBox();
            this.sharingLink = new System.Windows.Forms.Label();
            this.stopServer = new System.Windows.Forms.Button();
            this.connectingLink = new System.Windows.Forms.Label();
            this.startServer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            this.clientGroupBox.SuspendLayout();
            this.serverGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientButton
            // 
            this.clientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientButton.Location = new System.Drawing.Point(12, 32);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(90, 36);
            this.clientButton.TabIndex = 0;
            this.clientButton.Text = "Client";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // screen
            // 
            this.screen.Location = new System.Drawing.Point(255, 32);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(611, 445);
            this.screen.TabIndex = 1;
            this.screen.TabStop = false;
            // 
            // serverButton
            // 
            this.serverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverButton.Location = new System.Drawing.Point(133, 32);
            this.serverButton.Name = "serverButton";
            this.serverButton.Size = new System.Drawing.Size(90, 36);
            this.serverButton.TabIndex = 3;
            this.serverButton.Text = "Start Server";
            this.serverButton.UseVisualStyleBackColor = true;
            this.serverButton.Click += new System.EventHandler(this.serverButton_Click);
            // 
            // clientGroupBox
            // 
            this.clientGroupBox.Controls.Add(this.ipAddress);
            this.clientGroupBox.Controls.Add(this.ipTextBox);
            this.clientGroupBox.Controls.Add(this.startClient);
            this.clientGroupBox.Location = new System.Drawing.Point(12, 105);
            this.clientGroupBox.Name = "clientGroupBox";
            this.clientGroupBox.Size = new System.Drawing.Size(211, 341);
            this.clientGroupBox.TabIndex = 4;
            this.clientGroupBox.TabStop = false;
            // 
            // ipAddress
            // 
            this.ipAddress.AutoSize = true;
            this.ipAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddress.Location = new System.Drawing.Point(7, 20);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.Size = new System.Drawing.Size(74, 16);
            this.ipAddress.TabIndex = 2;
            this.ipAddress.Text = "IP Address";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(87, 19);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(100, 20);
            this.ipTextBox.TabIndex = 1;
            // 
            // startClient
            // 
            this.startClient.Location = new System.Drawing.Point(64, 291);
            this.startClient.Name = "startClient";
            this.startClient.Size = new System.Drawing.Size(85, 35);
            this.startClient.TabIndex = 0;
            this.startClient.Text = "Start Connection";
            this.startClient.UseVisualStyleBackColor = true;
            this.startClient.Click += new System.EventHandler(this.startClient_Click);
            // 
            // serverGroupBox
            // 
            this.serverGroupBox.Controls.Add(this.sharingLink);
            this.serverGroupBox.Controls.Add(this.stopServer);
            this.serverGroupBox.Controls.Add(this.connectingLink);
            this.serverGroupBox.Controls.Add(this.startServer);
            this.serverGroupBox.Location = new System.Drawing.Point(12, 105);
            this.serverGroupBox.Name = "serverGroupBox";
            this.serverGroupBox.Size = new System.Drawing.Size(211, 341);
            this.serverGroupBox.TabIndex = 5;
            this.serverGroupBox.TabStop = false;
            // 
            // sharingLink
            // 
            this.sharingLink.AutoSize = true;
            this.sharingLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharingLink.Location = new System.Drawing.Point(18, 57);
            this.sharingLink.Name = "sharingLink";
            this.sharingLink.Size = new System.Drawing.Size(93, 16);
            this.sharingLink.TabIndex = 5;
            this.sharingLink.Text = "ex: 192.168.1.1";
            // 
            // stopServer
            // 
            this.stopServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopServer.Location = new System.Drawing.Point(116, 291);
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
            this.connectingLink.Location = new System.Drawing.Point(18, 23);
            this.connectingLink.Name = "connectingLink";
            this.connectingLink.Size = new System.Drawing.Size(102, 16);
            this.connectingLink.TabIndex = 2;
            this.connectingLink.Text = "Connecting Link";
            // 
            // startServer
            // 
            this.startServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startServer.Location = new System.Drawing.Point(21, 291);
            this.startServer.Name = "startServer";
            this.startServer.Size = new System.Drawing.Size(85, 35);
            this.startServer.TabIndex = 0;
            this.startServer.Text = "Start";
            this.startServer.UseVisualStyleBackColor = true;
            this.startServer.Click += new System.EventHandler(this.startServer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 516);
            this.Controls.Add(this.serverGroupBox);
            this.Controls.Add(this.clientGroupBox);
            this.Controls.Add(this.serverButton);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.clientButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            this.clientGroupBox.ResumeLayout(false);
            this.clientGroupBox.PerformLayout();
            this.serverGroupBox.ResumeLayout(false);
            this.serverGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.PictureBox screen;
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
    }
}

