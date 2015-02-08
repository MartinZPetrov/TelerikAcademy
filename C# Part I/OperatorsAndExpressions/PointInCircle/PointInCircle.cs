using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PointInCircle
{
    static void Main(string[] args)
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        int radius = 2;

        bool isItInTheCircle = (x * x + y * y) <= radius * radius;

        Console.WriteLine("Is it in the circle ---> " + isItInTheCircle);
    }
}
