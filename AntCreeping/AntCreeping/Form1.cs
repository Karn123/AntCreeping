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
using System.Collections;

namespace AntCreeping
{
    public partial class Form1 : Form
    {
        float startTime;
        float nowTime;

        private System.Timers.Timer aTimer = new System.Timers.Timer();

        public bool isStart = false;
        public const int MAXLENGTH = 300;
        public Toward toward;
        CreepingGame creepingGame = new CreepingGame();
        List<Ant> antList = new List<Ant>();
        public Hashtable ht = new Hashtable();
        Stick myStick = new Stick(MAXLENGTH);
        public int[] pos = new int[] { 30, 80, 110, 160, 250 };
        public float default_velocity = 0.08f * 50;
        private float minTime;
        private float maxTime;

        public Toward setDirection(int i)
        {
            if (i == 0)
                return Toward.left;
            else
                return Toward.right;
        }

        public void addAnt(int[] pos, Toward[] dir)
        {
            for (int i = 0; i < pos.Length; i++)
            {
                Ant ant = new Ant(pos[i], dir[i], default_velocity);
                ht.Add(pos[i], ant);
                antList.Add(ant);
            }
        }

        /// <summary>
        /// play all possible games
        /// </summary>
        public void PlayGames()
        {
            MainPicture.GetInstance().Clear();
            MainPicture.GetInstance().DrawStick(MAXLENGTH);

            MainPicture.GetInstance().EndDraw();
            Toward[] toward = new Toward[5];

            minTime = float.MaxValue;
            maxTime = float.MinValue;
            //set each ant's direction
            for (int i = 0; i < 2; i++)
            {
                toward[0] = setDirection(i);
                for (int j = 0; j < 2; j++)
                {
                    toward[1] = setDirection(j);
                    for (int k = 0; k < 2; k++)
                    {
                        toward[2] = setDirection(k);
                        for (int l = 0; l < 2; l++)
                        {
                            toward[3] = setDirection(l);
                            for (int m = 0; m < 2; m++)
                            {
                                toward[4] = setDirection(m);
                                //Clear sets which have held ants
                                ht.Clear();
                                antList.Clear();
                                //add ants to hash set and list
                                addAnt(pos, toward);
                                
                                creepingGame.SetListAndStick(antList, myStick);
                                creepingGame.IsGameOver = false;

                                startTime = 0;
                                nowTime = 0;
                                TimerSetup();
                                while (!creepingGame.IsGameOver)
                                {
                                }
                                float timeInterval = (nowTime - startTime) * 50;
                                if (timeInterval > maxTime)
                                    maxTime = timeInterval ;
                                if (timeInterval < minTime)
                                    minTime = timeInterval;
                            }
                        }
                    }
                }
            }
            minTimeLabel.Text = minTime.ToString() + "ms";
            maxTimeLabel.Text = maxTime.ToString() + "ms";
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void StartOrEndButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            minTimeLabel.Text = null;
            maxTimeLabel.Text = null;
            isStart = true;
            b.Visible = false;
            BmpAndGraphicInitialize();
            PlayGames();
            b.Visible = true;
            BmpAndGraphicRelease();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aTimer.Elapsed += new ElapsedEventHandler(TimedEvent);
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

        private void BmpAndGraphicRelease()
        {
            MainPicture.GetInstance().Release();
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        public void TimerSetup()
        {
            aTimer.Interval = 16;    //配置文件中配置的秒数
            aTimer.Enabled = true;
        }

        private void TimedEvent(object sender, ElapsedEventArgs e)
        {
            nowTime += (float)aTimer.Interval;
            if (creepingGame.IsGameOver)
            {
                MainPicture.GetInstance().Clear();
                MainPicture.GetInstance().DrawStick(creepingGame.AntStick.Length);
                for (int i = 0; i < creepingGame.AntList.Count; i++)
                {
                    MainPicture.GetInstance().DrawAnt(creepingGame.AntList[i].Position, creepingGame.AntList[i].CreepingToward);
                }
                MainPicture.GetInstance().EndDraw();
                aTimer.Enabled = false;
            }
            else
            {
                creepingGame.drivingGame();
                if (!creepingGame.IsGameOver)
                {
                    MainPicture.GetInstance().Clear();
                    MainPicture.GetInstance().DrawStick(creepingGame.AntStick.Length);
                    for (int i = 0; i < creepingGame.AntList.Count; i++)
                    {
                        Console.WriteLine(creepingGame.AntList.Count);
                        MainPicture.GetInstance().DrawAnt(creepingGame.AntList[i].Position,creepingGame.AntList[i].CreepingToward);
                    }
                    MainPicture.GetInstance().EndDraw();
                }
            }
        }
    }
}