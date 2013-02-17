using System;

class ReturnsMinMaxNumberFromNsequence
{
    static void Main()
    {
        Console.Write("Please enter the count of numbers:");
        int n=int.Parse(Console.ReadLine());
        int minValue = int.MaxValue;
        int maxValue = int.MinValue;
        if (n<0)
        {
            Console.WriteLine("Error!!!Please enter n number which is positive");
        }
        else if ((n==1)||(n==0))
        {
            Console.WriteLine("Please enter minimum 2 numbers to be able to extract min and max number!");
        }
        else if (n >= 2)
        {
            for (int i = 0; i < n; i++)
            {
                    Console.Write("Please enter number:");
                    int numValue = int.Parse(Console.ReadLine());
                    if (numValue < minValue)
                    {
                        minValue = numValue;
                    }
                    else if (numValue > maxValue)
                    {
                        maxValue = numValue;
                    }
            }
            Console.WriteLine("min number : {0}, max number : {1}", minValue, maxValue);
        }
    }
}