using System;
class ExchangeValues
{
    static void Main()
    {
        int firstVar = 5;
        int secondVar = 10;
        Console.WriteLine("The value of first variavble before exchanging is:{0}", firstVar);
        Console.WriteLine("The value of second variavble before exchanging is:{0}", secondVar);
        int thirdVar;
        thirdVar = firstVar;
        firstVar = secondVar;
        secondVar = thirdVar;
        Console.WriteLine("The value of first variavble after exchanging is:{0}" ,firstVar);
        Console.WriteLine("The value of second variavble after exchanging is:{0}", secondVar);
    }
}