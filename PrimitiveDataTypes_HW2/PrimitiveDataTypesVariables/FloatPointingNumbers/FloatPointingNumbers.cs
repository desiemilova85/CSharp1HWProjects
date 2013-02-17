using System;

class FloatPointingNumbers
{
    static void Main()
    {
        decimal a = 5.3m;
        decimal b = 6.01m;
        decimal c = 5.00000001m;
        decimal d = 5.00000003m;
        decimal absAB=Math.Abs(a-b); 
        decimal absCD=Math.Abs(c-d);
        bool equalAB = absAB < 0.000001m;
        bool equalCD = absCD < 0.000001m;        
        Console.WriteLine("Is abs value of difference of numbers {0} and {1} < 0.000001? -  {2}", a, b, equalAB);
        Console.WriteLine("Is abs value of difference of numbers {0} and {1} < 0.000001? -  {2}", c, d, equalCD);
    }
}

