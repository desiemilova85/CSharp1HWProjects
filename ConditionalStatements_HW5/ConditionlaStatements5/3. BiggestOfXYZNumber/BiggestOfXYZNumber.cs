using System;

class BiggestOfXYZNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter 3 numbers :");
        Console.WriteLine("Please enter 1st number:");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter 2nd number:");
        int second = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter 3rd number:");
        int third = int.Parse(Console.ReadLine());
        if ((first > second) && (first > third))
        {
            Console.WriteLine("The biggest number is {0}", first);
        }
        else
        {
            if ((second > first) && (second > third))
            {
                Console.WriteLine("The biggest number is {0}", second);
            }
            else
            {
                if ((third > first) && (third > second))
                {
                    Console.WriteLine("The biggest number is {0}", third);
                }
            }
        }
    }
}