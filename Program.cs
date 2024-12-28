namespace ConsoleProject;

internal class Program
{
    static void Main(string[] args)
    {
        DialogWelcome Greeting = new DialogWelcome();
        Greeting.DialogWelcomeText();

        Map1 Generate = new Map1();
        Generate.Map1Generation();

        MainGameLoop GameStart = new MainGameLoop();
        GameStart.GameLoop();
    }
}