using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Shuffling
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        string[,] matrix = new string[row, col];
        for (int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }
        string input = Console.ReadLine();
        while(input != "END")
        {
            if (input.Contains("swap "))
            {
                input = input.Replace("swap ", "");
                int[] swapping = input.Split(' ').Select(int.Parse).ToArray();
                if ((swapping[0] < row && swapping[1] < col) && (swapping[2] < row && swapping[3] < col))
                {
                    string temp = matrix[swapping[0], swapping[1]];
                    matrix[swapping[0], swapping[1]] = matrix[swapping[2], swapping[3]];
                    matrix[swapping[2], swapping[3]] = temp;
                    Print(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            input = Console.ReadLine();
        }
    }
    static void Print(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
