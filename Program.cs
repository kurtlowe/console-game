namespace ConsoleProject; // Make sure to use ; instead of {} due to it being outdated

internal class Program
{
    static void Main(string[] args)
    {
        DialogWelcome Greeting = new DialogWelcome(); // Calling and instance of a method from a different class
        Greeting.DialogWelcomeText();

        Map1 Generate = new Map1();
        Generate.Map1Generation();

        MainGameLoop GameStart = new MainGameLoop();
        GameStart.GameLoop();
    }
}