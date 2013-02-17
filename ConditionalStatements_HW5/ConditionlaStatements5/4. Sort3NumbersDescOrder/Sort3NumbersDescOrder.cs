using System;

class Sort3NumbersDescOrder
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
            if (second > third)
            {
                Console.WriteLine("Numbers in descending order: {0} \n {1}\n {2}\n", first, second, third);
            }
            else
            {
                if (third > second)
                {
                    Console.WriteLine("Numbers in descending order:{0} \n {1}\n {2}\n", first, third, second);
                }
            }
        }

        else
        {
            if ((second > first) && (second > third))
            {
                if (first > third)
                {
                    Console.WriteLine("Numbers in descending order:{0} \n {1}\n {2}\n", second, first, third);
                }
                else
                {
                    if (third > first)
                    {
                        Console.WriteLine("Numbers in descending order:{0} \n {1}\n {2}\n", second, third, first);
                    }
                }
            }
            else
            {
                if ((third > first) && (third > second))
                {
                    if (first > second)
                    {
                        Console.WriteLine("Numbers in descending order:{0} \n {1}\n {2}\n", third, first, second);
                    }
                    else
                    {
                        if (second > first)
                        {
                            Console.WriteLine("Numbers in descending order:{0} \n {1}\n {2}\n", third, second, first);
                        }
                    }
                }
            }
        }
    }
}