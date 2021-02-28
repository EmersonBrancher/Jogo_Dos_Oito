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
        string returnValidation;
        int xUserLocation = -1;
        int yUserLocation = -1;

        inputMove.ToUpper();

        for (int xAxis = 0; xAxis < Math.Sqrt(boardGameShuffle.Length); xAxis++)
        {
            for (int yAxis = 0; yAxis < Math.Sqrt(boardGameShuffle.Length); yAxis++)
            {
                if (boardGameShuffle[xAxis,yAxis].Equals("-"))
                {
                    xUserLocation = xAxis;
                    yUserLocation = yAxis;
                }
            }            
        }     

        if (xUserLocation == 0 && yUserLocation == 0)
        {
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation + 1], 0);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation + 1, yUserLocation], 1);
        } 
        else if (xUserLocation == 0 && yUserLocation == 1)
        {
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation - 1], 0);            
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation + 1], 1);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation + 1, yUserLocation], 2);
        }
        else if (xUserLocation == 0 && yUserLocation == 2)
        {
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation - 1], 0);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation + 1, yUserLocation], 1);
        }        
        else if (xUserLocation == 1 && yUserLocation == 0)
        {
            allowedMoves.SetValue(boardGameShuffle[xUserLocation - 1, yUserLocation], 0);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation + 1, yUserLocation], 1);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation + 1], 2);
        }
        else if (xUserLocation == 1 && yUserLocation == 1)
        {
            allowedMoves.SetValue(boardGameShuffle[xUserLocation - 1, yUserLocation], 0);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation + 1, yUserLocation], 1);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation - 1], 2);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation + 1], 3);
        }
        else if (xUserLocation == 1 && yUserLocation == 2)
        {
            allowedMoves.SetValue(boardGameShuffle[xUserLocation - 1, yUserLocation], 0);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation - 1], 1);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation + 1, yUserLocation], 2);
        }
        else if (xUserLocation == 2 && yUserLocation == 0)
        {
            allowedMoves.SetValue(boardGameShuffle[xUserLocation - 1, yUserLocation], 0);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation + 1], 1);
        }
        else if (xUserLocation == 2 && yUserLocation == 1)
        {
            allowedMoves.SetValue(boardGameShuffle[xUserLocation - 1, yUserLocation], 0);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation - 1], 1);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation + 1], 2);
        }
        else if (xUserLocation == 2 && yUserLocation == 2)
        {           
            allowedMoves.SetValue(boardGameShuffle[xUserLocation - 1, yUserLocation], 0);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation - 1], 1);
        }

        if (Array.IndexOf(allowedMoves, inputMove) > -1)
        {
            for (int xAxis = 0; xAxis < Math.Sqrt(boardGameShuffle.Length); xAxis++)
            {
                for (int yAxis = 0; yAxis < Math.Sqrt(boardGameShuffle.Length); yAxis++)
                {
                    if (boardGameShuffle[xAxis,yAxis] == inputMove )
                    {   
                        boardGameShuffle.SetValue("-", xAxis, yAxis);
                        boardGameShuffle.SetValue(inputMove, xUserLocation, yUserLocation);                       
                        break;
                    }
                }
            }
        } else if (inputMove.ToUpper() == "SAIR")
        {
            returnValidation = "SAIR";
            return returnValidation;
        }
        else
        {
            Console.WriteLine("Movimento inválido.");
        }
        return null;
    }
}
