using System;
using System.Windows.Forms;

namespace ST10389916_AAPD7112_POE
{
    partial class EventForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchCategories = new System.Windows.Forms.TextBox();
            this.chkUseDate = new System.Windows.Forms.CheckBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.pnlEvents = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

            this.listRecommends = new System.Windows.Forms.ListView();

            this.pnlMain.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlEvents.SuspendLayout();
            this.SuspendLayout();

            // ============================================================
            // pnlMain
            // ============================================================
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Size = new System.Drawing.Size(1210, 630);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Controls.Add(this.pnlEvents);
            this.pnlMain.Controls.Add(this.pnlSearch);

            // ============================================================
            // pnlEvents
            // ============================================================
            this.pnlEvents.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.pnlEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEvents.Controls.Add(this.listView1);
            this.pnlEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEvents.Location = new System.Drawing.Point(20, 20);
            this.pnlEvents.Name = "pnlEvents";
            this.pnlEvents.Size = new System.Drawing.Size(1170, 390);
            this.pnlEvents.TabIndex = 0;

            // ============================================================
            // listView1
            // ============================================================
            this.listView1.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colTitle,
                this.colDate,
                this.colCategory,
                this.colDescription});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = false;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1168, 388);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;

            // ============================================================
            // Column Headers
            // ============================================================
            this.colTitle.Text = "EVENT TITLE";
            this.colTitle.Width = 250;
            this.colDate.Text = "DATE";
            this.colDate.Width = 160;
            this.colCategory.Text = "CATEGORY";
            this.colCategory.Width = 190;
            this.colDescription.Text = "DESCRIPTION";
            this.colDescription.Width = 500;

            // ============================================================
            // pnlSearch
            // ============================================================
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.txtSearchCategories);
            this.pnlSearch.Controls.Add(this.chkUseDate);
            this.pnlSearch.Controls.Add(this.datePicker);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.btnBack);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSearch.Location = new System.Drawing.Point(20, 410);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1170, 200);
            this.pnlSearch.TabIndex = 1;

            // ============================================================
            // lblSearch
            // ============================================================
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(245, 124, 0);
            this.lblSearch.Location = new System.Drawing.Point(22, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(117, 30);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search Events";

            // ============================================================
            // txtSearchCategories
            // ============================================================
            this.txtSearchCategories.BackColor = System.Drawing.Color.White;
            this.txtSearchCategories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchCategories.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.txtSearchCategories.Location = new System.Drawing.Point(22, 51);
            this.txtSearchCategories.Name = "txtSearchCategories";
            this.txtSearchCategories.Size = new System.Drawing.Size(335, 30);
            this.txtSearchCategories.TabIndex = 1;

            // ============================================================
            // chkUseDate
            // ============================================================
            this.chkUseDate.AutoSize = true;
            this.chkUseDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkUseDate.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.chkUseDate.Location = new System.Drawing.Point(370, 62);
            this.chkUseDate.Name = "chkUseDate";
            this.chkUseDate.Size = new System.Drawing.Size(123, 27);
            this.chkUseDate.TabIndex = 2;
            this.chkUseDate.Text = "Include Date";
            this.chkUseDate.UseVisualStyleBackColor = true;

            // ============================================================
            // datePicker
            // ============================================================
            this.datePicker.BackColor = System.Drawing.Color.White;
            this.datePicker.CalendarForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.datePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(255, 243, 224);
            this.datePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(245, 124, 0);
            this.datePicker.CalendarTitleForeColor = System.Drawing.Color.White;
            this.datePicker.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(500, 62);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(145, 30);
            this.datePicker.TabIndex = 3;

            // ============================================================
            // btnSearch
            // ============================================================
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(670, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 42);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);

            // ============================================================
            // btnBack
            // ============================================================
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(800, 54);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 42);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.materialButton1_Click);

            // ============================================================
            // EventForm
            // ============================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false;
            this.BackColor = System.Drawing.Color.FromArgb(255, 243, 224);
            this.ClientSize = new System.Drawing.Size(1210, 630);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "EventForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Events & Announcements";

            this.pnlMain.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlEvents.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlEvents;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchCategories;
        private System.Windows.Forms.CheckBox chkUseDate;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colCategory;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ListView listRecommends;
    }
}
