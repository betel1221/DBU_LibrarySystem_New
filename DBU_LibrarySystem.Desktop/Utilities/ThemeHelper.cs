using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace DBU_LibrarySystem.Utilities
{
    public static class ThemeHelper
    {
        // --- MODERN SAAS PALETTE ---
        public static Color BackgroundColor = Color.FromArgb(18, 18, 18);  // Deep Charcoal #121212
        public static Color SurfaceColor = Color.FromArgb(28, 28, 30);     // Slightly lighter
        public static Color CardColor = Color.FromArgb(24, 24, 26);        // Glass-like dark
        public static Color PrimaryColor = Color.FromArgb(0, 150, 255);    // Electric Blue
        public static Color AccentColor = Color.FromArgb(0, 255, 242);     // Vibrant Cyan
        public static Color TextPrimary = Color.FromArgb(240, 240, 245);   // High Contrast White
        public static Color TextSecondary = Color.FromArgb(140, 140, 160); // Muted Minimalist
        public static Color DangerColor = Color.FromArgb(255, 45, 85);
        public static Color SuccessColor = Color.FromArgb(50, 215, 75);

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
                StyleModernInput(txt);
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

        public static void StyleModernInput(TextBox txt)
        {
            txt.BackColor = Color.FromArgb(40, 40, 45); // Semi-transparent effect
            txt.ForeColor = TextPrimary;
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Font = new Font("Inter", 11F); // SaaS Font choice

            txt.Enter += (s, e) => { txt.BackColor = Color.FromArgb(50, 50, 60); };
            txt.Leave += (s, e) => { txt.BackColor = Color.FromArgb(40, 40, 45); };
        }

        private static void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0; // Modern minimalist
            btn.Cursor = Cursors.Hand;
            btn.Font = new Font("Inter", 10F, FontStyle.Bold);

            if (btn.Name.Contains("Register") || btn.Text.ToLower().Contains("register"))
            {
                // Glassmorphism / Gradient effect simulated with colors
                btn.BackColor = PrimaryColor;
                btn.ForeColor = Color.White;
                SetupButtonAnimation(btn, true);
            }
            else if (btn.Name.Contains("logout") || btn.Text.ToLower().Contains("logout"))
            {
                btn.BackColor = Color.Transparent;
                btn.ForeColor = PrimaryColor;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = PrimaryColor;
                SetupButtonAnimation(btn, false);
            }
            else
            {
                btn.BackColor = SurfaceColor;
                btn.ForeColor = TextPrimary;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 70);
                SetupButtonAnimation(btn, false);
            }
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

        private static void SetupButtonAnimation(Button btn, bool isRegister)
        {
            Color originalColor = btn.BackColor;
            Color originalFore = btn.ForeColor;
            
            btn.MouseEnter += (s, e) => {
                if (isRegister)
                {
                    btn.BackColor = AccentColor;
                    btn.ForeColor = BackgroundColor;
                    // Simulate glow with focus border if needed (skipped for simplicity in WinForms)
                }
                else
                {
                    btn.BackColor = Color.FromArgb(50, 50, 60);
                }
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

