using System;

class IfFirstGreaterThanSecond
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers.");
        Console.WriteLine("Please enter 1st number:");
        int biggerNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter 2nd numder:");
        int smallerNumber = int.Parse(Console.ReadLine());
        if (smallerNumber == biggerNumber)
        {
            Console.WriteLine("Two numbers are equal:");
        }
        else if (smallerNumber > biggerNumber)
        {
            biggerNumber = smallerNumber;
        }
        Console.WriteLine("The greater number is: {0}", biggerNumber);
    }
}