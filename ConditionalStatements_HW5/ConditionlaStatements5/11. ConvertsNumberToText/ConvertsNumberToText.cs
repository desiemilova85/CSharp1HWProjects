using System;

class ConvertsNumberToText
{
      public static void Digits (int number)
    {
        switch (number)
        {
            case 0:
                Console.WriteLine(" Zero ");
                break;
            case 1:
                Console.Write(" One ");
                break;
            case 2:
                Console.Write(" Two ");
                break;
            case 3:
                Console.Write(" Three ");
                break;
            case 4:
                Console.Write(" Four ");
                break;
            case 5:
                Console.Write(" Five ");
                break;
            case 6:
                Console.Write(" Six ");
                break;
            case 7:
                Console.Write(" Seven ");
                break;
            case 8:
                Console.Write(" Eight ");
                break;
            case 9:
                Console.Write(" Nine ");
                break;
            default:
                break;
        }
    }
    public static void SpecialCases (int number)
    {
        switch (number)
        {
            case 10:
                Console.Write(" Ten ");
                break;
            case 11:
                Console.Write(" Eleven ");
                break;
            case 12:
                Console.Write(" Twelve ");
                break;
            case 13:
                Console.Write(" Thirteen ");
                break;
            case 14:
                Console.Write(" Fourteen ");
                break;
            case 15:
                Console.Write(" Fifteen ");
                break;
            case 16:
                Console.Write(" Sixteen ");
                break;
            case 17:
                Console.Write(" Seventeen ");
                break;
            case 18:
                Console.Write(" Eighteen ");
                break;
            case 19:
                Console.Write(" Nineteen ");
                break;
            default:
                break;
        }
    }
     public static void Tens (int number)
    {
        switch (number)
        {
            case 2:
                Console.Write(" Twenty ");
                break;
            case 3:
                Console.Write(" Thirty ");
                break;
            case 4:
                Console.Write(" Fourty ");
                break;
            case 5:
                Console.Write(" Fifty ");
                break;
            case 6:
                Console.Write(" Sixty ");
                break;
            case 7:
                Console.Write(" Seventy ");
                break;
            case 8:
                Console.Write(" Eighty ");
                break;
            case 9:
                Console.Write(" Ninety ");
                break;
            default:
                break;
        }
    }
    public static void Hundreds(int number)
    {
        switch (number)
        {
            case 1:
                Console.Write(" One Hundred ");
                break;
            case 2:
                Console.Write(" Two Hunderd ");
                break;
            case 3:
                Console.Write(" Three Hundred ");
                break;
            case 4:
                Console.Write(" Four Hundred ");
                break;
            case 5:
                Console.Write(" Five Hundred ");
                break;
            case 6:
                Console.Write(" Six Hundred ");
                break;
            case 7:
                Console.Write(" Seven Hundred ");
                break;
            case 8:
                Console.Write(" Eight Hundred ");
                break;
            case 9:
                Console.Write(" Nine Hundred ");
                break;
            default:
                break;
        }
    }
    static void Main()
    {
        int number, first, second, third;
 
        Console.WriteLine("Enter number between 0 and 999");
        number = int.Parse(Console.ReadLine());
 
        while (number < 0 || number > 999)
        {
            Console.WriteLine("Invalid input number. Numbers must be in the range [0-999]");
            number = int.Parse(Console.ReadLine());
        }
 
        if (number < 10)
        {
            Digits(number);  
        }
        else if (number >= 10 && number <= 19 )
        {
            SpecialCases(number);
        }
        else if (number >= 20 && number < 100)
        {
            first = number / 10; 
            second = number % 10;
 
            if (second == 0)  
            {
                Tens(first);
            }
            else
            {
                Tens(first);
                Digits(second);
            }
        }
        else if (number >= 100 && number < 1000)
        {
            first = number / 100;
            second = (number / 10) % 10;
            third = number % 10;
            Hundreds(first);
 
            int special = number % 100;
            int digits = number % 100; 
            if ((digits > 0 && digits < 10) || (special >= 10 && special < 20) && special != 0)
            {  
                Console.Write("and");
                Digits(digits);
            }
            if (special >= 10 && special < 20)
            {
                SpecialCases(special);
            }
            int zeroNumber = number % 100;
            if (zeroNumber == 0)
            {
                Hundreds(zeroNumber);
            }
            else if(number > 20 && number < 1000)
            {
                Tens(second);
                int zeroChecker = number % 100;
                int otherZeroChecker = number % 10;
                if (otherZeroChecker != 0 && zeroChecker != 1 && zeroChecker != 2 && zeroChecker != 3 &&
                    zeroChecker != 4 && zeroChecker != 5 && zeroChecker != 6 &&
                    zeroChecker != 7 && zeroChecker != 8 && zeroChecker != 9 &&
                    !(special >= 10 && special < 20))
                {
                    Digits(third);
                }
            }
        }
        Console.WriteLine();
    }
    }
