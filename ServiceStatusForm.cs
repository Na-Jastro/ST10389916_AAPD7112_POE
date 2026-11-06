using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ST10389916_AAPD7112_POE
{
    public class ServiceStatusForm : Form
    {
        private readonly ListView listRequests;
        private readonly TextBox txtRequestId;
        private readonly Label lblTrackResult;
        private readonly ListBox lstTree;
        private readonly Label lblGraph;

        public ServiceStatusForm()
        {
            Text = "Service Request Status";
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(1180, 700);
            BackColor = Color.FromArgb(255, 243, 224);

            var pnlMain = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(14),
                BackColor = Color.FromArgb(255, 243, 224)
            };
            Controls.Add(pnlMain);

            listRequests = new ListView
            {
                View = View.Details,
                FullRowSelect = true,
                Dock = DockStyle.Top,
                Height = 320,
                Font = new Font("Segoe UI", 9.5f),
                BackColor = Color.White
            };
            listRequests.Columns.Add("Request ID", 100);
            listRequests.Columns.Add("Location", 230);
            listRequests.Columns.Add("Category", 100);
            listRequests.Columns.Add("Status", 110);
            listRequests.Columns.Add("Priority", 70);
            listRequests.Columns.Add("ETA (days)", 80);
            listRequests.Columns.Add("Submitted", 110);
            pnlMain.Controls.Add(listRequests);

            var pnlActions = new Panel
            {
                Dock = DockStyle.Top,
                Height = 120,
                Padding = new Padding(0, 10, 0, 10),
                BackColor = Color.FromArgb(255, 243, 224)
            };
            pnlMain.Controls.Add(pnlActions);

            var lblTrack = new Label
            {
                Text = "Track by Request ID:",
                Location = new Point(0, 6),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(245, 124, 0)
            };
            pnlActions.Controls.Add(lblTrack);

            txtRequestId = new TextBox
            {
                Location = new Point(170, 4),
                Width = 140,
                Font = new Font("Segoe UI", 10)
            };
            pnlActions.Controls.Add(txtRequestId);

            var btnTrack = new Button
            {
                Text = "TRACK",
                Location = new Point(320, 2),
                Width = 100,
                Height = 32,
                BackColor = Color.FromArgb(0, 137, 123),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White
            };
            btnTrack.FlatAppearance.BorderSize = 0;
            btnTrack.Click += BtnTrack_Click;
            pnlActions.Controls.Add(btnTrack);

            var btnByPriority = new Button
            {
                Text = "SORT PRIORITY",
                Location = new Point(0, 50),
                Width = 140,
                Height = 32,
                BackColor = Color.FromArgb(21, 101, 192),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White
            };
            btnByPriority.FlatAppearance.BorderSize = 0;
            btnByPriority.Click += delegate { PopulateRequestList(ServiceRequestRepository.GetRequestsByPriority()); };
            pnlActions.Controls.Add(btnByPriority);

            var btnByEta = new Button
            {
                Text = "SORT ETA",
                Location = new Point(150, 50),
                Width = 120,
                Height = 32,
                BackColor = Color.FromArgb(56, 142, 60),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White
            };
            btnByEta.FlatAppearance.BorderSize = 0;
            btnByEta.Click += delegate { PopulateRequestList(ServiceRequestRepository.GetRequestsByEstimatedResolution()); };
            pnlActions.Controls.Add(btnByEta);

            var btnReset = new Button
            {
                Text = "RESET",
                Location = new Point(280, 50),
                Width = 100,
                Height = 32,
                BackColor = Color.FromArgb(117, 117, 117),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White
            };
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.Click += delegate { PopulateRequestList(ServiceRequestRepository.GetAllRequests()); };
            pnlActions.Controls.Add(btnReset);

            var btnBack = new Button
            {
                Text = "BACK",
                Location = new Point(390, 50),
                Width = 100,
                Height = 32,
                BackColor = Color.FromArgb(69, 90, 100),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White
            };
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Click += BtnBack_Click;
            pnlActions.Controls.Add(btnBack);

            lblTrackResult = new Label
            {
                Text = "",
                Location = new Point(440, 8),
                AutoSize = true,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Italic),
                ForeColor = Color.FromArgb(33, 33, 33)
            };
            pnlActions.Controls.Add(lblTrackResult);

            var pnlBottom = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Vertical,
                SplitterDistance = 550,
                BackColor = Color.FromArgb(255, 243, 224)
            };
            pnlMain.Controls.Add(pnlBottom);

            lstTree = new ListBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Consolas", 9.5f)
            };
            pnlBottom.Panel1.Controls.Add(lstTree);

            var lblTree = new Label
            {
                Text = "Basic Tree (Category -> Request -> Status)",
                Dock = DockStyle.Top,
                Height = 25,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = Color.FromArgb(245, 124, 0)
            };
            pnlBottom.Panel1.Controls.Add(lblTree);

            lblGraph = new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10),
                Padding = new Padding(8),
                BackColor = Color.White,
                ForeColor = Color.FromArgb(33, 33, 33)
            };
            pnlBottom.Panel2.Controls.Add(lblGraph);

            var lblGraphHeader = new Label
            {
                Text = "Graph Traversal + MST Summary",
                Dock = DockStyle.Top,
                Height = 25,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = Color.FromArgb(245, 124, 0)
            };
            pnlBottom.Panel2.Controls.Add(lblGraphHeader);

            Load += ServiceStatusForm_Load;
        }

        private void ServiceStatusForm_Load(object sender, EventArgs e)
        {
            PopulateRequestList(ServiceRequestRepository.GetAllRequests());

            lstTree.Items.Clear();
            foreach (var line in ServiceRequestRepository.GetCategoryTreeLines())
            {
                lstTree.Items.Add(line);
            }

            List<string> traversal = ServiceRequestRepository.GetZoneTraversalFrom("Ward 1");
            int mstCost = ServiceRequestRepository.GetMinimumNetworkCost("Ward 1");
            lblGraph.Text =
                "BFS from Ward 1: " + string.Join(" -> ", traversal) + Environment.NewLine + Environment.NewLine +
                "Minimum spanning network cost (Prim): " + mstCost + Environment.NewLine +
                "Interpretation: lower cost means more efficient routing for service crews.";
        }

        private void PopulateRequestList(IEnumerable<ServiceRequest> requests)
        {
            listRequests.Items.Clear();
            foreach (var request in requests)
            {
                var item = new ListViewItem(request.RequestId);
                item.SubItems.Add(request.Location);
                item.SubItems.Add(request.Category);
                item.SubItems.Add(request.Status);
                item.SubItems.Add(request.Priority.ToString());
                item.SubItems.Add(request.EstimatedDays.ToString());
                item.SubItems.Add(request.SubmittedOn.ToShortDateString());
                listRequests.Items.Add(item);
            }
        }

        private void BtnTrack_Click(object sender, EventArgs e)
        {
            var result = ServiceRequestRepository.FindById(txtRequestId.Text);
            if (result == null)
            {
                lblTrackResult.Text = "Request not found. Example: SR-1001";
                return;
            }

            lblTrackResult.Text = "Found: " + result.RequestId + " | " + result.Status + " | ETA " + result.EstimatedDays + " day(s).";
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var main = new frmMain();
            main.Show();
            Close();
        }
    }
}
