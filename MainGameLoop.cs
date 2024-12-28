using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject;
internal class MainGameLoop
{
    public void GameLoop() 
    {

        var X = 10; var Y = 10;

        Console.SetCursorPosition(X, Y);
        Console.WriteLine("@");

        while (true)
        {
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.A) // Left Movement
            {
                Console.SetCursorPosition(X, Y);
                Console.WriteLine(" ");
                X--;
                Console.SetCursorPosition(X, Y);
                Console.WriteLine("@");
            }
            if (key.Key == ConsoleKey.D) // Right Movement
            {
                Console.SetCursorPosition(X, Y);
                Console.WriteLine(" ");
                X++;
                Console.SetCursorPosition(X, Y);
                Console.WriteLine("@");
            }
            if (key.Key == ConsoleKey.W) // Up Movement
            {
                Console.SetCursorPosition(X, Y);
                Console.WriteLine(" ");
                Y--;
                Console.SetCursorPosition(X, Y);
                Console.WriteLine("@");
            }
            if (key.Key == ConsoleKey.S) // Down Movement
            {
                Console.SetCursorPosition(X, Y);
                Console.WriteLine(" ");
                Y++;
                Console.SetCursorPosition(X, Y);
                Console.WriteLine("@");
            }
            if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
        }
    }
}

