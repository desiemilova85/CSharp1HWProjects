using System;
using System.Text;

class CheckThirdDigitOfInteger
{
    static void Main()
    {
        Console.Write("Please Enter integer with min 3 digits length:");
        int number = int.Parse(Console.ReadLine());
        int firstRest= (number/100);
        int secondRest= (firstRest%10);
        Console.WriteLine((secondRest==7) ? "Third number is: {0}" : "Third number is not 7",secondRest);
    }
}
