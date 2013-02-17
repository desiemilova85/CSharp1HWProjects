using System;

class FindGreatestOf5Variables
{
    static void Main()
    {
        Console.WriteLine("Please enter 1st number:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter 2nd number:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter 3rd number:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter 4th number:");
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter 5th number:");
        double e = double.Parse(Console.ReadLine());
        double temp=0;
        if ((a > b) && (a > c) && (a > d) && (a > e))
        {
            temp=a;
            Console.WriteLine("The Greatest Number is {0}",temp);
        }
        if ((b > a) && (b > c) && (b > d) && (b > e))
        {
            temp = b;
            Console.WriteLine("The Greatest Number is {0}", temp);
        }
        if ((c > a) && (c > b) && (c > d) && (c > e))
        {
            temp = c;
            Console.WriteLine("The Greatest Number is {0}", temp);
        }
        if ((d > a) && (d > b) && (d > c) && (d > e))
        {
            temp = d;
            Console.WriteLine("The Greatest Number is {0}", temp);
        }
        if ((e > a) && (e > b) && (e > c) && (e > d))
        {
            temp = e;
            Console.WriteLine("The Greatest Number is {0}", temp);
        }
    }
}
