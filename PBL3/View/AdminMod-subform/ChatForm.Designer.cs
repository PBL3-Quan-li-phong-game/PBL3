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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SocketList = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lUserName = new System.Windows.Forms.Label();
            this.SocketList.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(218, 31);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(580, 297);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(218, 348);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(477, 90);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(708, 348);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(90, 90);
            this.bSend.TabIndex = 2;
            this.bSend.Text = "Gửi";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // SocketList
            // 
            this.SocketList.Controls.Add(this.panel1);
            this.SocketList.Location = new System.Drawing.Point(13, 13);
            this.SocketList.Name = "SocketList";
            this.SocketList.Size = new System.Drawing.Size(188, 425);
            this.SocketList.TabIndex = 3;
            this.SocketList.TabStop = false;
            this.SocketList.Text = "Danh sách kết nối";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 404);
            this.panel1.TabIndex = 0;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.lUserName);
            this.Controls.Add(this.SocketList);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.SocketList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox SocketList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lUserName;
    }
}