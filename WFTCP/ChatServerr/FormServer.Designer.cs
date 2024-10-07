
namespace ChatServerr
{
    partial class FormServer
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
            this.btnSendServer = new System.Windows.Forms.Button();
            this.txtSendServer = new System.Windows.Forms.TextBox();
            this.txtChatBoardServer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConnectServer = new System.Windows.Forms.Button();
            this.txtIPAClient = new System.Windows.Forms.TextBox();
            this.txtPortClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIPAServer = new System.Windows.Forms.TextBox();
            this.txtPortServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPAddLable = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendServer
            // 
            this.btnSendServer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSendServer.Location = new System.Drawing.Point(884, 432);
            this.btnSendServer.Name = "btnSendServer";
            this.btnSendServer.Size = new System.Drawing.Size(104, 47);
            this.btnSendServer.TabIndex = 13;
            this.btnSendServer.Text = "Send";
            this.btnSendServer.UseVisualStyleBackColor = false;
            // 
            // txtSendServer
            // 
            this.txtSendServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSendServer.Location = new System.Drawing.Point(503, 288);
            this.txtSendServer.Multiline = true;
            this.txtSendServer.Name = "txtSendServer";
            this.txtSendServer.Size = new System.Drawing.Size(489, 122);
            this.txtSendServer.TabIndex = 12;
            // 
            // txtChatBoardServer
            // 
            this.txtChatBoardServer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtChatBoardServer.Location = new System.Drawing.Point(12, 288);
            this.txtChatBoardServer.Multiline = true;
            this.txtChatBoardServer.Name = "txtChatBoardServer";
            this.txtChatBoardServer.ReadOnly = true;
            this.txtChatBoardServer.Size = new System.Drawing.Size(485, 268);
            this.txtChatBoardServer.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConnectServer);
            this.groupBox2.Controls.Add(this.txtIPAClient);
            this.groupBox2.Controls.Add(this.txtPortClient);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(503, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 262);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // btnConnectServer
            // 
            this.btnConnectServer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnConnectServer.Location = new System.Drawing.Point(284, 197);
            this.btnConnectServer.Name = "btnConnectServer";
            this.btnConnectServer.Size = new System.Drawing.Size(104, 47);
            this.btnConnectServer.TabIndex = 5;
            this.btnConnectServer.Text = "Connect";
            this.btnConnectServer.UseVisualStyleBackColor = false;
            this.btnConnectServer.Click += new System.EventHandler(this.btnConnectServer_Click);
            // 
            // txtIPAClient
            // 
            this.txtIPAClient.Location = new System.Drawing.Point(163, 40);
            this.txtIPAClient.Multiline = true;
            this.txtIPAClient.Name = "txtIPAClient";
            this.txtIPAClient.Size = new System.Drawing.Size(226, 35);
            this.txtIPAClient.TabIndex = 2;
            // 
            // txtPortClient
            // 
            this.txtPortClient.Location = new System.Drawing.Point(163, 142);
            this.txtPortClient.Multiline = true;
            this.txtPortClient.Name = "txtPortClient";
            this.txtPortClient.Size = new System.Drawing.Size(226, 35);
            this.txtPortClient.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP Address:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIPAServer);
            this.groupBox1.Controls.Add(this.txtPortServer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IPAddLable);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 262);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // txtIPAServer
            // 
            this.txtIPAServer.Location = new System.Drawing.Point(162, 40);
            this.txtIPAServer.Multiline = true;
            this.txtIPAServer.Name = "txtIPAServer";
            this.txtIPAServer.Size = new System.Drawing.Size(226, 35);
            this.txtIPAServer.TabIndex = 2;
            this.txtIPAServer.TextChanged += new System.EventHandler(this.txtIPAServer_TextChanged);
            // 
            // txtPortServer
            // 
            this.txtPortServer.Location = new System.Drawing.Point(162, 142);
            this.txtPortServer.Multiline = true;
            this.txtPortServer.Name = "txtPortServer";
            this.txtPortServer.Size = new System.Drawing.Size(226, 35);
            this.txtPortServer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // IPAddLable
            // 
            this.IPAddLable.AutoSize = true;
            this.IPAddLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAddLable.Location = new System.Drawing.Point(11, 39);
            this.IPAddLable.Name = "IPAddLable";
            this.IPAddLable.Size = new System.Drawing.Size(136, 29);
            this.IPAddLable.TabIndex = 0;
            this.IPAddLable.Text = "IP Address:";
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 572);
            this.Controls.Add(this.btnSendServer);
            this.Controls.Add(this.txtSendServer);
            this.Controls.Add(this.txtChatBoardServer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormServer";
            this.Text = "FormServer";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendServer;
        private System.Windows.Forms.TextBox txtSendServer;
        private System.Windows.Forms.TextBox txtChatBoardServer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConnectServer;
        private System.Windows.Forms.TextBox txtIPAClient;
        private System.Windows.Forms.TextBox txtPortClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIPAServer;
        private System.Windows.Forms.TextBox txtPortServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IPAddLable;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}

