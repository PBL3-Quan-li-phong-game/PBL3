namespace PBL3.View.AdminMod_subform
{
    partial class StatiticForm
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
            this.cbbRange = new System.Windows.Forms.ComboBox();
            this.StatiticView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cbbRange
            // 
            this.cbbRange.FormattingEnabled = true;
            this.cbbRange.Location = new System.Drawing.Point(82, 30);
            this.cbbRange.Name = "cbbRange";
            this.cbbRange.Size = new System.Drawing.Size(191, 24);
            this.cbbRange.TabIndex = 0;
            this.cbbRange.SelectedIndexChanged += new System.EventHandler(this.cbbRange_SelectedIndexChanged);
            // 
            // StatiticView
            // 
            this.StatiticView.HideSelection = false;
            this.StatiticView.Location = new System.Drawing.Point(30, 79);
            this.StatiticView.Name = "StatiticView";
            this.StatiticView.Size = new System.Drawing.Size(300, 350);
            this.StatiticView.TabIndex = 1;
            this.StatiticView.UseCompatibleStateImageBehavior = false;
            this.StatiticView.View = System.Windows.Forms.View.Details;
            this.StatiticView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.StatiticView_ColumnWidthChanging);
            // 
            // StatiticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.StatiticView);
            this.Controls.Add(this.cbbRange);
            this.Name = "StatiticForm";
            this.Text = "StatiticForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbRange;
        private System.Windows.Forms.ListView StatiticView;
    }
}