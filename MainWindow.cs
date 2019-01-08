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
using PlanetCNC.API;

namespace RoboticArmCapture
{
    public partial class MainWindow : Form
    {
        public CNC cnc;
        public CameraForm cameraForm;
        public GoProCamera goPro;
        public PointGreyForm pointGrey;
        public enum CameraType
        {
            Undefined,
            WebCam,
            GoPro,
            PointGrey
        }
        CameraType currentCameraType = CameraType.Undefined;
        const double STEP = 1;
        const double SPEED = 300;
        public bool stop_task = false;
        public List<ICoord> marks = new List<ICoord>();
        public Coord initialPos;
        public double extendY = 8.475;
        public double extendZ = -30;
        public bool first_initialize = false;

        public const int CAP_STATUS_IDLE = 0;
        public const int CAP_STATUS_RUNNING = 1;
        public const int CAP_STATUS_PAUSE = 2;
        public int captureStatus = CAP_STATUS_IDLE;

        public int range = 36;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void button_initialize_Click(object sender, EventArgs e)
        {
            if (cnc != null)
            {
                cnc.Dispose();
                cnc = null;
            }
            if (button_initialize.Text.Equals("Initialize"))
            {
                cnc = new CNC();

                bool ok = cnc.Initialize();
                if (ok)
                {
                    outputTextBox.SelectionFont = new Font(outputTextBox.Font, FontStyle.Bold);
                    outputTextBox.AppendText("Initialize SUCCESS\r\n");
                    outputTextBox.AppendText(string.Format("API version: {0}\r\n", cnc.VersionAPI));
                    outputTextBox.AppendText(string.Format("Software version: {0}\r\n", cnc.VersionSW));
                    outputTextBox.AppendText(string.Format("Firmware version: {0}\r\n", cnc.VersionHW));
                    outputTextBox.AppendText(string.Format("Required firmware version: {0}\r\n", cnc.VersionHWRequired));

                    if ((cnc.VersionHW == null) || (cnc.VersionHW != cnc.VersionHWRequired))
                    {
                        if (cnc != null)
                        {
                            cnc.Dispose();
                            cnc = null;
                            return;
                        }

                    }
                    outputTextBox.AppendText(string.Format("Serial: {0}\r\n", cnc.Serial));
                    outputTextBox.AppendText(string.Format("License Valid: {0}\r\n", cnc.LicenseValid));
                    outputTextBox.AppendText(string.Format("Steps Per Unit: {0}\r\n", cnc.StepsPerUnit.ToString()));
                    outputTextBox.ScrollToCaret();
                    //register OnUpdate event
                    cnc.OnUpdate += new OnUpdateDelegate(OnUpdate);
                    button_initialize.Text = "Dispose";
                    button_left.Enabled = true;
                    button_right.Enabled = true;
                    button_up.Enabled = true;
                    button_down.Enabled = true;
                    button_up2.Enabled = true;
                    button_down2.Enabled = true;
                    button_all_up.Enabled = true;
                    button_all_down.Enabled = true;

                    if (!first_initialize)
                    {
                        initialPos = (Coord)cnc.Position;
                        first_initialize = true;
                    }
                }
                else
                {
                    outputTextBox.AppendText("Initialize FAILED\r\n");
                    outputTextBox.ScrollToCaret();
                    if (cnc != null)
                    {
                        cnc.Dispose();
                        cnc = null;
                    }
                }
            }
            else
            {
                button_initialize.Text = "Initialize";
                button_left.Enabled = false;
                button_right.Enabled = false;
                button_up.Enabled = false;
                button_down.Enabled = false;
                button_up2.Enabled = false;
                button_down2.Enabled = false;
                button_all_up.Enabled = false;
                button_all_down.Enabled = false;

                oneAngleButton.Enabled = oneRowButton.Enabled = allButton.Enabled = false;

                outputTextBox.AppendText("Dispose the connection!\r\n");
                outputTextBox.ScrollToCaret();
            }
        }

