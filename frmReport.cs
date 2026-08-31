using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ST10389916_AAPD7112_POE
{
    public partial class frmReport : Form
    {
        private List<string> attachments = new List<string>();
        private List<Issue> issues = new List<Issue>();
        public frmReport()
        {
            InitializeComponent();
        }

        private void Input_ValueChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.AddRange(new string[]
            {
                "Sanitation",
                "Roads",
                "Utilities"
            });

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 4;
            progressBar1.Value = 0;

            txtLocation.TextChanged += Input_ValueChanged;
            cmbCategory.SelectedIndexChanged += Input_ValueChanged;
            rchDescription.TextChanged += Input_ValueChanged;

            UpdateProgress();
        }

        private void btnAddMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select a file to attach";
                ofd.Filter = "All Supported Files (*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx;*.txt;*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx;*.txt;*.jpg;*.jpeg;*.png;*.bmp;*.gif|" +
                             "Documents (*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx;*.txt)|*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx;*.txt|" +
                             "Images (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Multiselect = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    attachments.Clear();
                    attachments.AddRange(ofd.FileNames);

                    string files = string.Join(Environment.NewLine, ofd.FileNames);
                    
                    lblFile.Text = "Attached Files: " + files;
                    lblFile.Visible = true;
                }
                UpdateProgress();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void UpdateProgress()
        {
            int filled = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                filled++;

            if (cmbCategory.SelectedIndex >= 0)  
                filled++;

            if (!string.IsNullOrWhiteSpace(rchDescription.Text))
                filled++;

            if (attachments.Count > 0)
                filled++;

            progressBar1.Value = filled;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Issue myissue = new Issue
            {
                Location = txtLocation.Text.Trim(),
                Category = cmbCategory.SelectedItem?.ToString() ?? "",
                Description = rchDescription.Text.Trim(),
                Attachments = new List<string>(attachments)
            };

            issues.Add(myissue);

            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rchDescription.Clear();
            attachments.Clear();
            lblFile.Text = "";
            lblFile.Visible = false;

            UpdateProgress();

            MessageBox.Show("Entry saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
