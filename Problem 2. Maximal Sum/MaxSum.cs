using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxSum
{
    static void Main()
    {
        int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[,] matrix = new int[sizes[0], sizes[1]];
        int[,] currentSquare = new int[3, 3];
        
        for (int i = 0; i < sizes[0]; i++)
        {
            int[] container = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int j = 0; j < sizes[1]; j++)
            {
                matrix[i, j] = container[j];
            }
        }
        int maxsum = int.MinValue;
        int bestrow = 0;
        int bestcol = 0;
        for (int row = 0; row < (sizes[0] - 2); row++)
        {

            for (int col = 0; col < (sizes[1] - 2); col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > maxsum)
                {
                    maxsum = sum;
                    bestrow = row;
                    bestcol = col;
                }
            }
        }
        Console.WriteLine("Sum: {0}", maxsum);
        Console.WriteLine("{0} {1} {2}", matrix[bestrow, bestcol], matrix[bestrow, bestcol + 1], matrix[bestrow, bestcol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[bestrow + 1, bestcol], matrix[bestrow + 1, bestcol + 1], matrix[bestrow + 1, bestcol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[bestrow + 2, bestcol], matrix[bestrow + 2, bestcol + 1], matrix[bestrow + 2, bestcol + 2]);
    }
}
