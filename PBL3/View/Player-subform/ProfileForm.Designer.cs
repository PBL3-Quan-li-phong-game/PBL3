﻿namespace PBL3.View.Player_subform
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bLogOut = new System.Windows.Forms.Button();
            this.bPWDChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đăng xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // bLogOut
            // 
            this.bLogOut.BackgroundImage = global::PBL3.Properties.Resources.logout_icon;
            this.bLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bLogOut.Location = new System.Drawing.Point(241, 37);
            this.bLogOut.Name = "bLogOut";
            this.bLogOut.Size = new System.Drawing.Size(90, 90);
            this.bLogOut.TabIndex = 4;
            this.bLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bLogOut.UseVisualStyleBackColor = true;
            // 
            // bPWDChange
            // 
            this.bPWDChange.BackgroundImage = global::PBL3.Properties.Resources.pwdchange_icon;
            this.bPWDChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPWDChange.Location = new System.Drawing.Point(66, 37);
            this.bPWDChange.Name = "bPWDChange";
            this.bPWDChange.Size = new System.Drawing.Size(90, 90);
            this.bPWDChange.TabIndex = 3;
            this.bPWDChange.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bPWDChange.UseVisualStyleBackColor = true;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 172);
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bLogOut;
        private System.Windows.Forms.Button bPWDChange;
    }
}