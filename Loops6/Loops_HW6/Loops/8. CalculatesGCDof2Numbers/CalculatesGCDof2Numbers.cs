using System;

class CalculatesGCDof2Numbers
{
static void Main()
{
            uint temp;
            uint greatCD;
            Console.Write("Please enter value for a: ");
            uint a = uint.Parse(Console.ReadLine());
            Console.Write("Please enter value for b: ");
            uint b = uint.Parse(Console.ReadLine());
            if (a == 0 && b > 0)
            {
                greatCD = b;
            }
            else if (b == 0 && a > 0)
            {
                greatCD = a;
            }
            else if (a > 0 && b > 0)
            {
                while (b > 0)
                {
                    temp = b;
                    b = a % b;
                    a = temp;
                }
                    greatCD = a;
                Console.WriteLine("The GCD of the entered numbers is {0}.", greatCD);
            }
    }
}