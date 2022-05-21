namespace PBL3.View.AdminMod_subform
{
    partial class ChatForm
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
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.rtbSend = new System.Windows.Forms.RichTextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.SocketList = new System.Windows.Forms.GroupBox();
            this.lvConnection = new System.Windows.Forms.ListView();
            this.lUserName = new System.Windows.Forms.Label();
            this.SocketList.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Enabled = false;
            this.rtbDisplay.Location = new System.Drawing.Point(218, 31);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.ReadOnly = true;
            this.rtbDisplay.Size = new System.Drawing.Size(580, 297);
            this.rtbDisplay.TabIndex = 0;
            this.rtbDisplay.Text = "";
            // 
            // rtbSend
            // 
            this.rtbSend.Location = new System.Drawing.Point(218, 348);
            this.rtbSend.Name = "rtbSend";
            this.rtbSend.Size = new System.Drawing.Size(477, 90);
            this.rtbSend.TabIndex = 1;
            this.rtbSend.Text = "";
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(708, 348);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(90, 90);
            this.bSend.TabIndex = 2;
            this.bSend.Text = "Gửi";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // SocketList
            // 
            this.SocketList.Controls.Add(this.lvConnection);
            this.SocketList.Location = new System.Drawing.Point(13, 13);
            this.SocketList.Name = "SocketList";
            this.SocketList.Size = new System.Drawing.Size(188, 425);
            this.SocketList.TabIndex = 3;
            this.SocketList.TabStop = false;
            this.SocketList.Text = "Danh sách kết nối";
            // 
            // lvConnection
            // 
            this.lvConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConnection.HideSelection = false;
            this.lvConnection.Location = new System.Drawing.Point(3, 18);
            this.lvConnection.MultiSelect = false;
            this.lvConnection.Name = "lvConnection";
            this.lvConnection.Size = new System.Drawing.Size(182, 404);
            this.lvConnection.TabIndex = 0;
            this.lvConnection.UseCompatibleStateImageBehavior = false;
            this.lvConnection.View = System.Windows.Forms.View.List;
            this.lvConnection.SelectedIndexChanged += new System.EventHandler(this.lwConnection_SelectedIndexChanged);
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Location = new System.Drawing.Point(215, 9);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(76, 16);
            this.lUserName.TabIndex = 4;
            this.lUserName.Text = "User Name";
            // 
            // ChatForm
            // 
            this.AcceptButton = this.bSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.lUserName);
            this.Controls.Add(this.SocketList);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.rtbSend);
            this.Controls.Add(this.rtbDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.SocketList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtbDisplay;
        public System.Windows.Forms.RichTextBox rtbSend;
        public System.Windows.Forms.Button bSend;
        public System.Windows.Forms.GroupBox SocketList;
        public System.Windows.Forms.Label lUserName;
        public System.Windows.Forms.ListView lvConnection;
    }
}