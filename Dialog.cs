namespace ConsoleProject;

internal class Dialog
{
    static string PlayerName;
    public void DialogWelcomeText() 
    {
        Console.WriteLine("Pleas Enter Your Player Name:  ");
        PlayerName = Console.ReadLine();

        Console.Clear();
    }

    public void DialogPlayerName()
    {
        Console.WriteLine("Welcome: " + PlayerName);
    }
}