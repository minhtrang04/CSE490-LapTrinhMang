
namespace ChatClient
{
    partial class FormClient
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
            this.IPAddLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPAServer = new System.Windows.Forms.TextBox();
            this.txtPortServer = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIPAClient = new System.Windows.Forms.TextBox();
            this.txtPortClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtChatBoardClient = new System.Windows.Forms.TextBox();
            this.txtSendClient = new System.Windows.Forms.TextBox();
            this.btnSendClient = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // txtIPAServer
            // 
            this.txtIPAServer.Location = new System.Drawing.Point(162, 40);
            this.txtIPAServer.Multiline = true;
            this.txtIPAServer.Name = "txtIPAServer";
            this.txtIPAServer.Size = new System.Drawing.Size(226, 35);
            this.txtIPAServer.TabIndex = 2;
            // 
            // txtPortServer
            // 
            this.txtPortServer.Location = new System.Drawing.Point(162, 142);
            this.txtPortServer.Multiline = true;
            this.txtPortServer.Name = "txtPortServer";
            this.txtPortServer.Size = new System.Drawing.Size(226, 35);
            this.txtPortServer.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIPAServer);
            this.groupBox1.Controls.Add(this.txtPortServer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IPAddLable);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 262);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.txtIPAClient);
            this.groupBox2.Controls.Add(this.txtPortClient);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(503, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 262);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
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
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnConnect.Location = new System.Drawing.Point(284, 199);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(104, 47);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            // 
            // txtChatBoardClient
            // 
            this.txtChatBoardClient.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtChatBoardClient.Location = new System.Drawing.Point(12, 292);
            this.txtChatBoardClient.Multiline = true;
            this.txtChatBoardClient.Name = "txtChatBoardClient";
            this.txtChatBoardClient.ReadOnly = true;
            this.txtChatBoardClient.Size = new System.Drawing.Size(485, 268);
            this.txtChatBoardClient.TabIndex = 6;
            // 
            // txtSendClient
            // 
            this.txtSendClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSendClient.Location = new System.Drawing.Point(503, 292);
            this.txtSendClient.Multiline = true;
            this.txtSendClient.Name = "txtSendClient";
            this.txtSendClient.Size = new System.Drawing.Size(489, 122);
            this.txtSendClient.TabIndex = 7;
            // 
            // btnSendClient
            // 
            this.btnSendClient.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSendClient.Location = new System.Drawing.Point(884, 436);
            this.btnSendClient.Name = "btnSendClient";
            this.btnSendClient.Size = new System.Drawing.Size(104, 47);
            this.btnSendClient.TabIndex = 8;
            this.btnSendClient.Text = "Send";
            this.btnSendClient.UseVisualStyleBackColor = false;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 572);
            this.Controls.Add(this.btnSendClient);
            this.Controls.Add(this.txtSendClient);
            this.Controls.Add(this.txtChatBoardClient);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormClient";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPAddLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPAServer;
        private System.Windows.Forms.TextBox txtPortServer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtIPAClient;
        private System.Windows.Forms.TextBox txtPortClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChatBoardClient;
        private System.Windows.Forms.TextBox txtSendClient;
        private System.Windows.Forms.Button btnSendClient;
    }
}

