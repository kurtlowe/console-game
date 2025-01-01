using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
