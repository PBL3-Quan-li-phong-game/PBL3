namespace PBL3.View.Player_subform
{
    partial class ProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.bPWDChange = new System.Windows.Forms.Button();
            this.bLog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // bPWDChange
            // 
            this.bPWDChange.BackgroundImage = global::PBL3.Properties.Resources.pwdchange_icon;
            this.bPWDChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPWDChange.Location = new System.Drawing.Point(73, 37);
            this.bPWDChange.Name = "bPWDChange";
            this.bPWDChange.Size = new System.Drawing.Size(90, 90);
            this.bPWDChange.TabIndex = 3;
            this.bPWDChange.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bPWDChange.UseVisualStyleBackColor = true;
            this.bPWDChange.Click += new System.EventHandler(this.bPWDChange_Click);
            // 
            // bLog
            // 
            this.bLog.BackgroundImage = global::PBL3.Properties.Resources.Login_History_icon;
            this.bLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bLog.Location = new System.Drawing.Point(226, 37);
            this.bLog.Name = "bLog";
            this.bLog.Size = new System.Drawing.Size(90, 90);
            this.bLog.TabIndex = 3;
            this.bLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bLog.UseVisualStyleBackColor = true;
            this.bLog.Click += new System.EventHandler(this.bLog_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Xem lịch sử";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "đăng nhập";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 176);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bLog);
            this.Controls.Add(this.bPWDChange);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bPWDChange;
        private System.Windows.Forms.Button bLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}