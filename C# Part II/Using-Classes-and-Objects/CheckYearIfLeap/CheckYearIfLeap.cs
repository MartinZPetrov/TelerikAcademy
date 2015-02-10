//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckYearIfLeap
{
    static void Main()
    {
        Console.Write("Enter year: "); 
        int year = Int32.Parse(Console.ReadLine());

        if (DateTime.IsLeapYear(year)) // static bool method
        {
            Console.WriteLine("Year is Leap");
        }
        else
        {
            Console.WriteLine("Year is not leap");
        }
    }
}

