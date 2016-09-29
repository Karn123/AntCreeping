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
    /// </summary>
    class PlayRoom
    {
        public bool isStart = false;
        public const int MAXLENGTH = 300;
        public Toward toward;
        public CreepingGame creeepingGame;
        public Hashtable ht;
        public int pos_1 = 30;
        public int pos_2 = 80;
        public int pos_3 = 110;
        public int pos_4 = 160;
        public int pos_5 = 250;
        public int default_velocity = 5;

        public PlayRoom()
        {
            creeepingGame = new CreepingGame();
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
            MainPicture.GetInstance().DrawAnt(pos, dir);
            Ant ant = new Ant(pos, dir, default_velocity);
            ht.Add(pos, ant);
        }
        public void PlayGames()
        {
            Random rd = new Random();

            MainPicture.GetInstance().Clear();
            MainPicture.GetInstance().DrawStick(MAXLENGTH);
            for (int i = 0; i < 2; i++)
            {
                toward = setDirection(i);
                addAnt(pos_1, toward);
                for (int j = 0; j < 2; j++)
                {
                    toward = setDirection(j);
                    addAnt(pos_2, toward);
                    for (int k = 0; k < 2; k++)
                    {
                        toward = setDirection(k);
                        addAnt(pos_3, toward);
                        for(int l=0;l<2;l++)
                        {
                            toward = setDirection(l);
                            addAnt(pos_4, toward);
                            for (int m = 0; m < 2; m++)
                            {
                                toward = setDirection(m);
                                addAnt(pos_5, toward);
                            }
                        }
                    }
                }
            }
        }
    }
}
