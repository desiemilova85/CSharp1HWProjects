using System;

class PrintPerimeterAreaOfCircle
{
    static void Main()
    {
        Console.Write("Please enter the radius of circle:");
        double radius = double.Parse(Console.ReadLine());
        double circlePerimeter=(2*Math.PI*radius);
        Console.Write("Perimeter of circle is {0:0.000}:\n",circlePerimeter);
        double circleArea=(Math.PI*radius*radius);
        Console.Write("Perimeter of circle is {0:0.000}:\n",circleArea);
    }
}
