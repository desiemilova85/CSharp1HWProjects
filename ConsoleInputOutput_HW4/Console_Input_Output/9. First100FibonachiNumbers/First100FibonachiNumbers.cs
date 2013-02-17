using System;

class First100FibonachiNumbers
{
    static void Main()
    {
        ////Write a program to print the first 100 members of the sequence of Fibonachi
        long firstNumber =-1;
        long secondNumber = 1;
        long sum = 0;
        for (int i = 0; i <= 100; i++)
        {
            sum = secondNumber + firstNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
            Console.WriteLine(sum);
        }
    }
}