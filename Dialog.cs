namespace ConsoleProject;

internal class dialog
{
    string playerName;
    public void dialogWelcomeText() 
    {
        Console.WriteLine("Pleas Enter Your Player Name:  ");
        playerName = Console.ReadLine();

        Console.Clear();
    }

    public void dialogPlayerName()
    {
        Console.WriteLine("Welcome: " + playerName);
    }
}