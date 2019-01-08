using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

using System.Diagnostics;

using FlyCapture2Managed;
using FlyCapture2Managed.Gui;

namespace RoboticArmCapture
{
    public partial class PointGreyForm : Form
    {
        private FlyCapture2Managed.Gui.CameraControlDialog m_camCtlDlg;
        private ManagedCameraBase m_camera = null;
        private ManagedImage m_rawImage;
        private ManagedImage m_processedImage;
        private bool m_grabImages;
        private AutoResetEvent m_grabThreadExited;
        private BackgroundWorker m_grabThread;

        public PointGreyForm()
        {
            InitializeComponent();

            m_rawImage = new ManagedImage();
            m_processedImage = new ManagedImage();
            m_camCtlDlg = new CameraControlDialog();

            m_grabThreadExited = new AutoResetEvent(false);
        }

        private void UpdateUI(object sender, ProgressChangedEventArgs e)
        {
            UpdateStatusBar();

            pictureBox1.Image = m_processedImage.bitmap;
            pictureBox1.Invalidate();
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

        private void UpdateStatusBar()
        {
            String statusString;

            statusString = String.Format(
                "Image size: {0} x {1}",
                m_rawImage.cols,
                m_rawImage.rows);

            toolStripStatusLabelImageSize.Text = statusString;

            try
            {
                statusString = String.Format(
                "Requested frame rate: {0}Hz",
                m_camera.GetProperty(PropertyType.FrameRate).absValue);
            }
            catch (FC2Exception ex)
            {
                statusString = "Requested frame rate: 0.00Hz";
            }

            toolStripStatusLabelFrameRate.Text = statusString;

            TimeStamp timestamp;

            lock (this)
            {
                timestamp = m_rawImage.timeStamp;
            }

            statusString = String.Format(
                "Timestamp: {0:000}.{1:0000}.{2:0000}",
                timestamp.cycleSeconds,
                timestamp.cycleCount,
                timestamp.cycleOffset);

            toolStripStatusLabelTimestamp.Text = statusString;
            statusStrip1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();

            CameraSelectionDialog camSlnDlg = new CameraSelectionDialog();
            bool retVal = camSlnDlg.ShowModal();
            if (retVal)
            {
                try
                {
                    ManagedPGRGuid[] selectedGuids = camSlnDlg.GetSelectedCameraGuids();
                    if ( selectedGuids.Length == 0 )
                    {
                        Debug.WriteLine("No cameras selected!");
                        Close();
                        return;
                    }

                    ManagedPGRGuid guidToUse = selectedGuids[0];

                    ManagedBusManager busMgr = new ManagedBusManager();
                    InterfaceType ifType = busMgr.GetInterfaceTypeFromGuid(guidToUse);

                    if (ifType == InterfaceType.GigE)
                    {
                        m_camera = new ManagedGigECamera();
                    }
                    else
                    {
                        m_camera = new ManagedCamera();
                    }

                    // Connect to the first selected GUID
                    m_camera.Connect(guidToUse);

                    m_camCtlDlg.Connect(m_camera);

                    CameraInfo camInfo = m_camera.GetCameraInfo();
                    UpdateFormCaption(camInfo);

                    // Set embedded timestamp to on
                    EmbeddedImageInfo embeddedInfo = m_camera.GetEmbeddedImageInfo();
                    embeddedInfo.timestamp.onOff = true;
                    m_camera.SetEmbeddedImageInfo(embeddedInfo);

                    m_camera.StartCapture();

                    m_grabImages = true;

                    StartGrabLoop();
                }
                catch (FC2Exception ex)
                {
                    Debug.WriteLine("Failed to load form successfully: " + ex.Message);
                    Close();
                }
            }
            else
            {
                Close();
            }

            Show();
        }

        private void UpdateFormCaption(CameraInfo camInfo)
        {
            String captionString = String.Format(
                "FlyCapture2SimpleGUI_CSharp - {0} {1} ({2})",
                camInfo.vendorName,
                camInfo.modelName,
                camInfo.serialNumber);

            this.Text = captionString;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                m_camera.Disconnect();
            }
            catch (FC2Exception ex)
            {
                // Nothing to do here
            }
            catch (NullReferenceException ex)
            {
                // Nothing to do here
            }
        }

        private void StartGrabLoop()
        {
            m_grabThread = new BackgroundWorker();
            m_grabThread.ProgressChanged += new ProgressChangedEventHandler(UpdateUI);
            m_grabThread.DoWork += new DoWorkEventHandler(GrabLoop);
            m_grabThread.WorkerReportsProgress = true;
            m_grabThread.RunWorkerAsync();
        }

        private void GrabLoop(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (m_grabImages)
            {
                try
                {
                    m_camera.RetrieveBuffer(m_rawImage);
                }
                catch (FC2Exception ex)
                {
                    Debug.WriteLine("Error: " + ex.Message);
                    continue;
                }

                lock (this)
                {
                    m_rawImage.Convert(PixelFormat.PixelFormatBgr, m_processedImage);
                }

                worker.ReportProgress(0);
            }

            m_grabThreadExited.Set();
        }

        private void OnNewCameraClick(object sender, EventArgs e)
        {
            if (m_grabImages == true)
            {
                m_camCtlDlg.Hide();
                m_camCtlDlg.Disconnect();
                m_camera.Disconnect();
            }

            Form1_Load(sender, e);
        }

        private void OnCameraSettingsClick(object sender, EventArgs e)
        {
            if (m_camCtlDlg.IsVisible())
            {
                m_camCtlDlg.Hide();
            }
            else
            {
                m_camCtlDlg.Show();
            }
        }
    }
}
