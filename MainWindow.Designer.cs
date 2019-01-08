namespace RoboticArmCapture
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPointGrey = new System.Windows.Forms.Button();
            this.labelCountDown = new System.Windows.Forms.Label();
            this.buttonWebcam = new System.Windows.Forms.Button();
            this.buttonGoPro = new System.Windows.Forms.Button();
            this.lblSpd2 = new System.Windows.Forms.Label();
            this.lblSpd = new System.Windows.Forms.Label();
            this.lblJogRaw2 = new System.Windows.Forms.Label();
            this.lblLimRaw2 = new System.Windows.Forms.Label();
            this.lblJog2 = new System.Windows.Forms.Label();
            this.lblLim2 = new System.Windows.Forms.Label();
            this.lblJogRaw = new System.Windows.Forms.Label();
            this.lblLimRaw = new System.Windows.Forms.Label();
            this.lblJog = new System.Windows.Forms.Label();
            this.lblLim = new System.Windows.Forms.Label();
            this.lblBuf2 = new System.Windows.Forms.Label();
            this.lblOut2 = new System.Windows.Forms.Label();
            this.lblPos2 = new System.Windows.Forms.Label();
            this.lblBuf = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.button_initialize = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_all_down = new System.Windows.Forms.Button();
            this.button_all_up = new System.Windows.Forms.Button();
            this.button_camera = new System.Windows.Forms.Button();
            this.button_down2 = new System.Windows.Forms.Button();
            this.button_up2 = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_up = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.roboticArmControl = new RoboticArmCapture.RoboticArm();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numericUpDownCountPanoMarks = new System.Windows.Forms.NumericUpDown();
            this.buttonGeneratePanoMarks = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonTriggerAll = new System.Windows.Forms.Button();
            this.allButton = new System.Windows.Forms.Button();
            this.oneRowButton = new System.Windows.Forms.Button();
            this.oneAngleButton = new System.Windows.Forms.Button();
            this.button_extend = new System.Windows.Forms.Button();
            this.button_load_delta = new System.Windows.Forms.Button();
            this.button_save_delta = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_clear_all_marks = new System.Windows.Forms.Button();
            this.button_add_mark = new System.Windows.Forms.Button();
            this.marksListBox = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton120 = new System.Windows.Forms.RadioButton();
            this.radioButton180 = new System.Windows.Forms.RadioButton();
            this.radioButton360 = new System.Windows.Forms.RadioButton();
            this.checkBoxZigZag = new System.Windows.Forms.CheckBox();
            this.checkBoxCloseApp = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountPanoMarks)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPointGrey);
            this.groupBox1.Controls.Add(this.labelCountDown);
            this.groupBox1.Controls.Add(this.buttonWebcam);
            this.groupBox1.Controls.Add(this.buttonGoPro);
            this.groupBox1.Controls.Add(this.lblSpd2);
            this.groupBox1.Controls.Add(this.lblSpd);
            this.groupBox1.Controls.Add(this.lblJogRaw2);
            this.groupBox1.Controls.Add(this.lblLimRaw2);
            this.groupBox1.Controls.Add(this.lblJog2);
            this.groupBox1.Controls.Add(this.lblLim2);
            this.groupBox1.Controls.Add(this.lblJogRaw);
            this.groupBox1.Controls.Add(this.lblLimRaw);
            this.groupBox1.Controls.Add(this.lblJog);
            this.groupBox1.Controls.Add(this.lblLim);
            this.groupBox1.Controls.Add(this.lblBuf2);
            this.groupBox1.Controls.Add(this.lblOut2);
            this.groupBox1.Controls.Add(this.lblPos2);
            this.groupBox1.Controls.Add(this.lblBuf);
            this.groupBox1.Controls.Add(this.lblOut);
            this.groupBox1.Controls.Add(this.lblPos);
            this.groupBox1.Controls.Add(this.button_initialize);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Group";
            // 
            // buttonPointGrey
            // 
            this.buttonPointGrey.Location = new System.Drawing.Point(686, 28);
            this.buttonPointGrey.Name = "buttonPointGrey";
            this.buttonPointGrey.Size = new System.Drawing.Size(63, 23);
            this.buttonPointGrey.TabIndex = 23;
            this.buttonPointGrey.Text = "PTGrey";
            this.buttonPointGrey.UseVisualStyleBackColor = true;
            this.buttonPointGrey.Click += new System.EventHandler(this.buttonPointGrey_Click);
            // 
            // labelCountDown
            // 
            this.labelCountDown.AutoSize = true;
            this.labelCountDown.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountDown.ForeColor = System.Drawing.Color.Maroon;
            this.labelCountDown.Location = new System.Drawing.Point(523, 31);
            this.labelCountDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountDown.Name = "labelCountDown";
            this.labelCountDown.Size = new System.Drawing.Size(23, 22);
            this.labelCountDown.TabIndex = 22;
            this.labelCountDown.Text = "0";
            // 
            // buttonWebcam
            // 
            this.buttonWebcam.Location = new System.Drawing.Point(619, 28);
            this.buttonWebcam.Name = "buttonWebcam";
            this.buttonWebcam.Size = new System.Drawing.Size(60, 23);
            this.buttonWebcam.TabIndex = 21;
            this.buttonWebcam.Text = "Webcam";
            this.buttonWebcam.UseVisualStyleBackColor = true;
            this.buttonWebcam.Click += new System.EventHandler(this.buttonWebcam_Click);
            // 
            // buttonGoPro
            // 
            this.buttonGoPro.Location = new System.Drawing.Point(557, 28);
            this.buttonGoPro.Name = "buttonGoPro";
            this.buttonGoPro.Size = new System.Drawing.Size(56, 23);
            this.buttonGoPro.TabIndex = 20;
            this.buttonGoPro.Text = "GoPro";
            this.buttonGoPro.UseVisualStyleBackColor = true;
            this.buttonGoPro.Click += new System.EventHandler(this.buttonGoPro_Click);
            // 
            // lblSpd2
            // 
            this.lblSpd2.AutoSize = true;
            this.lblSpd2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpd2.Location = new System.Drawing.Point(454, 37);
            this.lblSpd2.Name = "lblSpd2";
            this.lblSpd2.Size = new System.Drawing.Size(28, 14);
            this.lblSpd2.TabIndex = 18;
            this.lblSpd2.Text = "---";
            // 
            // lblSpd
            // 
            this.lblSpd.AutoSize = true;
            this.lblSpd.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpd.Location = new System.Drawing.Point(403, 37);
            this.lblSpd.Name = "lblSpd";
            this.lblSpd.Size = new System.Drawing.Size(35, 14);
            this.lblSpd.TabIndex = 19;
            this.lblSpd.Text = "Spd:";
            // 
            // lblJogRaw2
            // 
            this.lblJogRaw2.AutoSize = true;
            this.lblJogRaw2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogRaw2.Location = new System.Drawing.Point(362, 37);
            this.lblJogRaw2.Name = "lblJogRaw2";
            this.lblJogRaw2.Size = new System.Drawing.Size(28, 14);
            this.lblJogRaw2.TabIndex = 10;
            this.lblJogRaw2.Text = "---";
            // 
            // lblLimRaw2
            // 
            this.lblLimRaw2.AutoSize = true;
            this.lblLimRaw2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimRaw2.Location = new System.Drawing.Point(362, 25);
            this.lblLimRaw2.Name = "lblLimRaw2";
            this.lblLimRaw2.Size = new System.Drawing.Size(28, 14);
            this.lblLimRaw2.TabIndex = 11;
            this.lblLimRaw2.Text = "---";
            // 
            // lblJog2
            // 
            this.lblJog2.AutoSize = true;
            this.lblJog2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJog2.Location = new System.Drawing.Point(269, 37);
            this.lblJog2.Name = "lblJog2";
            this.lblJog2.Size = new System.Drawing.Size(28, 14);
            this.lblJog2.TabIndex = 12;
            this.lblJog2.Text = "---";
            // 
            // lblLim2
            // 
            this.lblLim2.AutoSize = true;
            this.lblLim2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLim2.Location = new System.Drawing.Point(269, 25);
            this.lblLim2.Name = "lblLim2";
            this.lblLim2.Size = new System.Drawing.Size(28, 14);
            this.lblLim2.TabIndex = 13;
            this.lblLim2.Text = "---";
            // 
            // lblJogRaw
            // 
            this.lblJogRaw.AutoSize = true;
            this.lblJogRaw.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogRaw.Location = new System.Drawing.Point(311, 37);
            this.lblJogRaw.Name = "lblJogRaw";
            this.lblJogRaw.Size = new System.Drawing.Size(56, 14);
            this.lblJogRaw.TabIndex = 14;
            this.lblJogRaw.Text = "JogRaw:";
            // 
            // lblLimRaw
            // 
            this.lblLimRaw.AutoSize = true;
            this.lblLimRaw.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimRaw.Location = new System.Drawing.Point(311, 25);
            this.lblLimRaw.Name = "lblLimRaw";
            this.lblLimRaw.Size = new System.Drawing.Size(56, 14);
            this.lblLimRaw.TabIndex = 15;
            this.lblLimRaw.Text = "LimRaw:";
            // 
            // lblJog
            // 
            this.lblJog.AutoSize = true;
            this.lblJog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJog.Location = new System.Drawing.Point(218, 37);
            this.lblJog.Name = "lblJog";
            this.lblJog.Size = new System.Drawing.Size(35, 14);
            this.lblJog.TabIndex = 16;
            this.lblJog.Text = "Jog:";
            // 
            // lblLim
            // 
            this.lblLim.AutoSize = true;
            this.lblLim.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLim.Location = new System.Drawing.Point(218, 25);
            this.lblLim.Name = "lblLim";
            this.lblLim.Size = new System.Drawing.Size(35, 14);
            this.lblLim.TabIndex = 17;
            this.lblLim.Text = "Lim:";
            // 
            // lblBuf2
            // 
            this.lblBuf2.AutoSize = true;
            this.lblBuf2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuf2.Location = new System.Drawing.Point(158, 25);
            this.lblBuf2.Name = "lblBuf2";
            this.lblBuf2.Size = new System.Drawing.Size(28, 14);
            this.lblBuf2.TabIndex = 4;
            this.lblBuf2.Text = "---";
            // 
            // lblOut2
            // 
            this.lblOut2.AutoSize = true;
            this.lblOut2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut2.Location = new System.Drawing.Point(158, 37);
            this.lblOut2.Name = "lblOut2";
            this.lblOut2.Size = new System.Drawing.Size(28, 14);
            this.lblOut2.TabIndex = 5;
            this.lblOut2.Text = "---";
            // 
            // lblPos2
            // 
            this.lblPos2.AutoSize = true;
            this.lblPos2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos2.Location = new System.Drawing.Point(158, 13);
            this.lblPos2.Name = "lblPos2";
            this.lblPos2.Size = new System.Drawing.Size(28, 14);
            this.lblPos2.TabIndex = 6;
            this.lblPos2.Text = "---";
            // 
            // lblBuf
            // 
            this.lblBuf.AutoSize = true;
            this.lblBuf.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuf.Location = new System.Drawing.Point(107, 25);
            this.lblBuf.Name = "lblBuf";
            this.lblBuf.Size = new System.Drawing.Size(35, 14);
            this.lblBuf.TabIndex = 7;
            this.lblBuf.Text = "Buf:";
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(107, 37);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(35, 14);
            this.lblOut.TabIndex = 8;
            this.lblOut.Text = "Out:";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.Location = new System.Drawing.Point(107, 13);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(35, 14);
            this.lblPos.TabIndex = 9;
            this.lblPos.Text = "Pos:";
            // 
            // button_initialize
            // 
            this.button_initialize.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_initialize.Location = new System.Drawing.Point(7, 21);
            this.button_initialize.Name = "button_initialize";
            this.button_initialize.Size = new System.Drawing.Size(94, 23);
            this.button_initialize.TabIndex = 0;
            this.button_initialize.Text = "Initialize";
            this.button_initialize.UseVisualStyleBackColor = true;
            this.button_initialize.Click += new System.EventHandler(this.button_initialize_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputTextBox);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 550);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Log";
            // 
            // outputTextBox
            // 
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(7, 20);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(187, 524);
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_all_down);
            this.groupBox3.Controls.Add(this.button_all_up);
            this.groupBox3.Controls.Add(this.button_camera);
            this.groupBox3.Controls.Add(this.button_down2);
            this.groupBox3.Controls.Add(this.button_up2);
            this.groupBox3.Controls.Add(this.button_down);
            this.groupBox3.Controls.Add(this.button_up);
            this.groupBox3.Controls.Add(this.button_right);
            this.groupBox3.Controls.Add(this.button_left);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(218, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 248);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Jog Handle";
            // 
            // button_all_down
            // 
            this.button_all_down.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_all_down.Enabled = false;
            this.button_all_down.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_all_down.Location = new System.Drawing.Point(126, 114);
            this.button_all_down.Name = "button_all_down";
            this.button_all_down.Size = new System.Drawing.Size(35, 52);
            this.button_all_down.TabIndex = 8;
            this.button_all_down.Text = "D";
            this.button_all_down.UseVisualStyleBackColor = false;
            this.button_all_down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_all_down_MouseDown);
            this.button_all_down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_all_down_MouseUp);
            // 
            // button_all_up
            // 
            this.button_all_up.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_all_up.Enabled = false;
            this.button_all_up.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_all_up.Location = new System.Drawing.Point(126, 26);
            this.button_all_up.Name = "button_all_up";
            this.button_all_up.Size = new System.Drawing.Size(35, 52);
            this.button_all_up.TabIndex = 7;
            this.button_all_up.Text = "U";
            this.button_all_up.UseVisualStyleBackColor = false;
            this.button_all_up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_all_up_MouseDown);
            this.button_all_up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_all_up_MouseUp);
            // 
            // button_camera
            // 
            this.button_camera.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_camera.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_camera.Location = new System.Drawing.Point(68, 85);
            this.button_camera.Name = "button_camera";
            this.button_camera.Size = new System.Drawing.Size(45, 23);
            this.button_camera.TabIndex = 6;
            this.button_camera.Text = "Cam";
            this.button_camera.UseVisualStyleBackColor = false;
            this.button_camera.Click += new System.EventHandler(this.button_camera_Click);
            // 
            // button_down2
            // 
            this.button_down2.Enabled = false;
            this.button_down2.Location = new System.Drawing.Point(61, 143);
            this.button_down2.Name = "button_down2";
            this.button_down2.Size = new System.Drawing.Size(58, 23);
            this.button_down2.TabIndex = 5;
            this.button_down2.Text = "v";
            this.button_down2.UseVisualStyleBackColor = true;
            this.button_down2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_down2_MouseDown);
            this.button_down2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_down2_MouseUp);
            // 
            // button_up2
            // 
            this.button_up2.Enabled = false;
            this.button_up2.Location = new System.Drawing.Point(61, 26);
            this.button_up2.Name = "button_up2";
            this.button_up2.Size = new System.Drawing.Size(58, 23);
            this.button_up2.TabIndex = 4;
            this.button_up2.Text = "^";
            this.button_up2.UseVisualStyleBackColor = true;
            this.button_up2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_up2_MouseDown);
            this.button_up2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_up2_MouseUp);
            // 
            // button_down
            // 
            this.button_down.Enabled = false;
            this.button_down.Location = new System.Drawing.Point(61, 114);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(58, 23);
            this.button_down.TabIndex = 3;
            this.button_down.Text = "v";
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_down_MouseDown);
            this.button_down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_down_MouseUp);
            // 
            // button_up
            // 
            this.button_up.Enabled = false;
            this.button_up.Location = new System.Drawing.Point(61, 55);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(58, 23);
            this.button_up.TabIndex = 2;
            this.button_up.Text = "^";
            this.button_up.UseVisualStyleBackColor = true;
            this.button_up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_up_MouseDown);
            this.button_up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_up_MouseUp);
            // 
            // button_right
            // 
            this.button_right.Enabled = false;
            this.button_right.Location = new System.Drawing.Point(120, 85);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(58, 23);
            this.button_right.TabIndex = 1;
            this.button_right.Text = ">";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_right_MouseDown);
            this.button_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_right_MouseUp);
            // 
            // button_left
            // 
            this.button_left.Enabled = false;
            this.button_left.Location = new System.Drawing.Point(6, 85);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(58, 23);
            this.button_left.TabIndex = 0;
            this.button_left.Text = "<";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_left_MouseDown);
            this.button_left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_left_MouseUp);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.roboticArmControl);
            this.groupBox4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(218, 328);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(559, 296);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Robotic Arm Status";
            // 
            // roboticArmControl
            // 
            this.roboticArmControl.BackColor = System.Drawing.SystemColors.Control;
            this.roboticArmControl.Location = new System.Drawing.Point(6, 21);
            this.roboticArmControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.roboticArmControl.Name = "roboticArmControl";
            this.roboticArmControl.Size = new System.Drawing.Size(492, 258);
            this.roboticArmControl.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.buttonPause);
            this.groupBox5.Controls.Add(this.buttonTriggerAll);
            this.groupBox5.Controls.Add(this.allButton);
            this.groupBox5.Controls.Add(this.oneRowButton);
            this.groupBox5.Controls.Add(this.oneAngleButton);
            this.groupBox5.Controls.Add(this.button_extend);
            this.groupBox5.Controls.Add(this.button_load_delta);
            this.groupBox5.Controls.Add(this.button_save_delta);
            this.groupBox5.Controls.Add(this.button_reset);
            this.groupBox5.Controls.Add(this.button_clear_all_marks);
            this.groupBox5.Controls.Add(this.button_add_mark);
            this.groupBox5.Controls.Add(this.marksListBox);
            this.groupBox5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(409, 74);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(368, 248);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Capture Utility";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.numericUpDownCountPanoMarks);
            this.groupBox7.Controls.Add(this.buttonGeneratePanoMarks);
            this.groupBox7.Location = new System.Drawing.Point(134, 85);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(102, 116);
            this.groupBox7.TabIndex = 26;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Panorama";
            // 
            // numericUpDownCountPanoMarks
            // 
            this.numericUpDownCountPanoMarks.Location = new System.Drawing.Point(7, 21);
            this.numericUpDownCountPanoMarks.Maximum = new decimal(new int[] {
            7200,
            0,
            0,
            0});
            this.numericUpDownCountPanoMarks.Name = "numericUpDownCountPanoMarks";
            this.numericUpDownCountPanoMarks.Size = new System.Drawing.Size(89, 22);
            this.numericUpDownCountPanoMarks.TabIndex = 2;
            // 
            // buttonGeneratePanoMarks
            // 
            this.buttonGeneratePanoMarks.Location = new System.Drawing.Point(7, 51);
            this.buttonGeneratePanoMarks.Name = "buttonGeneratePanoMarks";
            this.buttonGeneratePanoMarks.Size = new System.Drawing.Size(89, 23);
            this.buttonGeneratePanoMarks.TabIndex = 1;
            this.buttonGeneratePanoMarks.Text = "Generate";
            this.buttonGeneratePanoMarks.UseVisualStyleBackColor = true;
            this.buttonGeneratePanoMarks.Click += new System.EventHandler(this.buttonGeneratePanoMarks_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Enabled = false;
            this.buttonPause.Font = new System.Drawing.Font("Consolas", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPause.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonPause.Location = new System.Drawing.Point(71, 207);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(54, 23);
            this.buttonPause.TabIndex = 25;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonTriggerAll
            // 
            this.buttonTriggerAll.AutoSize = true;
            this.buttonTriggerAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTriggerAll.Image = ((System.Drawing.Image)(resources.GetObject("buttonTriggerAll.Image")));
            this.buttonTriggerAll.Location = new System.Drawing.Point(71, 147);
            this.buttonTriggerAll.Name = "buttonTriggerAll";
            this.buttonTriggerAll.Size = new System.Drawing.Size(54, 54);
            this.buttonTriggerAll.TabIndex = 24;
            this.buttonTriggerAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTriggerAll.UseVisualStyleBackColor = true;
            this.buttonTriggerAll.Click += new System.EventHandler(this.buttonTriggerAll_Click);
            // 
            // allButton
            // 
            this.allButton.AutoSize = true;
            this.allButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allButton.Enabled = false;
            this.allButton.Image = ((System.Drawing.Image)(resources.GetObject("allButton.Image")));
            this.allButton.Location = new System.Drawing.Point(9, 147);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(56, 56);
            this.allButton.TabIndex = 23;
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // oneRowButton
            // 
            this.oneRowButton.AutoSize = true;
            this.oneRowButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.oneRowButton.Enabled = false;
            this.oneRowButton.Image = ((System.Drawing.Image)(resources.GetObject("oneRowButton.Image")));
            this.oneRowButton.Location = new System.Drawing.Point(71, 85);
            this.oneRowButton.Name = "oneRowButton";
            this.oneRowButton.Size = new System.Drawing.Size(56, 56);
            this.oneRowButton.TabIndex = 22;
            this.oneRowButton.UseVisualStyleBackColor = true;
            this.oneRowButton.Click += new System.EventHandler(this.oneRowButton_Click);
            // 
            // oneAngleButton
            // 
            this.oneAngleButton.AutoSize = true;
            this.oneAngleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.oneAngleButton.Enabled = false;
            this.oneAngleButton.Image = ((System.Drawing.Image)(resources.GetObject("oneAngleButton.Image")));
            this.oneAngleButton.Location = new System.Drawing.Point(9, 85);
            this.oneAngleButton.Name = "oneAngleButton";
            this.oneAngleButton.Size = new System.Drawing.Size(56, 56);
            this.oneAngleButton.TabIndex = 21;
            this.oneAngleButton.UseVisualStyleBackColor = true;
            this.oneAngleButton.Click += new System.EventHandler(this.oneAngleButton_Click);
            // 
            // button_extend
            // 
            this.button_extend.Location = new System.Drawing.Point(134, 50);
            this.button_extend.Name = "button_extend";
            this.button_extend.Size = new System.Drawing.Size(102, 23);
            this.button_extend.TabIndex = 6;
            this.button_extend.Text = "Extend";
            this.button_extend.UseVisualStyleBackColor = true;
            this.button_extend.Click += new System.EventHandler(this.button_extend_Click);
            // 
            // button_load_delta
            // 
            this.button_load_delta.Location = new System.Drawing.Point(242, 15);
            this.button_load_delta.Name = "button_load_delta";
            this.button_load_delta.Size = new System.Drawing.Size(120, 23);
            this.button_load_delta.TabIndex = 5;
            this.button_load_delta.Text = "Load Delta";
            this.button_load_delta.UseVisualStyleBackColor = true;
            this.button_load_delta.Click += new System.EventHandler(this.button_load_delta_Click);
            // 
            // button_save_delta
            // 
            this.button_save_delta.Location = new System.Drawing.Point(242, 214);
            this.button_save_delta.Name = "button_save_delta";
            this.button_save_delta.Size = new System.Drawing.Size(120, 23);
            this.button_save_delta.TabIndex = 4;
            this.button_save_delta.Text = "Save Delta";
            this.button_save_delta.UseVisualStyleBackColor = true;
            this.button_save_delta.Click += new System.EventHandler(this.button_save_delta_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(6, 49);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(119, 23);
            this.button_reset.TabIndex = 3;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_clear_all_marks
            // 
            this.button_clear_all_marks.Location = new System.Drawing.Point(134, 21);
            this.button_clear_all_marks.Name = "button_clear_all_marks";
            this.button_clear_all_marks.Size = new System.Drawing.Size(102, 23);
            this.button_clear_all_marks.TabIndex = 2;
            this.button_clear_all_marks.Text = "Clear";
            this.button_clear_all_marks.UseVisualStyleBackColor = true;
            this.button_clear_all_marks.Click += new System.EventHandler(this.button_clear_all_marks_Click);
            // 
            // button_add_mark
            // 
            this.button_add_mark.Location = new System.Drawing.Point(7, 20);
            this.button_add_mark.Name = "button_add_mark";
            this.button_add_mark.Size = new System.Drawing.Size(118, 23);
            this.button_add_mark.TabIndex = 1;
            this.button_add_mark.Text = "Add Mark";
            this.button_add_mark.UseVisualStyleBackColor = true;
            this.button_add_mark.Click += new System.EventHandler(this.button_add_mark_Click);
            // 
            // marksListBox
            // 
            this.marksListBox.FormattingEnabled = true;
            this.marksListBox.ItemHeight = 14;
            this.marksListBox.Location = new System.Drawing.Point(242, 40);
            this.marksListBox.Name = "marksListBox";
            this.marksListBox.Size = new System.Drawing.Size(120, 158);
            this.marksListBox.TabIndex = 0;
            this.marksListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.marksListBox_MouseDoubleClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton120);
            this.groupBox6.Controls.Add(this.radioButton180);
            this.groupBox6.Controls.Add(this.radioButton360);
            this.groupBox6.Controls.Add(this.checkBoxZigZag);
            this.groupBox6.Controls.Add(this.checkBoxCloseApp);
            this.groupBox6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(12, 631);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(765, 44);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Settings";
            // 
            // radioButton120
            // 
            this.radioButton120.AutoSize = true;
            this.radioButton120.Location = new System.Drawing.Point(504, 19);
            this.radioButton120.Name = "radioButton120";
            this.radioButton120.Size = new System.Drawing.Size(53, 18);
            this.radioButton120.TabIndex = 4;
            this.radioButton120.TabStop = true;
            this.radioButton120.Text = "120°";
            this.radioButton120.UseVisualStyleBackColor = true;
            this.radioButton120.CheckedChanged += new System.EventHandler(this.radioButton120_CheckedChanged);
            // 
            // radioButton180
            // 
            this.radioButton180.AutoSize = true;
            this.radioButton180.Location = new System.Drawing.Point(444, 19);
            this.radioButton180.Name = "radioButton180";
            this.radioButton180.Size = new System.Drawing.Size(53, 18);
            this.radioButton180.TabIndex = 3;
            this.radioButton180.TabStop = true;
            this.radioButton180.Text = "180°";
            this.radioButton180.UseVisualStyleBackColor = true;
            this.radioButton180.CheckedChanged += new System.EventHandler(this.radioButton180_CheckedChanged);
            // 
            // radioButton360
            // 
            this.radioButton360.AutoSize = true;
            this.radioButton360.Checked = true;
            this.radioButton360.Location = new System.Drawing.Point(385, 19);
            this.radioButton360.Name = "radioButton360";
            this.radioButton360.Size = new System.Drawing.Size(53, 18);
            this.radioButton360.TabIndex = 2;
            this.radioButton360.TabStop = true;
            this.radioButton360.Text = "360°";
            this.radioButton360.UseVisualStyleBackColor = true;
            this.radioButton360.CheckedChanged += new System.EventHandler(this.radioButton360_CheckedChanged);
            // 
            // checkBoxZigZag
            // 
            this.checkBoxZigZag.AutoSize = true;
            this.checkBoxZigZag.Enabled = false;
            this.checkBoxZigZag.Location = new System.Drawing.Point(206, 20);
            this.checkBoxZigZag.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxZigZag.Name = "checkBoxZigZag";
            this.checkBoxZigZag.Size = new System.Drawing.Size(159, 18);
            this.checkBoxZigZag.TabIndex = 1;
            this.checkBoxZigZag.Text = "Zig-zag camera path";
            this.checkBoxZigZag.UseVisualStyleBackColor = true;
            // 
            // checkBoxCloseApp
            // 
            this.checkBoxCloseApp.AutoSize = true;
            this.checkBoxCloseApp.Location = new System.Drawing.Point(7, 20);
            this.checkBoxCloseApp.Name = "checkBoxCloseApp";
            this.checkBoxCloseApp.Size = new System.Drawing.Size(194, 18);
            this.checkBoxCloseApp.TabIndex = 0;
            this.checkBoxCloseApp.Text = "Close App After Finished";
            this.checkBoxCloseApp.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 683);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Robotic Arm Capture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountPanoMarks)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_initialize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Label lblSpd2;
        private System.Windows.Forms.Label lblSpd;
        private System.Windows.Forms.Label lblJogRaw2;
        private System.Windows.Forms.Label lblLimRaw2;
        private System.Windows.Forms.Label lblJog2;
        private System.Windows.Forms.Label lblLim2;
        private System.Windows.Forms.Label lblJogRaw;
        private System.Windows.Forms.Label lblLimRaw;
        private System.Windows.Forms.Label lblJog;
        private System.Windows.Forms.Label lblLim;
        private System.Windows.Forms.Label lblBuf2;
        private System.Windows.Forms.Label lblOut2;
        private System.Windows.Forms.Label lblPos2;
        private System.Windows.Forms.Label lblBuf;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_down2;
        private System.Windows.Forms.Button button_up2;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_camera;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_all_down;
        private System.Windows.Forms.Button button_all_up;
        private RoboticArm roboticArmControl;
        private System.Windows.Forms.ListBox marksListBox;
        private System.Windows.Forms.Button button_add_mark;
        private System.Windows.Forms.Button button_clear_all_marks;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_load_delta;
        private System.Windows.Forms.Button button_save_delta;
        private System.Windows.Forms.Button button_extend;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Button oneRowButton;
        private System.Windows.Forms.Button oneAngleButton;
        private System.Windows.Forms.Button buttonTriggerAll;
        private System.Windows.Forms.Button buttonWebcam;
        private System.Windows.Forms.Button buttonGoPro;
        private System.Windows.Forms.Label labelCountDown;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBoxCloseApp;
        private System.Windows.Forms.CheckBox checkBoxZigZag;
        private System.Windows.Forms.Button buttonPointGrey;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button buttonGeneratePanoMarks;
        private System.Windows.Forms.NumericUpDown numericUpDownCountPanoMarks;
        private System.Windows.Forms.RadioButton radioButton120;
        private System.Windows.Forms.RadioButton radioButton180;
        private System.Windows.Forms.RadioButton radioButton360;
    }
}

