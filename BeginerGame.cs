using System;

public class BeginerGame 
{
    public static void ConsoleBoard()
    {
        string move;

        BeginerBoardGame boardGame = new BeginerBoardGame();

        boardGame.PopulateBoardGame();

        if (boardGame.ValidadeBeginerBoardSolution())
        {
        }
        else
        {
            boardGame.WriteBeginerBoardGame();
            move = Console.ReadLine();
            MainFunction.ValidateMove(move, boardGame.beginerBoardGameShuffle);
            boardGame.WriteBeginerBoardGame();
            
        }
    }

}

