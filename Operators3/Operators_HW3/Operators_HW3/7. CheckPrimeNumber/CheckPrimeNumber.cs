using System;

class CheckPrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter integer number:");
        int x = int.Parse(Console.ReadLine());
        //bool isPrime = true;
        for(int i = 2; i <= Math.Sqrt(x); i++)
        {
            if((x%i) == 0)
            {
                Console.WriteLine("Your number is not prime");
                return;
            }
        }
            Console.WriteLine("Your number is prime");
    }
}
