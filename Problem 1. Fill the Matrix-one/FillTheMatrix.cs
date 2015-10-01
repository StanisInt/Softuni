using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillTheMatrix
{
    static int n;

    static void MatrixPatternA()
    {
        int[,] matrixA = new int[n, n];
        int counter = 1;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrixA[row, col] = counter;
                counter++;
            }
        }
        PrintMatrix(matrixA);
    }

    static void MatrixPatternB()
    {
        int[,] matrixB = new int[n, n];
        int counter = 1;
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrixB[row, col] = counter;
                    counter++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--) 
                {
                    matrixB[row, col] = counter;
                    counter++;
                }
            }

        }
        PrintMatrix(matrixB);
    }
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(" {0,2} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        n = int.Parse(Console.ReadLine());
        MatrixPatternA();
        Console.WriteLine();
        MatrixPatternB();
    }
}

