using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pList; //поле типа List, в котором будут содержаться значения типа(класса) Point

        public void Draw() //метод рисовки точек
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure) //метод для проверки столкновения, который берет объект типа(класса) Figure
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point) //метод для проверки столкновения который берет объект типа(класса) Point и возвращает значение bool
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
