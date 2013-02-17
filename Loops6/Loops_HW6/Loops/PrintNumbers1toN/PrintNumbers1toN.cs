using System;


class PrintNumbers1toN
{
    static void Main()
    {
        Console.WriteLine("Please enter number N:");
        int numberN=int.Parse(Console.ReadLine());
        for (int i = 1; i <= numberN; i++)
        {
            Console.WriteLine(i);
        }
    }
}