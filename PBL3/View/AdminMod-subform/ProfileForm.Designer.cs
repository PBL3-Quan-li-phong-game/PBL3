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
            this.bLogOut = new System.Windows.Forms.Button();
            this.bPWDChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bLogOut
            // 
            this.bLogOut.BackgroundImage = global::PBL3.Properties.Resources.logout_icon;
            this.bLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bLogOut.Location = new System.Drawing.Point(244, 31);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(90, 90);
            this.bLogOut.TabIndex = 1;
            this.bLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bLogOut.UseVisualStyleBackColor = true;
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
            this.label2.Location = new System.Drawing.Point(257, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đăng xuất";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 175);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bLogOut);
            this.Controls.Add(this.bPWDChange);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPWDChange;
        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}