        void OnUpdate()
        {
            lblBuf2.Text = cnc.BufferFree.ToString() + "/" + cnc.BufferSize.ToString();

            lblPos2.Text = cnc.Position.ToString();
            lblSpd2.Text = cnc.Speed.ToString("#0.00");

            lblOut2.Text = cnc.Output.ToString("X") + (cnc.EStop ? " E" : "") + (cnc.Pause ? " P" : "");

            lblLim2.Text = cnc.Limit.ToString("X");
            lblLimRaw2.Text = cnc.LimitRaw.ToString("X");

            lblJog2.Text = cnc.Jog.ToString("X");
            lblJogRaw2.Text = cnc.JogRaw.ToString("X");

            ICoord delta = (Coord)cnc.Position - initialPos;
            roboticArmControl.setAngles(delta.X, delta.Y, delta.Z);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentCameraType == CameraType.GoPro && GoProControl.streaming &&
                DialogResult.Yes == MessageBox.Show("Are you going to stop GoPro Streaming?", "Before closing", MessageBoxButtons.YesNo))
            {
                goPro.stopStreaming();
                e.Cancel = true;
            }
            if (cnc != null)
            {
                ICoord delta = (Coord)cnc.Position - initialPos; 
                if ((delta.X <= 0.001 && delta.Y <= 0.001 && delta.Z <= 0.001) ||
                    DialogResult.No == MessageBox.Show("Are you going to reset Robotic Arm to initial position?", "Before closing", MessageBoxButtons.YesNo))
                {
                    cnc.Dispose();
                    cnc = null;
                }
                else
                {
                    cnc.SendMovePos(cnc.Position, initialPos, SPEED);
                    e.Cancel = true;
                }
            }
        }

        private void button_up_MouseDown(object sender, MouseEventArgs e)
        {
            if ((cnc != null) && (cnc.BufferFree > 10))
            {
                cnc.SendJog(AxisDirEnum.Y2, SPEED, false, STEP, UnitsEnum.Millimeters);
            }
        }

        private void button_up_MouseUp(object sender, MouseEventArgs e)
        {
            if ((cnc != null) && (cnc.BufferFree > 10))
            {
                cnc.SendStop();
            }
        }

        private void button_down_MouseDown(object sender, MouseEventArgs e)
        {
            if ((cnc != null) && (cnc.BufferFree > 10))
            {
                cnc.SendJog(AxisDirEnum.Y1, SPEED, false, STEP, UnitsEnum.Millimeters);
            }
        }

        private void button_down_MouseUp(object sender, MouseEventArgs e)
        {
            if ((cnc != null) && (cnc.BufferFree > 10))
            {
                cnc.SendStop();
            }
        }

        private void button_left_MouseDown(object sender, MouseEventArgs e)
        {
            if ((cnc != null) && (cnc.BufferFree > 10))
            {
                cnc.SendJog(AxisDirEnum.X2, SPEED, false, STEP, UnitsEnum.Millimeters);
            }
        }

        private void button_left_MouseUp(object sender, MouseEventArgs e)
        {
            if ((cnc != null) && (cnc.BufferFree > 10))
            {
                cnc.SendStop();
            }
        }

        private void button_right_MouseDown(object sender, MouseEventArgs e)
        {
            if ((cnc != null) && (cnc.BufferFree > 10))
            {
                cnc.SendJog(AxisDirEnum.X1, SPEED, false, STEP, UnitsEnum.Millimeters);
            }
        }

        private void button_right_MouseUp(object sender, MouseEventArgs e)
        {
            if ((cnc != null) && (cnc.BufferFree > 10))
            {
                cnc.SendStop();
            }
        }

        private void button_up2_MouseDown(object sender, MouseEventArgs e)
        {
            if ((cnc != null) && (cnc.BufferFree > 10))
            {
                cnc.SendJog(AxisDirEnum.Z2, SPEED, false, STEP, UnitsEnum.Millimeters);
            }
        }

        private void button_up2_MouseUp(object sender, MouseEventArgs e)
        {
            if ((cnc != null) && (cnc.BufferFree > 10))
            {
                cnc.SendStop();
            }
        }

        private void button_down2_MouseDown(object sender, MouseEventArgs e)
        {
            if ((cnc != null) && (cnc.BufferFree > 10))
            {
                cnc.SendJog(AxisDirEnum.Z1, SPEED, false, STEP, UnitsEnum.Millimeters);
            }
        }

        private void button_down2_MouseUp(object sender, MouseEventArgs e)
        {
            if ((cnc != null) && (cnc.BufferFree > 10))
            {
                cnc.SendStop();
            }
        }

        private async void button_camera_Click(object sender, EventArgs e)
        {
            if (currentCameraType == CameraType.GoPro)
                await goPro.capture();
            else if (currentCameraType == CameraType.WebCam)
                cameraForm.captureNextFrame = true;
        }

        private void button_all_up_MouseDown(object sender, MouseEventArgs e)
        {
            if ((cnc != null) && (cnc.BufferFree > 10))
            {
                cnc.SendJog(AxisDirEnum.Y2 | AxisDirEnum.Z2, SPEED, false, STEP, UnitsEnum.Millimeters);
            }
        }

