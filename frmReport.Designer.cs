namespace ST10389916_AAPD7112_POE
{
    partial class frmReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rchDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddMedia = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFile = new System.Windows.Forms.Label();

            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0))
            );
            this.label1.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location";

            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.White;
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocation.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0))
            );
            this.txtLocation.Location = new System.Drawing.Point(180, 28);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(570, 25);
            this.txtLocation.TabIndex = 1;

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0))
            );
            this.label2.ForeColor = System.Drawing.Color.FromArgb(55, 71, 79);
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";

            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.White;
            this.cmbCategory.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbCategory.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0))
            );

            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location =
                new System.Drawing.Point(180, 78);

            this.cmbCategory.Name =
                "cmbCategory";

            this.cmbCategory.Size =
                new System.Drawing.Size(300, 25);

            this.cmbCategory.TabIndex = 2;

            this.cmbCategory.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cmbCategory_SelectedIndexChanged
                );

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font(
                "Segoe UI",
                10F,
                System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point,
                ((byte)(0))
            );
            this.label3.ForeColor =
                System.Drawing.Color.FromArgb(55, 71, 79);

            this.label3.Location =
                new System.Drawing.Point(35, 128);

            this.label3.Name =
                "label3";

            this.label3.Size =
                new System.Drawing.Size(86, 19);

            this.label3.TabIndex = 5;

            this.label3.Text =
                "Description";

            // 
            // rchDescription
            // 
            this.rchDescription.BackColor =
                System.Drawing.Color.White;

            this.rchDescription.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;

            this.rchDescription.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0))
                );

            this.rchDescription.Location =
                new System.Drawing.Point(180, 124);

            this.rchDescription.Name =
                "rchDescription";

            this.rchDescription.Size =
                new System.Drawing.Size(570, 120);

            this.rchDescription.TabIndex = 4;

            this.rchDescription.Text =
                "";

            // 
            // btnAddMedia
            // 
            this.btnAddMedia.BackColor =
                System.Drawing.Color.FromArgb(69, 90, 100);

            this.btnAddMedia.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnAddMedia.FlatAppearance.BorderSize =
                0;

            this.btnAddMedia.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnAddMedia.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0))
                );

            this.btnAddMedia.ForeColor =
                System.Drawing.Color.White;

            this.btnAddMedia.Location =
                new System.Drawing.Point(38, 270);

            this.btnAddMedia.Name =
                "btnAddMedia";

            this.btnAddMedia.Size =
                new System.Drawing.Size(125, 38);

            this.btnAddMedia.TabIndex = 6;

            this.btnAddMedia.Text =
                "Add Attachment";

            this.btnAddMedia.UseVisualStyleBackColor =
                false;

            this.btnAddMedia.Click +=
                new System.EventHandler(
                    this.btnAddMedia_Click
                );

            // 
            // lblFile
            // 
            this.lblFile.AutoEllipsis = true;
            this.lblFile.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0))
                );

            this.lblFile.ForeColor =
                System.Drawing.Color.FromArgb(69, 90, 100);

            this.lblFile.Location =
                new System.Drawing.Point(180, 281);

            this.lblFile.Name =
                "lblFile";

            this.lblFile.Size =
                new System.Drawing.Size(400, 20);

            this.lblFile.TabIndex = 10;

            this.lblFile.Text =
                "No attachment selected";

            this.lblFile.Visible =
                false;

            // 
            // progressBar1
            // 
            this.progressBar1.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.progressBar1.Location =
                new System.Drawing.Point(0, 0);

            this.progressBar1.Name =
                "progressBar1";

            this.progressBar1.Size =
                new System.Drawing.Size(820, 6);

            this.progressBar1.Style =
                System.Windows.Forms.ProgressBarStyle.Continuous;

            this.progressBar1.TabIndex = 7;

            this.progressBar1.Click +=
                new System.EventHandler(
                    this.progressBar1_Click
                );

            // 
            // btnBack
            // 
            this.btnBack.BackColor =
                System.Drawing.Color.FromArgb(96, 125, 139);

            this.btnBack.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnBack.FlatAppearance.BorderSize =
                0;

            this.btnBack.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnBack.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0))
                );

            this.btnBack.ForeColor =
                System.Drawing.Color.White;

            this.btnBack.Location =
                new System.Drawing.Point(555, 350);

            this.btnBack.Name =
                "btnBack";

            this.btnBack.Size =
                new System.Drawing.Size(95, 40);

            this.btnBack.TabIndex = 8;

            this.btnBack.Text =
                "BACK";

            this.btnBack.UseVisualStyleBackColor =
                false;

            this.btnBack.Click +=
                new System.EventHandler(
                    this.btnBack_Click
                );

            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor =
                System.Drawing.Color.FromArgb(46, 125, 50);

            this.btnSubmit.Cursor =
                System.Windows.Forms.Cursors.Hand;

            this.btnSubmit.FlatAppearance.BorderSize =
                0;

            this.btnSubmit.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnSubmit.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    9F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0))
                );

            this.btnSubmit.ForeColor =
                System.Drawing.Color.White;

            this.btnSubmit.Location =
                new System.Drawing.Point(665, 350);

            this.btnSubmit.Name =
                "btnSubmit";

            this.btnSubmit.Size =
                new System.Drawing.Size(95, 40);

            this.btnSubmit.TabIndex = 9;

            this.btnSubmit.Text =
                "SUBMIT";

            this.btnSubmit.UseVisualStyleBackColor =
                false;

            this.btnSubmit.Click +=
                new System.EventHandler(
                    this.btnSubmit_Click
                );

            // 
            // groupBox1
            // 
            this.groupBox1.BackColor =
                System.Drawing.Color.White;

            this.groupBox1.Controls.Add(
                this.lblFile
            );

            this.groupBox1.Controls.Add(
                this.btnSubmit
            );

            this.groupBox1.Controls.Add(
                this.btnBack
            );

            this.groupBox1.Controls.Add(
                this.btnAddMedia
            );

            this.groupBox1.Controls.Add(
                this.label3
            );

            this.groupBox1.Controls.Add(
                this.rchDescription
            );

            this.groupBox1.Controls.Add(
                this.label2
            );

            this.groupBox1.Controls.Add(
                this.cmbCategory
            );

            this.groupBox1.Controls.Add(
                this.txtLocation
            );

            this.groupBox1.Controls.Add(
                this.label1
            );

            this.groupBox1.Dock =
                System.Windows.Forms.DockStyle.Fill;

            this.groupBox1.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point,
                    ((byte)(0))
                );

            this.groupBox1.ForeColor =
                System.Drawing.Color.FromArgb(38, 50, 56);

            this.groupBox1.Location =
                new System.Drawing.Point(0, 6);

            this.groupBox1.Name =
                "groupBox1";

            this.groupBox1.Padding =
                new System.Windows.Forms.Padding(20);

            this.groupBox1.Size =
                new System.Drawing.Size(820, 444);

            this.groupBox1.TabIndex = 10;

            this.groupBox1.TabStop = false;

            this.groupBox1.Text =
                "Report a Municipal Issue";

            this.groupBox1.Enter +=
                new System.EventHandler(
                    this.groupBox1_Enter
                );

            // 
            // frmReport
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(6F, 13F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(
                    245,
                    247,
                    250
                );

            this.ClientSize =
                new System.Drawing.Size(820, 450);

            this.Controls.Add(
                this.groupBox1
            );

            this.Controls.Add(
                this.progressBar1
            );

            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.MaximizeBox =
                false;

            this.MinimizeBox =
                false;

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Name =
                "frmReport";

            this.Text =
                "Report a Municipal Issue";

            this.Load +=
                new System.EventHandler(
                    this.frmReport_Load
                );

            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddMedia;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFile;
    }
}