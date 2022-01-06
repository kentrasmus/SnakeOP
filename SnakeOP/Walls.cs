using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOP
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            wallList = new List<Figure>();
            HorizontalLine top = new HorizontalLine(0, 80, 0, '#');           
            VerticalLine left = new VerticalLine(0, 25, 0, '#');            
            HorizontalLine bottom = new HorizontalLine(0, 80, 25, '$');           
            VerticalLine right = new VerticalLine(0, 25, 80, '$');

            VerticalLine obstacle = new VerticalLine(10, 13, 50, '%');
            VerticalLine obstacles = new VerticalLine(12, 16, 60, '%');
            wallList.Add(top);
            wallList.Add(left);
            wallList.Add(bottom);
            wallList.Add(right);
            wallList.Add(obstacle);
            wallList.Add(obstacles);

        }
        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
        public bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if (wall.ISHit(figure))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
