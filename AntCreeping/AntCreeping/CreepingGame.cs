using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AntCreeping
{
    class CreepingGame
    {
        private bool isGameOver=false;
        private List<Ant> antList;
        private Stick antStick;
        private Hashtable antHt = new Hashtable();
        private Timer aTimer;
        public CreepingGame()
        {
            AntList = new List<Ant>();
            AntStick = new Stick();
        }
        #region setters&getters
        public bool IsGameOver
        {
            get
            {
                return isGameOver;
            }

            set
            {
                isGameOver = value;
            }
        }

        internal List<Ant> AntList
        {
            get
            {
                return antList;
            }

            set
            {
                antList = value;
            }
        }

        internal Stick AntStick
        {
            get
            {
                return antStick;
            }

            set
            {
                antStick = value;
            }
        }
        #endregion

        public void removeAnt(Ant ant)
        {
            AntList.Remove(ant);
            antHt.Remove(ant.Position);
            if (AntList.Count == 0)
                isGameOver = true;
        }

        public bool isHavingCollision(Ant ant)
        {
            return (antHt.ContainsKey(ant.Position));
        }
        public void drivingGame()
        {
            if (!isGameOver)
            {
                antHt.Clear();
                foreach (Ant ant in AntList)
                {
                    ant.creeping(1);
                    if (AntStick.isOutOfRange(ant.Position))
                    {
                        removeAnt(ant);
                        continue;
                    }
                    float pos = ant.Position;
                    if(isHavingCollision(ant))
                    {
                        Ant collisionAnt = (Ant)antHt[ant.Position];
                        if (collisionAnt.CreepingToward == ant.CreepingToward)
                        {
                            if (collisionAnt.Velocity > ant.Velocity)
                            {
                                //collisionAnt.changeCreepDirection();
                                //int i = antList.FindIndex( x => x.Equals((Ant)antHt[ant.Position]));
                                //antList[i] = collisionAnt;
                                ((Ant)antHt[ant.Position]).changeCreepDirection();
                            }   
                            else
                                ant.changeCreepDirection();
                        }
                        else
                        {
                            //collisionAnt.changeCreepDirection();
                            //int i = antList.FindIndex(x => x.Equals((Ant)antHt[ant.Position]));
                            //antList[i] = collisionAnt;
                            ((Ant)antHt[ant.Position]).changeCreepDirection();
                            ant.changeCreepDirection();
                        }
                    }
                    else
                        antHt.Add(pos, ant);
                }
                MainPicture.GetInstance().Clear();
                MainPicture.GetInstance().DrawStick(AntStick.Length);
                for (int i = 0; i < antList.Count; i++)
                {
                    MainPicture.GetInstance().DrawAnt(antList[i].Position,antList[i].CreepingToward);
                }
                MainPicture.GetInstance().EndDraw();
            }
        }

        public void playGame(List<Ant> myAntList,Stick myStick)
        {
            AntList = myAntList;
            AntStick = myStick;

            #region 定时器事件 
            aTimer = new Timer();
            aTimer.Elapsed += new ElapsedEventHandler(TimedEvent);
            aTimer.Interval = 16;    //配置文件中配置的秒数
            aTimer.Enabled = true;
            #endregion
        }

        private void TimedEvent(object sender, ElapsedEventArgs e)
        {
            if (isGameOver)
                aTimer.Enabled = false;
            else
                drivingGame();
        }
    }
} 