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
            this.button1 = new System.Windows.Forms.Button();
            this.clientGroupBox = new System.Windows.Forms.GroupBox();
            this.serverGroupBox = new System.Windows.Forms.GroupBox();
            this.stopServer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.startServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startClient = new System.Windows.Forms.Button();
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
            // 
            // screen
            // 
            this.screen.Location = new System.Drawing.Point(253, 32);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(611, 445);
            this.screen.TabIndex = 1;
            this.screen.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(133, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start Server";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // clientGroupBox
            // 
            this.clientGroupBox.Controls.Add(this.serverGroupBox);
            this.clientGroupBox.Controls.Add(this.label1);
            this.clientGroupBox.Controls.Add(this.textBox1);
            this.clientGroupBox.Controls.Add(this.startClient);
            this.clientGroupBox.Location = new System.Drawing.Point(12, 105);
            this.clientGroupBox.Name = "clientGroupBox";
            this.clientGroupBox.Size = new System.Drawing.Size(211, 341);
            this.clientGroupBox.TabIndex = 4;
            this.clientGroupBox.TabStop = false;
            // 
            // serverGroupBox
            // 
            this.serverGroupBox.Controls.Add(this.stopServer);
            this.serverGroupBox.Controls.Add(this.label2);
            this.serverGroupBox.Controls.Add(this.textBox2);
            this.serverGroupBox.Controls.Add(this.startServer);
            this.serverGroupBox.Location = new System.Drawing.Point(0, 10);
            this.serverGroupBox.Name = "serverGroupBox";
            this.serverGroupBox.Size = new System.Drawing.Size(211, 341);
            this.serverGroupBox.TabIndex = 5;
            this.serverGroupBox.TabStop = false;
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connecting Link";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // startClient
            // 
            this.startClient.Location = new System.Drawing.Point(64, 291);
            this.startClient.Name = "startClient";
            this.startClient.Size = new System.Drawing.Size(85, 35);
            this.startClient.TabIndex = 0;
            this.startClient.Text = "Start Connection";
            this.startClient.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 516);
            this.Controls.Add(this.clientGroupBox);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox clientGroupBox;
        private System.Windows.Forms.GroupBox serverGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button startServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startClient;
        private System.Windows.Forms.Button stopServer;
    }
}

