using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art.Figures
{
    internal class TriangleClass : Figure
    {
        public int x1, x2, x3;
        public int y1, y2, y3;
        public Point[] trianglePoints;
        public TriangleClass(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            trianglePoints = new Point[]
            {
                new Point(x1,y1),
                new Point(x2,y2),
                new Point(x3,y3)
            };
        }

        public override void Draw()
        {
            for (int i = 0; i < trianglePoints.Length; i++)
            {
                if (trianglePoints[i].X > Init.pictureBox.Width || trianglePoints[i].Y > Init.pictureBox.Height)
                {
                    MessageBox.Show("Выход за границы!");
                    return;
                }
            }
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawPolygon(Init.pen, this.trianglePoints);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo( int x, int y)
        {
            if (RangeCheck(x,y))
            {
                for (int i = 0; i < trianglePoints.Length; i++)
                {
                    trianglePoints[i].X += x;
                    trianglePoints[i].Y += y;
                }
                this.DeleteFigure(false);
                this.Draw();
            }
        }
        public bool RangeCheck(int x, int y)
        {
            bool flag = true;
            for (int i = 0; i < trianglePoints.Length; i++)
            {
                if (!((trianglePoints[i].X + x < 0 && trianglePoints[i].Y + y < 0)
                || (trianglePoints[i].Y + y < 0)
                || (trianglePoints[i].X + x < 0)
                || (trianglePoints[i].X + x > Init.pictureBox.Width)
                || (trianglePoints[i].Y + y > Init.pictureBox.Height)
                || (trianglePoints[i].X + x > Init.pictureBox.Width && trianglePoints[i].Y + y < 0)
                || (trianglePoints[i].X + x > Init.pictureBox.Width && trianglePoints[i].Y + y > Init.pictureBox.Height)
                || (trianglePoints[i].X + x < 0 && trianglePoints[i].Y + y > Init.pictureBox.Height))) {
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
