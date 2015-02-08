//Write a program that reads the radius r of a circle and prints its perimeter and area.
using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        double radius, area, perimeter;

        Console.Write("Enter circle radius: ");
        radius = float.Parse(Console.ReadLine());
        area = Math.PI * (radius * 2.0);
        perimeter = Math.PI * (Math.Pow(radius, 2));
        Console.WriteLine("The area is : {0}", area);
        Console.WriteLine("The perimeter is : {0}:", perimeter);
    }
}
