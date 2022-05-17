namespace PBL3.View.AdminMod_subform
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
            this.label2 = new System.Windows.Forms.Label();
            this.bChangeAccount = new System.Windows.Forms.Button();
            this.bPWDChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chuyển tài khoản";
            // 
            // bChangeAccount
            // 
            this.bChangeAccount.BackgroundImage = global::PBL3.Properties.Resources.ChangeAccount_icon;
            this.bChangeAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bChangeAccount.Location = new System.Drawing.Point(244, 31);
            this.bChangeAccount.Name = "bChangeAccount";
            this.bChangeAccount.Size = new System.Drawing.Size(90, 90);
            this.bChangeAccount.TabIndex = 1;
            this.bChangeAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bChangeAccount.UseVisualStyleBackColor = true;
            this.bChangeAccount.Click += new System.EventHandler(this.bChangeAccount_Click);
            // 
            // bPWDChange
            // 
            this.bPWDChange.BackgroundImage = global::PBL3.Properties.Resources.pwdchange_icon;
            this.bPWDChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPWDChange.Location = new System.Drawing.Point(66, 31);
            this.bPWDChange.Name = "bPWDChange";
            this.bPWDChange.Size = new System.Drawing.Size(90, 90);
            this.bPWDChange.TabIndex = 0;
            this.bPWDChange.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bPWDChange.UseVisualStyleBackColor = true;
            this.bPWDChange.Click += new System.EventHandler(this.bPWDChange_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 175);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bChangeAccount);
            this.Controls.Add(this.bPWDChange);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPWDChange;
        private System.Windows.Forms.Button bChangeAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}