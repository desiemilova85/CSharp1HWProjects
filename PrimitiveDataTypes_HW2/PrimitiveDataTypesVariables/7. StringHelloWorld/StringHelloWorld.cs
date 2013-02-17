using System;

class StringHelloWorld
{
    static void Main()
    {
        string firstWord= "Hello";
        string secondWord = "World";
        object concatenion = firstWord + ", " + secondWord + "!";
        string finalConcatenation = (string)concatenion;
        Console.WriteLine(finalConcatenation);
    }
}
