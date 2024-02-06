/*
 [5_a] a. Write a function inside(x,y,x1,y1,x2,y2) that returns True or False depending on whether the point (x,y) lies in the rectangle with lower left corner (x1,y1) and upper right corner (x2,y2).
 */
using System;

class quea_5
{
    static void Main()
    {
        Console.WriteLine("Enter both the coordinates of point (x, y):");

        Console.Write("x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter all the coordinates of rectangle (x1, y1) and (x2, y2):");

        Console.Write("x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        bool isInside = Inside(x, y, x1, y1, x2, y2);

        Console.WriteLine($"The point ({x},{y}) is inside the rectangle: {isInside}");
    }

    static bool Inside(double x, double y, double x1, double y1, double x2, double y2)
    {
        return x >= x1 && x <= x2 && y >= y1 && y <= y2;
    }
}

