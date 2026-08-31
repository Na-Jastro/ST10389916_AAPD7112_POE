using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Drawing;
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
            this.card1 = new MaterialSkin.Controls.MaterialCard();
            this.listView1 = new MaterialSkin.Controls.MaterialListView();

            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();

            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.btnSearch1 = new MaterialSkin.Controls.MaterialButton();

            this.datePicker = new System.Windows.Forms.DateTimePicker();

            this.listRecommends = new MaterialSkin.Controls.MaterialListView();

            this.chkUseDate = new MaterialSkin.Controls.MaterialCheckbox();

            this.txtSearchCategories = new MaterialSkin.Controls.MaterialTextBox();

            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();

            this.card1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();

            // ============================================================
            // card1
            // ============================================================

            this.card1.Anchor =
                ((System.Windows.Forms.AnchorStyles)(
                    (((System.Windows.Forms.AnchorStyles.Top |
                    System.Windows.Forms.AnchorStyles.Bottom) |
                    System.Windows.Forms.AnchorStyles.Left) |
                    System.Windows.Forms.AnchorStyles.Right)));

            this.card1.AutoSizeMode =
                System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            this.card1.BackColor =
                System.Drawing.Color.White;

            this.card1.Controls.Add(
                this.listView1
            );

            this.card1.Depth = 0;

            this.card1.ForeColor =
                System.Drawing.Color.FromArgb(
                    45,
                    45,
                    45
                );

            this.card1.Location =
                new System.Drawing.Point(20, 75);

            this.card1.Margin =
                new System.Windows.Forms.Padding(0);

            this.card1.MouseState =
                MaterialSkin.MouseState.HOVER;

            this.card1.Name =
                "card1";

            this.card1.Padding =
                new System.Windows.Forms.Padding(16);

            this.card1.Size =
                new System.Drawing.Size(
                    1170,
                    390
                );

            this.card1.TabIndex = 0;

            // ============================================================
            // listView1
            // ============================================================

            this.listView1.AutoSizeTable = false;

            this.listView1.BackColor =
                System.Drawing.Color.White;

            this.listView1.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.listView1.Columns.AddRange(
                new System.Windows.Forms.ColumnHeader[]
                {
                    this.Title,
                    this.Date,
                    this.Category,
                    this.Description
                }
            );

            this.listView1.Depth = 0;

            this.listView1.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.listView1.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0))
                );

            this.listView1.ForeColor =
                System.Drawing.Color.FromArgb(
                    45,
                    45,
                    45
                );

            this.listView1.FullRowSelect =
                true;

            this.listView1.GridLines =
                false;

            this.listView1.HeaderStyle =
                System.Windows.Forms.ColumnHeaderStyle.Nonclickable;

            this.listView1.HideSelection =
                false;

            this.listView1.HoverSelection =
                false;

            this.listView1.Location =
                new System.Drawing.Point(
                    16,
                    16
                );

            this.listView1.Margin =
                new System.Windows.Forms.Padding(0);

            this.listView1.MinimumSize =
                new System.Drawing.Size(
                    150,
                    100
                );

            this.listView1.MouseLocation =
                new System.Drawing.Point(
                    -1,
                    -1
                );

            this.listView1.MouseState =
                MaterialSkin.MouseState.OUT;

            this.listView1.Name =
                "listView1";

            this.listView1.OwnerDraw =
                true;

            this.listView1.Size =
                new System.Drawing.Size(
                    1138,
                    358
                );

            this.listView1.TabIndex =
                0;

            this.listView1.UseCompatibleStateImageBehavior =
                false;

            this.listView1.View =
                System.Windows.Forms.View.Details;

            // ============================================================
            // Title
            // ============================================================

            this.Title.Text =
                "EVENT TITLE";

            this.Title.Width =
                250;

            // ============================================================
            // Date
            // ============================================================

            this.Date.Text =
                "DATE";

            this.Date.Width =
                160;

            // ============================================================
            // Category
            // ============================================================

            this.Category.Text =
                "CATEGORY";

            this.Category.Width =
                190;

            // ============================================================
            // Description
            // ============================================================

            this.Description.Text =
                "DESCRIPTION";

            this.Description.Width =
                500;

            // ============================================================
            // materialCard1
            // ============================================================

            this.materialCard1.Anchor =
                ((System.Windows.Forms.AnchorStyles)(
                    ((System.Windows.Forms.AnchorStyles.Bottom |
                    System.Windows.Forms.AnchorStyles.Left) |
                    System.Windows.Forms.AnchorStyles.Right)));

            this.materialCard1.BackColor =
                System.Drawing.Color.White;

            this.materialCard1.Controls.Add(
                this.materialButton1
            );

            this.materialCard1.Controls.Add(
                this.btnSearch1
            );

            this.materialCard1.Controls.Add(
                this.datePicker
            );

            this.materialCard1.Controls.Add(
                this.chkUseDate
            );

            this.materialCard1.Controls.Add(
                this.txtSearchCategories
            );

            this.materialCard1.Controls.Add(
                this.materialLabel1
            );

            this.materialCard1.Depth = 0;

            this.materialCard1.ForeColor =
                System.Drawing.Color.FromArgb(
                    45,
                    45,
                    45
                );

            this.materialCard1.Location =
                new System.Drawing.Point(
                    20,
                    485
                );

            this.materialCard1.Margin =
                new System.Windows.Forms.Padding(0);

            this.materialCard1.MouseState =
                MaterialSkin.MouseState.HOVER;

            this.materialCard1.Name =
                "materialCard1";

            this.materialCard1.Padding =
                new System.Windows.Forms.Padding(20);

            this.materialCard1.Size =
                new System.Drawing.Size(
                    1170,
                    125
                );

            this.materialCard1.TabIndex =
                1;

            // ============================================================
            // materialLabel1
            // ============================================================

            this.materialLabel1.AutoSize =
                true;

            this.materialLabel1.Depth =
                0;

            this.materialLabel1.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    13F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0))
                );

            this.materialLabel1.ForeColor =
                System.Drawing.Color.FromArgb(
                    55,
                    71,
                    79
                );

            this.materialLabel1.Location =
                new System.Drawing.Point(
                    22,
                    17
                );

            this.materialLabel1.Margin =
                new System.Windows.Forms.Padding(0);

            this.materialLabel1.MouseState =
                MaterialSkin.MouseState.HOVER;

            this.materialLabel1.Name =
                "materialLabel1";

            this.materialLabel1.Size =
                new System.Drawing.Size(
                    117,
                    20
                );

            this.materialLabel1.TabIndex =
                1;

            this.materialLabel1.Text =
                "Search Events";

            // ============================================================
            // txtSearchCategories
            // ============================================================

            this.txtSearchCategories.AnimateReadOnly =
                false;

            this.txtSearchCategories.BackColor =
                System.Drawing.Color.White;

            this.txtSearchCategories.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.txtSearchCategories.Depth =
                0;

            this.txtSearchCategories.Font =
                new System.Drawing.Font(
                    "Roboto",
                    16F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Pixel
                );

            this.txtSearchCategories.ForeColor =
                System.Drawing.Color.FromArgb(
                    45,
                    45,
                    45
                );

            this.txtSearchCategories.Hint =
                "Search category";

            this.txtSearchCategories.LeadingIcon =
                null;

            this.txtSearchCategories.Location =
                new System.Drawing.Point(
                    22,
                    51
                );

            this.txtSearchCategories.Margin =
                new System.Windows.Forms.Padding(0);

            this.txtSearchCategories.MaxLength =
                50;

            this.txtSearchCategories.MouseState =
                MaterialSkin.MouseState.OUT;

            this.txtSearchCategories.Multiline =
                false;

            this.txtSearchCategories.Name =
                "txtSearchCategories";

            this.txtSearchCategories.Size =
                new System.Drawing.Size(
                    200,
                    50
                );

            this.txtSearchCategories.TabIndex =
                0;

            this.txtSearchCategories.Text =
                "";

            this.txtSearchCategories.TrailingIcon =
                null;

            // ============================================================
            // chkUseDate
            // ============================================================

            this.chkUseDate.AutoSize =
                true;

            this.chkUseDate.Depth =
                0;

            this.chkUseDate.ForeColor =
                System.Drawing.Color.FromArgb(
                    55,
                    71,
                    79
                );

            this.chkUseDate.Location =
                new System.Drawing.Point(
                    235,
                    59
                );

            this.chkUseDate.Margin =
                new System.Windows.Forms.Padding(0);

            this.chkUseDate.MouseLocation =
                new System.Drawing.Point(
                    -1,
                    -1
                );

            this.chkUseDate.MouseState =
                MaterialSkin.MouseState.HOVER;

            this.chkUseDate.Name =
                "chkUseDate";

            this.chkUseDate.ReadOnly =
                false;

            this.chkUseDate.Ripple =
                true;

            this.chkUseDate.Size =
                new System.Drawing.Size(
                    123,
                    37
                );

            this.chkUseDate.TabIndex =
                4;

            this.chkUseDate.Text =
                "Include Date";

            this.chkUseDate.UseVisualStyleBackColor =
                true;

            // ============================================================
            // datePicker
            // ============================================================

            this.datePicker.BackColor =
                System.Drawing.Color.White;

            this.datePicker.CalendarForeColor =
                System.Drawing.Color.FromArgb(
                    45,
                    45,
                    45
                );

            this.datePicker.CalendarMonthBackground =
                System.Drawing.Color.White;

            this.datePicker.CalendarTitleBackColor =
                System.Drawing.Color.FromArgb(
                    55,
                    71,
                    79
                );

            this.datePicker.CalendarTitleForeColor =
                System.Drawing.Color.White;

            this.datePicker.CalendarTrailingForeColor =
                System.Drawing.Color.Gray;

            this.datePicker.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0))
                );

            this.datePicker.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;

            this.datePicker.Location =
                new System.Drawing.Point(
                    370,
                    62
                );

            this.datePicker.Margin =
                new System.Windows.Forms.Padding(0);

            this.datePicker.Name =
                "datePicker";

            this.datePicker.Size =
                new System.Drawing.Size(
                    145,
                    25
                );

            this.datePicker.TabIndex =
                1;

            this.datePicker.ValueChanged +=
                new System.EventHandler(
                    this.BtnSearch_Click
                );

            // ============================================================
            // btnSearch1
            // GREEN
            // ============================================================

            this.btnSearch1.AutoSizeMode =
                System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            this.btnSearch1.BackColor =
                System.Drawing.Color.FromArgb(
                    46,
                    125,
                    50
                );

            this.btnSearch1.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnSearch1.Density =
                MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;

            this.btnSearch1.Depth =
                0;

            this.btnSearch1.HighEmphasis =
                true;

            this.btnSearch1.Icon =
                null;

            this.btnSearch1.Location =
                new System.Drawing.Point(
                    540,
                    54
                );

            this.btnSearch1.Margin =
                new System.Windows.Forms.Padding(0);

            this.btnSearch1.MouseState =
                MaterialSkin.MouseState.HOVER;

            this.btnSearch1.Name =
                "btnSearch1";

            this.btnSearch1.NoAccentTextColor =
                System.Drawing.Color.White;

            this.btnSearch1.Size =
                new System.Drawing.Size(
                    110,
                    42
                );

            this.btnSearch1.TabIndex =
                2;

            this.btnSearch1.Text =
                "SEARCH";

            this.btnSearch1.Type =
                MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;

            this.btnSearch1.UseAccentColor =
                false;

            this.btnSearch1.UseVisualStyleBackColor =
                false;

            this.btnSearch1.Click +=
                new System.EventHandler(
                    this.BtnSearch_Click
                );

            // ============================================================
            // materialButton1
            // DARK CHARCOAL
            // ============================================================

            this.materialButton1.AutoSizeMode =
                System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            this.materialButton1.BackColor =
                System.Drawing.Color.FromArgb(
                    55,
                    71,
                    79
                );

            this.materialButton1.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.materialButton1.Density =
                MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;

            this.materialButton1.Depth =
                0;

            this.materialButton1.HighEmphasis =
                true;

            this.materialButton1.Icon =
                null;

            this.materialButton1.Location =
                new System.Drawing.Point(
                    670,
                    54
                );

            this.materialButton1.Margin =
                new System.Windows.Forms.Padding(0);

            this.materialButton1.MouseState =
                MaterialSkin.MouseState.HOVER;

            this.materialButton1.Name =
                "materialButton1";

            this.materialButton1.NoAccentTextColor =
                System.Drawing.Color.White;

            this.materialButton1.Size =
                new System.Drawing.Size(
                    100,
                    42
                );

            this.materialButton1.TabIndex =
                5;

            this.materialButton1.Text =
                "BACK";

            this.materialButton1.Type =
                MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;

            this.materialButton1.UseAccentColor =
                false;

            this.materialButton1.UseVisualStyleBackColor =
                false;

            this.materialButton1.Click +=
                new System.EventHandler(
                    this.materialButton1_Click
                );

            // ============================================================
            // listRecommends
            // KEPT EXACTLY BECAUSE YOUR IMPLEMENTATION USES IT
            // ============================================================

            this.listRecommends.AutoSizeTable =
                false;

            this.listRecommends.BackColor =
                System.Drawing.Color.White;

            this.listRecommends.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.listRecommends.Depth =
                0;

            this.listRecommends.FullRowSelect =
                true;

            this.listRecommends.HideSelection =
                false;

            this.listRecommends.Location =
                new System.Drawing.Point(
                    800,
                    51
                );

            this.listRecommends.Margin =
                new System.Windows.Forms.Padding(0);

            this.listRecommends.MinimumSize =
                new System.Drawing.Size(
                    150,
                    50
                );

            this.listRecommends.MouseLocation =
                new System.Drawing.Point(
                    -1,
                    -1
                );

            this.listRecommends.MouseState =
                MaterialSkin.MouseState.OUT;

            this.listRecommends.Name =
                "listRecommends";

            this.listRecommends.OwnerDraw =
                true;

            this.listRecommends.Size =
                new System.Drawing.Size(
                    345,
                    55
                );

            this.listRecommends.TabIndex =
                3;

            this.listRecommends.UseCompatibleStateImageBehavior =
                false;

            this.listRecommends.View =
                System.Windows.Forms.View.Details;

            // ============================================================
            // EventForm
            // ============================================================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(
                    6F,
                    13F
                );

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.AutoSize =
                false;

            this.BackColor =
                System.Drawing.Color.FromArgb(
                    245,
                    246,
                    247
                );

            this.ClientSize =
                new System.Drawing.Size(
                    1210,
                    630
                );

            this.Controls.Add(
                this.materialCard1
            );

            this.Controls.Add(
                this.card1
            );

            this.Margin =
                new System.Windows.Forms.Padding(2);

            this.MinimumSize =
                new System.Drawing.Size(
                    1000,
                    550
                );

            this.Name =
                "EventForm";

            this.Padding =
                new System.Windows.Forms.Padding(
                    2,
                    52,
                    2,
                    2
                );

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text =
                "Local Events & Announcements";

            this.card1.ResumeLayout(
                false
            );

            this.materialCard1.ResumeLayout(
                false
            );

            this.materialCard1.PerformLayout();

            this.ResumeLayout(
                false
            );
        }

        #endregion

        private MaterialCard card1;

        private MaterialListView listView1;

        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Description;

        private MaterialCard materialCard1;

        private MaterialTextBox txtSearchCategories;

        private MaterialButton btnSearch1;

        private System.Windows.Forms.DateTimePicker datePicker;

        private MaterialListView listRecommends;

        private MaterialCheckbox chkUseDate;

        private MaterialLabel materialLabel1;

        private MaterialButton materialButton1;
    }
}