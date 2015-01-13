using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 15.* Age after 10 Years
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

namespace _15.AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter current age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Age after 10 years will be \n{0}: ", age+10);
        }
    }
}
