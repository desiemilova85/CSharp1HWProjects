using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 4;
            Console.WriteLine(a > b ? "a>b" : "b>=a"); // a>b
            Console.WriteLine((long)a); // 6
            int c = b = 3; // b=3; followed by c=3;
            Console.WriteLine(c); // 3
            Console.WriteLine(a is int); // True
            Console.WriteLine((a + b) / 2); // 4
            Console.WriteLine(typeof(int)); // System.Int32
            int d = new int();
            Console.WriteLine(d); // 0 


        }
    }
}
