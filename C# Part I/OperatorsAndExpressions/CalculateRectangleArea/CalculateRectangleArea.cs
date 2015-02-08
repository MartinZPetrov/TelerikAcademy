//Write an expression that calculates rectangle’s area by given width and height.
using System;
class CalculateRectangleArea
{
    static void Main()
    {
        float height, width, area;
        Console.WriteLine("Enter floating or integer numbers to calculate the area of the rectanagle!");
        Console.Write("height : "); //read the height from the console
        height = float.Parse(Console.ReadLine());
        Console.Write("width : "); //read the width from the console
        width = float.Parse(Console.ReadLine());
        area = height * width; //calculate the area and print
        Console.WriteLine("The area of the the rectange with width:{0} and height:{1} = {2}", width, height, area);
    }
}

