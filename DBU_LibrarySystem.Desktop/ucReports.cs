using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using DBU_LibrarySystem.Utilities;

namespace DBU_LibrarySystem
{
    public partial class ucReports : UserControl
    {
        private Dictionary<string, int> _chartData = new Dictionary<string, int>();

        public ucReports()
        {
            InitializeComponent();
            ThemeHelper.ApplyTheme(this);
            
            // Wire up the paint event for the graph
            panelGraph.Paint += PanelGraph_Paint;
            
            LoadStats();
        }

        private void LoadStats()
        {
            try
            {
                var (total, members, borrowed) = DBU_LibrarySystem.Services.LibraryManager.GetLibraryStats();
                lblTBooksNum.Text = total.ToString("N0");
                lblAMembersNum.Text = members.ToString("N0");
                lblBBorrowedNum.Text = borrowed.ToString("N0");

                // Load graph data
                _chartData = DBU_LibrarySystem.Services.LibraryManager.GetMonthlyBorrowingStats();
                panelGraph.Invalidate(); // Redraw graph
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message);
            }
        }

        private void PanelGraph_Paint(object sender, PaintEventArgs e)
        {
            if (_chartData == null || _chartData.Count == 0) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int width = panelGraph.Width - 100;
            int height = panelGraph.Height - 100;
            int startX = 60;
            int startY = 50;

            int maxVal = _chartData.Values.Max();
            if (maxVal < 10) maxVal = 10; // Minimum scale

            int barWidth = (width / _chartData.Count) - 30;
            int i = 0;

            foreach (var item in _chartData)
            {
                int barHeight = (int)((float)item.Value / maxVal * height);
                int x = startX + (i * (barWidth + 30));
                int y = startY + height - barHeight;

                // Draw Bar with Gradient (Teal/Cyan)
                Rectangle rect = new Rectangle(x, y, barWidth, barHeight);
                if (barHeight > 0)
                {
                    using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Teal, Color.Cyan, LinearGradientMode.Vertical))
                    {
                        // Add glow effect simulation
                        g.FillRectangle(brush, rect);
                    }
                }

                // Draw Label (Month)
                g.DrawString(item.Key, new Font("Segoe UI", 9, FontStyle.Bold), Brushes.Gray, x, startY + height + 10);
                
                // Draw Value
                g.DrawString(item.Value.ToString(), new Font("Segoe UI", 9, FontStyle.Bold), Brushes.White, x + (barWidth / 4), y - 20);

                i++;
            }

            // Draw Y-Axis line
            g.DrawLine(new Pen(Color.FromArgb(50, 50, 50), 2), startX - 10, startY, startX - 10, startY + height);
            
            // Draw X-Axis line
            g.DrawLine(new Pen(Color.FromArgb(50, 50, 50), 2), startX - 10, startY + height, startX + width, startY + height);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadStats();
        }
    }
}
