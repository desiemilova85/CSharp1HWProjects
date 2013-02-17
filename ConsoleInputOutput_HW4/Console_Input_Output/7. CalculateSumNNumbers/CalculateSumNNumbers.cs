using System;

class CalculateSumNNumbers
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        uint n = uint.Parse(Console.ReadLine());
        double sum = 0;
        for (uint i = 1; i <= n; i++)
        {
            Console.Write("Please enter the numbers you want to sum :");
            double number = double.Parse(Console.ReadLine());
            sum = sum + number;
        }
        Console.WriteLine("The total sum of the entered numbers is: {0}.", sum);
    }
}
