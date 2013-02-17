using System;
using System.Text;

class AssigningNullValues
{
    static void Main()
    {
        int? intVar = null;
        Console.WriteLine(intVar);//no result is shown at the Console
        Console.WriteLine(intVar + 20);//no result is shown in the Console
        intVar= 20;// cmd shows 20 :)
        Console.WriteLine(intVar.GetValueOrDefault());
        double? doubleVar = null;
        Console.WriteLine(doubleVar);//no result is shown at the Console
        Console.WriteLine(doubleVar + 2);//no result is shown at the Console
        doubleVar = 2;// cmd shows 2 :)
        Console.WriteLine(doubleVar.GetValueOrDefault());
    }
}
