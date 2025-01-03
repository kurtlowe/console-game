﻿namespace ConsoleProject;

internal class MainGameLoop
{
    
    public int X = 1; //int that supplies cursor position value
    public int Y = 1;

    public void gameLoop(MapManager screenInfo) 
    {
        Console.SetCursorPosition(X, Y); //sets cursor position to value of X & Y and prints @ at cords
        Console.Write("@");

        while (true)
        {
            var key = Console.ReadKey(true); //waits and reads the key the user inputs into the console without typing the char into the console
            if (key.Key == ConsoleKey.W) { movePlayer(X, Y - 1); }
            if (key.Key == ConsoleKey.A) { movePlayer(X - 1, Y); }
            if (key.Key == ConsoleKey.S) { movePlayer(X, Y + 1); }
            if (key.Key == ConsoleKey.D) { movePlayer(X + 1, Y); }
            if (key.Key == ConsoleKey.Escape) // breaks out of loop if esc is pressed
            {
                break;
            }
          //  Map1Teleport();
        }
    }

    public void movePlayer(int newX, int newY) //stops the game crashing when reaching edges of the console
    {
        if (newX < 0 || newY < 0) { return; }
        Console.SetCursorPosition(X, Y);
        Console.Write(" ");
        X = newX;
        Y = newY;
        Console.SetCursorPosition(X, Y);
        Console.Write("@");
    }

   /* public void Map1Teleport() // clears console and prints map 2 into the console when desiered cords are reached
    {
        if (X == 25 && Y == 10) {
            Console.Clear();
            Map2 Generate = new Map2();
            Generate.Map2Generation();
            Console.SetCursorPosition(X, Y);
            Console.Write("@");
        }
    }*/
}
