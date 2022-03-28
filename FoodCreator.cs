using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth; //поле: ширина
        int mapHeight; //поле: высота
        char sym; //поле: еда

        Random random = new Random(); //переменная класса Random

        public FoodCreator(int mapWidth,int mapHeight, char sym) //конструктор для создания еды, использующий поля: ширины, высоты и еды
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood() //метод создания еды в случайной точке
        {
            int x = random.Next(2, mapWidth - 2); //задает случайное значение переменной с помощью рандома в пределах ширины
            int y = random.Next(2, mapHeight - 2); //задает случайное значение переменной с помощью рандома в пределах высоты
            return new Point(x, y, sym); //создает и возвращает новую точку, подставляя значение в конструктор Point
        }
    }
}
