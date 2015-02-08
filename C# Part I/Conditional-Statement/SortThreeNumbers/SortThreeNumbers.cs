using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.
class SortThreeNumbers
{
    static void Main()
    {
           Console.Write("Enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double c = double.Parse(Console.ReadLine());

            if (a >= b)
            {
                if (b >+ c) Print(a, b, c);
                else if (c >= a) Print(c, a, b);
                else Print(a, c, b);
            }
            else if (b >= a)
            {
                if (a >= c) Print(b, a, c);
                else if (c >= b) Print(c, b, a);
                else Print(b, c, a);
            }

        }

        private static void Print(double a, double b, double c)
        {
            Console.Clear();
            Console.WriteLine("{0}  {1}  {2}", a, b, c);
        }
    }
}
