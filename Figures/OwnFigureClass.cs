using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Art.Figures
{
    internal class OwnFigureClass : Figure
    {
        public RectangleClass rectangle;
        public TriangleClass triangle;
        public EllipsClass ellips1;
        public EllipsClass ellips2;
        public int x, y;
        public int width, height;
        public OwnFigureClass(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public override void Draw()
        {
            rectangle = new RectangleClass(x,y,width,height/2);
            ellips1 = new EllipsClass(x,y,width/2,height/2);
            ellips2 = new EllipsClass(x+width/2,y,width/2,height/2);
            triangle = new TriangleClass(x,y + height/2,x+width/2,y+height,x+width,y+height/2);
            rectangle.Draw();
            ellips1.Draw();
            ellips2.Draw();
            triangle.Draw();
        }

        public override void MoveTo(int x, int y)
        {
            if (!((this.x + x < 0 && this.y + y < 0)
                || (this.y + y < 0)
                || (this.x + x > Init.pictureBox.Width && this.y + y < 0)
                || (this.x + this.width + x > Init.pictureBox.Width)
                || (this.x + x > Init.pictureBox.Width && this.y + y > Init.pictureBox.Height)
                || (this.y + this.height + y > Init.pictureBox.Height)
                || (this.x + x < 0 && this.y + y > Init.pictureBox.Height)
                || (this.x + x < 0)))
            {
                this.x += x;
                this.y += y;
                DeleteFigure(false);
                Draw();
            }
        }
    }
}
