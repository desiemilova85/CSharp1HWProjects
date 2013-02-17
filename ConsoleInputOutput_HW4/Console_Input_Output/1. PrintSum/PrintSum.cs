using System;

class PrintSum
{
    static void Main()
    {
        Console.Write("Please enter number 1:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("please enter number 2:");
        double b = double.Parse(Console.ReadLine());
        double sum = a + b;
        Console.Write(" Sum of a+b= {0:0.000000}", sum);
    }
}
