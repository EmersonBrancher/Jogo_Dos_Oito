using System;
using System.Collections;

public class BeginerBoardGame 
{

    public ArrayList LoadBeginerBoardGame = new ArrayList();
    public ArrayList BeginerBoardGameShuffle = new ArrayList();
    public string[,] beginerBoardGameShuffle = new string[3,3];
    public bool[,] beginerBoardGameValidation = new bool[3,3];
    private string [,] BeginerBoardGameSolution = new string[3,3]
    {
        {"A","B","C"},
        {"D","E","F"},
        {"G","H","-"}
    };    

    public void PopulateBoardGame()
    {
        LoadBeginerBoardGame.Add("A");
        LoadBeginerBoardGame.Add("B");
        LoadBeginerBoardGame.Add("C");
        LoadBeginerBoardGame.Add("D");
        LoadBeginerBoardGame.Add("E");
        LoadBeginerBoardGame.Add("F");
        LoadBeginerBoardGame.Add("G");
        LoadBeginerBoardGame.Add("H");
        LoadBeginerBoardGame.Add("-");

        Random shuffle = new Random();

        int size = LoadBeginerBoardGame.Count;
        while (size > 1)
        {
            size--;
            int pos = shuffle.Next(size + 1);
            Object value = LoadBeginerBoardGame[pos];
            LoadBeginerBoardGame[pos] = LoadBeginerBoardGame[size];
            LoadBeginerBoardGame[size] = value;
        }

        BeginerBoardGameShuffle = new ArrayList(LoadBeginerBoardGame);
        LoadBeginerBoardGame.Clear();

        int counter = 0;
        for (int xAxis = 0; xAxis < 3; xAxis++)
        {
            for (int yAxis = 0; yAxis < 3; yAxis++)
            {
                beginerBoardGameShuffle[xAxis,yAxis] = BeginerBoardGameShuffle[counter].ToString();
                counter++;
            }
        }
    }
    public void WriteBeginerBoardGame()
    {
        for (int xAxis = 0; xAxis < 3; xAxis++)
        {
            Console.WriteLine($"| {beginerBoardGameShuffle[xAxis,0]} | {beginerBoardGameShuffle[xAxis,1]} | {beginerBoardGameShuffle[xAxis,2]} |");   
        }    

    }

    public Boolean ValidadeBeginerBoardSolution()
    {
        bool solution = false;

        for (int xAxis = 0; xAxis < 3; xAxis++)
        {
            for (int yAxis = 0; yAxis < 3; yAxis++)
            {
                if (BeginerBoardGameSolution[xAxis,yAxis] != beginerBoardGameShuffle[xAxis,yAxis])
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
