using System;
class CountTrailingZerosOfNFactorial
{
    static void Main(string[] args)
    {
        int divider = 5;
        Console.Write("Please enter number N =");
        int p = int.Parse(Console.ReadLine());
        int count = 0;
        while ((p / divider) >= 1)
        {
            count += (p / divider);
            divider *= 5;
        }
        Console.WriteLine( "The number of the trailing zeros in {0}! is = {1}",p,count);
    }
}
