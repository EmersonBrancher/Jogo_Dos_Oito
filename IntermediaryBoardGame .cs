using System;
using System.Collections;

public class IntermediaryBoardGame 
{

    public ArrayList LoadIntermediaryBoardGame = new ArrayList();
    public ArrayList IntermediaryBoardGameShuffle = new ArrayList();
    public string[,] intermediaryBoardGameShuffle = new string[3,3];
    public bool[,] intermediaryBoardGameValidation = new bool[3,3];
    private string [,] IntermediaryBoardGameSolution = new string[3,3]
    {
        {"A","B","C"},
        {"D","E","F"},
        {"G","H"," "}
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
        LoadIntermediaryBoardGame.Add(" ");

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
        for (int xAxis = 0; xAxis < 3; xAxis++)
        {
            for (int yAxis = 0; yAxis < 3; yAxis++)
            {
                intermediaryBoardGameShuffle[xAxis,yAxis] = IntermediaryBoardGameShuffle[counter].ToString();
                counter++;
            }
        }
    }
    public void WriteIntermediaryBoardGame()
    {
        for (int xAxis = 0; xAxis < 3; xAxis++)
        {
            Console.WriteLine($"| {intermediaryBoardGameShuffle[xAxis,0]} | {intermediaryBoardGameShuffle[xAxis,1]} | {intermediaryBoardGameShuffle[xAxis,2]} |");   
        }    

    }

    public Boolean ValidadeBoardSolution()
    {
        bool solution = false;

        for (int xAxis = 0; xAxis < 3; xAxis++)
        {
            for (int yAxis = 0; yAxis < 3; yAxis++)
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
