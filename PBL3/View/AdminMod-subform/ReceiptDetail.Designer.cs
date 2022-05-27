namespace PBL3.View.AdminMod_subform
{
    partial class ReceiptDetail
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
            this.lvReceiptDetail = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lTotalCost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lFormedDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvReceiptDetail
            // 
            this.lvReceiptDetail.HideSelection = false;
            this.lvReceiptDetail.Location = new System.Drawing.Point(23, 131);
            this.lvReceiptDetail.Name = "lvReceiptDetail";
            this.lvReceiptDetail.Size = new System.Drawing.Size(300, 275);
            this.lvReceiptDetail.TabIndex = 6;
            this.lvReceiptDetail.UseCompatibleStateImageBehavior = false;
            this.lvReceiptDetail.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "T.Tiền:";
            // 
            // lTotalCost
            // 
            this.lTotalCost.AutoSize = true;
            this.lTotalCost.Location = new System.Drawing.Point(266, 425);
            this.lTotalCost.Name = "lTotalCost";
            this.lTotalCost.Size = new System.Drawing.Size(57, 16);
            this.lTotalCost.TabIndex = 8;
            this.lTotalCost.Text = "totalcost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã hóa đơn: ";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(106, 40);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(20, 16);
            this.IDlabel.TabIndex = 10;
            this.IDlabel.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tài khoản:";
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Location = new System.Drawing.Point(94, 66);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(67, 16);
            this.lUserName.TabIndex = 12;
            this.lUserName.Text = "username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày lập hóa đơn:";
            // 
            // lFormedDate
            // 
            this.lFormedDate.AutoSize = true;
            this.lFormedDate.Location = new System.Drawing.Point(147, 91);
            this.lFormedDate.Name = "lFormedDate";
            this.lFormedDate.Size = new System.Drawing.Size(59, 16);
            this.lFormedDate.TabIndex = 14;
            this.lFormedDate.Text = "datetime";
            // 
            // ReceiptDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 471);
            this.Controls.Add(this.lFormedDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lTotalCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvReceiptDetail);
            this.Name = "ReceiptDetail";
            this.Text = "ReceiptDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lvReceiptDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lTotalCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lFormedDate;
    }
}