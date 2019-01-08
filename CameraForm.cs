using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

//EMGU
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.Util;

//DiresctShow
using DirectShowLib;

namespace RoboticArmCapture
{
    struct Video_Device
    {
        public string Device_Name;
        public int Device_ID;
        public Guid Identifier;

        public Video_Device(int ID, string Name, Guid Identity = new Guid())
        {
            Device_ID = ID;
            Device_Name = Name;
            Identifier = Identity;
        }

        /// <summary>
        /// Represent the Device as a String
        /// </summary>
        /// <returns>The string representation of this color</returns>
        public override string ToString()
        {
            return String.Format("[{0}] {1}: {2}", Device_ID, Device_Name, Identifier);
        }
    }

    public partial class CameraForm : Form
    {
        #region Camera Capture Variables
        public Capture _capture = null; //Camera
        private int CameraDevice = 1; //Variable to track camera device selected
        private Video_Device[] WebCams; //List containing all the camera available
        private Mat frame;
        #endregion

        public bool captureNextFrame = false;
        private int frameId = 0;

        private int width = 1600;
        private int height = 896;
        private int targetWidth = 960;
        private int targetHeight = 1080;
        private String snapshotsDir = "snapshots";

        public bool autoRefresh = true;

        public CameraForm()
        {
            InitializeComponent();

            DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            WebCams = new Video_Device[_SystemCamereas.Length];
            for (int i = 0; i < _SystemCamereas.Length; i++)
            {
                WebCams[i] = new Video_Device(i, _SystemCamereas[i].Name, _SystemCamereas[i].ClassID); //fill web cam array
            }
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

        private void CameraForm_Load(object sender, EventArgs e)
        {
            //Dispose of Capture if it was created before
            if (_capture != null) _capture.Dispose();
            try
            {
                //Set up capture device
                _capture = new Capture(CameraDevice);
                Application.Idle += ProcessFrame;
                _capture.SetCaptureProperty(CapProp.FrameWidth, width);
                _capture.SetCaptureProperty(CapProp.FrameHeight, height);
                _capture.Start();
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
            RefreshSnapshots();
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            if (frame != null) frame.Dispose();
            frame = _capture.QueryFrame();
            cameraPictureBox.Image = frame.Bitmap;
            if (captureNextFrame)
            {
                String fileName = String.Format("{0}/{1:000}.png", snapshotsDir, frameId);

                var img = frame.ToImage<Bgr, byte>();
                img.ROI = new Rectangle((frame.Width - frame.Height * targetWidth / targetHeight) / 2, 0, frame.Height * targetWidth / targetHeight, frame.Height);
                var cropped = img.Copy();
                var resized = cropped.Resize(targetWidth, targetHeight, Inter.Linear);
                
                resized.Save(fileName);
                
                img.Dispose();
                cropped.Dispose();
                resized.Dispose();
                captureNextFrame = false;
                frameId++;
                if (autoRefresh)
                    RefreshSnapshots();
            }
        }

        private void RefreshSnapshots()
        {
            snapshotsPanel.Controls.Clear();
            DirectoryInfo dir = new DirectoryInfo(snapshotsDir);
            if (!dir.Exists) dir.Create();
            int i = 0;
            int snapshotWidth = snapshotsPanel.Width - 20;
            int snapshotHeight = snapshotWidth * cameraPictureBox.Height / cameraPictureBox.Width;
            foreach (FileInfo file in dir.GetFiles().Reverse<FileInfo>())
            {
                try
                {
                    PictureBox box = new PictureBox();
                    using (FileStream stream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read))
                    {
                        box.Image = Image.FromStream(stream);
                    }
                    box.Location = new Point(0, i * (snapshotHeight + 5));
                    box.SizeMode = PictureBoxSizeMode.StretchImage;
                    box.Size = new Size(snapshotWidth, snapshotHeight);
                    snapshotsPanel.Controls.Add(box);

                    Label label = new Label();
                    label.Text = file.Name;
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
                    view.Tag = file.FullName;
                    view.Click += thumbnailViewButton_Click;
                    view.Parent = box;

                    Button del = new Button();
                    del.Text = "Del";
                    del.Location = new Point(snapshotWidth - 50, 15);
                    del.Size = new Size(50, 20);
                    del.Tag = file.FullName;
                    del.Click += thumbnailDelButton_Click;
                    del.Parent = box;
                    del.BackColor = Color.DarkRed;
                    del.ForeColor = Color.White;

                    i++;
                    if (i >= 10) break;
                }
                catch
                {
                    Console.WriteLine("This is not an image file");
                }
            }
            snapshotsPanel.AutoScrollMinSize = new Size(0, 1200);
            snapshotsPanel.AutoScroll = true;
        }

        private void thumbnailViewButton_Click(object sender, EventArgs e)
        {
            Process.Start((string)((Button)sender).Tag);
        }

        private void thumbnailDelButton_Click(object sender, EventArgs e)
        {
            File.Delete((string)((Button)sender).Tag);
            RefreshSnapshots();
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            captureNextFrame = true;
        }

        private void SnapshotsDirButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", snapshotsDir);
        }

        private void cameraSettingButton_Click(object sender, EventArgs e)
        {
            Process.Start("LogiDPPApp.exe");
        }

        private void deleteAllButton_Click(object sender, EventArgs e)
        {
            Directory.Delete(snapshotsDir, true);
            RefreshSnapshots();
        }

        private void CameraForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_capture != null)
            {
                _capture.Stop();
                _capture.Dispose();
                Application.Idle -= ProcessFrame;
            }    
        }

        private void checkBoxAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            autoRefresh = checkBoxAutoRefresh.Checked;
        }
    }
}
