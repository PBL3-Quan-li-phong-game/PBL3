namespace PBL3.View.Player_subform
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
            this.bSend = new System.Windows.Forms.Button();
            this.rtbSend = new System.Windows.Forms.RichTextBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.lAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(502, 348);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(90, 90);
            this.bSend.TabIndex = 7;
            this.bSend.Text = "Gửi";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // rtbSend
            // 
            this.rtbSend.Location = new System.Drawing.Point(12, 348);
            this.rtbSend.Name = "rtbSend";
            this.rtbSend.Size = new System.Drawing.Size(477, 90);
            this.rtbSend.TabIndex = 6;
            this.rtbSend.Text = "";
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Enabled = false;
            this.rtbDisplay.Location = new System.Drawing.Point(12, 31);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.ReadOnly = true;
            this.rtbDisplay.Size = new System.Drawing.Size(580, 297);
            this.rtbDisplay.TabIndex = 5;
            this.rtbDisplay.Text = "";
            // 
            // lAdmin
            // 
            this.lAdmin.AutoSize = true;
            this.lAdmin.Location = new System.Drawing.Point(9, 9);
            this.lAdmin.Name = "lAdmin";
            this.lAdmin.Size = new System.Drawing.Size(45, 16);
            this.lAdmin.TabIndex = 9;
            this.lAdmin.Text = "Admin";
            // 
            // ChatForm
            // 
            this.AcceptButton = this.bSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.rtbSend);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.lAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button bSend;
        public System.Windows.Forms.RichTextBox rtbSend;
        public System.Windows.Forms.RichTextBox rtbDisplay;
        public System.Windows.Forms.Label lAdmin;
    }
}