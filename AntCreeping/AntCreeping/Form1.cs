using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntCreeping
{
    public partial class Form1 : Form
    {
        DateTime startTime;
        DateTime nowTime;
        PlayRoom playroom;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartOrEndButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (playroom.isStart)
            {
                playroom.isStart = false;
                b.Text = "Start";
                nowTime = DateTime.Now;
                //TimeSpan timeInterval = (nowTime - startTime);
                int timeInterval = (nowTime - startTime).Milliseconds;
                TimeLabel.Text = timeInterval.ToString() + "ms";

                //clear the picture box and cache
                //this.Refresh();
                Bitmap bmp = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.Clear(this.MainPictureBox.BackColor);
                g.Dispose();
                MainPicture mp = MainPicture.GetInstance();
                //mp.originBmp = bmp;
                //mp.finishingBmp = bmp;
                mp.Clear();
            }
            else
            {
                playroom.isStart = true;
                b.Text = "Stop";
                playroom.PlayGames();
                startTime = DateTime.Now;
                TimeLabel.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BmpAndGraphicInitialize();
            playroom = new PlayRoom();
        }

        private void BmpAndGraphicInitialize()
        {
            Bitmap bmp = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.Clear(this.MainPictureBox.BackColor);
            g.Dispose();
            MainPicture mp = MainPicture.GetInstance();
            mp.SetGraphics(MainPictureBox.CreateGraphics(), bmp, MainPictureBox.Width, MainPictureBox.Height);
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
