using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art.Figures
{
    internal class PolygonClass : Figure
    {
        public int count = 0;
        public Point[] polygonPoints;
        public PolygonClass() 
        {
            count = 0;
        }
        public PolygonClass(int count, Point[] polygonPoints)
        {
            this.count = count;
            this.polygonPoints = polygonPoints;
        }

        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawPolygon(Init.pen, this.polygonPoints);
            Init.pictureBox.Image = Init.bitmap;
        }

        public override void MoveTo(int x, int y)
        {
            if (RangeCheck(x, y))
            {
                for (int i = 0; i < polygonPoints.Length; i++)
                {
                    polygonPoints[i].X += x;
                    polygonPoints[i].Y += y;
                }
            }
            this.DeleteFigure(false);
            this.Draw();
        }
        public bool RangeCheck(int x, int y)
        {
            bool flag = true;
            for (int i = 0; i < polygonPoints.Length; i++)
            {
                if (!(polygonPoints[i].X + x < 0 && polygonPoints[i].Y + y < 0)
                || (polygonPoints[i].Y + y < 0)
                || (polygonPoints[i].X + x < 0)
                || (polygonPoints[i].X + x > Init.pictureBox.Width && polygonPoints[i].Y + y < 0)
                || (polygonPoints[i].X + x > Init.pictureBox.Width && polygonPoints[i].Y + y > Init.pictureBox.Height)
                || (polygonPoints[i].X + x < 0 && polygonPoints[i].Y + y > Init.pictureBox.Height))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
