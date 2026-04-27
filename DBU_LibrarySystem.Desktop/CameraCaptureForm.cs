using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace DBU_LibrarySystem
{
    public class CameraCaptureForm : Form
    {
        private PictureBox picPreview;
        private Button btnCapture;
        private Button btnClose;
        private VideoCaptureDevice videoSource;
        private FilterInfoCollection videoDevices;

        public string CapturedFilePath { get; private set; }

        public CameraCaptureForm()
        {
            InitializeComponent();
            Load += CameraCaptureForm_Load;
            FormClosing += CameraCaptureForm_FormClosing;
        }

        private void InitializeComponent()
        {
            this.Text = "Capture ID Card Image";
            this.Size = new Size(640, 520);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;

            picPreview = new PictureBox();
            picPreview.Size = new Size(600, 400);
            picPreview.Location = new Point(20, 20);
            picPreview.BorderStyle = BorderStyle.FixedSingle;
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            Controls.Add(picPreview);

            btnCapture = new Button();
            btnCapture.Text = "Capture";
            btnCapture.Size = new Size(100, 35);
            btnCapture.Location = new Point(150, 440);
            btnCapture.BackColor = Color.FromArgb(44, 127, 184);
            btnCapture.ForeColor = Color.White;
            btnCapture.FlatStyle = FlatStyle.Flat;
            btnCapture.FlatAppearance.BorderSize = 0;
            btnCapture.Click += BtnCapture_Click;
            Controls.Add(btnCapture);

            btnClose = new Button();
            btnClose.Text = "Close";
            btnClose.Size = new Size(100, 35);
            btnClose.Location = new Point(380, 440);
            btnClose.BackColor = Color.FromArgb(44, 127, 184);
            btnClose.ForeColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            Controls.Add(btnClose);
        }

        private void CameraCaptureForm_Load(object? sender, EventArgs e)
        {
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videoDevices.Count == 0)
                {
                    MessageBox.Show("No webcam detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    return;
                }
                // Use first device
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to start webcam: " + ex.Message);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void VideoSource_NewFrame(object? sender, NewFrameEventArgs eventArgs)
        {
            // Clone the frame to avoid cross‑thread issues
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            if (picPreview.InvokeRequired)
            {
                picPreview.BeginInvoke(new Action(() => picPreview.Image = frame));
            }
            else
            {
                picPreview.Image = frame;
            }
        }

        private void BtnCapture_Click(object? sender, EventArgs e)
        {
            if (picPreview.Image == null)
            {
                MessageBox.Show("No image to capture.");
                return;
            }

            // Ensure folder exists
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DBU_LibrarySystem", "IdCardImages");
            Directory.CreateDirectory(folder);
            string fileName = Guid.NewGuid().ToString() + ".png";
            string fullPath = Path.Combine(folder, fileName);
            // Save the currently displayed image
            picPreview.Image.Save(fullPath, System.Drawing.Imaging.ImageFormat.Png);
            CapturedFilePath = fullPath;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CameraCaptureForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
    }
}
