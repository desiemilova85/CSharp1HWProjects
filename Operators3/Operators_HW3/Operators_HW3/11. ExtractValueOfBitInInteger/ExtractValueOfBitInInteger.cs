using System;

class ExtractValueOfBitInInteger
{
    static void Main()
    {
        Console.Write("Please Enter integer number:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please Enter integer number for positon:");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        Console.WriteLine(((bit) == 1) ? "The bit value of {0} is 1" : "The The bit value of {0} is 0", n);
    }
}
