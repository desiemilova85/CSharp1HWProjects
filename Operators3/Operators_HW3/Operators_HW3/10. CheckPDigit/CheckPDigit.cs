using System;

class CheckPDigit
{
    static void Main()
    {
        Console.Write("Please Enter integer number:");
        int intNumber = int.Parse(Console.ReadLine());
        Console.Write("Please Enter integer number for positon:");
        int intPosition = int.Parse(Console.ReadLine());
        int mask = 1 << intPosition;
        int nAndMask = intNumber & mask;
        int bit = nAndMask >> intPosition;
        Console.WriteLine(((bit) == 1) ? "The \"p\" digit of {0} is 1" : "The p digit of {1} is 0",intPosition, intNumber);
    }
}