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
                choice = MainFunction.WriteMenu();
                switch (choice)
                {
                    case "1":
                        BeginnerGame.ConsoleBoard();
                        break;
                    case "2":
                        IntermediaryGame.ConsoleBoard();
                        break;
                    case "3":
                        AdvancedGame.ConsoleBoard();
                        break;
                    case "4":
                        MainFunction.WriteHowToPlay();
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