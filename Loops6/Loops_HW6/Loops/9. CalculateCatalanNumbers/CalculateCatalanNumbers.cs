using System;

class CalculateCatalanNumbers
{
    static void Main()
    {
        Console.Write("Please enter number N= ");
        long n = long.Parse(Console.ReadLine());
        long catalanNumber;
        long firstFactorial = 1;
        long secondFactorial = 1;
        long thirdFactorial = 1;
        if (n > 0)
        {
            for (int i = 1; i <= (2 * n); i++)
            {
                firstFactorial *= i;
            }
            for (int i = 1; i <= (n + 1); i++)
            {
                secondFactorial *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                thirdFactorial *= i;
            }
            catalanNumber = firstFactorial / (secondFactorial * thirdFactorial);
            Console.WriteLine("Catalan number is ={0}", catalanNumber);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
