using System;

class SumOfFirstNFibonacciNumbers
{
    static void Main()
    {
        Console.Write("Please enter value for N: ");
        int n = int.Parse(Console.ReadLine());
        int i;
        long first = 0;
        long second = 1;
        long temp = 0;
        long sum = 0;

        if (n>1)
        {
            for (i = 0; i <n; i++)
            {
                temp = first;
                first = second;
                second += temp;
                sum += temp;
            }

            Console.WriteLine("Sum of firts N numbers of Fibonacci Sequence is = {0}", sum);
        }
        else
        {
            Console.WriteLine("N has to be greater than 1.Please enter valid values for N once again.");
        }
    }
}
