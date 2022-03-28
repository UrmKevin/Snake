using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x; //поле значение x 
        public int y; //поле значение y
        public char sym; //поле символа

        public Point() { } // пустой конструктор

        public Point(int _x, int _y, char _sym) //конструктор с кординатами и символом
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p) //конструктор который обновляет значения объекта типа Point
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction) //метод движения
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public bool IsHit(Point p) //метод поедание еды
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Draw() //метод отрисовки точек
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear() //метод для очистки
        {
            sym = ' ';
            Draw();
        }
        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
