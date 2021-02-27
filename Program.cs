using System;

namespace JogoDosOito
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                choice = MainMenu.WriteMenu();
                switch (choice)
                {
                    case "1":
                        IntermediaryGame.ConsoleBoard();
                        break;
                    case "2":
                        Console.WriteLine("Escolheu 2");
                        break;
                    case "3":
                        Console.WriteLine("Escolheu 3");
                        break;
                    case "4":
                        Console.WriteLine("Escolheu 4");
                        break;
                    default:
                        choice = "Done";
                        Console.WriteLine("Até logo.");
                        break;                                                            
                }
            } while (choice != "Done");
        }
    }
}