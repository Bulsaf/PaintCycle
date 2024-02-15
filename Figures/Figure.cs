using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Art.Figures
{
    abstract public class Figure
    {
        protected int x;
        protected int y;
        protected int width;
        protected int height;
        abstract public void Draw();
        abstract public void MoveTo(int x, int y);
        public void DeleteFigure(bool flag = true)
        {
            if (flag == true)
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer.shapeContainer.Remove(this);
                this.Clear();
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer.shapeContainer)
                {
                    f.Draw();
                }
            }
            else
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                ShapeContainer.shapeContainer.Remove(this);
                this.Clear();
                Init.pictureBox.Image = Init.bitmap;
                foreach (Figure f in ShapeContainer.shapeContainer)
                {
                    f.Draw();
                }
                ShapeContainer.shapeContainer.Add(this);
            }
        }
        public void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
        }
    }
}
