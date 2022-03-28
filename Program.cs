using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(800, 250); //размер окна

            Snake score = new Snake();
            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*'); //расположение змейки
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$'); //создаёт еду в случайном месте
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true) //основа
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    score.Output();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            GameOver gameOver = new GameOver();
            gameOver.WriteGameOver(); //конец игры
            score.Output_2();
            Console.ReadLine();
        }
    }
}
