namespace PBL3.Component
{
    partial class cpnService
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.bPlus1 = new System.Windows.Forms.Button();
            this.bMinus1 = new System.Windows.Forms.Button();
            this.pbDemo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.lUnitPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDemo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(32, 140);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(60, 22);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bPlus1
            // 
            this.bPlus1.Location = new System.Drawing.Point(97, 139);
            this.bPlus1.Name = "bPlus1";
            this.bPlus1.Size = new System.Drawing.Size(25, 25);
            this.bPlus1.TabIndex = 2;
            this.bPlus1.Text = "+";
            this.bPlus1.UseVisualStyleBackColor = true;
            this.bPlus1.Click += new System.EventHandler(this.bPlus1_Click);
            // 
            // bMinus1
            // 
            this.bMinus1.Location = new System.Drawing.Point(1, 138);
            this.bMinus1.Name = "bMinus1";
            this.bMinus1.Size = new System.Drawing.Size(25, 25);
            this.bMinus1.TabIndex = 3;
            this.bMinus1.Text = "-";
            this.bMinus1.UseVisualStyleBackColor = true;
            this.bMinus1.Click += new System.EventHandler(this.bMinus1_Click);
            // 
            // pbDemo
            // 
            this.pbDemo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDemo.InitialImage = null;
            this.pbDemo.Location = new System.Drawing.Point(20, 31);
            this.pbDemo.Name = "pbDemo";
            this.pbDemo.Size = new System.Drawing.Size(80, 80);
            this.pbDemo.TabIndex = 0;
            this.pbDemo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtServiceName);
            this.panel1.Controls.Add(this.lUnitPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 167);
            this.panel1.TabIndex = 4;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Enabled = false;
            this.txtServiceName.Location = new System.Drawing.Point(2, 4);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.ReadOnly = true;
            this.txtServiceName.Size = new System.Drawing.Size(119, 22);
            this.txtServiceName.TabIndex = 1;
            this.txtServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lUnitPrice
            // 
            this.lUnitPrice.AutoSize = true;
            this.lUnitPrice.Location = new System.Drawing.Point(59, 117);
            this.lUnitPrice.Name = "lUnitPrice";
            this.lUnitPrice.Size = new System.Drawing.Size(37, 16);
            this.lUnitPrice.TabIndex = 0;
            this.lUnitPrice.Text = "price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đ.giá:";
            // 
            // cpnService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bMinus1);
            this.Controls.Add(this.bPlus1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.pbDemo);
            this.Controls.Add(this.panel1);
            this.Name = "cpnService";
            this.Size = new System.Drawing.Size(123, 167);
            ((System.ComponentModel.ISupportInitialize)(this.pbDemo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbDemo;
        public System.Windows.Forms.TextBox txtAmount;
        public System.Windows.Forms.Button bPlus1;
        public System.Windows.Forms.Button bMinus1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lUnitPrice;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtServiceName;
    }
}
