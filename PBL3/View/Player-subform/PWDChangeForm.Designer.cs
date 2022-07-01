namespace PBL3.View.Player_subform
{
    partial class PWDChangeForm
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
            this.lNotify = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bOK = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.txtConfirmPWD = new System.Windows.Forms.TextBox();
            this.txtNewPWD = new System.Windows.Forms.TextBox();
            this.txtOldPWD = new System.Windows.Forms.TextBox();
            this.lUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Xác nhận:";
            // 
            // lNotify
            // 
            this.lNotify.AutoSize = true;
            this.lNotify.ForeColor = System.Drawing.Color.Red;
            this.lNotify.Location = new System.Drawing.Point(62, 205);
            this.lNotify.Name = "lNotify";
            this.lNotify.Size = new System.Drawing.Size(41, 16);
            this.lNotify.TabIndex = 17;
            this.lNotify.Text = "Notify";
            this.lNotify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(193, 241);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 14;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(50, 241);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 13;
            this.bCancel.Text = "Hủy";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // txtConfirmPWD
            // 
            this.txtConfirmPWD.Location = new System.Drawing.Point(152, 159);
            this.txtConfirmPWD.Name = "txtConfirmPWD";
            this.txtConfirmPWD.PasswordChar = '*';
            this.txtConfirmPWD.Size = new System.Drawing.Size(128, 22);
            this.txtConfirmPWD.TabIndex = 3;
            this.txtConfirmPWD.TextChanged += new System.EventHandler(this.txtConfirmPWD_TextChanged);
            // 
            // txtNewPWD
            // 
            this.txtNewPWD.Location = new System.Drawing.Point(152, 115);
            this.txtNewPWD.Name = "txtNewPWD";
            this.txtNewPWD.PasswordChar = '*';
            this.txtNewPWD.Size = new System.Drawing.Size(128, 22);
            this.txtNewPWD.TabIndex = 2;
            this.txtNewPWD.TextChanged += new System.EventHandler(this.txtNewPWD_TextChanged);
            // 
            // txtOldPWD
            // 
            this.txtOldPWD.Location = new System.Drawing.Point(152, 73);
            this.txtOldPWD.Name = "txtOldPWD";
            this.txtOldPWD.PasswordChar = '*';
            this.txtOldPWD.Size = new System.Drawing.Size(128, 22);
            this.txtOldPWD.TabIndex = 1;
            this.txtOldPWD.TextChanged += new System.EventHandler(this.txtOldPWD_TextChanged);
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserName.Location = new System.Drawing.Point(121, 26);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(81, 16);
            this.lUserName.TabIndex = 9;
            this.lUserName.Text = "UserName";
            this.lUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PWDChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lNotify);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.txtConfirmPWD);
            this.Controls.Add(this.txtNewPWD);
            this.Controls.Add(this.txtOldPWD);
            this.Controls.Add(this.lUserName);
            this.Name = "PWDChangeForm";
            this.Text = "PWDChangeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNotify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox txtConfirmPWD;
        private System.Windows.Forms.TextBox txtNewPWD;
        private System.Windows.Forms.TextBox txtOldPWD;
        private System.Windows.Forms.Label lUserName;
    }
}