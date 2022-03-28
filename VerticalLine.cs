﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure // класс типа наследования
    {
        public VerticalLine(int yUp, int yDown, int x, char sym) //конструктор создания линий
        {
            pList = new List<Point>();
            for (int y = yUp; y < yDown; y++) 
			{
                Point p = new Point(x, y, sym);
                pList.Add(p);
			}

        }
    }
}
