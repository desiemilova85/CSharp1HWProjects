using System;

class PrintBiggerNumber
{
    static void Main()
    {
        //Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

        Console.Write("Enter first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double second = double.Parse(Console.ReadLine());
        double third = Math.Max(first, second);
        Console.WriteLine("The bigest number from {0} and {1} is: {2}", first, second, third);     
    }
}
