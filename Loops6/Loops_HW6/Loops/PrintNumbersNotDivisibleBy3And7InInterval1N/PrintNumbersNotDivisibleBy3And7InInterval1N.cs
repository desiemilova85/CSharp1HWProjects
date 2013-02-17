using System;

class PrintNumbersNotDivisibleBy3And7InInterval1N
{
    static void Main()
    {
        Console.WriteLine("Console will print all the numbers in the interval [1:N] which are divisible by 3 and 7 simultaneously");
        Console.Write("Please enter Number N:");
        int numberN=int.Parse(Console.ReadLine());
        if (numberN<=0)
        {
            Console.WriteLine("Please enter positive number!");
        }
        else 
        {

            for (int i=1; i<= numberN; i++)
            {
                if (i % (3 * 7) != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

