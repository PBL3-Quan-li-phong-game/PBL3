namespace PBL3.View.AdminMod_subform
{
    partial class OrderGettingForm
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
            this.SocketList = new System.Windows.Forms.GroupBox();
            this.lwConnection = new System.Windows.Forms.ListView();
            this.lwOrder = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.bDiscard = new System.Windows.Forms.Button();
            this.bMarkasDone = new System.Windows.Forms.Button();
            this.lNotify = new System.Windows.Forms.Label();
            this.SocketList.SuspendLayout();
            this.SuspendLayout();
            // 
            // SocketList
            // 
            this.SocketList.Controls.Add(this.lwConnection);
            this.SocketList.Location = new System.Drawing.Point(12, 13);
            this.SocketList.Name = "SocketList";
            this.SocketList.Size = new System.Drawing.Size(188, 425);
            this.SocketList.TabIndex = 4;
            this.SocketList.TabStop = false;
            this.SocketList.Text = "Danh sách kết nối";
            // 
            // lwConnection
            // 
            this.lwConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lwConnection.HideSelection = false;
            this.lwConnection.Location = new System.Drawing.Point(3, 18);
            this.lwConnection.MultiSelect = false;
            this.lwConnection.Name = "lwConnection";
            this.lwConnection.Size = new System.Drawing.Size(182, 404);
            this.lwConnection.TabIndex = 0;
            this.lwConnection.UseCompatibleStateImageBehavior = false;
            this.lwConnection.View = System.Windows.Forms.View.List;
            this.lwConnection.SelectedIndexChanged += new System.EventHandler(this.lwConnection_SelectedIndexChanged);
            // 
            // lwOrder
            // 
            this.lwOrder.HideSelection = false;
            this.lwOrder.Location = new System.Drawing.Point(216, 31);
            this.lwOrder.Name = "lwOrder";
            this.lwOrder.Size = new System.Drawing.Size(300, 359);
            this.lwOrder.TabIndex = 5;
            this.lwOrder.UseCompatibleStateImageBehavior = false;
            this.lwOrder.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "T.Tiền";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(216, 412);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(88, 22);
            this.txtTotalPrice.TabIndex = 7;
            // 
            // bDiscard
            // 
            this.bDiscard.ForeColor = System.Drawing.Color.Red;
            this.bDiscard.Location = new System.Drawing.Point(310, 393);
            this.bDiscard.Name = "bDiscard";
            this.bDiscard.Size = new System.Drawing.Size(75, 45);
            this.bDiscard.TabIndex = 8;
            this.bDiscard.Text = "Hủy đơn";
            this.bDiscard.UseVisualStyleBackColor = true;
            this.bDiscard.Click += new System.EventHandler(this.bDiscard_Click);
            // 
            // bMarkasDone
            // 
            this.bMarkasDone.Location = new System.Drawing.Point(391, 393);
            this.bMarkasDone.Name = "bMarkasDone";
            this.bMarkasDone.Size = new System.Drawing.Size(125, 45);
            this.bMarkasDone.TabIndex = 9;
            this.bMarkasDone.Text = "Đánh dấu đã làm";
            this.bMarkasDone.UseVisualStyleBackColor = true;
            this.bMarkasDone.Click += new System.EventHandler(this.bMarkasDone_Click);
            // 
            // lNotify
            // 
            this.lNotify.AutoSize = true;
            this.lNotify.Location = new System.Drawing.Point(300, 198);
            this.lNotify.Name = "lNotify";
            this.lNotify.Size = new System.Drawing.Size(146, 16);
            this.lNotify.TabIndex = 10;
            this.lNotify.Text = "Không có đơn nào cả :<";
            // 
            // OrderGettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 447);
            this.Controls.Add(this.lNotify);
            this.Controls.Add(this.bMarkasDone);
            this.Controls.Add(this.bDiscard);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lwOrder);
            this.Controls.Add(this.SocketList);
            this.Name = "OrderGettingForm";
            this.Text = "OrderGettingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderGettingForm_FormClosing);
            this.SocketList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox SocketList;
        public System.Windows.Forms.ListView lwConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button bDiscard;
        private System.Windows.Forms.Button bMarkasDone;
        private System.Windows.Forms.Label lNotify;
        public System.Windows.Forms.ListView lwOrder;
    }
}