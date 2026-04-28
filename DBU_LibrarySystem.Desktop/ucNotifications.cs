using System;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;
using System.Linq;
using System.Drawing;

namespace DBU_LibrarySystem
{
    public partial class ucNotifications : UserControl
    {
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel mainLayout;

        public ucNotifications()
        {
            InitializeComponent();
            this.AutoScroll = true;
            // Apply global theme first
            ThemeHelper.ApplyTheme(this);
            this.Dock = DockStyle.Fill;
            
            // Set dark background to match the dashboard
            this.BackColor = Color.FromArgb(32, 33, 36); 
        }

        private void InitializeComponent()
        {
            // 1. Setup the Layout Panel to prevent UI overlap
            mainLayout = new TableLayoutPanel();
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.ColumnCount = 1;
            mainLayout.RowCount = 2;
            mainLayout.BackColor = Color.Transparent;
            
            // Fix top row for title (60px) and bottom for grid (rest of space)
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            // 2. Title Label
            labelTitle = new Label();
            labelTitle.Text = "My Notifications";
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(0, 212, 255); // Cyan color
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Padding = new Padding(20, 0, 0, 0);

            // 3. DataGridView (Dark Theme)
            dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.BackgroundColor = Color.FromArgb(32, 33, 36);
            dataGridView1.GridColor = Color.FromArgb(60, 64, 67);
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            
            // Cell Styling
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(32, 33, 36);
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 127, 184);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10F);

            // Header Styling
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 212, 255);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // 4. Assemble Controls
            this.Controls.Add(mainLayout);
            mainLayout.Controls.Add(labelTitle, 0, 0);
            mainLayout.Controls.Add(dataGridView1, 0, 1);
        }

        public void LoadNotifications(string userId)
        {
            dataGridView1.Rows.Clear();
            
            // Define columns if they don't exist
            if (dataGridView1.Columns.Count == 0)
            {
                var dateCol = new DataGridViewTextBoxColumn { Name = "Date", HeaderText = "Date", FillWeight = 25 };
                var msgCol = new DataGridViewTextBoxColumn { Name = "Message", HeaderText = "Message", FillWeight = 75 };
                
                dataGridView1.Columns.Add(dateCol);
                dataGridView1.Columns.Add(msgCol);
            }

            try 
            {
                using (var db = new DBU_LibrarySystem.Data.LibraryContext())
                {
                    var notes = db.Notifications
                                  .Where(n => n.UserId == userId)
                                  .OrderByDescending(n => n.Date)
                                  .ToList();

                    foreach (var n in notes)
                    {
                        dataGridView1.Rows.Add(n.Date.ToShortDateString(), n.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                // Silently handle or log if database is not reachable during DBU lab session
                Console.WriteLine("Error loading notifications: " + ex.Message);
            }
        }
    }
}
