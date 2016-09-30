using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;

namespace AntCreeping
{
    class CreepingGame
    {
        private bool isGameOver=false;
        private List<Ant> antList;
        private Stick antStick;
        private Hashtable antHt = new Hashtable();
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
                for(int i=0;i<antList.Count;i++)
                {
                    Ant  ant = antList[i];
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
            }
        }
        public void SetListAndStick(List<Ant> myAntList, Stick myStick)
        {
            AntList = myAntList;
            AntStick = myStick;
        }
    }
} 