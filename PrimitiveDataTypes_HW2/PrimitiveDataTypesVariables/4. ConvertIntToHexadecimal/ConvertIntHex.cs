using System;

class ConvertIntHex
{
static void Main()
    {
        int IntNumber = 254;
        string HexNumber = IntNumber.ToString();
        Console.WriteLine("The hexadecimal value of {0} is {0:X}", IntNumber, HexNumber);
    }
}


