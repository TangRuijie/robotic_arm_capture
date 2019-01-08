using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace RoboticArmCapture
{
    public partial class GoProCamera : Form
    {
        private string snapshotsDir = "snapshots";
        private string dcimUrl = "http://10.5.5.9:8080/videos/DCIM";
        private int targetWidth = 960;
        private int targetHeight = 1080;

        public bool autoRefresh = true;

        public GoProCamera()
        {
            InitializeComponent();
            GoProControl.goPro = this;
            DirectoryInfo dir = new DirectoryInfo(snapshotsDir);
            if (!dir.Exists) dir.Create();
        }

        private const int WS_SYSMENU = 0x80000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }

        private async void GoProCamera_Load(object sender, EventArgs e)
        {
            await RefreshSnapshots();
        }

        public async Task capture()
        {
            await GoProControl.Trigger();
            await GoProControl.WaitProcessingDone();
            if (autoRefresh)
                await RefreshSnapshots();
        }

        public void addLog(string log)
        {
            outputTextBox.AppendText(log);
            outputTextBox.ScrollToCaret();
        }

        private async void captureButton_Click(object sender, EventArgs e)
        {
            await capture();
        }

        public async Task downloadLatestPhoto(int frameId)
        {
            var paths = await GoProControl.GetMediaList();
            string path = paths[paths.Count - 1];
            string url = dcimUrl + path;
            String fileName = String.Format("{0}/{1:000}.png", snapshotsDir, frameId);
            Image image = await GoProControl.GetImage(url);
            var img = new Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte>(new Bitmap(image));
            double angle = checkBoxRotateCamera.Checked ? -90 : 0;
            var rimg = img.Rotate(angle, new Emgu.CV.Structure.Bgr(0, 0, 0), false);

            rimg.ROI = new Rectangle((rimg.Width - rimg.Height * targetWidth / targetHeight) / 2, 0, rimg.Height * targetWidth / targetHeight, rimg.Height);
            var cropped = rimg.Copy();
            var resized = cropped.Resize(targetWidth, targetHeight, Emgu.CV.CvEnum.Inter.Linear);

            resized.Save(fileName);

            rimg.Dispose();
            img.Dispose();
            cropped.Dispose();
            resized.Dispose();
        }

        private async Task RefreshSnapshots()
        {
            snapshotsPanel.Controls.Clear();
            int i = 0;
            var paths = await GoProControl.GetMediaList();
            int snapshotWidth = snapshotsPanel.Width - 20;
            int snapshotHeight = snapshotWidth * 120 / 160;
            paths.Reverse();
            foreach (string path in paths)
            {
                PictureBox box = new PictureBox();
                box.Image = await GoProControl.GetThumbnail(path);

                box.Location = new Point(0, i * (snapshotHeight + 5));
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                box.Size = new Size(snapshotWidth, snapshotHeight);
                snapshotsPanel.Controls.Add(box);

                Label label = new Label();
                label.Text = path;
                label.Location = new Point(0, 0);
                label.Font = new Font("Consolas", 8);
                label.Size = new Size(snapshotWidth, 15);
                label.BackColor = Color.FromArgb(100, 0, 0, 0);
                label.ForeColor = Color.White;
                label.Parent = box;

                Button view = new Button();
                view.Text = "View";
                view.Location = new Point(snapshotWidth - 50, snapshotHeight - 20);
                view.Size = new Size(50, 20);
                view.Tag = dcimUrl + path;
                view.Click += thumbnailViewButton_Click;
                view.Parent = box;

                Button del = new Button();
                del.Text = "Del";
                del.Location = new Point(snapshotWidth - 50, 15);
                del.Size = new Size(50, 20);
                del.Tag = path;
                del.Click += thumbnailDelButton_Click;
                del.Parent = box;
                del.BackColor = Color.DarkRed;
                del.ForeColor = Color.White;

                i++;
                if (i >= 20) break;
            }
            snapshotsPanel.AutoScrollMinSize = new Size(0, 1200);
            snapshotsPanel.AutoScroll = true;
        }

        private void thumbnailViewButton_Click(object sender, EventArgs e)
        {
            Process.Start((string)((Button)sender).Tag);
        }

        private async void thumbnailDelButton_Click(object sender, EventArgs e)
        {
            await GoProControl.DeleteFile((string)((Button)sender).Tag);
            await RefreshSnapshots();
        }

        private async void buttonStartStreaming_Click(object sender, EventArgs e)
        {
            if (buttonStartStreaming.Text.Equals("Start Streaming"))
            {
                buttonStartStreaming.Text = "Stop Streaming";
                await GoProControl.StartStreaming();
            }
            else
            {
                stopStreaming();
            }
        }

        public void stopStreaming()
        {
            buttonStartStreaming.Text = "Start Streaming";
            GoProControl.StopStreaming();
        }

        private void GoProCamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopStreaming();
        }

        public Panel getStreamingPanel()
        {
            return streamingPanel;
        }

        private void SnapshotsDirButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", snapshotsDir);
        }

        private async void buttonSleep_Click(object sender, EventArgs e)
        {
            await GoProControl.Sleep();
        }

        private void checkBoxAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            autoRefresh = checkBoxAutoRefresh.Checked;
        }
    }
}
