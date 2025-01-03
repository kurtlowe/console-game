namespace ConsoleProject;

internal class Dialog
{
    private string _playerName = "";

    public void DialogWelcomeText() 
    {
        Console.WriteLine("Pleas Enter Your Player Name:  ");
        _playerName = Console.ReadLine() ?? "";
    }

    public void DialogPlayerName()
    {
        Console.WriteLine("Welcome: " + _playerName);
    }
}