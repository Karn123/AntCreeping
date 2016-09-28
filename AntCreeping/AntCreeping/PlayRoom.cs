using System;
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
        public const int MAXLENGTH = 500;
        public Toward toward;

        public void PlayGames()
        {
            Random rd = new Random();

            MainPicture.GetInstance().Clear();
            MainPicture.GetInstance().DrawStick(MAXLENGTH);

            for (int i = 0; i < 5; i++)
            {
                int leftPosition = rd.Next(MAXLENGTH);

                switch (rd.Next(2))
                {
                    case 0:
                        toward = Toward.left;
                        break;
                    case 1:
                        toward = Toward.right;
                        break;
                    default:
                        Console.WriteLine("PlayRoom #1#");
                        break;
                }
                MainPicture.GetInstance().DrawAnt(leftPosition, toward);
            }
        }
    }
}
