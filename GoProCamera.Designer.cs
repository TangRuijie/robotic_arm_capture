namespace RoboticArmCapture
{
    partial class GoProCamera
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
            this.snapshotsPanel = new System.Windows.Forms.Panel();
            this.captureButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonStartStreaming = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAutoRefresh = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.streamingPanel = new System.Windows.Forms.Panel();
            this.SnapshotsDirButton = new System.Windows.Forms.Button();
            this.buttonSleep = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxRotateCamera = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // snapshotsPanel
            // 
            this.snapshotsPanel.Location = new System.Drawing.Point(9, 75);
            this.snapshotsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.snapshotsPanel.Name = "snapshotsPanel";
            this.snapshotsPanel.Size = new System.Drawing.Size(278, 807);
            this.snapshotsPanel.TabIndex = 6;
            // 
            // captureButton
            // 
            this.captureButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.captureButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captureButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.captureButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.captureButton.Location = new System.Drawing.Point(700, 22);
            this.captureButton.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(132, 53);
            this.captureButton.TabIndex = 7;
            this.captureButton.Text = "Capture";
            this.captureButton.UseVisualStyleBackColor = false;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(9, 28);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(615, 263);
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 675);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(633, 302);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Log";
            // 
            // buttonStartStreaming
            // 
            this.buttonStartStreaming.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartStreaming.Location = new System.Drawing.Point(18, 20);
            this.buttonStartStreaming.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStartStreaming.Name = "buttonStartStreaming";
            this.buttonStartStreaming.Size = new System.Drawing.Size(186, 53);
            this.buttonStartStreaming.TabIndex = 9;
            this.buttonStartStreaming.Text = "Start Streaming";
            this.buttonStartStreaming.UseVisualStyleBackColor = true;
            this.buttonStartStreaming.Click += new System.EventHandler(this.buttonStartStreaming_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAutoRefresh);
            this.groupBox1.Controls.Add(this.snapshotsPanel);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(660, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(296, 892);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thumbnails";
            // 
            // checkBoxAutoRefresh
            // 
            this.checkBoxAutoRefresh.AutoSize = true;
            this.checkBoxAutoRefresh.Checked = true;
            this.checkBoxAutoRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoRefresh.Location = new System.Drawing.Point(9, 35);
            this.checkBoxAutoRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxAutoRefresh.Name = "checkBoxAutoRefresh";
            this.checkBoxAutoRefresh.Size = new System.Drawing.Size(156, 26);
            this.checkBoxAutoRefresh.TabIndex = 8;
            this.checkBoxAutoRefresh.Text = "Auto Refresh";
            this.checkBoxAutoRefresh.UseVisualStyleBackColor = true;
            this.checkBoxAutoRefresh.CheckedChanged += new System.EventHandler(this.checkBoxAutoRefresh_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.streamingPanel);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(18, 85);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(633, 580);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Streaming Video";
            // 
            // streamingPanel
            // 
            this.streamingPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.streamingPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.streamingPanel.Location = new System.Drawing.Point(9, 35);
            this.streamingPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.streamingPanel.Name = "streamingPanel";
            this.streamingPanel.Size = new System.Drawing.Size(615, 535);
            this.streamingPanel.TabIndex = 0;
            // 
            // SnapshotsDirButton
            // 
            this.SnapshotsDirButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnapshotsDirButton.Location = new System.Drawing.Point(444, 20);
            this.SnapshotsDirButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SnapshotsDirButton.Name = "SnapshotsDirButton";
            this.SnapshotsDirButton.Size = new System.Drawing.Size(248, 53);
            this.SnapshotsDirButton.TabIndex = 13;
            this.SnapshotsDirButton.Text = "Open Snapshots Dir...";
            this.SnapshotsDirButton.UseVisualStyleBackColor = true;
            this.SnapshotsDirButton.Click += new System.EventHandler(this.SnapshotsDirButton_Click);
            // 
            // buttonSleep
            // 
            this.buttonSleep.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSleep.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSleep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSleep.Location = new System.Drawing.Point(838, 22);
            this.buttonSleep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.Size = new System.Drawing.Size(117, 53);
            this.buttonSleep.TabIndex = 14;
            this.buttonSleep.Text = "Sleep";
            this.buttonSleep.UseVisualStyleBackColor = false;
            this.buttonSleep.Click += new System.EventHandler(this.buttonSleep_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxRotateCamera);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(18, 986);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(937, 57);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Advanced Settings";
            // 
            // checkBoxRotateCamera
            // 
            this.checkBoxRotateCamera.AutoSize = true;
            this.checkBoxRotateCamera.Location = new System.Drawing.Point(9, 26);
            this.checkBoxRotateCamera.Name = "checkBoxRotateCamera";
            this.checkBoxRotateCamera.Size = new System.Drawing.Size(251, 23);
            this.checkBoxRotateCamera.TabIndex = 0;
            this.checkBoxRotateCamera.Text = "Rotate the camera by 90°";
            this.checkBoxRotateCamera.UseVisualStyleBackColor = true;
            // 
            // GoProCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 1055);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.buttonSleep);
            this.Controls.Add(this.SnapshotsDirButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStartStreaming);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.captureButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "GoProCamera";
            this.Text = "GoPro Camera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GoProCamera_FormClosing);
            this.Load += new System.EventHandler(this.GoProCamera_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel snapshotsPanel;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStartStreaming;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel streamingPanel;
        private System.Windows.Forms.Button SnapshotsDirButton;
        private System.Windows.Forms.Button buttonSleep;
        private System.Windows.Forms.CheckBox checkBoxAutoRefresh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxRotateCamera;
    }
}