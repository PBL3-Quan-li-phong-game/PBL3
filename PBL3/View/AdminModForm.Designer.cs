namespace PBL3
{
    partial class AdminModForm
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
            this.components = new System.ComponentModel.Container();
            this.pFooter = new System.Windows.Forms.Panel();
            this.lDateTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.lUserName = new System.Windows.Forms.Label();
            this.bProfile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bHelp = new System.Windows.Forms.Button();
            this.bReceipt = new System.Windows.Forms.Button();
            this.bMsg = new System.Windows.Forms.Button();
            this.bStat = new System.Windows.Forms.Button();
            this.bQuit = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPC = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCurrReceipt = new System.Windows.Forms.DataGridView();
            this.dgvPC = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearchPC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvReceiptHistory = new System.Windows.Forms.DataGridView();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bAddUser = new System.Windows.Forms.Button();
            this.bSearchReceipt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchAcc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmsAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Charge = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetPWD = new System.Windows.Forms.ToolStripMenuItem();
            this.Del = new System.Windows.Forms.ToolStripMenuItem();
            this.pFooter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPC.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel7.SuspendLayout();
            this.cmsAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pFooter
            // 
            this.pFooter.Controls.Add(this.lDateTime);
            this.pFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFooter.Location = new System.Drawing.Point(0, 776);
            this.pFooter.Name = "pFooter";
            this.pFooter.Size = new System.Drawing.Size(1542, 17);
            this.pFooter.TabIndex = 0;
            // 
            // lDateTime
            // 
            this.lDateTime.AutoSize = true;
            this.lDateTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lDateTime.Location = new System.Drawing.Point(1475, 0);
            this.lDateTime.Name = "lDateTime";
            this.lDateTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lDateTime.Size = new System.Drawing.Size(67, 16);
            this.lDateTime.TabIndex = 0;
            this.lDateTime.Text = "DateTime";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lUserName);
            this.panel2.Controls.Add(this.bProfile);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1542, 37);
            this.panel2.TabIndex = 2;
            // 
            // lUserName
            // 
            this.lUserName.AutoSize = true;
            this.lUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUserName.Location = new System.Drawing.Point(1433, 10);
            this.lUserName.Name = "lUserName";
            this.lUserName.Size = new System.Drawing.Size(73, 16);
            this.lUserName.TabIndex = 1;
            this.lUserName.Text = "UserName";
            this.lUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bProfile
            // 
            this.bProfile.BackgroundImage = global::PBL3.Properties.Resources.Setting_Profile;
            this.bProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bProfile.Dock = System.Windows.Forms.DockStyle.Right;
            this.bProfile.Location = new System.Drawing.Point(1505, 0);
            this.bProfile.Name = "bProfile";
            this.bProfile.Size = new System.Drawing.Size(37, 37);
            this.bProfile.TabIndex = 0;
            this.bProfile.UseVisualStyleBackColor = true;
            this.bProfile.Click += new System.EventHandler(this.bProfile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bHelp);
            this.panel1.Controls.Add(this.bReceipt);
            this.panel1.Controls.Add(this.bMsg);
            this.panel1.Controls.Add(this.bStat);
            this.panel1.Controls.Add(this.bQuit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 739);
            this.panel1.TabIndex = 0;
            // 
            // bHelp
            // 
            this.bHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bHelp.Image = global::PBL3.Properties.Resources.help_icon;
            this.bHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bHelp.Location = new System.Drawing.Point(12, 588);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(80, 96);
            this.bHelp.TabIndex = 0;
            this.bHelp.Text = "Trợ giúp";
            this.bHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bHelp.UseVisualStyleBackColor = true;
            // 
            // bReceipt
            // 
            this.bReceipt.Image = global::PBL3.Properties.Resources.bill_icon;
            this.bReceipt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bReceipt.Location = new System.Drawing.Point(12, 313);
            this.bReceipt.Name = "bReceipt";
            this.bReceipt.Size = new System.Drawing.Size(80, 96);
            this.bReceipt.TabIndex = 0;
            this.bReceipt.Text = "Đơn mới";
            this.bReceipt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bReceipt.UseVisualStyleBackColor = true;
            this.bReceipt.Click += new System.EventHandler(this.bReceipt_Click);
            // 
            // bMsg
            // 
            this.bMsg.Image = global::PBL3.Properties.Resources.msg_icon;
            this.bMsg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bMsg.Location = new System.Drawing.Point(12, 175);
            this.bMsg.Name = "bMsg";
            this.bMsg.Size = new System.Drawing.Size(80, 96);
            this.bMsg.TabIndex = 0;
            this.bMsg.Text = "Nhắn tin";
            this.bMsg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bMsg.UseVisualStyleBackColor = true;
            this.bMsg.Click += new System.EventHandler(this.bMsg_Click);
            // 
            // bStat
            // 
            this.bStat.Image = global::PBL3.Properties.Resources.statitic_ico;
            this.bStat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bStat.Location = new System.Drawing.Point(12, 37);
            this.bStat.Name = "bStat";
            this.bStat.Size = new System.Drawing.Size(80, 96);
            this.bStat.TabIndex = 0;
            this.bStat.Text = "Thống kê";
            this.bStat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bStat.UseVisualStyleBackColor = true;
            // 
            // bQuit
            // 
            this.bQuit.Image = global::PBL3.Properties.Resources.quit_icon;
            this.bQuit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bQuit.Location = new System.Drawing.Point(12, 451);
            this.bQuit.Name = "bQuit";
            this.bQuit.Size = new System.Drawing.Size(80, 96);
            this.bQuit.TabIndex = 0;
            this.bQuit.Text = "Thoát";
            this.bQuit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bQuit.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPC);
            this.tabControl.Controls.Add(this.tabAccount);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(104, 37);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1438, 739);
            this.tabControl.TabIndex = 3;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPC
            // 
            this.tabPC.Controls.Add(this.panel4);
            this.tabPC.Location = new System.Drawing.Point(4, 25);
            this.tabPC.Name = "tabPC";
            this.tabPC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPC.Size = new System.Drawing.Size(1430, 710);
            this.tabPC.TabIndex = 0;
            this.tabPC.Text = "Máy";
            this.tabPC.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.dgvPC);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1424, 704);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dgvCurrReceipt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1074, 35);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.panel3.Size = new System.Drawing.Size(350, 669);
            this.panel3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hóa đơn";
            // 
            // dgvCurrReceipt
            // 
            this.dgvCurrReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrReceipt.Location = new System.Drawing.Point(10, 20);
            this.dgvCurrReceipt.Name = "dgvCurrReceipt";
            this.dgvCurrReceipt.RowHeadersWidth = 51;
            this.dgvCurrReceipt.RowTemplate.Height = 24;
            this.dgvCurrReceipt.Size = new System.Drawing.Size(340, 649);
            this.dgvCurrReceipt.TabIndex = 0;
            // 
            // dgvPC
            // 
            this.dgvPC.AllowUserToAddRows = false;
            this.dgvPC.AllowUserToDeleteRows = false;
            this.dgvPC.AllowUserToResizeRows = false;
            this.dgvPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPC.Location = new System.Drawing.Point(0, 35);
            this.dgvPC.Name = "dgvPC";
            this.dgvPC.ReadOnly = true;
            this.dgvPC.RowHeadersWidth = 51;
            this.dgvPC.RowTemplate.Height = 24;
            this.dgvPC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPC.Size = new System.Drawing.Size(1078, 669);
            this.dgvPC.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSearchPC);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1424, 35);
            this.panel5.TabIndex = 0;
            // 
            // txtSearchPC
            // 
            this.txtSearchPC.Location = new System.Drawing.Point(71, 6);
            this.txtSearchPC.Name = "txtSearchPC";
            this.txtSearchPC.Size = new System.Drawing.Size(164, 22);
            this.txtSearchPC.TabIndex = 1;
            this.txtSearchPC.TextChanged += new System.EventHandler(this.txtSearchPC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.panel6);
            this.tabAccount.Controls.Add(this.dgvAccount);
            this.tabAccount.Controls.Add(this.panel7);
            this.tabAccount.Location = new System.Drawing.Point(4, 25);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(1430, 710);
            this.tabAccount.TabIndex = 1;
            this.tabAccount.Text = "Tài khoản";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.dgvReceiptHistory);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1077, 38);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.panel6.Size = new System.Drawing.Size(350, 669);
            this.panel6.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lịch sử hóa đơn";
            // 
            // dgvReceiptHistory
            // 
            this.dgvReceiptHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReceiptHistory.Location = new System.Drawing.Point(10, 20);
            this.dgvReceiptHistory.Name = "dgvReceiptHistory";
            this.dgvReceiptHistory.RowHeadersWidth = 51;
            this.dgvReceiptHistory.RowTemplate.Height = 24;
            this.dgvReceiptHistory.Size = new System.Drawing.Size(340, 649);
            this.dgvReceiptHistory.TabIndex = 0;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.AllowUserToResizeRows = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(3, 38);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(1073, 669);
            this.dgvAccount.TabIndex = 4;
            this.dgvAccount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvAccount_MouseClick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.bAddUser);
            this.panel7.Controls.Add(this.bSearchReceipt);
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.txtSearchAcc);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1424, 35);
            this.panel7.TabIndex = 3;
            // 
            // bAddUser
            // 
            this.bAddUser.Image = global::PBL3.Properties.Resources.add_user_icon;
            this.bAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAddUser.Location = new System.Drawing.Point(949, 3);
            this.bAddUser.Name = "bAddUser";
            this.bAddUser.Size = new System.Drawing.Size(124, 29);
            this.bAddUser.TabIndex = 3;
            this.bAddUser.Text = "Thêm tài khoản";
            this.bAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAddUser.UseVisualStyleBackColor = true;
            this.bAddUser.Click += new System.EventHandler(this.bAddUser_Click);
            // 
            // bSearchReceipt
            // 
            this.bSearchReceipt.BackgroundImage = global::PBL3.Properties.Resources.Search;
            this.bSearchReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSearchReceipt.Location = new System.Drawing.Point(1390, 0);
            this.bSearchReceipt.Name = "bSearchReceipt";
            this.bSearchReceipt.Size = new System.Drawing.Size(34, 35);
            this.bSearchReceipt.TabIndex = 2;
            this.bSearchReceipt.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1221, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1153, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm kiếm";
            // 
            // txtSearchAcc
            // 
            this.txtSearchAcc.Location = new System.Drawing.Point(71, 6);
            this.txtSearchAcc.Name = "txtSearchAcc";
            this.txtSearchAcc.Size = new System.Drawing.Size(164, 22);
            this.txtSearchAcc.TabIndex = 1;
            this.txtSearchAcc.TextChanged += new System.EventHandler(this.txtSearchAcc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm";
            // 
            // cmsAccount
            // 
            this.cmsAccount.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Charge,
            this.ResetPWD,
            this.Del});
            this.cmsAccount.Name = "contextMenuStrip1";
            this.cmsAccount.Size = new System.Drawing.Size(182, 76);
            // 
            // Charge
            // 
            this.Charge.Name = "Charge";
            this.Charge.Size = new System.Drawing.Size(181, 24);
            this.Charge.Text = "Nạp tiền";
            this.Charge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Charge.Click += new System.EventHandler(this.Charge_Click);
            // 
            // ResetPWD
            // 
            this.ResetPWD.Name = "ResetPWD";
            this.ResetPWD.Size = new System.Drawing.Size(181, 24);
            this.ResetPWD.Text = "Reset password";
            this.ResetPWD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetPWD.Click += new System.EventHandler(this.ResetPWD_Click);
            // 
            // Del
            // 
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(181, 24);
            this.Del.Text = "Xóa tài khoản";
            this.Del.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // AdminModForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1542, 793);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminModForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NetCafe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminModForm_FormClosed);
            this.pFooter.ResumeLayout(false);
            this.pFooter.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPC.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabAccount.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.cmsAccount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pFooter;
        private System.Windows.Forms.Label lDateTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPC;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Button bProfile;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvPC;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtSearchPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtSearchAcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lUserName;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Button bMsg;
        private System.Windows.Forms.Button bStat;
        private System.Windows.Forms.Button bQuit;
        private System.Windows.Forms.Button bAddUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCurrReceipt;
        private System.Windows.Forms.Button bSearchReceipt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip cmsAccount;
        private System.Windows.Forms.ToolStripMenuItem Charge;
        private System.Windows.Forms.ToolStripMenuItem ResetPWD;
        private System.Windows.Forms.ToolStripMenuItem Del;
        private System.Windows.Forms.Button bReceipt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvReceiptHistory;
    }
}