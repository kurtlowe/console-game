using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    internal class DialogWelcome
    {
        public void DialogWelcomeText() 
        {
            Console.Clear();

            Console.WriteLine("Pleas Enter Your Player Name:  ");
            string PlayerName = Console.ReadLine();

            Console.WriteLine("Welcome: " + PlayerName);
        }
    }
}
