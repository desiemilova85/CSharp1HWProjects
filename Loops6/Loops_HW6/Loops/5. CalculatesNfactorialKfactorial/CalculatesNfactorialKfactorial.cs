using System;

class CalculatesNfactorialKfactorial
{
    static void Main()
    {
        decimal nFactorial = 1;
        decimal kFactorial = 1;
        decimal resultkn=1;
        int i;
        Console.Write("Please enter value for N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter value for K: ");
        int k = int.Parse(Console.ReadLine());
        if (n < k && n > 1)
        {
            for (i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            for (i = 1; i <= k; i++)
            {
                kFactorial *= i;
            }
            int diffK_N=(k-n);
            for (i = 1; i <= diffK_N; i++)
            {
                resultkn *=i;
            }

                Console.WriteLine("The value of equation of N!*K!/(N-K)! is ={0} ", ((nFactorial * kFactorial)/resultkn));
        }

        else
        {
            Console.WriteLine("N has to be greater than 1 and smaller than K.Please enter valid values for K and N once again.");
        }
    }
}