using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOP
{
    class Figure
    {
      protected List<Point> pointList;


        public void Draw()
        {
            foreach (Point point in pointList)
            {
                point.Draw();
            }
        }
        public bool ISHit(Figure figure)
        {
            foreach(var point in pointList)
            {
                if (figure.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsHit(Point point)
        {
            foreach(var p in pointList)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
