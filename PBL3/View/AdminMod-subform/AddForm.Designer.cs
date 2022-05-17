namespace PBL3.View.AdminMod_subform
{
    partial class AddForm
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.lNotify = new System.Windows.Forms.Label();
            this.cbMOD = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(149, 29);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 22);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(149, 69);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(100, 22);
            this.txtPWD.TabIndex = 1;
            this.txtPWD.TextChanged += new System.EventHandler(this.txtPWD_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiền nạp lần đầu:";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(149, 111);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 22);
            this.txtMoney.TabIndex = 1;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(24, 207);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Hủy";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(174, 207);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 3;
            this.bOK.Text = "Tạo";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // lNotify
            // 
            this.lNotify.AutoSize = true;
            this.lNotify.ForeColor = System.Drawing.Color.Red;
            this.lNotify.Location = new System.Drawing.Point(36, 176);
            this.lNotify.Name = "lNotify";
            this.lNotify.Size = new System.Drawing.Size(41, 16);
            this.lNotify.TabIndex = 4;
            this.lNotify.Text = "Notify";
            // 
            // cbMOD
            // 
            this.cbMOD.AutoSize = true;
            this.cbMOD.Location = new System.Drawing.Point(91, 145);
            this.cbMOD.Name = "cbMOD";
            this.cbMOD.Size = new System.Drawing.Size(101, 20);
            this.cbMOD.TabIndex = 5;
            this.cbMOD.Text = "Vai trò MOD";
            this.cbMOD.UseVisualStyleBackColor = true;
            this.cbMOD.CheckedChanged += new System.EventHandler(this.cbMOD_CheckedChanged);
            // 
            // AddForm
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 253);
            this.Controls.Add(this.cbMOD);
            this.Controls.Add(this.lNotify);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Label lNotify;
        private System.Windows.Forms.CheckBox cbMOD;
    }
}