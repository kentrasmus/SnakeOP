using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOP
{
    class HorizontalLine : Figure
    {
        

        public HorizontalLine(int XLeft, int xRight, int y, char symb)
        {
            pointList = new List<Point>();

            for(int i = XLeft; i<= xRight; i++)
            {
                Point p = new Point(i, y, symb);
                pointList.Add(p);
            }
            
        }

        
    }
}
