using System;

class CalculateSumNX
{
    static void Main()
    {
             Console.Write("Please enter value for N: ");
             int n = int.Parse(Console.ReadLine());
             Console.Write("Please enter value for X: ");
             int x = int.Parse(Console.ReadLine());
             decimal sum = 1.0m;
             decimal nFactorial=1.0m;
             decimal power = 1.0m;
             int i;
             if (1 <= n)
             {
                 for (i = 1; i <= n; i++)
                 {
                     nFactorial *= i;
                     power*=x;
                     sum += (nFactorial/power);
                 }

                 Console.WriteLine("Result of sum is = {0}",sum);
             }
             else
                 {
                 Console.WriteLine("N has to be greater than 1 and smaller than K.Please enter valid values for K and N once again.");
                 }
    }
}