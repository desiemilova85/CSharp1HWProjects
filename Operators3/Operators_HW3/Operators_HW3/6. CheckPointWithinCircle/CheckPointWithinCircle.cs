using System;

class CheckPointWithinCircle
{
    static void Main()
    {
        int circleX = 0;
        int circleY = 0;
        int radius = 5;
        Console.WriteLine("Please enter X point:");
        int xPoint = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter Y point:");
        int yPoint = int.Parse(Console.ReadLine());
        int x = (xPoint - circleX);
        int y = (yPoint - circleY);
        if (((x * x) + (y * y))<= (radius * radius))
        {
            Console.WriteLine("The point with coordinates ({0},{1}) is within the circle K((0.0),5)",xPoint,yPoint);
        }
        else Console.WriteLine("The point with coordinates ({0},{1}) is OUT of the circle K((0.0),5)",xPoint,yPoint);
        }
    }