        private void button_all_up_MouseUp(object sender, MouseEventArgs e)
        {
            if ((cnc != null) && (cnc.BufferFree > 10))
            {
                cnc.SendStop();
            }
        }

        private void button_all_down_MouseDown(object sender, MouseEventArgs e)
        {
            if ((cnc != null) && (cnc.BufferFree > 10))
            {
                cnc.SendJog(AxisDirEnum.Y1 | AxisDirEnum.Z1, SPEED, false, STEP, UnitsEnum.Millimeters);
            }
        }

        private void button_all_down_MouseUp(object sender, MouseEventArgs e)
        {
            if ((cnc != null) && (cnc.BufferFree > 10))
            {
                cnc.SendStop();
            }
        }

        public void addMark(ICoord mark, bool quiet = false)
        {
            marks.Add(mark);
            marksListBox.Items.Add(String.Format("[{0}]({1:0.00},{2:0.00},{3:0.00})", marks.Count, mark.X, mark.Y, mark.Z));
            outputTextBox.SelectionColor = Color.Green;
            if (!quiet)
            {
                outputTextBox.AppendText(String.Format("Add mark [{0}]({1:0.00},{2:0.00},{3:0.00})\r\n", marks.Count, mark.X, mark.Y, mark.Z));
                outputTextBox.ScrollToCaret();
            }
        }

        public void addMark(double X, double Y, double Z, bool quiet = false)
        {
            if (cnc != null)
            {
                Coord mark = (Coord)cnc.Position.Clone();
                mark.X = X;
                mark.Y = Y;
                mark.Z = Z;
                addMark(mark, quiet);
            }
        }

        private void button_add_mark_Click(object sender, EventArgs e)
        {
            if (cnc != null)
            {
                addMark(cnc.Position);
                checkBoxZigZag.Checked = checkBoxZigZag.Enabled = false;
            }
        }

