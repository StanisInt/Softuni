using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Coins
{
    static char[][] jagged;
    static int colectedCoins = 0;
    static int wallHit = 0;
    static int rowcheck;
    static int colcheck;
    static int row = 0;
    static int col = 0;
    static void Main()
    {
        jagged = new char[4][];
        jagged[0] = Console.ReadLine().ToArray();
        jagged[1] = Console.ReadLine().ToArray();
        jagged[2] = Console.ReadLine().ToArray();
        jagged[3] = Console.ReadLine().ToArray();
        char[] commands = Console.ReadLine().ToArray();        
        
        for(int i = 0; i < commands.Length; i++)
        {
            if (jagged[row][col] == '$')
            {
                colectedCoins++;
            }
            if(commands[i] == 'V')
            {
                rowcheck = row;
                colcheck = col;
                row++;
                IsValidPosition(row, col);  
            }
            else if (commands[i] == '^')
            {
                rowcheck = row;
                colcheck = col;
                row--;
                IsValidPosition(row, col);
            }
            else if(commands[i] == '>')
            {
                rowcheck = row;
                colcheck = col;
                col++;
                IsValidPosition(row, col);
            }
            else if (commands[i] == '<')
            {
                rowcheck = row;
                colcheck = col;
                col--;
                IsValidPosition(row, col);
            }
        }
        Console.WriteLine("Coins collected: {0}", colectedCoins);
        Console.WriteLine("Walls hit: {0}", wallHit);
    }
    static void IsValidPosition(int i, int j)
    {
        char position = new char();
        try
        {
            position = jagged[i][j];
        }
        catch(IndexOutOfRangeException exc)
        {
            wallHit++;
            row = rowcheck;
            col = colcheck;
        }
    }
}