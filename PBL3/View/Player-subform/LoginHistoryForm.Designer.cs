namespace PBL3.View.Player_subform
{
    partial class LoginHistoryForm
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
            this.lvLog = new System.Windows.Forms.ListView();
            this.UsedPC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoginTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogoutTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvLog
            // 
            this.lvLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UsedPC,
            this.LoginTime,
            this.LogoutTime,
            this.TotalTime});
            this.lvLog.HideSelection = false;
            this.lvLog.Location = new System.Drawing.Point(13, 12);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(608, 394);
            this.lvLog.TabIndex = 0;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.Details;
            // 
            // UsedPC
            // 
            this.UsedPC.Text = "Máy";
            this.UsedPC.Width = 45;
            // 
            // LoginTime
            // 
            this.LoginTime.Text = "Thời gian đăng nhập";
            this.LoginTime.Width = 145;
            // 
            // LogoutTime
            // 
            this.LogoutTime.Text = "Thời gian đăng xuất";
            this.LogoutTime.Width = 145;
            // 
            // TotalTime
            // 
            this.TotalTime.Text = "Tổng thời gian";
            this.TotalTime.Width = 95;
            // 
            // LoginHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 421);
            this.Controls.Add(this.lvLog);
            this.Name = "LoginHistoryForm";
            this.Text = "LoginHistoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.ColumnHeader UsedPC;
        private System.Windows.Forms.ColumnHeader LoginTime;
        private System.Windows.Forms.ColumnHeader LogoutTime;
        private System.Windows.Forms.ColumnHeader TotalTime;
    }
}