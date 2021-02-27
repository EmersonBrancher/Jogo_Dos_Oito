using System;

class MainMenu 
{

    
    public static string WriteMenu()
    {
        string choice;

        Console.WriteLine("Seja bem vindo.");
        Console.WriteLine("Digite o número da dificuldade desejada:");
        Console.WriteLine("1 - Iniciante");        
        Console.WriteLine("2 - Intermediário");
        Console.WriteLine("3 - Avançado");
        Console.WriteLine("4 - Como jogar");
        Console.WriteLine("Pressione qualquer outra tecla para sair.");
        choice = Console.ReadLine();

        return choice;

    }    
}
