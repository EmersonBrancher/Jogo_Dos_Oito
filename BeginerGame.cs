using System;

public class BeginerGame 
{
    public static void ConsoleBoard()
    {
        string move;
        int counterMove = 0;
        BeginerBoardGame boardGame = new BeginerBoardGame();

        boardGame.PopulateBoardGame();

        if (boardGame.ValidadeBeginerBoardSolution())
        {
        }
        else
        {
            do
            {
                boardGame.WriteBeginerBoardGame();
                move = Console.ReadLine();
                if (MainFunction.ValidateMove(move.ToUpper(), boardGame.beginerBoardGameShuffle) == "SAIR")
                {
                    break;
                } 
                else 
                {
                    counterMove++;
                }
            }
            while(boardGame.ValidadeBeginerBoardSolution() == false);
            boardGame.WriteBeginerBoardGame();
            Console.WriteLine($"Quantidade de movimento: {counterMove}");
                        
        }
    }

}

