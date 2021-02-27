using System;
using System.Collections;

public class LoadIntermediaryGame 
{

    public static ArrayList IntermediaryBoardGame = new ArrayList();
    public static ArrayList IntermediaryBoardGameShuffle = new ArrayList();
    public static string[,] intermediaryBoardGameShuffle = new string[3,3];

    public void PopulateBoardGame() 
    {
        IntermediaryBoardGame.Add("A");
        IntermediaryBoardGame.Add("B");
        IntermediaryBoardGame.Add("C");
        IntermediaryBoardGame.Add("D");
        IntermediaryBoardGame.Add("E");
        IntermediaryBoardGame.Add("F");
        IntermediaryBoardGame.Add("G");
        IntermediaryBoardGame.Add("H");
        IntermediaryBoardGame.Add(" ");

        string intermediaryBoardGame;
        int slot;
        Random shuffle = new Random();

        for (int index = 0; index > 9; index++)
        {
            do 
            {
                slot = shuffle.Next(1, IntermediaryBoardGame.Count + 1);
                intermediaryBoardGame = IntermediaryBoardGame.IndexOf(slot).ToString();
            } while (IntermediaryBoardGame.Contains(intermediaryBoardGame));

            IntermediaryBoardGameShuffle.Add(intermediaryBoardGame);
            IntermediaryBoardGame.Remove(IntermediaryBoardGame.IndexOf(slot));
        }

        for (int xAxis = 0; xAxis > 9; xAxis++)
        {
            for (int yAxis = 0; yAxis > 9; yAxis++)
            {
                intermediaryBoardGameShuffle[xAxis,yAxis] = IntermediaryBoardGameShuffle.IndexOf(1).ToString();
                IntermediaryBoardGameShuffle.Remove(1);
            }
        }

    }

    /*public static string WriteIntermediaryBoardGame(string [,] intermediaryBoardGameShuffle)
    {
        for (int xAxis = 0; xAxis > 9; xAxis++)
        {
            for (int yAxis = 0; yAxis > 9; yAxis++)
            {
                Console.WriteLine(intermediaryBoardGameShuffle[xAxis,yAxis]);
            }
        }    
    }*/
    
}
