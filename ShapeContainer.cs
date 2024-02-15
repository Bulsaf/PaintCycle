using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Art.Figures;

namespace Art
{
    internal static class ShapeContainer
    {
        public static List<Figure> shapeContainer;
        public static void AddFigure(Figure figure)
        {
            if(shapeContainer == null)
            {
                shapeContainer = new List<Figure>();
            }
            shapeContainer.Add(figure);
        }
    }
}
