namespace PBL3
{
    partial class PCSelectForm
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
            this.cbbPC = new System.Windows.Forms.ComboBox();
            this.bOK = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lUserName = new System.Windows.Forms.Label();
            this.lNotify = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbPC
            // 
            this.cbbPC.FormattingEnabled = true;
            this.cbbPC.Location = new System.Drawing.Point(98, 60);
            this.cbbPC.Name = "cbbPC";
            this.cbbPC.Size = new System.Drawing.Size(121, 24);
            this.cbbPC.TabIndex = 0;
            this.cbbPC.SelectedIndexChanged += new System.EventHandler(this.cbbPC_SelectedIndexChanged);
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(148, 135);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 1;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(31, 135);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Hủy";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lUserName.Location = new System.Drawing.Point(95, 21);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(81, 16);
            this.lUserName.TabIndex = 3;
            this.lUserName.Text = "UserName";
            // 
            // lNotify
            // 
            this.lNotify.AutoSize = true;
            this.lNotify.ForeColor = System.Drawing.Color.Red;
            this.lNotify.Location = new System.Drawing.Point(65, 100);
            this.lNotify.Name = "lNotify";
            this.lNotify.Size = new System.Drawing.Size(41, 16);
            this.lNotify.TabIndex = 4;
            this.lNotify.Text = "Notify";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Máy:";
            // 
            // PCSelectForm
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lNotify);
            this.Controls.Add(this.lUserName);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.cbbPC);
            this.Name = "PCSelectForm";
            this.Text = "PCSelectForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PCSelectForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbPC;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.Label lNotify;
        private System.Windows.Forms.Label label1;
    }
}