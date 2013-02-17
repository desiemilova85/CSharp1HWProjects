using System;
using System.Text;

class FindBitTreeOfInteger
{
    static void Main()
    {
        //Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
        Console.Write("Please Enter integer number:");
        int number = int.Parse(Console.ReadLine());
        int mask = 8;                      
        Console.WriteLine(((number&mask)==8)? "The 3d digit of {0} is 1":"The 3d digit of {0} is 0", number);
    }
}
