using System;

class CalculateN_Kfactorial
{
    static void Main()
    {
            long nFactorial = 1;
            long kFactorial = 1;
            int i;
            Console.Write("Please enter value for N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter value for K: ");
            int k = int.Parse(Console.ReadLine());
            if (k < n && k > 1)
            {
                for (i = 1; i <= n; i++)
                {
                    nFactorial *= i;
                }
 
                for (i = 1; i <= k; i++)
                {
                    kFactorial *= i;
                }
                Console.WriteLine("The division of N!/K! is ={0} ", (nFactorial / kFactorial));
            }
 
            else
            {
                Console.WriteLine("K has to be greater than 1 and smaller than N.Please enter values for K and N once again.");
            }
 
        }
    }
