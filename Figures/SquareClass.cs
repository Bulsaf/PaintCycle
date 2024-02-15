using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art.Figures
{
    internal class SquareClass:RectangleClass
    {
        public int x;
        public int y;
        public int width;
        public SquareClass(int x, int y, int width) : base(x ,y, width , width)
        {
            this.x = x;
            this.y = y;
            this.width = width;
        }
        public override void Draw()
        {
            if (x > Init.pictureBox.Width || y > Init.pictureBox.Height || x + width > Init.pictureBox.Width || y + width > Init.pictureBox.Height)
            {
                MessageBox.Show("Выход за границы!");
                return;
            }
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(Init.pen, this.x, this.y, this.width, this.width);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y)
        {
            if (!((this.x + x < 0 && this.y + y < 0)
                || (this.y + y < 0)
                || (this.x + x > Init.pictureBox.Width && this.y + y < 0)
                || (this.x + this.width + x > Init.pictureBox.Width)
                || (this.x + x > Init.pictureBox.Width && this.y + y > Init.pictureBox.Height)
                || (this.y + this.width + y > Init.pictureBox.Height)
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
