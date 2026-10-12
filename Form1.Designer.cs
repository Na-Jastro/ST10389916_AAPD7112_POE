namespace ST10389916_AAPD7112_POE
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_Announcements = new System.Windows.Forms.Button();
            this.btn_Status = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();

            // pnlMain
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.pnlMain.Controls.Add(this.btn_Status);
            this.pnlMain.Controls.Add(this.btn_Announcements);
            this.pnlMain.Controls.Add(this.btn_Report);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.pnlMain.Size = new System.Drawing.Size(616, 224);
            this.pnlMain.TabIndex = 0;

            // btn_Report
            this.btn_Report.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btn_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Report.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Report.FlatAppearance.BorderSize = 0;
            this.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Report.Location = new System.Drawing.Point(10, 11);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(596, 36);
            this.btn_Report.TabIndex = 0;
            this.btn_Report.Text = "REPORT ISSUE";
            this.btn_Report.UseVisualStyleBackColor = false;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);

            // btn_Announcements
            this.btn_Announcements.BackColor = System.Drawing.Color.FromArgb(0, 137, 123);
            this.btn_Announcements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Announcements.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Announcements.FlatAppearance.BorderSize = 0;
            this.btn_Announcements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Announcements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Announcements.ForeColor = System.Drawing.Color.White;
            this.btn_Announcements.Location = new System.Drawing.Point(10, 67);
            this.btn_Announcements.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Announcements.Name = "btn_Announcements";
            this.btn_Announcements.Size = new System.Drawing.Size(596, 36);
            this.btn_Announcements.TabIndex = 3;
            this.btn_Announcements.Text = "LOCAL EVENTS AND ANNOUNCEMENTS";
            this.btn_Announcements.UseVisualStyleBackColor = false;
            this.btn_Announcements.Click += new System.EventHandler(this.btn_Announcements_Click);

            // btn_Status
            this.btn_Status.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btn_Status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Status.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Status.FlatAppearance.BorderSize = 0;
            this.btn_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Status.ForeColor = System.Drawing.Color.White;
            this.btn_Status.Location = new System.Drawing.Point(10, 123);
            this.btn_Status.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(596, 36);
            this.btn_Status.TabIndex = 5;
            this.btn_Status.Text = "SERVICE REQUEST STATUS";
            this.btn_Status.UseVisualStyleBackColor = false;

            // frmMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.ClientSize = new System.Drawing.Size(616, 224);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmMain";
            this.Text = "Municipal Service Portal";
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btn_Report;
        private System.Windows.Forms.Button btn_Announcements;
        private System.Windows.Forms.Button btn_Status;
    }
}
