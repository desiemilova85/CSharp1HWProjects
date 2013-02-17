using System;

    class AgeAfter10Years
    {
        static void Main()
        {
            DateTime birthDate = new DateTime(1985,1,2);
            DateTime now = DateTime.Now;
            int age=now.Year-birthDate.Year;
            Console.WriteLine("My age after 10 AgeAfter10Years will be:{0}", age + 10);
        }
    }

