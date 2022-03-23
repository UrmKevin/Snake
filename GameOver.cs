using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class GameOver
    {
        public void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=", xOffset, yOffset++);
            WriteText("G A M E   O V E R !", xOffset + 5, yOffset++);
            yOffset++;
            WriteText("Creator : Kevin Urm", xOffset + 5, yOffset++);
            WriteText("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=", xOffset, yOffset++);
        }

        public void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }
    }
}
