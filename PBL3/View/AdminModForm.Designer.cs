﻿namespace PBL3
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
            this.lbUserName = new System.Windows.Forms.Label();
            this.bProfile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bHelp = new System.Windows.Forms.Button();
            this.bReceipt = new System.Windows.Forms.Button();
            this.bMsg = new System.Windows.Forms.Button();
            this.bStat = new System.Windows.Forms.Button();
            this.bQuit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPC = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCurrInvoice = new System.Windows.Forms.DataGridView();
            this.dgvPC = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bSearchPC = new System.Windows.Forms.Button();
            this.txtSearchPC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.bAddUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bSeachAcc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchAcc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmsAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AccMenuResetPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.AccMenuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.pFooter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPC.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel2.Controls.Add(this.lbUserName);
            this.panel2.Controls.Add(this.bProfile);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1542, 37);
            this.panel2.TabIndex = 2;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(1433, 10);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(73, 16);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "UserName";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPC);
            this.tabControl1.Controls.Add(this.tabAccount);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(104, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1438, 739);
            this.tabControl1.TabIndex = 3;
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
            this.panel3.Controls.Add(this.dgvCurrInvoice);
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
            // dgvCurrInvoice
            // 
            this.dgvCurrInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrInvoice.Location = new System.Drawing.Point(10, 20);
            this.dgvCurrInvoice.Name = "dgvCurrInvoice";
            this.dgvCurrInvoice.RowHeadersWidth = 51;
            this.dgvCurrInvoice.RowTemplate.Height = 24;
            this.dgvCurrInvoice.Size = new System.Drawing.Size(340, 649);
            this.dgvCurrInvoice.TabIndex = 0;
            // 
            // dgvPC
            // 
            this.dgvPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPC.Location = new System.Drawing.Point(0, 35);
            this.dgvPC.Name = "dgvPC";
            this.dgvPC.RowHeadersWidth = 51;
            this.dgvPC.RowTemplate.Height = 24;
            this.dgvPC.Size = new System.Drawing.Size(1424, 669);
            this.dgvPC.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bSearchPC);
            this.panel5.Controls.Add(this.txtSearchPC);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1424, 35);
            this.panel5.TabIndex = 0;
            // 
            // bSearchPC
            // 
            this.bSearchPC.BackgroundImage = global::PBL3.Properties.Resources.Search;
            this.bSearchPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSearchPC.Location = new System.Drawing.Point(241, -1);
            this.bSearchPC.Name = "bSearchPC";
            this.bSearchPC.Size = new System.Drawing.Size(34, 35);
            this.bSearchPC.TabIndex = 2;
            this.bSearchPC.UseVisualStyleBackColor = true;
            // 
            // txtSearchPC
            // 
            this.txtSearchPC.Location = new System.Drawing.Point(71, 6);
            this.txtSearchPC.Name = "txtSearchPC";
            this.txtSearchPC.Size = new System.Drawing.Size(164, 22);
            this.txtSearchPC.TabIndex = 1;
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
            this.panel6.Controls.Add(this.dataGridView1);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(340, 649);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToResizeColumns = false;
            this.dgvAccount.AllowUserToResizeRows = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(3, 38);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(1424, 669);
            this.dgvAccount.TabIndex = 4;
            this.dgvAccount.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAccount_CellMouseClick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.bAddUser);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.textBox1);
            this.panel7.Controls.Add(this.bSeachAcc);
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
            // button1
            // 
            this.button1.BackgroundImage = global::PBL3.Properties.Resources.Search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1390, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 35);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1221, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 1;
            // 
            // bSeachAcc
            // 
            this.bSeachAcc.BackgroundImage = global::PBL3.Properties.Resources.Search;
            this.bSeachAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSeachAcc.Location = new System.Drawing.Point(241, -1);
            this.bSeachAcc.Name = "bSeachAcc";
            this.bSeachAcc.Size = new System.Drawing.Size(34, 35);
            this.bSeachAcc.TabIndex = 2;
            this.bSeachAcc.UseVisualStyleBackColor = true;
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
            this.toolStripMenuItem1,
            this.AccMenuResetPwd,
            this.AccMenuDel});
            this.cmsAccount.Name = "contextMenuStrip1";
            this.cmsAccount.Size = new System.Drawing.Size(182, 76);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 24);
            this.toolStripMenuItem1.Text = "Nạp tiền";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // AccMenuResetPwd
            // 
            this.AccMenuResetPwd.Name = "AccMenuResetPwd";
            this.AccMenuResetPwd.Size = new System.Drawing.Size(181, 24);
            this.AccMenuResetPwd.Text = "Reset password";
            this.AccMenuResetPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AccMenuDel
            // 
            this.AccMenuDel.Name = "AccMenuDel";
            this.AccMenuDel.Size = new System.Drawing.Size(181, 24);
            this.AccMenuDel.Text = "Xóa tài khoản";
            this.AccMenuDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminModForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1542, 793);
            this.Controls.Add(this.tabControl1);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPC.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabAccount.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPC;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Button bProfile;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvPC;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bSearchPC;
        private System.Windows.Forms.TextBox txtSearchPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button bSeachAcc;
        private System.Windows.Forms.TextBox txtSearchAcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Button bMsg;
        private System.Windows.Forms.Button bStat;
        private System.Windows.Forms.Button bQuit;
        private System.Windows.Forms.Button bAddUser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCurrInvoice;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip cmsAccount;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AccMenuResetPwd;
        private System.Windows.Forms.ToolStripMenuItem AccMenuDel;
        private System.Windows.Forms.Button bReceipt;
    }
}