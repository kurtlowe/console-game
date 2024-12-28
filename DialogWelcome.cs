using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject;

internal class DialogWelcome
{
    public void DialogWelcomeText() 
    {
        Console.WriteLine("Pleas Enter Your Player Name:  ");
        string PlayerName = Console.ReadLine();

        Console.Clear();

        Console.WriteLine("Welcome: " + PlayerName);
    }
}
