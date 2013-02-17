using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindRealRootsOfQuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter number A:");
        double a = double.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("The quadratic equation must have value for a different from 0. \nPlease enter once again value for A");
        }
        else if (a != 0)
        {
            Console.WriteLine("Enter number B:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number C:");
            double c = double.Parse(Console.ReadLine());
            double D = (b * b) - (4 * a * c);
            if (D < 0)
            {
                Console.WriteLine("Discriminant is < 0 and the quadratic equation has no real roots", D);
            }
            else
                if (D == 0)
                {
                    double x = (-b) / (2 * a);
                    Console.WriteLine("Discriminant is:{0} = 0 ", D);
                    Console.WriteLine("Quadratic equation has one real root: x= {0}", x);
                }
                else
                    if (D > 0)
                    {
                        double x1 = (b + Math.Sqrt(D)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                        Console.WriteLine("Discriminant is: {0} > 0", D);
                        Console.WriteLine("Quadratic equation has two real roots: X1={0} and X2={1}", x1, x2);
                    }
        }
    }
}
