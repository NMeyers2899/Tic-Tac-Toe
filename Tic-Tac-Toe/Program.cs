using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            void AddRows(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    int rowSum = 0;

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        rowSum += array[i, j];
                    }

                    Console.WriteLine(rowSum);
                }
            }

            int[,] grid = new int[3, 3] { { 1, 7, 3 }, 
                                          { 42, 412, 6 }, 
                                          { 7, 123, 12 } };

            AddRows(grid);
        }
    }
}
