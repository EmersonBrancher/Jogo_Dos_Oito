using System;

public class AdvancedGame 
{
    public static void ConsoleBoard()
    {
        string move;
        int counterMove = 0;
        AdvancedBoardGame boardGame = new AdvancedBoardGame();

        boardGame.PopulateBoardGame();

        if (boardGame.ValidadeAdvancedBoardSolution())
        {
        }
        else
        {
            do
            {
                boardGame.WriteAdvancedBoardGame();
                move = Console.ReadLine();
                if (MainFunction.ValidateMove(move.ToUpper(), boardGame.advancedBoardGameShuffle) == "SAIR")
                {
                    break;
                } 
                else 
                {
                    counterMove++;
                }
            }
            while(boardGame.ValidadeAdvancedBoardSolution() == false);
            boardGame.WriteAdvancedBoardGame();
            Console.WriteLine($"Quantidade de movimento: {counterMove}");
                        
        }
    }

}

