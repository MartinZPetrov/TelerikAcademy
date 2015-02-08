//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        float a, b, h, area;
       
        bool isA, isB, isH;

        Console.WriteLine("Input data to calucate Trapezoid area");
        Console.Write("Side A : ");
        isA = float.TryParse(Console.ReadLine(), out a);
        Console.Write("Side B: ");
        isB = float.TryParse(Console.ReadLine(), out b);

        Console.Write("Height : ");
        isH = float.TryParse(Console.ReadLine(), out h);
      
        if (isA && isB && isH)
        {
            area = (((a+b)/2)*h); // calculate the area
            Console.WriteLine("{0} is the area of the trapezoid", area);
        }
        else
        {
            Console.WriteLine("Please enter only numbers");
        }
    }
}

