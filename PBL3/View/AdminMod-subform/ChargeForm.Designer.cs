namespace PBL3.View.AdminMod_subform
{
    partial class ChargeForm
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
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.lNotify = new System.Windows.Forms.Label();
            this.lUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền:";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(102, 51);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(120, 22);
            this.txtMoney.TabIndex = 1;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(33, 115);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Hủy";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(159, 115);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 3;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // lNotify
            // 
            this.lNotify.AutoSize = true;
            this.lNotify.ForeColor = System.Drawing.Color.Red;
            this.lNotify.Location = new System.Drawing.Point(69, 86);
            this.lNotify.Name = "lNotify";
            this.lNotify.Size = new System.Drawing.Size(41, 16);
            this.lNotify.TabIndex = 4;
            this.lNotify.Text = "Notify";
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lUserName.Location = new System.Drawing.Point(105, 18);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(81, 16);
            this.lUserName.TabIndex = 5;
            this.lUserName.Text = "UserName";
            // 
            // ChargeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 154);
            this.Controls.Add(this.lUserName);
            this.Controls.Add(this.lNotify);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label1);
            this.Name = "ChargeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Label lNotify;
        private System.Windows.Forms.Label lUserName;
    }
}