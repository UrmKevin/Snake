using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class GameOver
    {
        public void WriteGameOver() //метод, который пишет в конце игры что-то типа "GameOver"
        {
            int xOffset = 25; //кординаты по x
            int yOffset = 8; //кординаты по y
            Console.ForegroundColor = ConsoleColor.Red; //цвет текста
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=", xOffset, yOffset++); //текст
            WriteText("G A M E   O V E R !", xOffset + 5, yOffset++);
            yOffset++;
            WriteText("Creator : Kevin Urm", xOffset + 5, yOffset++);
            WriteText("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=", xOffset, yOffset++);
        }

        public void WriteText(String text, int xOffset, int yOffset) //метод написание текста в определенной позиции
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
