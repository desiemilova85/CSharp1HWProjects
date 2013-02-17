using System;

class ModifiesNToHoldTheValueVAtPositionP
{
    static void Main()
    {
        //We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
        //Example: n = 5 (00000101), p=3, v=1  13 (00001101)
        //n = 5 (00000101), p=2, v=0  1 (00000001)

        Console.Write("Please Enter integer number:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please Enter number for positon:");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please Enter V number 0 or 1 to change the bit at position p:");
        int v = int.Parse(Console.ReadLine());
        int mask, newNumber;
        if (v == 1)
        {
            mask = 1 << p;
            newNumber = mask | n;
            Console.WriteLine("The new number is {0}",newNumber);
        }
        else if (v == 0)
        {
            mask = ~(1 << p);
            newNumber = mask & n;
            Console.WriteLine("The new number is: {0}",newNumber);
        }
        else Console.WriteLine("Not valid entered V number.Please enter again values for V :\"1\" or \"0\" only");
    }
}