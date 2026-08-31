using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ST10389916_AAPD7112_POE
{
    public partial class EventForm : MaterialForm
    {
        private List<Event> allEvents; // all events
        private Queue<string> lastCategories; // memory of last 3 searches

        public EventForm()
        {
            InitializeComponent();
            lastCategories = new Queue<string>();
            LoadAllEvents();
        }

        private void LoadAllEvents()
        {
            allEvents = EventRepository.GetAllEvents();
            PopulateListView(allEvents);
            PopulateRecommendations(new List<Event>());
        }

        // Main ListView
        private void PopulateListView(IEnumerable<Event> events)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();

            listView1.Columns.Add("Title", 200);
            listView1.Columns.Add("Date", 120);
            listView1.Columns.Add("Category", 150);
            listView1.Columns.Add("Description", 400);
            listView1.View = View.Details;

            foreach (var ev in events)
            {
                var item = new ListViewItem(ev.Title);
                item.SubItems.Add(ev.EventDate.ToShortDateString());
                item.SubItems.Add(ev.Category);
                item.SubItems.Add(ev.Description);
                listView1.Items.Add(item);
            }
        }

        // Recommendations ListView
        private void PopulateRecommendations(IEnumerable<Event> events)
        {
            this.listRecommends.Items.Clear();
            listRecommends.Columns.Clear();

            listRecommends.Columns.Add("Title", 150);
            listRecommends.Columns.Add("Date", 100);
            listRecommends.Columns.Add("Category", 120);
            listRecommends.Columns.Add("Description", 200);
            listRecommends.View = View.Details;

            foreach (var ev in events)
            {
                var item = new ListViewItem(ev.Title);
                item.SubItems.Add(ev.EventDate.ToShortDateString());
                item.SubItems.Add(ev.Category);
                item.SubItems.Add(ev.Description);
                listRecommends.Items.Add(item);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchCategory = txtSearchCategories.Text.Trim();
                bool useDateFilter = chkUseDate.Checked;
                DateTime selectedDate = datePicker.Value.Date;

                // Filter main results
                var filtered = allEvents.Where(ev =>
                    (string.IsNullOrEmpty(searchCategory) || ev.Category.IndexOf(searchCategory, StringComparison.OrdinalIgnoreCase) >= 0) &&
                    (!useDateFilter || ev.EventDate.Date == selectedDate)
                ).ToList();

                if (filtered.Any())
                {
                    PopulateListView(filtered);

                    // Add this search category to memory
                    if (!string.IsNullOrEmpty(searchCategory))
                    {
                        lastCategories.Enqueue(searchCategory);
                        if (lastCategories.Count > 3)
                            lastCategories.Dequeue();
                    }

                    // Gather recommendations from all last 3 search categories
                    var recommended = allEvents
                        .Where(ev => lastCategories.Any(cat => ev.Category.IndexOf(cat, StringComparison.OrdinalIgnoreCase) >= 0))
                        .ToList();

                    PopulateRecommendations(recommended);
                }
                else
                {
                    MessageBox.Show("No events found matching the criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateListView(allEvents);
                    PopulateRecommendations(new List<Event>());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during search:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain mainForm = new frmMain();
            mainForm.Show();
        }
    }
}
