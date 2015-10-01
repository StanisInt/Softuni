using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixSequence
{
    static string[,] matrix;
    static string current = null;
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        matrix = new string[row, col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }
        Longestseq();
        
    }
    static void Longestseq()
    {
        int longestSeq = 0;
        string bestString = null;
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                current = matrix[i, j];
                int row = Row(i, j);
                int col = Col(i, j);
                int diag = Diagonal(i, j);
                int temp = Math.Max(Math.Max(row, col), diag);
                if (temp > longestSeq)
                {
                    longestSeq = temp;
                    bestString = current;
                }
            }
        }
        Print(longestSeq, bestString);

    }
    static int Row(int i, int j)
    {
        int count = 1;
        for(int k = j+1; k < matrix.GetLength(1); k++)
        {
            if(matrix[i,k] == current)
            {
                count++;
            }
        }
        return count;
    }
    static int Col(int i, int j)
    {
        int count = 1;
        for (int k = i + 1; k < matrix.GetLength(0); k++)
        {
            if (matrix[k, j] == current)
            {
                count++;
            }
        }
        return count;
    }
    static int Diagonal(int i, int j)
    {
        int count = 1;
        int diagonal = new int();
        if(matrix.GetLength(0) < matrix.GetLength(1))
        {
            diagonal = matrix.GetLength(0);
        }
        else
        {
            diagonal = matrix.GetLength(1);
        }
        for (int k = j + 1; k < diagonal; k++)
        {
            if (matrix[k, k] == current)
            {
                count++;
            }
        }
        return count;
    }
    static void Print(int count, string best)
    {
        for(int i = 0; i < count; i++)
        {
            if(i == count - 1)
            {
                Console.Write("{0}", best);
                Console.WriteLine();
            }
            else
            {
                Console.Write("{0}, ", best);
            }
        }
    }
    
}
