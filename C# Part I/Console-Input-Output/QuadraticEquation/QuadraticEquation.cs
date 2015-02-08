//Write a program that reads the coefficients a, b and c of a quadratic
//equation ax2+bx+c=0 and solves it (prints its real roots).
using System;
class QuadraticEquation
{
    static void Main()
    {
        double a, b, c, descrimenant, x1, x2;

        Console.Write("A: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("B: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("C: ");
        c = double.Parse(Console.ReadLine());

        descrimenant = Math.Pow(b, 2) - (4 * a * c);
        Console.WriteLine("The quadratic equations {0}x^2 + {1}x + {2} = 0", b, a, c);
        if (descrimenant < 0)
        {
            Console.WriteLine(" D < 0 ");
            Environment.Exit(1);
        }
        else if (descrimenant == 0)
        {
            x1 = -b / 2 * a;
            Console.WriteLine("D = 0");
            Console.WriteLine("x = {0}", x1);
        }
        else
        {
            x1 = (-b + Math.Sqrt(descrimenant)) / (2 * a);
            x2 = (-b - Math.Sqrt(descrimenant)) /( 2 * a);
            Console.WriteLine("D > 0");
            Console.WriteLine("x1 = {0}", x1);
            Console.WriteLine("x2 = {0}", x2);
        }
    
    }
}

