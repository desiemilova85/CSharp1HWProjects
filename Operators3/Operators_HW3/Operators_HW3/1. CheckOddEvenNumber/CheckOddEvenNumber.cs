using System;
using System.Text;

class CheckOddEvenNumber
{
    static void Main()
    {
        Console.Write("Please Enter interger number:");
        int number = int.Parse(Console.ReadLine());
        if ((number % 2) == 0)  
            Console.WriteLine(" The number {0} is ODD", number);
        else if ((number % 2) == 1) 
            Console.WriteLine("The number {0} is EVEN", number);
    }
}
