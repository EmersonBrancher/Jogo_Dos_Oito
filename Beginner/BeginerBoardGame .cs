using System;
using System.Collections;

public class BeginnerBoardGame 
{

    public ArrayList LoadBeginnerBoardGame = new ArrayList();
    public ArrayList BeginnerBoardGameShuffle = new ArrayList();
    public string[,] beginnerBoardGameShuffle = new string[3,3];
    public bool[,] beginnerBoardGameValidation = new bool[3,3];
    private string [,] BeginnerBoardGameSolution = new string[3,3]
    {
        {"A","B","C"},
        {"D","E","F"},
        {"G","H","-"}
    };    

    public void PopulateBoardGame()
    {
        LoadBeginnerBoardGame.Add("A");
        LoadBeginnerBoardGame.Add("B");
        LoadBeginnerBoardGame.Add("C");
        LoadBeginnerBoardGame.Add("D");
        LoadBeginnerBoardGame.Add("E");
        LoadBeginnerBoardGame.Add("F");
        LoadBeginnerBoardGame.Add("G");
        LoadBeginnerBoardGame.Add("H");
        LoadBeginnerBoardGame.Add("-");

        Random shuffle = new Random();

        int size = LoadBeginnerBoardGame.Count;
        while (size > 1)
        {
            size--;
            int pos = shuffle.Next(size + 1);
            Object value = LoadBeginnerBoardGame[pos];
            LoadBeginnerBoardGame[pos] = LoadBeginnerBoardGame[size];
            LoadBeginnerBoardGame[size] = value;
        }

        BeginnerBoardGameShuffle = new ArrayList(LoadBeginnerBoardGame);
        LoadBeginnerBoardGame.Clear();

        int counter = 0;
        for (int xAxis = 0; xAxis < 3; xAxis++)
        {
            for (int yAxis = 0; yAxis < 3; yAxis++)
            {
                beginnerBoardGameShuffle[xAxis,yAxis] = BeginnerBoardGameShuffle[counter].ToString();
                counter++;
            }
        }
    }
    public void WriteBeginnerBoardGame()
    {
        for (int xAxis = 0; xAxis < 3; xAxis++)
        {
            Console.WriteLine($"| {beginnerBoardGameShuffle[xAxis,0]} | {beginnerBoardGameShuffle[xAxis,1]} | {beginnerBoardGameShuffle[xAxis,2]} |");   
        }    

    }

    public Boolean ValidadeBeginnerBoardSolution()
    {
        bool solution = false;

        for (int xAxis = 0; xAxis < 3; xAxis++)
        {
            for (int yAxis = 0; yAxis < 3; yAxis++)
            {
                if (BeginnerBoardGameSolution[xAxis,yAxis] != beginnerBoardGameShuffle[xAxis,yAxis])
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
