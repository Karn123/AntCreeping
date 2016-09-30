using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Timers;

namespace AntCreeping
{
    public partial class Form1 : Form
    {
        float startTime;
        float nowTime;
        PlayRoom playroom;
        private System.Timers.Timer aTimer;
        Thread playRoomThread;

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
                //TimeSpan timeInterval = (nowTime - startTime);
                float timeInterval = nowTime - startTime;
                TimeLabel.Text = timeInterval.ToString() + "ms";

                //clear the picture box and cache
                //this.Refresh();
                Bitmap bmp = new Bitmap(MainPictureBox.Width, MainPictureBox.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.Clear(this.MainPictureBox.BackColor);
                g.Dispose();
                MainPicture mp = MainPicture.GetInstance();
                mp.Clear();

                try
                {
                    playRoomThread.Abort();
                }
                catch
                {

                }
            }
            else
            {
                playroom.isStart = true;
                b.Text = "Stop";

                playRoomThread = new Thread(new ThreadStart(playroom.PlayGames));
                playRoomThread.Start();

                TimerSetup();
                startTime = 0;
                nowTime = 0;
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

        public void TimerSetup()
        {
            #region 定时器事件 
            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(TimedEvent);
            aTimer.Interval = 16;    //配置文件中配置的秒数
            aTimer.Enabled = true;
            #endregion
        }

        private void TimedEvent(object sender, ElapsedEventArgs e)
        {
            if (!playroom.isReady)
            {
                startTime = 0;
                nowTime = 0;
                return;
            }
            nowTime += (float)aTimer.Interval;
            if (playroom.creeepingGame.IsGameOver)
            {
                MainPicture.GetInstance().Clear();
                MainPicture.GetInstance().DrawStick(playroom.creeepingGame.AntStick.Length);
                for (int i = 0; i < playroom.creeepingGame.AntList.Count; i++)
                {
                    MainPicture.GetInstance().DrawAnt(playroom.creeepingGame.AntList[i].Position, playroom.creeepingGame.AntList[i].CreepingToward);
                }
                MainPicture.GetInstance().EndDraw();
                //aTimer.Enabled = false;
                playroom.isReady = false;
            }
            else
            {
                playroom.creeepingGame.drivingGame();
                if (!playroom.creeepingGame.IsGameOver)
                {
                    MainPicture.GetInstance().Clear();
                    MainPicture.GetInstance().DrawStick(playroom.creeepingGame.AntStick.Length);
                    for (int i = 0; i < playroom.creeepingGame.AntList.Count; i++)
                    {
                        Console.WriteLine(playroom.creeepingGame.AntList.Count);
                        MainPicture.GetInstance().DrawAnt(playroom.creeepingGame.AntList[i].Position, playroom.creeepingGame.AntList[i].CreepingToward);
                    }
                    MainPicture.GetInstance().EndDraw();
                }
            }
        }
    }
}
