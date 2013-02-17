using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Please Enter side A of the trapezoid in cm:");
        double sideA = double.Parse(Console.ReadLine());
        Console.Write("Please Enter side B of the trapezoid in cm:");
        double sideB = double.Parse(Console.ReadLine());
        Console.Write("Please Enter the height of the trapezoid in cm:");
        double height = double.Parse(Console.ReadLine());
        double trapezoidArea = (((sideA+sideB)/2)*height);
        Console.WriteLine(((sideA > 0) && (sideB > 0) && (height>0)) ? "Rectangle area is : {0}" : "Area cannot be calculated.Please enter positive numbers", trapezoidArea);

    }
}
