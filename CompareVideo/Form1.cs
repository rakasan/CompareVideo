using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompareVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Video1 = 0;
        public int Video1Step = 0;
        public int Video2 = 0;
        public int Video2Step = 0;
        public int Video3 = 0;
        public int Video3Step = 0;
        public int Video4 = 0;
        public int Video4Step = 0;
        private void btnLoad1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
           
          
        }

        private void btnPlay1_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec1.Text);
          
              
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            Video1 = 0;
            axWindowsMediaPlayer1.Ctlcontrols.pause();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Video1 == 1)
            {
                Video1Step++;
                if (Video1Step == Convert.ToInt32(FrameRate1.Text))
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    Video1Step = 0;
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                }
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Video1 = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec1.Text);
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer2.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec2.Text);
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec1.Text);
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer3.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec3.Text);
            axWindowsMediaPlayer3.Ctlcontrols.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec1.Text);
            axWindowsMediaPlayer1.Ctlcontrols.play();
            axWindowsMediaPlayer3.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec4.Text);
            axWindowsMediaPlayer3.Ctlcontrols.play();
        }

        private void btnLoad2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            axWindowsMediaPlayer2.URL = openFileDialog2.FileName;
        }

        private void btnPlay2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.play();
            axWindowsMediaPlayer2.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec2.Text);
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            Video2 = 0;
            axWindowsMediaPlayer2.Ctlcontrols.pause();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Video2 = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec2.Text);
            axWindowsMediaPlayer2.Ctlcontrols.play();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec1.Text);
            axWindowsMediaPlayer1.Ctlcontrols.play();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec2.Text);
            axWindowsMediaPlayer2.Ctlcontrols.play();
            axWindowsMediaPlayer3.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec3.Text);
            axWindowsMediaPlayer3.Ctlcontrols.play();
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec2.Text);
            axWindowsMediaPlayer2.Ctlcontrols.play();
            axWindowsMediaPlayer4.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec4.Text);
            axWindowsMediaPlayer4.Ctlcontrols.play();
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec3.Text);
            axWindowsMediaPlayer3.Ctlcontrols.play();
            axWindowsMediaPlayer2.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec2.Text);
            axWindowsMediaPlayer2.Ctlcontrols.play();
          
        }

        private void button11_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec3.Text);
            axWindowsMediaPlayer3.Ctlcontrols.play();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec1.Text);
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec3.Text);
            axWindowsMediaPlayer3.Ctlcontrols.play();
            axWindowsMediaPlayer4.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec4.Text);
            axWindowsMediaPlayer4.Ctlcontrols.play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer4.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec4.Text);
            axWindowsMediaPlayer4.Ctlcontrols.play();
            axWindowsMediaPlayer3.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec3.Text);
            axWindowsMediaPlayer3.Ctlcontrols.play();
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer4.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec4.Text);
            axWindowsMediaPlayer4.Ctlcontrols.play();
            axWindowsMediaPlayer2.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec2.Text);
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer4.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec4.Text);
            axWindowsMediaPlayer4.Ctlcontrols.play();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec1.Text);
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Video3 = 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Video4 = 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Video2 == 1)
            {
                Video2Step++;
                if (Video2Step == Convert.ToInt32(FrameRate2.Text))
                {
                    axWindowsMediaPlayer2.Ctlcontrols.play();
                    Video2Step = 0;
                }
                else
                {
                    axWindowsMediaPlayer2.Ctlcontrols.pause();
                }
            }
        }

        private void btnLoad3_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
            axWindowsMediaPlayer3.URL = openFileDialog3.FileName;
        }

        private void btnLoad4_Click(object sender, EventArgs e)
        {
            openFileDialog4.ShowDialog();
            axWindowsMediaPlayer4.URL = openFileDialog4.FileName;
        }

        private void btnPlay3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.Ctlcontrols.play();
            axWindowsMediaPlayer3.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec3.Text);
        }

        private void btnPlay4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer4.Ctlcontrols.play();
            axWindowsMediaPlayer4.Ctlcontrols.currentPosition = Convert.ToInt32(StartSec4.Text);
        }

        private void btnStop3_Click(object sender, EventArgs e)
        {
            Video3 = 0;
            axWindowsMediaPlayer3.Ctlcontrols.pause();
        }

        private void btnStop4_Click(object sender, EventArgs e)
        {
            Video4 = 0;
            axWindowsMediaPlayer4.Ctlcontrols.pause();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Video3 == 1)
            {
                Video3Step++;
                if (Video3Step == Convert.ToInt32(FrameRate3.Text))
                {
                    axWindowsMediaPlayer3.Ctlcontrols.play();
                    Video3Step = 0;
                }
                else
                {
                    axWindowsMediaPlayer3.Ctlcontrols.pause();
                }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (Video4 == 1)
            {
                Video4Step++;
                if (Video4Step == Convert.ToInt32(FrameRate4.Text))
                {
                    axWindowsMediaPlayer4.Ctlcontrols.play();
                    Video4Step = 0;
                }
                else
                {
                    axWindowsMediaPlayer4.Ctlcontrols.pause();
                }
            }
        }
        
    }
}
