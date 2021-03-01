using System;
using System.Collections;

public class AdvancedBoardGame 
{

    public ArrayList LoadAdvancedBoardGame = new ArrayList();
    public ArrayList AdvancedBoardGameShuffle = new ArrayList();
    public string[,] advancedBoardGameShuffle = new string[5,5];
    public bool[,] advancedBoardGameValidation = new bool[5,5];
    private string [,] AdvancedBoardGameSolution = new string[5,5]
    {
        {"A","B","C","D","E"},
        {"F","G","H","I","J"},
        {"K","L","M","N","O"},
        {"P","Q","R","S","T"},
        {"U","V","W","X","-"}
    };    

    public void PopulateBoardGame()
    {
        LoadAdvancedBoardGame.Add("A");
        LoadAdvancedBoardGame.Add("B");
        LoadAdvancedBoardGame.Add("C");
        LoadAdvancedBoardGame.Add("D");
        LoadAdvancedBoardGame.Add("E");
        LoadAdvancedBoardGame.Add("F");
        LoadAdvancedBoardGame.Add("G");
        LoadAdvancedBoardGame.Add("H");
        LoadAdvancedBoardGame.Add("I");
        LoadAdvancedBoardGame.Add("J");
        LoadAdvancedBoardGame.Add("K");
        LoadAdvancedBoardGame.Add("L");
        LoadAdvancedBoardGame.Add("M");
        LoadAdvancedBoardGame.Add("N");
        LoadAdvancedBoardGame.Add("O");
        LoadAdvancedBoardGame.Add("P");
        LoadAdvancedBoardGame.Add("Q");
        LoadAdvancedBoardGame.Add("R");
        LoadAdvancedBoardGame.Add("S");
        LoadAdvancedBoardGame.Add("T");
        LoadAdvancedBoardGame.Add("U");
        LoadAdvancedBoardGame.Add("V");
        LoadAdvancedBoardGame.Add("W");
        LoadAdvancedBoardGame.Add("X");
        LoadAdvancedBoardGame.Add("-");

        Random shuffle = new Random();

        int size = LoadAdvancedBoardGame.Count;
        while (size > 1)
        {
            size--;
            int pos = shuffle.Next(size + 1);
            Object value = LoadAdvancedBoardGame[pos];
            LoadAdvancedBoardGame[pos] = LoadAdvancedBoardGame[size];
            LoadAdvancedBoardGame[size] = value;
        }

        AdvancedBoardGameShuffle = new ArrayList(LoadAdvancedBoardGame);
        LoadAdvancedBoardGame.Clear();

        int counter = 0;
        for (int xAxis = 0; xAxis < 5; xAxis++)
        {
            for (int yAxis = 0; yAxis < 5; yAxis++)
            {
                advancedBoardGameShuffle[xAxis,yAxis] = AdvancedBoardGameShuffle[counter].ToString();
                counter++;
            }
        }
    }
    public void WriteAdvancedBoardGame()
    {
        for (int xAxis = 0; xAxis < 5; xAxis++)
        {
            Console.WriteLine($"| {advancedBoardGameShuffle[xAxis,0]} | {advancedBoardGameShuffle[xAxis,1]} | {advancedBoardGameShuffle[xAxis,2]} | {advancedBoardGameShuffle[xAxis,3]} | {advancedBoardGameShuffle[xAxis,4]} |");   
        }    

    }

    public Boolean ValidadeAdvancedBoardSolution()
    {
        bool solution = false;

        for (int xAxis = 0; xAxis < 5; xAxis++)
        {
            for (int yAxis = 0; yAxis < 5; yAxis++)
            {
                if (AdvancedBoardGameSolution[xAxis,yAxis] != advancedBoardGameShuffle[xAxis,yAxis])
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
