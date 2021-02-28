using System;

class MainFunction
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

    public static string ValidateMove(string inputMove, string[,] boardGameShuffle)
    {
        string [] allowedMoves = new string [25];
        int xUserLocation = -1;
        int yUserLocation = -1;

        inputMove.ToUpper();
Console.WriteLine("Passou as declarações");
        for (int xAxis = 0; xAxis < boardGameShuffle.Length; xAxis++)
        {
            for (int yAxis = 0; yAxis < boardGameShuffle.Length; yAxis++)
            {
Console.WriteLine("lado de fora do primeiro if");
                if (boardGameShuffle[xAxis,yAxis].Equals(" "))
                {
                    xUserLocation = xAxis;
                    yUserLocation = yAxis;
Console.WriteLine("lado de dentro do primeiro if");                    
                }
            }
Console.WriteLine("lado de fora do primeiro par de loop");
            
        }     

        for (int xAxis = 0; xAxis < boardGameShuffle.Length; xAxis++)
        {
            allowedMoves[xAxis] = boardGameShuffle[xAxis, yUserLocation];
        }

        if (Array.IndexOf(allowedMoves, inputMove) > -1)
        {
            for (int xAxis = 0; xAxis < boardGameShuffle.Length; xAxis++)
            {
                for (int yAxis = 0; yAxis < boardGameShuffle.Length; yAxis++)
                {
                    if (boardGameShuffle[xAxis,yAxis] == inputMove )
                    {
                        boardGameShuffle[yAxis,yAxis] = " ";
                        boardGameShuffle[xUserLocation, yUserLocation] = inputMove;
                        break;
                    }
                }
            }

        } else 
        {
            Console.WriteLine("Movimento inválido.");
        }
        
        return null;


    }

}
