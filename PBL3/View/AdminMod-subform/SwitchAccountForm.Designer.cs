namespace PBL3.View.AdminMod_subform
{
    partial class SwitchAccountForm
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
            this.lNotify = new System.Windows.Forms.Label();
            this.bSwitch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lNotify
            // 
            this.lNotify.AutoSize = true;
            this.lNotify.ForeColor = System.Drawing.Color.Red;
            this.lNotify.Location = new System.Drawing.Point(101, 126);
            this.lNotify.Name = "lNotify";
            this.lNotify.Size = new System.Drawing.Size(41, 16);
            this.lNotify.TabIndex = 17;
            this.lNotify.Text = "Notify";
            this.lNotify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bSwitch
            // 
            this.bSwitch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bSwitch.Location = new System.Drawing.Point(134, 167);
            this.bSwitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSwitch.Name = "bSwitch";
            this.bSwitch.Size = new System.Drawing.Size(122, 34);
            this.bSwitch.TabIndex = 14;
            this.bSwitch.Text = "Chuyển tài khoản";
            this.bSwitch.UseVisualStyleBackColor = false;
            this.bSwitch.Click += new System.EventHandler(this.bSwitch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(192, 79);
            this.txtPWD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.PasswordChar = '*';
            this.txtPWD.Size = new System.Drawing.Size(131, 22);
            this.txtPWD.TabIndex = 13;
            this.txtPWD.TextChanged += new System.EventHandler(this.txtPWD_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(192, 37);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(131, 22);
            this.txtUserName.TabIndex = 12;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // SwitchAccountForm
            // 
            this.AcceptButton = this.bSwitch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 227);
            this.Controls.Add(this.lNotify);
            this.Controls.Add(this.bSwitch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Name = "SwitchAccountForm";
            this.Text = "SwitchAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNotify;
        private System.Windows.Forms.Button bSwitch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
    }
}