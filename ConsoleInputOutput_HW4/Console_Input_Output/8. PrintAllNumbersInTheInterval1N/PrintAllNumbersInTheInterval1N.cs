using System;

class PrintAllNumbersInTheInterval1N
{
    static void Main()
    {
        Console.Write("Write an integer number:");
        int number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i);
            }
        }
        else
        {
            for (int i = number; i <= 1; i++)
            {
                Console.Write("The sequence is the following: {0}", i);
            }
        }
    }
}
