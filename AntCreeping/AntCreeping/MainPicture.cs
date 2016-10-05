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
    public enum Toward { left, right };

    /// <summary>
    /// please GetInstance() first
    /// </summary>
    public class MainPicture
    {
        private static MainPicture instance = null;
        public Bitmap originBmp = null;
        public Bitmap finishingBmp = null;
        private Graphics mainPictureGraphics = null;
        private Color nowColor;
        private Point startPoint;
        private int antWidth = 5;
        private int boxWidth = 0;
        private int boxHeight = 0;
        MainPicture()
        {
        }

        /// <summary>
        /// use SetGraphics() after get instance
        /// </summary>
        /// <returns></returns>
        public static MainPicture GetInstance()
        {
            if (instance == null)
            {
                instance = new MainPicture();
                instance.Initialize();
            }
            return instance;
        }

        public void SetGraphics(Graphics graphics, Bitmap bmp, int boxWidth, int boxHeight)
        {
            mainPictureGraphics = graphics;
            finishingBmp = (Bitmap)bmp.Clone();
            originBmp = (Bitmap)bmp.Clone();
            this.boxWidth = boxWidth;
            this.boxHeight = boxHeight;
        }

        protected void Initialize()
        {
            instance.nowColor = Color.Black;
            startPoint = new Point(100, 100);
        }

        public void Release()
        {
            mainPictureGraphics.Dispose();
            mainPictureGraphics = null;
            //instance = null;
        }

        public void DrawStick(int length)
        {
            MyDrawLine(length);
        }

        public void DrawAnt(float leftPosition, Toward toward)
        {
            MyDrawCircle(leftPosition);
        }

        protected void MyDrawLine(int length)
        {
            Graphics g = Graphics.FromImage(finishingBmp);
            Pen p = new Pen(nowColor, antWidth);
            g.DrawLine(p, startPoint.X, startPoint.Y, startPoint.X + length, startPoint.Y);
            g.Dispose();
            p.Dispose();
        }

        protected void MyDrawCircle(float leftPosition)
        {
            Graphics g = Graphics.FromImage(finishingBmp);
            Pen p = new Pen(nowColor, antWidth);
            g.DrawEllipse(p, startPoint.X + leftPosition, startPoint.Y - antWidth * 2, antWidth, antWidth);
            g.Dispose();
            p.Dispose();
        }

        public void EndDraw()
        {
            //为了让完成后的绘图过程保留下来，要将中间图片绘制到原始画布上
            //Graphics tempGraphics = Graphics.FromImage(originBmp);
            //tempGraphics.DrawImage(finishingBmp, 0, 0);
            //tempGraphics.Dispose();
            mainPictureGraphics.DrawImage(finishingBmp, new Point(0, 0));
        }

        public void Clear()
        {
            Graphics g = Graphics.FromImage(finishingBmp);
            g.Clear(Color.White);
            g.Dispose();
        }
    }
}