using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace DBU_LibrarySystem.Utilities
{
    public static class ThemeHelper
    {
        // --- DEEP SPACE PALETTE ---
        public static Color BackgroundColor = Color.FromArgb(10, 10, 12);  // Near Black
        public static Color SurfaceColor = Color.FromArgb(22, 22, 26);     // Dark Gray/Blue
        public static Color CardColor = Color.FromArgb(30, 30, 38);        // Slightly lighter surface
        public static Color PrimaryColor = Color.FromArgb(44, 127, 184);   // Professional Blue
        public static Color AccentColor = Color.FromArgb(0, 242, 255);     // Neon Teal
        public static Color TextPrimary = Color.FromArgb(245, 245, 255);   // Off-white
        public static Color TextSecondary = Color.FromArgb(160, 160, 180); // Muted blue-gray
        public static Color DangerColor = Color.FromArgb(255, 60, 100);    // Neon Pink/Red
        public static Color SuccessColor = Color.FromArgb(46, 213, 115);

        public static Font AppHeaderFont = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
        public static Font CardHeaderFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
        public static Font AppNormalFont = new Font("Segoe UI", 10F, FontStyle.Regular);

        // --- THEME ENGINE ---

        public static void ApplyTheme(Control parent)
        {
            parent.BackColor = BackgroundColor;
            parent.ForeColor = TextPrimary;
            parent.Font = AppNormalFont;

            foreach (Control c in parent.Controls)
            {
                ApplyToControl(c);
            }
        }

        private static void ApplyToControl(Control c)
        {
            // Consistent Readability & Colors
            if (c is Panel pnl)
            {
                // Sidebar or Header panels might need special treatment
                if (pnl.Name == "panel1" || pnl.Name.Contains("Header"))
                    pnl.BackColor = BackgroundColor;
                else if (pnl.Name == "panel2" || pnl.Name.Contains("Sidebar"))
                    pnl.BackColor = SurfaceColor;
                else
                    pnl.BackColor = CardColor;
            }
            else if (c is Button btn)
            {
                StyleButton(btn);
            }
            else if (c is TextBox txt)
            {
                txt.BackColor = SurfaceColor;
                txt.ForeColor = TextPrimary;
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.Font = new Font("Segoe UI", 11F);
            }
            else if (c is Label lbl)
            {
                if (lbl.Font.Size > 14) { lbl.Font = AppHeaderFont; lbl.ForeColor = AccentColor; }
                else if (lbl.Font.Bold) { lbl.Font = CardHeaderFont; lbl.ForeColor = TextPrimary; }
                else { lbl.ForeColor = TextSecondary; }
                lbl.BackColor = Color.Transparent;
            }
            else if (c is DataGridView grid)
            {
                StyleGrid(grid);
            }

            // Recursive application
            foreach (Control child in c.Controls)
            {
                ApplyToControl(child);
            }
        }

        private static void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = PrimaryColor;
            btn.Cursor = Cursors.Hand;

            if (btn.Name.Contains("logout") || btn.Text.ToLower().Contains("logout"))
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = PrimaryColor;
                btn.FlatAppearance.BorderColor = PrimaryColor;
            }
            else if (btn.Name.Contains("Add") || btn.Name.Contains("Save") || btn.Name.Contains("Create"))
            {
                btn.BackColor = SuccessColor;
                btn.ForeColor = BackgroundColor;
                btn.FlatAppearance.BorderColor = SuccessColor;
            }
            else
            {
                btn.BackColor = PrimaryColor;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderColor = PrimaryColor;
            }

            SetupButtonAnimation(btn);
        }

        private static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = CardColor;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.GridColor = Color.FromArgb(40, 40, 50);
            
            grid.DefaultCellStyle.BackColor = CardColor;
            grid.DefaultCellStyle.ForeColor = TextPrimary;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 44, 127, 184);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.DefaultCellStyle.Padding = new Padding(10, 5, 10, 5);

            grid.ColumnHeadersDefaultCellStyle.BackColor = SurfaceColor;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = AccentColor;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersHeight = 45;

            grid.EnableHeadersVisualStyles = false;
            grid.RowTemplate.Height = 40;
            grid.RowHeadersVisible = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private static void SetupButtonAnimation(Button btn)
        {
            Color originalColor = btn.BackColor;
            Color originalFore = btn.ForeColor;
            
            btn.MouseEnter += (s, e) => {
                btn.BackColor = AccentColor;
                btn.ForeColor = BackgroundColor;
            };
            
            btn.MouseLeave += (s, e) => {
                btn.BackColor = originalColor;
                btn.ForeColor = originalFore;
            };
        }

        public static GraphicsPath GetRoundedRectangle(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0) { path.AddRectangle(bounds); return path; }

            path.AddArc(arc, 180, 90);
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}

