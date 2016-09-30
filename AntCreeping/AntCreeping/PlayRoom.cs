using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntCreeping
{
    /// <summary>
    /// 如下使用作图函数
    /// MainPicture.GetInstance().Clear();
    /// MainPicture.GetInstance().DrawStick(MAXLENGTH);
    /// MainPicture.GetInstance().DrawAnt(leftPosition, toward);
    /// MainPicture.GetInstance().EndDraw();
    /// </summary>
    class PlayRoom
    {
        public bool isStart = false;
        public const int MAXLENGTH = 500;
        public Toward toward;
        public CreepingGame creeepingGame;
        public List<Ant> antList;
        public Hashtable ht;
        public Stick myStick = new Stick();
        public int pos_1 = 30;
        public int pos_2 = 80;
        public int pos_3 = 110;
        public int pos_4 = 160;
        public int pos_5 = 250;
        public int default_velocity = 5;
        public bool isReady = false;

        public PlayRoom()
        {
            myStick.Length = MAXLENGTH;
            creeepingGame = new CreepingGame();
            antList = new List<Ant>();
            ht = new Hashtable();
        }

        public Toward setDirection(int i)
        {
            if (i == 0)
                return Toward.left;
            else
                return Toward.right;
        }

        public void addAnt(int pos, Toward dir)
        {
            if (ht.ContainsKey(pos))
            {
                Ant toBeRemovedAnt = (Ant)ht[pos];
                antList.Remove(toBeRemovedAnt);
                ht.Remove(pos);
            }
            Ant ant = new Ant(pos, dir, default_velocity);
            ht.Add(pos, ant);
            antList.Add(ant);
        }
        public void drawFiveAnts()
        {
            int pos = 0;
            Toward dir = Toward.left;
            //draw five ants
            for (int i = 1; i <= 5; i++)
            {
                switch (i)
                {
                    case 1:
                        pos = pos_1;
                        break;
                    case 2:
                        pos = pos_2;
                        break;
                    case 3:
                        pos = pos_3;
                        break;
                    case 4:
                        pos = pos_4;
                        break;
                    case 5:
                        pos = pos_5;
                        break;
                    default:
                        break;
                }
                MainPicture.GetInstance().DrawAnt(pos, dir);
            }
        }
        /// <summary>
        /// play all possible games
        /// </summary>
        public void PlayGames()
        {
            Random rd = new Random();

            MainPicture.GetInstance().Clear();
            MainPicture.GetInstance().DrawStick(MAXLENGTH);
            drawFiveAnts();
            MainPicture.GetInstance().EndDraw();
            //set each ant's direction
            for (int i = 0; i < 2; i++)
            {
                toward = setDirection(i);
                addAnt(pos_1, toward);
                //Console.WriteLine("1");
                for (int j = 0; j < 2; j++)
                {
                    toward = setDirection(j);
                    addAnt(pos_2, toward);
                    //Console.WriteLine("2");
                    for (int k = 0; k < 2; k++)
                    {
                        toward = setDirection(k);
                        addAnt(pos_3, toward);
                        //Console.WriteLine("3");
                        for (int l = 0;l < 2;l++)
                        {
                            toward = setDirection(l);
                            addAnt(pos_4, toward);
                            //Console.WriteLine("4");
                            for (int m = 0; m < 2; m++)
                            {
                                toward = setDirection(m);
                                addAnt(pos_5, toward);
                                //Console.WriteLine("5");
                                creeepingGame.SetListAndStick(antList,myStick);
                                isReady = true;
                                creeepingGame.IsGameOver = false;
                                while (isReady == true)
                                {
                                    //Console.WriteLine(isReady);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}