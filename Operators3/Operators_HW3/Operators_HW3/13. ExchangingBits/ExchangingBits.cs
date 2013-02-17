using System;

class ExchangingBits
{
    static void Main()
    {
        //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
        Console.Write("Enter uint integer: ");
        uint number = uint.Parse(Console.ReadLine());

        uint mask3 = 1 << 3;
        uint newNumber3 = number & mask3;
        uint bit3 = newNumber3 >> 3;

        uint mask4 = 1 << 4;
        uint newNumber4 = number & mask4;
        uint bit4 = newNumber4 >> 4;

        uint mask5 = 1 << 5;
        uint newNumber5 = number & mask5;
        uint bit5 = newNumber5 >> 5;

        uint mask24 = 1 << 24;
        uint newNumber24 = number & mask24;
        uint bit24 = newNumber24 >> 24;

        uint mask25 = 1 << 25;
        uint newnumber25 = number & mask25;
        uint bit25 = newnumber25 >> 25;

        uint mask26 = 1 << 26;
        uint newNumber26 = number & mask26;
        uint bit26 = newNumber26 >> 26;

        uint temp;
        uint result;  

        if (bit3 == 0)
        {
            uint mask = ~((uint)(1 << 24)); 
            temp = number & mask;
        }
        else
        {
            uint mask = 1 << 24;    
            temp = number | mask;
        }
        result = temp;

        if (bit4 == 0)
        {
            uint mask = ~((uint)(1 << 25));  
            temp = result & mask;
        }
        else
        {
            uint mask = 1 << 25;   
            temp = result | mask;
        }
        result = temp;

        if (bit5 == 0)
        {
            uint mask = ~((uint)(1 << 26)); 
            temp = result & mask;
        }
        else
        {
            uint mask = 1 << 26;  
            temp = result | mask;
        }
        result = temp;

        if (bit24 == 0)
        {
            uint mask = ~((uint)(1 << 3));
            temp = result & mask;
        }
        else
        {
            uint mask = 1 << 3;  
            temp = result | mask;
        }
        result = temp;

        if (bit25 == 0)
        {
            uint mask = ~((uint)(1 << 4));  
            temp = result & mask;
        }
        else
        {
            uint mask = 1 << 4;   
            temp = result | mask;
        }
        result = temp;

        if (bit26 == 0)
        {
            uint mask = ~((uint)(1 << 5));  
            temp = result & mask;
        }
        else
        {
            uint mask = 1 << 5; 
            temp = result | mask;
        }
        result = temp;

        Console.WriteLine("Before modification number {0} is this binary number  {1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("After modification number {0} is this binary number  {1}", number, Convert.ToString(result, 2).PadLeft(32, '0'));
       
    }
}
