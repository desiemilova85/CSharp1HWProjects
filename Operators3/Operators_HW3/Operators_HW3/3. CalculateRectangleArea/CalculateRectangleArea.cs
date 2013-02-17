using System;
using System.Text;

class CalculateRectangleArea
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Please Enter rectangle width in cm:");
        double width = double.Parse(Console.ReadLine()); 
        Console.Write("Please Enter rectangle height in cm:");
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        Console.WriteLine(((width > 0) && (height > 0)) ? "Rectangle area is : {0}" : "Area cannot be calculated.Please enter positive numbers", area);
    }
}
 