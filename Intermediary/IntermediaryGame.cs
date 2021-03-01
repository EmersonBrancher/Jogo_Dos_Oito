using System;

public class IntermediaryGame 
{
    public static void ConsoleBoard()
    {
        string move;
        int counterMove = 0;
        IntermediaryBoardGame boardGame = new IntermediaryBoardGame();

        boardGame.PopulateBoardGame();

        if (boardGame.ValidadeIntermediaryBoardSolution())
        {
        }
        else
        {
            do
            {
                boardGame.WriteIntermediaryBoardGame();
                move = Console.ReadLine();
                if (MainFunction.ValidateMove(move.ToUpper(), boardGame.intermediaryBoardGameShuffle) == "SAIR")
                {
                    break;
                } 
                else 
                {
                    counterMove++;
                }
            }
            while(boardGame.ValidadeIntermediaryBoardSolution() == false);
            boardGame.WriteIntermediaryBoardGame();
            Console.WriteLine($"Quantidade de movimento: {counterMove}");
                        
        }
    }

}

