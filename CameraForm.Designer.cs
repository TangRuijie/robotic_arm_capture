namespace RoboticArmCapture
{
    partial class CameraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cameraPictureBox = new System.Windows.Forms.PictureBox();
            this.captureButton = new System.Windows.Forms.Button();
            this.SnapshotsDirButton = new System.Windows.Forms.Button();
            this.cameraSettingButton = new System.Windows.Forms.Button();
            this.snapshotsPanel = new System.Windows.Forms.Panel();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAutoRefresh = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cameraPictureBox
            // 
            this.cameraPictureBox.Location = new System.Drawing.Point(14, 45);
            this.cameraPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cameraPictureBox.Name = "cameraPictureBox";
            this.cameraPictureBox.Size = new System.Drawing.Size(648, 756);
            this.cameraPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cameraPictureBox.TabIndex = 0;
            this.cameraPictureBox.TabStop = false;
            // 
            // captureButton
            // 
            this.captureButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.captureButton.Location = new System.Drawing.Point(725, 7);
            this.captureButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(88, 30);
            this.captureButton.TabIndex = 2;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // SnapshotsDirButton
            // 
            this.SnapshotsDirButton.Location = new System.Drawing.Point(550, 7);
            this.SnapshotsDirButton.Name = "SnapshotsDirButton";
            this.SnapshotsDirButton.Size = new System.Drawing.Size(169, 30);
            this.SnapshotsDirButton.TabIndex = 3;
            this.SnapshotsDirButton.Text = "Open Snapshots Dir...";
            this.SnapshotsDirButton.UseVisualStyleBackColor = true;
            this.SnapshotsDirButton.Click += new System.EventHandler(this.SnapshotsDirButton_Click);
            // 
            // cameraSettingButton
            // 
            this.cameraSettingButton.Location = new System.Drawing.Point(13, 7);
            this.cameraSettingButton.Name = "cameraSettingButton";
            this.cameraSettingButton.Size = new System.Drawing.Size(133, 30);
            this.cameraSettingButton.TabIndex = 4;
            this.cameraSettingButton.Text = "Camera Setting";
            this.cameraSettingButton.UseVisualStyleBackColor = true;
            this.cameraSettingButton.Click += new System.EventHandler(this.cameraSettingButton_Click);
            // 
            // snapshotsPanel
            // 
            this.snapshotsPanel.Location = new System.Drawing.Point(6, 46);
            this.snapshotsPanel.Name = "snapshotsPanel";
            this.snapshotsPanel.Size = new System.Drawing.Size(133, 667);
            this.snapshotsPanel.TabIndex = 5;
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.BackColor = System.Drawing.Color.Brown;
            this.deleteAllButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteAllButton.Location = new System.Drawing.Point(6, 719);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(133, 27);
            this.deleteAllButton.TabIndex = 6;
            this.deleteAllButton.Text = "Delete All";
            this.deleteAllButton.UseVisualStyleBackColor = false;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAutoRefresh);
            this.groupBox1.Controls.Add(this.snapshotsPanel);
            this.groupBox1.Controls.Add(this.deleteAllButton);
            this.groupBox1.Location = new System.Drawing.Point(668, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 752);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thumbnails";
            // 
            // checkBoxAutoRefresh
            // 
            this.checkBoxAutoRefresh.AutoSize = true;
            this.checkBoxAutoRefresh.Checked = true;
            this.checkBoxAutoRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoRefresh.Location = new System.Drawing.Point(7, 22);
            this.checkBoxAutoRefresh.Name = "checkBoxAutoRefresh";
            this.checkBoxAutoRefresh.Size = new System.Drawing.Size(110, 18);
            this.checkBoxAutoRefresh.TabIndex = 7;
            this.checkBoxAutoRefresh.Text = "Auto Refresh";
            this.checkBoxAutoRefresh.UseVisualStyleBackColor = true;
            this.checkBoxAutoRefresh.CheckedChanged += new System.EventHandler(this.checkBoxAutoRefresh_CheckedChanged);
            // 
            // CameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(821, 809);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cameraSettingButton);
            this.Controls.Add(this.SnapshotsDirButton);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.cameraPictureBox);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CameraForm";
            this.Text = "Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraForm_FormClosing);
            this.Load += new System.EventHandler(this.CameraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cameraPictureBox;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button SnapshotsDirButton;
        private System.Windows.Forms.Button cameraSettingButton;
        private System.Windows.Forms.Panel snapshotsPanel;
        private System.Windows.Forms.Button deleteAllButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxAutoRefresh;
    }
}