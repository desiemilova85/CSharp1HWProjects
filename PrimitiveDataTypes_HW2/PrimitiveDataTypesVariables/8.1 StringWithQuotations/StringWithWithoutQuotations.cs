using System;

class StringWithWithoutQuotations
{
    static void Main()
    {
        string first = "The \"use\" of quotations causes difficulties.";//using escape sequences
        Console.WriteLine(first);
        string second = @"The ""use"" of quotations causes difficulties.";//using @ symbol
        Console.WriteLine(second);
    }
}
