using System;
using System.Text;

class PrintASCIItable
{
    static void Main()
    {
        Console.WriteLine("| Unicode| Symbol|");
        Console.OutputEncoding = Encoding.UTF8;
        for (int i = 1; i <=255; i++)
        {
            char aVar = (char)i;
            Console.WriteLine("|   {0}    |  {1}    |",i,aVar);
        }
    }
}
