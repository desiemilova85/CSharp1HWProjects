using System;

class ExchangingBitsPQK
{
    static void Main()
    {
        Console.WriteLine("enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("enter p position: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("enter q position: ");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the length: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Initial number is:");
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        int number = n;
        int bitP;
        int bitQ;
        for (int i = 0; i < k; i++)
        {
            bitP = (number & (1 << p)) >> p; 
            bitQ = (number & (1 << q)) >> q; 

            if (bitP != bitQ)
            {
                if (bitP == 1 && bitQ == 0)
                {
                    number = number & (~(1 << p));
                    number = number | (1 << q);
                }
                else
                {
                    number = number & (~(1 << q));
                    number = number | (1 << p);
                }
            }

            p++;
            q++;
        }

        Console.WriteLine("the new number is:");
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
