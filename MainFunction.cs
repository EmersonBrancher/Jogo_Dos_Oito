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
        double boardGameLenght = Math.Sqrt(boardGameShuffle.Length);

        inputMove.ToUpper();

        for (int xAxis = 0; xAxis < boardGameLenght; xAxis++)
        {
            for (int yAxis = 0; yAxis < boardGameLenght; yAxis++)
            {
                if (boardGameShuffle[xAxis,yAxis].Equals("-"))
                {
                    xUserLocation = xAxis;
                    yUserLocation = yAxis;
                }
            }            
        }     


        if (inputMove == "SAIR")
        {
        }
        else if (xUserLocation == 0 && yUserLocation == 0)
        {
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation + 1], 0);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation + 1, yUserLocation], 1);
        }                    
        else if (xUserLocation == 1 && yUserLocation == 1)
        {
            allowedMoves.SetValue(boardGameShuffle[xUserLocation - 1, yUserLocation], 0);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation + 1, yUserLocation], 1);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation - 1], 2);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation + 1], 3);
        }
        else if ((xUserLocation == yUserLocation && yUserLocation + 1 == boardGameLenght) || (xUserLocation == 3 && yUserLocation == 3) || (xUserLocation == 2 && yUserLocation == 2))
        {         
            allowedMoves.SetValue(boardGameShuffle[xUserLocation - 1, yUserLocation], 0);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation - 1], 1);
            if (boardGameLenght >= 4 && (xUserLocation != 4 && yUserLocation != 4) && !(xUserLocation == 3 && yUserLocation == 3 && boardGameLenght == 4))
            {
                allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation + 1], 2);
                allowedMoves.SetValue(boardGameShuffle[xUserLocation + 1, yUserLocation], 3);            
            }
        }        
        else if ((xUserLocation == 2 && yUserLocation == 0) || (xUserLocation == 3 && yUserLocation == 0) ||(xUserLocation == 4 && yUserLocation == 0))
        {
            allowedMoves.SetValue(boardGameShuffle[xUserLocation - 1, yUserLocation], 0);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation + 1], 1);
            if (boardGameLenght >= 4 && xUserLocation != 4 && !(xUserLocation == 3 && yUserLocation == 0))
            {
                allowedMoves.SetValue(boardGameShuffle[xUserLocation + 1, yUserLocation], 2);
            }
        }        
        else if ((xUserLocation == 0 && yUserLocation == 2) || (xUserLocation == 0 && yUserLocation == 3) || (xUserLocation == 0 && yUserLocation == 4))
        {
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation - 1], 0);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation + 1, yUserLocation], 1);
            if (boardGameLenght >= 4 && !(xUserLocation == 0 && yUserLocation == 3 && boardGameLenght == 4) && !(xUserLocation == 0 && yUserLocation == 4))
            {
                allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation + 1], 2);                
            }
        }            
        else if ((xUserLocation == 1 && yUserLocation == 2) || (xUserLocation == 1 && yUserLocation == 3) || (xUserLocation == 2 && yUserLocation == 3) || (xUserLocation == 1 && yUserLocation == 4) || (xUserLocation == 2 && yUserLocation == 4) || (xUserLocation == 3 && yUserLocation == 4))
        {           
            allowedMoves.SetValue(boardGameShuffle[xUserLocation - 1, yUserLocation], 0);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation - 1], 1);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation + 1, yUserLocation], 2); 
            if (boardGameLenght >= 4 && yUserLocation != 4 && !(xUserLocation == 1 && yUserLocation == 3) && !(xUserLocation == 2 && yUserLocation == 3))
            {  
                allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation + 1], 3);
            }
        }        
        else if (xUserLocation == 1 && yUserLocation == 0)
        {
            allowedMoves.SetValue(boardGameShuffle[xUserLocation - 1, yUserLocation], 0);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation + 1, yUserLocation], 1);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation + 1], 2);
        }            
        else if (xUserLocation == 0 && yUserLocation == 1)
        {
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation - 1], 0);            
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation + 1], 1);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation + 1, yUserLocation], 2);
        }          
        else if ((xUserLocation == 2 && yUserLocation == 1) || (xUserLocation == 3 && yUserLocation == 1) || (xUserLocation == 3 && yUserLocation == 2) || (xUserLocation == 4 && yUserLocation == 1) || (xUserLocation == 4 && yUserLocation == 2) || (xUserLocation == 4 && yUserLocation == 3))
        {
            allowedMoves.SetValue(boardGameShuffle[xUserLocation - 1, yUserLocation], 0);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation - 1], 1);
            allowedMoves.SetValue(boardGameShuffle[xUserLocation, yUserLocation + 1], 2);
            if ((boardGameLenght >= 4 && xUserLocation != 4) && !(xUserLocation == 3 && yUserLocation == 1 && boardGameLenght == 4) && !(xUserLocation == 3 && yUserLocation == 2)) 
            {
                allowedMoves.SetValue(boardGameShuffle[xUserLocation + 1, yUserLocation], 3);
            }
        } 

        if (Array.IndexOf(allowedMoves, inputMove) > -1)
        {
            for (int xAxis = 0; xAxis < boardGameLenght; xAxis++)
            {
                for (int yAxis = 0; yAxis < boardGameLenght; yAxis++)
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

    public static string WriteHowToPlay()
    {
        Console.WriteLine("Seja bem vindo.");
        Console.WriteLine("Para iniciar, deverá ser informado o nível de dificuldade desejada.");
        Console.WriteLine("Ao iniciar o jogo, deverá ser considerado o - (hífen) como o espaço vazio.");        
        Console.WriteLine("Deverá ser informado o valor da letra que deseja mover para que ocorra a movimentação.");
        Console.WriteLine("Só sera aceito as letras nas direções cardeais, sendo a primeira letra de cada direção.");
        Console.WriteLine("Caso queira sair do jogo, poderá ser digitado o comando (sair).");
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadLine();
        return null;

    }    


}
