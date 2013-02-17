using System;

class BonusScoreInterval1to9
{
    static void Main()
    {
        Console.Write("Enter a digit from the interval (1..9) so that a bonus to be applied: ");

        int digit = int.Parse(Console.ReadLine());
        switch (digit)
        {
            case 0:
                Console.WriteLine("Invalid digit!");
                break;
            case 1:
                Console.WriteLine("Entered digit will be multiplied by 10: {0}",digit*10);
                break;
            case 2:
                Console.WriteLine("Entered digit will be multiplied by 10: {0}",digit*10);
                break;
            case 3:
                Console.WriteLine("Entered digit will be multiplied by 10: {0}",digit*10);
                break;
            case 4:
                Console.WriteLine("Entered digit will be multiplied by 100: {0}",digit*100);
                break;
            case 5:
                Console.WriteLine("Entered digit will be multiplied by 100: {0}",digit*100);
                break;
            case 6:
                Console.WriteLine("Entered digit will be multiplied by 100: {0}",digit*100);
                break;
            case 7:
                Console.WriteLine("Entered digit will be multiplied by 1000: {0}",digit*1000);
                break;
            case 8:
                Console.WriteLine("Entered digit will be multiplied by 1000: {0}",digit*1000);
                break;
            case 9:
                Console.WriteLine("Entered digit will be multiplied by 1000: {0}",digit*1000);
                break;
            default:
                Console.WriteLine("Invalid digit!");
                break;
        }
    }
}
