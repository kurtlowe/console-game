namespace ConsoleProject;

internal class MainGameLoop
{
    public int X = 1; //int that supplies cursor position value
    public int Y = 1;

    public void GameLoop() 
    {
        Console.SetCursorPosition(X, Y); //sets cursor position to value of X & Y and prints @ at cords
        Console.Write("@");

        while (true)
        {
            var key = Console.ReadKey(true); //waits and reads the key the user inputs into the console without typing the char into the console
            if (key.Key == ConsoleKey.W) { MovePlayer(X, Y - 1); }
            if (key.Key == ConsoleKey.A) { MovePlayer(X - 1, Y); }
            if (key.Key == ConsoleKey.S) { MovePlayer(X, Y + 1); }
            if (key.Key == ConsoleKey.D) { MovePlayer(X + 1, Y); }
            if (key.Key == ConsoleKey.Escape) // breaks out of loop if esc is pressed
            {
                break;
            }
          //  Map1Teleport();
        }
    }

    public void MovePlayer(int newX, int newY) //stops the game crashing when reaching edges of the console
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


/*
 * 
 * Original main game loop
 * 
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
 */
