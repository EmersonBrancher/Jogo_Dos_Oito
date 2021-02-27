using System;

public class IntermediaryGame 
{

    public static void ConsoleBoard()
    {
        IntermediaryBoardGame boardGame = new IntermediaryBoardGame();

        boardGame.PopulateBoardGame();

        if (boardGame.ValidadeBoardSolution())
        {
        }
        else
        {
            boardGame.WriteIntermediaryBoardGame();
            Console.ReadLine();
            
        }
    }

}

