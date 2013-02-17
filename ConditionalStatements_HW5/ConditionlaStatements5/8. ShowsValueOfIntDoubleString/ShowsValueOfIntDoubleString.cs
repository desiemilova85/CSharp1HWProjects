using System;

class ShowsValueOfIntDoubleString
{
    static void Main()
    {
            Console.WriteLine("Please choose 0 to input Integer value or 1 to input Double value or 2 to input String value");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Enter a value for Integer : ");
                    int varInt = int.Parse(Console.ReadLine());
                    Console.WriteLine("Integer value will be increased with 1 and the result is = {0}", varInt + 1);
                    break;
                case 1:
                    Console.WriteLine("Enter a value for Double : ");
                    double varDouble = double.Parse(Console.ReadLine());
                    Console.WriteLine("Double value will be increased with 1 and the result is = {0}", varDouble + 1);
                    break;
                case 2:
                    Console.WriteLine("Enter a value for String : ");
                    string varStr = Console.ReadLine();
                    Console.WriteLine("* will be addes to String value as sufix = {0}", varStr + '*');
                    break;
                default:
                    Console.WriteLine("You have chosen number different than 0, 1 or 2. Please try again.");
                    break;
            }
        }
    }
