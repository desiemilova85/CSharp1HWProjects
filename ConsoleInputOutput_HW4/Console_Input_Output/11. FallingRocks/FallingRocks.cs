using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

struct Object
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}

class Program
{
    static void PrintOnPosition(int x, int y, char c,
        ConsoleColor color = ConsoleColor.Yellow)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintStringOnPosition(int x, int y, string str,
        ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }
    static void Main()
    {

        //Move our dwarf (key pressed)
        //Move rocks
        //check if other rocks are hitting us
        //clear the console
        //redraw playfield
        //draw info
        //slow down program

        double speed = 100.0;
        double acceleration = 0.5;
        int playfieldWidth = 25;
        int livesCount =5;
        int difficulty = 1;
        char[] objectType = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        ConsoleColor[] objectColor =
        {
            ConsoleColor.Blue,
            ConsoleColor.Cyan,
            ConsoleColor.DarkBlue,
            ConsoleColor.DarkCyan,
            ConsoleColor.DarkGray,
            ConsoleColor.DarkGreen,
            ConsoleColor.DarkMagenta,
            ConsoleColor.DarkYellow,
            ConsoleColor.Gray,
            ConsoleColor.Green,
            ConsoleColor.Magenta,
            ConsoleColor.Yellow
        };

        //clear the scroll bars
        Console.BufferHeight = Console.WindowHeight = 50;
        Console.BufferWidth = Console.WindowWidth = 50;
        Object dwarf = new Object();

        dwarf.x = 2;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.c = '0';
        dwarf.color = ConsoleColor.Yellow;

        Random randomGenerator = new Random();
        List<Object> objects = new List<Object>();

        while (true)
        {
            speed += acceleration;
            if (speed > 400)
            {
                speed = 400;
            }

            bool hitted = false;
            {
                int chance = randomGenerator.Next(0, 100);
                if (chance < 10)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.White;
                    newObject.c = '-';
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }
                else if (chance < 20)
                {
                    Object newObject = new Object();
                    newObject.color = ConsoleColor.Cyan;
                    newObject.c = '1';
                    newObject.x = randomGenerator.Next(0, playfieldWidth);
                    newObject.y = 0;
                    objects.Add(newObject);
                }

                else
                {
                    for (int i = 0; i < difficulty; i++)
                    {
                        Object newRock = new Object();
                        newRock.color = objectColor[randomGenerator.Next(0, 12)];
                        newRock.x = randomGenerator.Next(0, playfieldWidth);
                        newRock.y = 0;
                        newRock.c = objectType[randomGenerator.Next(0, 11)];
                        objects.Add(newRock);
                    }
                }
            }

            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                //while (Console.KeyAvailable) Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x = dwarf.x - 1;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 1 < playfieldWidth)
                    {
                        dwarf.x = dwarf.x + 1;
                    }
                }
            }
            List<Object> newList = new List<Object>();
            for (int i = 0; i < objects.Count; i++)
            {
                Object oldRock = objects[i];
                Object newObject = new Object();
                newObject.x = oldRock.x;
                newObject.y = oldRock.y + 1;
                newObject.c = oldRock.c;
                newObject.color = oldRock.color;
                if (newObject.c == '-' && newObject.y == dwarf.y && newObject.x == dwarf.x)
                {
                    speed -= 20;
                }
                if (newObject.c == '1' && newObject.y == dwarf.y && newObject.x == dwarf.x)
                {
                    livesCount++;
                }

                if (newObject.y == dwarf.y && newObject.x == dwarf.x)
                {
                    livesCount--;
                    hitted = true;
                    speed += 50;
                    if (speed > 400)
                    {
                        speed = 400;
                    }
                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(8, 10, "GAME OVER!!!", ConsoleColor.Red);
                        PrintStringOnPosition(8, 12, "Press [enter] to exit", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                if (newObject.y < Console.WindowHeight)
                {
                    newList.Add(newObject);
                }
            }
            objects = newList;
            Console.Clear();
            if (hitted)
            {
                objects.Clear();
                PrintOnPosition(dwarf.x, dwarf.y, 'X', ConsoleColor.Red);
            }
            else
            {
                PrintOnPosition(dwarf.x, dwarf.y, dwarf.c, dwarf.color);
            }
            foreach (Object car in objects)
            {
                PrintOnPosition(car.x, car.y, car.c, car.color);
            }

            // Draw info
            PrintStringOnPosition(25, 10, "Lives: " + livesCount, ConsoleColor.White);
            PrintStringOnPosition(25, 11, "Speed: " + speed, ConsoleColor.White);
            PrintStringOnPosition(25, 12, "Acceleration: " + acceleration, ConsoleColor.White);
            //Console.Beep();

             //slow down program
            Thread.Sleep((int)(600 - speed));
        }
    }
}
