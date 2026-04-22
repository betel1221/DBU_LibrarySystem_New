using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DBU_LibrarySystem.Utilities
{
    public static class ThemeHelper
    {
        // Dark Theme Palette
        public static Color BackgroundColor = Color.FromArgb(18, 18, 18); // Deep Dark
        public static Color SurfaceColor = Color.FromArgb(30, 30, 30);    // Card Dark
        public static Color PrimaryColor = Color.FromArgb(98, 0, 238);    // Purple Deep
        public static Color AccentColor = Color.FromArgb(3, 218, 197);    // Teal Accent
        public static Color TextPrimary = Color.FromArgb(255, 255, 255);
        public static Color TextSecondary = Color.FromArgb(179, 179, 179);
        public static Color DangerColor = Color.FromArgb(207, 102, 121);
        
        public static Font HeaderFont = new Font("Segoe UI SemiBold", 16F, FontStyle.Bold);
        public static Font NormalFont = new Font("Segoe UI", 10F, FontStyle.Regular);

        public static void ApplyTheme(Control control)
        {
            control.BackColor = BackgroundColor;
            control.ForeColor = TextPrimary;
            control.Font = NormalFont;

            foreach (Control c in control.Controls)
            {
                ApplyThemeToControl(c);
            }
        }

        private static void ApplyThemeToControl(Control c)
        {
            if (c is Panel pnl)
            {
                pnl.BackColor = SurfaceColor;
            }
            else if (c is Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = PrimaryColor;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
                
                // Micro-animations (hover)
                btn.MouseEnter += (s, e) => { btn.BackColor = AccentColor; btn.ForeColor = BackgroundColor; };
                btn.MouseLeave += (s, e) => { btn.BackColor = PrimaryColor; btn.ForeColor = Color.White; };
            }
            else if (c is TextBox txt)
            {
                txt.BackColor = BackgroundColor;
                txt.ForeColor = TextPrimary;
                txt.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (c is Label lbl)
            {
                lbl.ForeColor = TextPrimary;
                lbl.BackColor = Color.Transparent;
            }
            else if (c is DataGridView grid)
            {
                grid.BackgroundColor = SurfaceColor;
                grid.BorderStyle = BorderStyle.None;
                grid.DefaultCellStyle.BackColor = SurfaceColor;
                grid.DefaultCellStyle.ForeColor = TextPrimary;
                grid.DefaultCellStyle.SelectionBackColor = PrimaryColor;
                grid.ColumnHeadersDefaultCellStyle.BackColor = BackgroundColor;
                grid.ColumnHeadersDefaultCellStyle.ForeColor = AccentColor;
                grid.EnableHeadersVisualStyles = false;
                grid.RowHeadersVisible = false;
            }
            
            // Recursively apply to children
            foreach (Control child in c.Controls)
            {
                ApplyThemeToControl(child);
            }
        }
    }
}
