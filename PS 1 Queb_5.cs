/*
 [5_b] Use function inside() from part a. to write an expression that tests whether the point (1,1) lies in both of the following rectangles: one with lower left corner (0.3, 0.5) and upper right corner (1.1, 0.7) and the other with lower left corner (0.5, 0.2) and upper right corner (1.1, 2).
 */

using System;

class queb_5
{
    static void Main()
    {
        // point in the question is: (1,1)
        int x = 1;
        int y = 1;

        // First Rectangle where coordinates: x1,y1 is (0.3,0.5), x2,y2 is (1.1,0.7)
        double x1_rect1 = 0.3;
        double y1_rect1 = 0.5;
        double x2_rect1 = 1.1;
        double y2_rect1 = 0.7;

        // Se cond rectangle where coordinates: x1,y1 is (0.5,0.2), x2,y2 is (1.1,2)
        double x1_rect2 = 0.5;
        double y1_rect2 = 0.2;
        double x2_rect2 = 1.1;
        double y2_rect2 = 2.0;

        // Verifying if the given point is inside the first rectangle
        bool isInRect1 = Inside(x, y, x1_rect1, y1_rect1, x2_rect1, y2_rect1);
        if (isInRect1)
        {
            Console.WriteLine($"The point ({x}, {y}) is inside first rectangle.");
        }
        else
        {
            Console.WriteLine($"The point ({x}, {y}) is not inside first rectangle.");
        }

        // Verifying if the given point is inside the second rectangle
        bool isInRect2 = Inside(x, y, x1_rect2, y1_rect2, x2_rect2, y2_rect2);
        if (isInRect2)
        {
            Console.WriteLine($"The point ({x}, {y}) is inside second rectangle.");
        }
        else
        {
            Console.WriteLine($"The point ({x}, {y}) is not inside second rectangle.");
        }
    }
    static bool Inside(int x, int y, double x1, double y1, double x2, double y2)
    {
        return x1 <= x && x <= x2 && y1 <= y && y <= y2;
    }
}