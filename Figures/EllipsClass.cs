using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art.Figures
{
    internal class EllipsClass : Figure
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public EllipsClass(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public EllipsClass()
        {
            this.x = 0;
            this.y = 0;
            this.width = 0;
            this.height = 0;
        }
        public override void Draw()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawEllipse(Init.pen, this.x, this.y, this.width, this.height);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y)
        {
            if (!((this.x + x < 0 && this.y + y < 0)
                || (this.y + y < 0)
                || (this.x + x > Init.pictureBox.Width && this.y + y < 0)
                || (this.x + this.width + x > Init.pictureBox.Width)
                || (this.x + x > Init.pictureBox.Width && this.y + y > Init.pictureBox.Height)
                || (this.y + this.height + y > Init.pictureBox.Height)
                || (this.x + x < 0 && this.y + y > Init.pictureBox.Height) || (this.x + x < 0)))
            {
                this.x += x;
                this.y += y;
                this.DeleteFigure(false);
                this.Draw();
            }
        }
    }
}
