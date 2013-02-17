using System;
using System.Text;

class DivideIntegerBy5And7
{
static void Main()
{
    Console.Write("Please enter integer number: ");
    int number = int.Parse(Console.ReadLine());
    if ((number % 5 == 0) && (number % 7 == 0))
    {
        Console.WriteLine("The number CAN be divided by 5 and 7 simultaneously");
    }
    else
    {
        Console.WriteLine("The number CANNOT be divided by 5 and 7 simultaneously");
    }
}
}