        private void marksListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = marksListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches && cnc != null)
            {
                ICoord pos = marks[index];
                cnc.SendMovePos(cnc.Position, pos, SPEED);
                outputTextBox.SelectionColor = Color.Blue;
                outputTextBox.AppendText(String.Format("[{0}] Go to mark [{1}]({2:0.00},{3:0.00},{4:0.00})\r\n",
                    DateTime.Now.ToString("h:mm:ss"), index + 1, pos.X, pos.Y, pos.Z));
                outputTextBox.ScrollToCaret();
            }
        }

        private void button_clear_all_marks_Click(object sender, EventArgs e)
        {
            marks.Clear();
            marksListBox.Items.Clear();
            outputTextBox.SelectionColor = Color.Red;
            outputTextBox.AppendText("Clear all marks\r\n");
            outputTextBox.ScrollToCaret();
            checkBoxZigZag.Checked = checkBoxZigZag.Enabled = false;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            if (cnc != null)
            {
                cnc.SendMovePos(cnc.Position, initialPos, SPEED);
                outputTextBox.SelectionColor = Color.Black;
                outputTextBox.AppendText("Reset to initial position!");
            }
        }

        private void button_save_delta_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.Title = "Save a Text File";

            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter fs = new StreamWriter(saveFileDialog.FileName);
                foreach (ICoord p in marks)
                {
                    fs.WriteLine(String.Format("{0} {1} {2}",
                        p.X - initialPos.X,
                        p.Y - initialPos.Y,
                        p.Z - initialPos.Z));
                }
                fs.Close();
            }
        }

        private void button_load_delta_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";
            openFileDialog.Title = "Select a Text File";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .CUR file was selected, open it.
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    String[] posArray = line.Split();
                    ICoord p = initialPos.Clone();
                    p.X += Convert.ToDouble(posArray[0]);
                    p.Y += Convert.ToDouble(posArray[1]);
                    p.Z += Convert.ToDouble(posArray[2]);
                    marks.Add(p);
                    marksListBox.Items.Add(String.Format("[{0}]({0:0.00},{1:0.00},{2:0.00})", marks.Count, p.X, p.Y, p.Z));
                    outputTextBox.SelectionColor = Color.Green;
                    outputTextBox.AppendText(String.Format("Add mark [{0}]({0:0.00},{1:0.00},{2:0.00})\r\n", marks.Count, p.X, p.Y, p.Z));
                    outputTextBox.ScrollToCaret();
                }
                sr.Close();
                checkBoxZigZag.Checked = checkBoxZigZag.Enabled = false;
            }
        }

        private void button_extend_Click(object sender, EventArgs e)
        {
            if (cnc != null)
            {
                ICoord p = initialPos.Clone();
                p.Y += extendY;
                p.Z += extendZ;
                cnc.SendMovePos(cnc.Position, p, SPEED);
                outputTextBox.SelectionColor = Color.Orange;
                outputTextBox.AppendText("Extend the robotic arm!\n");
                oneAngleButton.Enabled = oneRowButton.Enabled = allButton.Enabled = true;
            }
        }

        public void relativePos(ICoord pos, ref double theta, ref double phi)
        {
            if (cnc != null)
            {
                theta = (pos.X - initialPos.X) * Metrics.degreePerUnit;
                phi = (pos.Y - (initialPos.Y + extendY)) * Metrics.degreePerUnit;
            }
        }

        public void relativeTP(double theta, double phi, ref ICoord pos)
        {
            if (cnc != null)
            {
                pos.X = theta * Metrics.unitPerDegree + initialPos.X;
                pos.Y = phi * Metrics.unitPerDegree + initialPos.Y + extendY;
                pos.Z = phi * Metrics.unitPerDegree + initialPos.Z + extendZ;
            }
        }

        public void generateMarksForPos(ICoord pos, bool quiet = false)
        {
            double theta = 0, phi = 0;
            relativePos(pos, ref theta, ref phi);
            double delta = 1;
            double pd1, td1, pd2, td2, pd3, td3, pd4, td4, pd5, td5, pd6, td6;
            pd6 = delta * Metrics.unitPerDegree;
            td6 = 0;

            pd3 = -delta * Metrics.unitPerDegree;
            td3 = 0;

            double phi_r = phi * Math.PI / 180;
            double delta_r = delta * Math.PI / 180;

            double delta_phi_r = Math.Asin(Math.Sin(delta_r) / 2);
            double delta_phi = delta_phi_r * 180 / Math.PI;
            pd5 = pd1 = delta_phi * Metrics.unitPerDegree;
            pd4 = pd2 = -delta_phi * Metrics.unitPerDegree;

            double delta_theta_r = Math.Acos((Math.Cos(delta_r) - Math.Sin(phi_r) * Math.Sin(phi_r + delta_phi_r)) /
                (Math.Cos(phi_r) * Math.Cos(phi_r + delta_phi_r)));
            double delta_theta = delta_theta_r * 180 / Math.PI;
            td5 = -delta_theta * Metrics.unitPerDegree;
            td1 = delta_theta * Metrics.unitPerDegree;

            delta_theta_r = Math.Acos((Math.Cos(delta_r) - Math.Sin(phi_r) * Math.Sin(phi_r - delta_phi_r)) /
                (Math.Cos(phi_r) * Math.Cos(phi_r - delta_phi_r)));
            delta_theta = delta_theta_r * 180 / Math.PI;
            td4 = -delta_theta * Metrics.unitPerDegree;
            td2 = delta_theta * Metrics.unitPerDegree;

            addMark(pos, quiet);
            addMark(pos.X + td1, pos.Y + pd1, pos.Z + pd1, quiet);
            addMark(pos.X + td2, pos.Y + pd2, pos.Z + pd2, quiet);
            addMark(pos.X + td3, pos.Y + pd3, pos.Z + pd3, quiet);
            addMark(pos.X + td4, pos.Y + pd4, pos.Z + pd4, quiet);
            addMark(pos.X + td5, pos.Y + pd5, pos.Z + pd5, quiet);
            addMark(pos.X + td6, pos.Y + pd6, pos.Z + pd6, quiet);
        }

        private void oneAngleButton_Click(object sender, EventArgs e)
        {
            if (cnc != null)
            {
                generateMarksForPos(cnc.Position);
                checkBoxZigZag.Checked = checkBoxZigZag.Enabled = false;
            }
        }

        private void oneRowButton_Click(object sender, EventArgs e)
        {
            if (cnc != null)
            {
                for (int i = range; i > -range; i--)
                {
                    ICoord pos = cnc.Position.Clone();
                    pos.X += (i * 5) * Metrics.unitPerDegree;
                    generateMarksForPos(pos);
                }
                checkBoxZigZag.Checked = checkBoxZigZag.Enabled = false;
            }
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            if (cnc != null)
            {
                for (int i = 0; i < 8; i++)
                {
                    double phi = i * 5;
                    for (int j = range; j > -range; j--)
                    {
                        double theta = j * 5;
                        ICoord pos = cnc.Position.Clone();
                        relativeTP(theta, phi, ref pos);
                        generateMarksForPos(pos, true);
                    }
                }
                checkBoxZigZag.Enabled = true;
            }
        }

        public async Task waitStill()
        {
            await Task.Delay(500); //wait for the command to be sent
            while (cnc.Speed > 0f) //wait for the speed drops to zero
                await Task.Delay(100);
            await Task.Delay(800); //wait for the wobbling time
        }

        private async void buttonTriggerAll_Click(object sender, EventArgs e)
        {
            if (cnc != null)
            {
                captureStatus = CAP_STATUS_RUNNING;
                buttonPause.Enabled = true;
                for (int i = 0; i <= 20; i++ )
                {
                    labelCountDown.Text = string.Format("{0}", 20 - i);
                    await Task.Delay(1000);
                }
                for (int i = 0; i < marks.Count; i++)
                {
                    int ind = i;
                    if (checkBoxZigZag.Checked)
                    {
                        int group = i / 7;
                        int index = i % 7;
                        int col = group / 8;
                        int row = group % 8;
                        row = col % 2 == 0 ? row : 7 - row;
                        ind = (row * 72 + col) * 7 + index;
                    }
                    while (captureStatus == CAP_STATUS_PAUSE)
                        await Task.Delay(200);
                    ICoord p = marks[ind];
                    cnc.SendMovePos(cnc.Position, p, SPEED);
                    outputTextBox.SelectionColor = Color.Blue;
                    outputTextBox.AppendText(String.Format("[{0}] Go to mark [{1}]({2:0.00},{3:0.00},{4:0.00})\r\n",
                        DateTime.Now.ToString("h:mm:ss"), ind + 1, p.X, p.Y, p.Z));
                    outputTextBox.ScrollToCaret();
                    await waitStill();
                    if (currentCameraType == CameraType.GoPro)
                    {
                        await goPro.capture();
                        await goPro.downloadLatestPhoto(i);
                    }
                    else if (currentCameraType == CameraType.WebCam)
                        cameraForm.captureNextFrame = true;
                }
                captureStatus = CAP_STATUS_IDLE;
                buttonPause.Enabled = false;
                if (checkBoxCloseApp.Checked)
                {
                    cnc.SendMovePos(cnc.Position, initialPos, SPEED);
                    await waitStill();
                    if (currentCameraType == CameraType.GoPro && GoProControl.streaming)
                        goPro.stopStreaming();
                    else if (currentCameraType == CameraType.WebCam)
                        cameraForm.Close();
                }
                EmailNotification.sendNotification();
            }
        }

        private void buttonGoPro_Click(object sender, EventArgs e)
        {
            if (goPro == null)
                goPro = new GoProCamera();
            goPro.Show();
            currentCameraType = CameraType.GoPro;
            buttonWebcam.Enabled = buttonPointGrey.Enabled = false;
        }

        private void buttonWebcam_Click(object sender, EventArgs e)
        {
            if (cameraForm == null)
                cameraForm = new CameraForm();
            cameraForm.Show();
            currentCameraType = CameraType.WebCam;
            buttonGoPro.Enabled = buttonPointGrey.Enabled = false;
        }

        private void buttonPointGrey_Click(object sender, EventArgs e)
        {
            if (pointGrey == null)
                pointGrey = new PointGreyForm();
            pointGrey.Show();
            currentCameraType = CameraType.PointGrey;
            buttonGoPro.Enabled = buttonWebcam.Enabled = false;
        }

        private async void buttonPause_Click(object sender, EventArgs e)
        {
            if (captureStatus == CAP_STATUS_RUNNING)
            {
                captureStatus = CAP_STATUS_PAUSE;
                buttonPause.Text = "Resume";
                for (int i = 0; i <= 20; i++)
                {
                    labelCountDown.Text = string.Format("{0}", 20 - i);
                    await Task.Delay(1000);
                }
                captureStatus = CAP_STATUS_RUNNING;
                buttonPause.Text = "Pause";
            }
            else if (captureStatus == CAP_STATUS_PAUSE)
            {
                captureStatus = CAP_STATUS_RUNNING;
                buttonPause.Text = "Pause";
            }
        }

        private void buttonGeneratePanoMarks_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDownCountPanoMarks.Value);
            int r_count = count * range / 36;
            if (cnc != null && count > 0)
            {
                for (int i = r_count / 2; i > -r_count / 2; i--)
                {
                    ICoord pos = cnc.Position.Clone();
                    pos.X += (i * 360.0 / count) * Metrics.unitPerDegree;
                    addMark(pos, true);
                }
                checkBoxZigZag.Checked = checkBoxZigZag.Enabled = false;
            }
        }

        private void radioButton360_CheckedChanged(object sender, EventArgs e)
        {
            range = 36;
        }

        private void radioButton180_CheckedChanged(object sender, EventArgs e)
        {
            range = 18;
        }

        private void radioButton120_CheckedChanged(object sender, EventArgs e)
        {
            range = 12;
        }
        
    }
}
