using System;

class MatrixSpiralNumbers
{
    static void Main()
    {
        Console.Write("Please enter number N = ");
        int n = int.Parse(Console.ReadLine()); 
        int a = 1;
        int x = 0; 
        int row = 0; 
        int col = -1;
        int[,] spiral = new int[n, n];

        if (n > 1 && n < 20)
        {
            for (int i = 0; i < n; i++)
            {
                x = x + 1;
                col = col + 1;
                spiral[row, col] = x;
            }
            for (int j = x + 1; x < n * n; j++)
            {
                for (int i = 0; i < n - a; i++)
                {
                    row = row + 1;
                    x = x + 1;
                    spiral[row, col] = x;
                }

                for (int i = 0; i < n - a; i++)
                {
                    col = col - 1;
                    x = x + 1;
                    spiral[row, col] = x;
                }
                a = a + 1;

                for (int i = 0; i < n - a; i++)
                {
                    row = row - 1;
                    x = x + 1;
                    spiral[row, col] = x;
                }

                for (int i = 0; i < n - a; i++)
                {
                    col = col + 1;
                    x = x + 1;
                    spiral[row, col] = x;
                }
                a = a + 1;
            }
            for (row = 0; row < n; row++)
            {
                for (col = 0; col < n; col++)
                {
                    Console.Write("{0,5}", spiral[row, col]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("The entered number N should be in the interval (1:20).Please enter number once again!");
        }
    }
}
