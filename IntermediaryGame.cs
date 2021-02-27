using System;

public class IntermediaryGame 
{
    private string[,] IntermediaryBoardGameSolution = new string[3,3]
    {
        {"A","B","C"},
        {"D","E","F"},
        {"G","H"," "}
    };

    public static void ConsoleBoard()
    {
        LoadIntermediaryGame boardgame = new LoadIntermediaryGame();

        boardgame.PopulateBoardGame();
        Console.WriteLine(boardgame.intermediaryBoardGameShuffle);
    }

}
