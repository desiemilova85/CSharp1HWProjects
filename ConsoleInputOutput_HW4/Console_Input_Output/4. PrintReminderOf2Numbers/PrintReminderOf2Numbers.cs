using System;

class PrintReminderOf2Numbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        uint min = uint.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        uint max = uint.Parse(Console.ReadLine());
        int numberOfIntegers=0;
        if (min > max)
        {
            uint temp = min;
            min = max;
            max = temp;
        }
        for (uint i = min; i <= max; i++)
        {
            if (i % 5 == 0)
            {
                numberOfIntegers++;
            }
        }
        Console.WriteLine("The number of integers that can be divided by 5 without remainder in the interval {0} to {1} is: {2}", min, max, numberOfIntegers);
    }
}
