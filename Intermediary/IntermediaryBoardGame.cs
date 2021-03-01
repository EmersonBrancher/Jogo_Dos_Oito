using System;
using System.Collections;

public class IntermediaryBoardGame 
{

    public ArrayList LoadIntermediaryBoardGame = new ArrayList();
    public ArrayList IntermediaryBoardGameShuffle = new ArrayList();
    public string[,] intermediaryBoardGameShuffle = new string[4,4];
    public bool[,] intermediaryBoardGameValidation = new bool[4,4];
    private string [,] IntermediaryBoardGameSolution = new string[4,4]
    {
        {"A","B","C","D"},
        {"E","F","G","H"},
        {"I","J","K","L"},
        {"M","N","O","-"}
    };    

    public void PopulateBoardGame()
    {
        LoadIntermediaryBoardGame.Add("A");
        LoadIntermediaryBoardGame.Add("B");
        LoadIntermediaryBoardGame.Add("C");
        LoadIntermediaryBoardGame.Add("D");
        LoadIntermediaryBoardGame.Add("E");
        LoadIntermediaryBoardGame.Add("F");
        LoadIntermediaryBoardGame.Add("G");
        LoadIntermediaryBoardGame.Add("H");
        LoadIntermediaryBoardGame.Add("I");
        LoadIntermediaryBoardGame.Add("J");
        LoadIntermediaryBoardGame.Add("K");
        LoadIntermediaryBoardGame.Add("L");
        LoadIntermediaryBoardGame.Add("M");
        LoadIntermediaryBoardGame.Add("N");
        LoadIntermediaryBoardGame.Add("O");
        LoadIntermediaryBoardGame.Add("-");

        Random shuffle = new Random();

        int size = LoadIntermediaryBoardGame.Count;
        while (size > 1)
        {
            size--;
            int pos = shuffle.Next(size + 1);
            Object value = LoadIntermediaryBoardGame[pos];
            LoadIntermediaryBoardGame[pos] = LoadIntermediaryBoardGame[size];
            LoadIntermediaryBoardGame[size] = value;
        }

        IntermediaryBoardGameShuffle = new ArrayList(LoadIntermediaryBoardGame);
        LoadIntermediaryBoardGame.Clear();

        int counter = 0;
        for (int xAxis = 0; xAxis < 4; xAxis++)
        {
            for (int yAxis = 0; yAxis < 4; yAxis++)
            {
                intermediaryBoardGameShuffle[xAxis,yAxis] = IntermediaryBoardGameShuffle[counter].ToString();
                counter++;
            }
        }
    }
    public void WriteIntermediaryBoardGame()
    {
        for (int xAxis = 0; xAxis < 4; xAxis++)
        {
            Console.WriteLine($"| {intermediaryBoardGameShuffle[xAxis,0]} | {intermediaryBoardGameShuffle[xAxis,1]} | {intermediaryBoardGameShuffle[xAxis,2]} | {intermediaryBoardGameShuffle[xAxis,3]} |");   
        }    

    }

    public Boolean ValidadeIntermediaryBoardSolution()
    {
        bool solution = false;

        for (int xAxis = 0; xAxis < 4; xAxis++)
        {
            for (int yAxis = 0; yAxis < 4; yAxis++)
            {
                if (IntermediaryBoardGameSolution[xAxis,yAxis] != intermediaryBoardGameShuffle[xAxis,yAxis])
                {
                    solution = false;
                    break;
                }
                else 
                {
                    solution = true;
                }
            }
        }
        return solution;
    }  
}
