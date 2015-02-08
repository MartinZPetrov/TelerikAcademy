using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.
//Examples:

//n	trailing zeroes of n!	explaination
//10	2	3628800
//20	4	2432902008176640000
//100000	24999	think why

class TrailingZeroesinN
{
  
    const int FIVE = 5;
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int zeros = 0;
        int powFive = 1;
        int denominator = 0;

        CalculateZeros(number, ref zeros, ref powFive, ref denominator);

        Console.WriteLine("{0}! has {1} trailing zeros.", number, zeros);
    }

    private static void CalculateZeros(int number, ref int zeros, ref int powFive, ref int denominator)
    {
        while (denominator <= number)
        {
            denominator = (int)Math.Pow(FIVE, powFive);
            zeros += number / denominator;
            ++powFive;
        }
    }

    
}

