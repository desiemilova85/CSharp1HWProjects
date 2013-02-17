using System;

class PointInCircleRectangle
{
static void Main()
{
    int circleX = 1;
    int circleY = 1;
    int radius = 3;
    Console.WriteLine("Please enter X point:");
    int xPoint = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter Y point:");
    int yPoint = int.Parse(Console.ReadLine());
    int x = (xPoint - circleX);
    int y = (yPoint - circleY);
    bool inCircle=((x * x) + (y * y))<= (radius * radius);
    bool outRectangle=(((xPoint>=-1)&&(xPoint<=5))&&((yPoint>=-1)&&(yPoint>=1)));
    Console.WriteLine((inCircle&&outRectangle)?"The point with coordinates ({0},{1}) is within the circle K((1.1),5) and out of the rectangleR(top=1, left=-1, width=6, height=2).":"The conditions are not applied to the point",xPoint,yPoint);
    }
}
