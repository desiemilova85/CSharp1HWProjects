using System;

class AccurantSumOFDoubleNumbers
{
    static void Main()
    {
        //Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
        decimal oldSum = 0.0m;
        decimal newSum = 1.0m;
        decimal reminder = 2m;
        decimal diff;
        do
        {
            oldSum = newSum;

            if (reminder % 2 == 0)
            {
                newSum += ((decimal)1 / reminder);
            }
            else
            {
                newSum -= ((decimal)1 / reminder);
            }

            reminder++;
        } while (Math.Abs(newSum - oldSum) >= 0.001M);

        Console.WriteLine("The sum is {0}", newSum);
    }
}
