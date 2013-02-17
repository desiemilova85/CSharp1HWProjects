using System;
using System.Text;

class CopyrightTriangle
{
    static void Main()
    {
        char copyRightSymbol = (char)169;
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("{0,4}", copyRightSymbol);
        Console.WriteLine("{0,3} {0,1}", copyRightSymbol);
        Console.WriteLine("{0,2} {0,3}", copyRightSymbol);
        Console.WriteLine("{0,1} {0,1} {0,1} {0,1}", copyRightSymbol); 
    }
}
