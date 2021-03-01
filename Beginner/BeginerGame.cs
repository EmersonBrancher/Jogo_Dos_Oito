using System;

public class BeginnerGame 
{
    public static void ConsoleBoard()
    {
        string move;
        int counterMove = 0;
        BeginnerBoardGame boardGame = new BeginnerBoardGame();

        boardGame.PopulateBoardGame();

        if (boardGame.ValidadeBeginnerBoardSolution())
        {
        }
        else
        {
            do
            {
                boardGame.WriteBeginnerBoardGame();
                move = Console.ReadLine();
                if (MainFunction.ValidateMove(move.ToUpper(), boardGame.beginnerBoardGameShuffle) == "SAIR")
                {
                    break;
                } 
                else 
                {
                    counterMove++;
                }
            }
            while(boardGame.ValidadeBeginnerBoardSolution() == false);
            boardGame.WriteBeginnerBoardGame();
            Console.WriteLine($"Quantidade de movimento: {counterMove}");
                        
        }
    }

}

