using System;

class PrintQuadraticMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Please enter Number N = ");
        int n = int.Parse(Console.ReadLine());
        if (n > 0 && n < 20)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,2} ", i + j);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("The number must be in the interval (0:20).Please enter value for N once again to see the matrix!");
        }

    }
}
