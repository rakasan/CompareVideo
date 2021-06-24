namespace CompareVideo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLoad1 = new System.Windows.Forms.Button();
            this.FrameRate1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.StartSec1 = new System.Windows.Forms.TextBox();
            this.StartSec2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlay2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FrameRate2 = new System.Windows.Forms.TextBox();
            this.btnLoad2 = new System.Windows.Forms.Button();
            this.StartSec3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPlay3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.FrameRate3 = new System.Windows.Forms.TextBox();
            this.btnLoad3 = new System.Windows.Forms.Button();
            this.StartSec4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPlay4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.FrameRate4 = new System.Windows.Forms.TextBox();
            this.btnLoad4 = new System.Windows.Forms.Button();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnStop3 = new System.Windows.Forms.Button();
            this.btnStop4 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer4 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad1
            // 
            this.btnLoad1.Location = new System.Drawing.Point(55, 411);
            this.btnLoad1.Name = "btnLoad1";
            this.btnLoad1.Size = new System.Drawing.Size(93, 23);
            this.btnLoad1.TabIndex = 1;
            this.btnLoad1.Text = "Load Video";
            this.btnLoad1.UseVisualStyleBackColor = true;
            this.btnLoad1.Click += new System.EventHandler(this.btnLoad1_Click);
            // 
            // FrameRate1
            // 
            this.FrameRate1.Location = new System.Drawing.Point(157, 448);
            this.FrameRate1.Name = "FrameRate1";
            this.FrameRate1.Size = new System.Drawing.Size(100, 20);
            this.FrameRate1.TabIndex = 2;
            this.FrameRate1.Text = "25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Frame Delay";
            // 
            // btnPlay1
            // 
            this.btnPlay1.Location = new System.Drawing.Point(164, 411);
            this.btnPlay1.Name = "btnPlay1";
            this.btnPlay1.Size = new System.Drawing.Size(93, 23);
            this.btnPlay1.TabIndex = 4;
            this.btnPlay1.Text = "Play";
            this.btnPlay1.UseVisualStyleBackColor = true;
            this.btnPlay1.Click += new System.EventHandler(this.btnPlay1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start Second";
            // 
            // StartSec1
            // 
            this.StartSec1.Location = new System.Drawing.Point(157, 485);
            this.StartSec1.Name = "StartSec1";
            this.StartSec1.Size = new System.Drawing.Size(100, 20);
            this.StartSec1.TabIndex = 6;
            this.StartSec1.Text = "0";
            // 
            // StartSec2
            // 
            this.StartSec2.Location = new System.Drawing.Point(581, 485);
            this.StartSec2.Name = "StartSec2";
            this.StartSec2.Size = new System.Drawing.Size(101, 20);
            this.StartSec2.TabIndex = 13;
            this.StartSec2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Start Second";
            // 
            // btnPlay2
            // 
            this.btnPlay2.Location = new System.Drawing.Point(588, 411);
            this.btnPlay2.Name = "btnPlay2";
            this.btnPlay2.Size = new System.Drawing.Size(94, 23);
            this.btnPlay2.TabIndex = 11;
            this.btnPlay2.Text = "Play";
            this.btnPlay2.UseVisualStyleBackColor = true;
            this.btnPlay2.Click += new System.EventHandler(this.btnPlay2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Frame Rate";
            // 
            // FrameRate2
            // 
            this.FrameRate2.Location = new System.Drawing.Point(581, 448);
            this.FrameRate2.Name = "FrameRate2";
            this.FrameRate2.Size = new System.Drawing.Size(101, 20);
            this.FrameRate2.TabIndex = 9;
            this.FrameRate2.Text = "25";
            // 
            // btnLoad2
            // 
            this.btnLoad2.Location = new System.Drawing.Point(479, 411);
            this.btnLoad2.Name = "btnLoad2";
            this.btnLoad2.Size = new System.Drawing.Size(94, 23);
            this.btnLoad2.TabIndex = 8;
            this.btnLoad2.Text = "Load Video";
            this.btnLoad2.UseVisualStyleBackColor = true;
            this.btnLoad2.Click += new System.EventHandler(this.btnLoad2_Click);
            // 
            // StartSec3
            // 
            this.StartSec3.Location = new System.Drawing.Point(1028, 485);
            this.StartSec3.Name = "StartSec3";
            this.StartSec3.Size = new System.Drawing.Size(101, 20);
            this.StartSec3.TabIndex = 20;
            this.StartSec3.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(931, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Start Second";
            // 
            // btnPlay3
            // 
            this.btnPlay3.Location = new System.Drawing.Point(1035, 411);
            this.btnPlay3.Name = "btnPlay3";
            this.btnPlay3.Size = new System.Drawing.Size(94, 23);
            this.btnPlay3.TabIndex = 18;
            this.btnPlay3.Text = "Play";
            this.btnPlay3.UseVisualStyleBackColor = true;
            this.btnPlay3.Click += new System.EventHandler(this.btnPlay3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(931, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Frame Rate";
            // 
            // FrameRate3
            // 
            this.FrameRate3.Location = new System.Drawing.Point(1028, 448);
            this.FrameRate3.Name = "FrameRate3";
            this.FrameRate3.Size = new System.Drawing.Size(101, 20);
            this.FrameRate3.TabIndex = 16;
            this.FrameRate3.Text = "25";
            // 
            // btnLoad3
            // 
            this.btnLoad3.Location = new System.Drawing.Point(926, 411);
            this.btnLoad3.Name = "btnLoad3";
            this.btnLoad3.Size = new System.Drawing.Size(94, 23);
            this.btnLoad3.TabIndex = 15;
            this.btnLoad3.Text = "Load Video";
            this.btnLoad3.UseVisualStyleBackColor = true;
            this.btnLoad3.Click += new System.EventHandler(this.btnLoad3_Click);
            // 
            // StartSec4
            // 
            this.StartSec4.Location = new System.Drawing.Point(1484, 485);
            this.StartSec4.Name = "StartSec4";
            this.StartSec4.Size = new System.Drawing.Size(101, 20);
            this.StartSec4.TabIndex = 27;
            this.StartSec4.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1387, 492);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Start Second";
            // 
            // btnPlay4
            // 
            this.btnPlay4.Location = new System.Drawing.Point(1491, 411);
            this.btnPlay4.Name = "btnPlay4";
            this.btnPlay4.Size = new System.Drawing.Size(94, 23);
            this.btnPlay4.TabIndex = 25;
            this.btnPlay4.Text = "Play";
            this.btnPlay4.UseVisualStyleBackColor = true;
            this.btnPlay4.Click += new System.EventHandler(this.btnPlay4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1387, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Frame Rate";
            // 
            // FrameRate4
            // 
            this.FrameRate4.Location = new System.Drawing.Point(1484, 448);
            this.FrameRate4.Name = "FrameRate4";
            this.FrameRate4.Size = new System.Drawing.Size(101, 20);
            this.FrameRate4.TabIndex = 23;
            this.FrameRate4.Text = "25";
            // 
            // btnLoad4
            // 
            this.btnLoad4.Location = new System.Drawing.Point(1382, 411);
            this.btnLoad4.Name = "btnLoad4";
            this.btnLoad4.Size = new System.Drawing.Size(94, 23);
            this.btnLoad4.TabIndex = 22;
            this.btnLoad4.Text = "Load Video";
            this.btnLoad4.UseVisualStyleBackColor = true;
            this.btnLoad4.Click += new System.EventHandler(this.btnLoad4_Click);
            // 
            // btnStop1
            // 
            this.btnStop1.Location = new System.Drawing.Point(277, 411);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(93, 23);
            this.btnStop1.TabIndex = 28;
            this.btnStop1.Text = "Pause";
            this.btnStop1.UseVisualStyleBackColor = true;
            this.btnStop1.Click += new System.EventHandler(this.btnStop1_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(709, 411);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(93, 23);
            this.btnStop2.TabIndex = 29;
            this.btnStop2.Text = "Pause";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // btnStop3
            // 
            this.btnStop3.Location = new System.Drawing.Point(1148, 411);
            this.btnStop3.Name = "btnStop3";
            this.btnStop3.Size = new System.Drawing.Size(93, 23);
            this.btnStop3.TabIndex = 30;
            this.btnStop3.Text = "Pause";
            this.btnStop3.UseVisualStyleBackColor = true;
            this.btnStop3.Click += new System.EventHandler(this.btnStop3_Click);
            // 
            // btnStop4
            // 
            this.btnStop4.Location = new System.Drawing.Point(1616, 411);
            this.btnStop4.Name = "btnStop4";
            this.btnStop4.Size = new System.Drawing.Size(93, 23);
            this.btnStop4.TabIndex = 31;
            this.btnStop4.Text = "Pause";
            this.btnStop4.UseVisualStyleBackColor = true;
            this.btnStop4.Click += new System.EventHandler(this.btnStop4_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 40;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 40;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 40;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // axWindowsMediaPlayer4
            // 
            this.axWindowsMediaPlayer4.Enabled = true;
            this.axWindowsMediaPlayer4.Location = new System.Drawing.Point(1382, 34);
            this.axWindowsMediaPlayer4.Name = "axWindowsMediaPlayer4";
            this.axWindowsMediaPlayer4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer4.OcxState")));
            this.axWindowsMediaPlayer4.Size = new System.Drawing.Size(354, 357);
            this.axWindowsMediaPlayer4.TabIndex = 21;
            // 
            // axWindowsMediaPlayer3
            // 
            this.axWindowsMediaPlayer3.Enabled = true;
            this.axWindowsMediaPlayer3.Location = new System.Drawing.Point(926, 34);
            this.axWindowsMediaPlayer3.Name = "axWindowsMediaPlayer3";
            this.axWindowsMediaPlayer3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer3.OcxState")));
            this.axWindowsMediaPlayer3.Size = new System.Drawing.Size(354, 357);
            this.axWindowsMediaPlayer3.TabIndex = 14;
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(479, 34);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(354, 357);
            this.axWindowsMediaPlayer2.TabIndex = 7;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(55, 34);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(353, 357);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Play by frame";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Sync with video 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 579);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Sync with video 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(55, 608);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 23);
            this.button4.TabIndex = 35;
            this.button4.Text = "Sync with video 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(709, 447);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 23);
            this.button5.TabIndex = 36;
            this.button5.Text = "Play by frame";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(487, 608);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 23);
            this.button6.TabIndex = 39;
            this.button6.Text = "Sync with video 4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(487, 579);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 23);
            this.button7.TabIndex = 38;
            this.button7.Text = "Sync with video 3";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(487, 550);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 23);
            this.button8.TabIndex = 37;
            this.button8.Text = "Sync with video 1";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(926, 608);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 23);
            this.button9.TabIndex = 42;
            this.button9.Text = "Sync with video 4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(926, 579);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(133, 23);
            this.button10.TabIndex = 41;
            this.button10.Text = "Sync with video 2";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(926, 550);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(133, 23);
            this.button11.TabIndex = 40;
            this.button11.Text = "Sync with video 1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(1382, 608);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(133, 23);
            this.button12.TabIndex = 45;
            this.button12.Text = "Sync with video 3";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(1382, 579);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(133, 23);
            this.button13.TabIndex = 44;
            this.button13.Text = "Sync with video 2";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(1382, 550);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(133, 23);
            this.button14.TabIndex = 43;
            this.button14.Text = "Sync with video 1";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(1148, 441);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(93, 23);
            this.button15.TabIndex = 46;
            this.button15.Text = "Play by frame";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(1616, 446);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(93, 23);
            this.button16.TabIndex = 47;
            this.button16.Text = "Play by frame";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 811);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStop4);
            this.Controls.Add(this.btnStop3);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnStop1);
            this.Controls.Add(this.StartSec4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPlay4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FrameRate4);
            this.Controls.Add(this.btnLoad4);
            this.Controls.Add(this.axWindowsMediaPlayer4);
            this.Controls.Add(this.StartSec3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPlay3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FrameRate3);
            this.Controls.Add(this.btnLoad3);
            this.Controls.Add(this.axWindowsMediaPlayer3);
            this.Controls.Add(this.StartSec2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPlay2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FrameRate2);
            this.Controls.Add(this.btnLoad2);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.StartSec1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPlay1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FrameRate1);
            this.Controls.Add(this.btnLoad1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnLoad1;
        private System.Windows.Forms.TextBox FrameRate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlay1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StartSec1;
        private System.Windows.Forms.TextBox StartSec2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlay2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FrameRate2;
        private System.Windows.Forms.Button btnLoad2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.TextBox StartSec3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPlay3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FrameRate3;
        private System.Windows.Forms.Button btnLoad3;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer3;
        private System.Windows.Forms.TextBox StartSec4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPlay4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FrameRate4;
        private System.Windows.Forms.Button btnLoad4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer4;
        private System.Windows.Forms.Button btnStop1;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnStop3;
        private System.Windows.Forms.Button btnStop4;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

