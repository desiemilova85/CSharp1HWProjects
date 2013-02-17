using System;
using System.Text;

class PrintBankAccountInfo
{
    static void Main()
    {
        string firstName = "Petar";
        string middleName = "Petrov";
        string lastName = "Ivanov";
        Console.WriteLine("Full Name :{0} {1} {2}",firstName,middleName,lastName);
        decimal moneyBalance = 126868.49m;
        Console.WriteLine("Available amount of money:{0}",moneyBalance);
        string bankName = "DSK BANK";
        Console.WriteLine("Bank: {0}",bankName);
        string iban = "BG43STSA93000004746981";
        Console.WriteLine("IBAN of {0} is: {1}",firstName,iban);
        string bic = "STSABGSF";
        Console.WriteLine("BIC code:" + " " + bic);
        ulong creditCard1 = 4111111111111111;
        ulong creditCard2 = 5500000000000004;
        ulong creditCard3 = 340000000000009;
        Console.WriteLine("Related Credit cards to the bank account:\n Visa :{0},\n MasterCard :{1},\n American Express :{2} ", creditCard1, creditCard2, creditCard3);
    }
}

