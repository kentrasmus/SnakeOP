﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 10, '*');           

            Point p2 = new Point(11, 10, '*');
                       

            HorizontalLine hLine = new HorizontalLine(10, 15, 5, '*');
           // hLine.Draw();
            VerticalLine vLine = new VerticalLine(6, 16, 10, '@');
           // vLine.Draw();

            //DRAWING A GAME FIELD FRAME
            HorizontalLine top = new HorizontalLine(0, 80, 0, '#');
            top.Draw();
            VerticalLine left = new VerticalLine(0, 25, 0, '#');            
            left.Draw();
            HorizontalLine bottom = new HorizontalLine(0, 80, 25, '$');
            bottom.Draw();
            VerticalLine right = new VerticalLine(0, 25, 80, '$');
            right.Draw();

            Point snakeTail = new Point(15, 15, 's');
            Snake snake = new Snake(snakeTail, 5, Direction.RIGHT);
            snake.Draw();
            snake.Move();

            for(int i = 0; i < 10; i++)
            {
                Thread.Sleep(300);
                snake.Move();
            }

            Console.ReadLine();
        }
        
    }
}
