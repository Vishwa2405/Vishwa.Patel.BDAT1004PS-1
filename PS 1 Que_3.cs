/*
 [3] Implement function triangleArea(a,b,c) that takes as input the lengths of the 3 sides of a triangle and returns the area of the triangle. By Heron's formula, the area of a triangle with side lengths a, b, and c is
s(s - a)(s -b)(s -c), where s = (a +b + c) /2.

>>> triangleArea(2,2,2)
1.7320508075688772
 */

using System;

class que3
{
    static void Main()
    {
        Console.WriteLine("Enter the length of side 'a': ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 'b': ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of side 'c': ");
        double c = Convert.ToDouble(Console.ReadLine());

        double areaTrg = TriangleArea(a, b, c);

        Console.WriteLine($"The area of the triangle with sides {a}, {b}, and {c} is: {areaTrg}");
    }

    static double TriangleArea(double a, double b, double c)
    {
        // Calculate semi perimeter
        double semiPerimeter = (a + b + c) / 2;

        // Calculate area using Heron's formula
        double area_of_triangle = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

        return area_of_triangle;
    }
}
