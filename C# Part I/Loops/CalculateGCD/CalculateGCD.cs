using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).
//Examples:

//a	b	GCD(a, b)
//3	2	1
//60	40	20
class CalculateGCD
{
    static void Main()
    {
        int firstNumber, secondNumber, greatestCommonDivider;
        Console.Write("FirstNumber:");
        firstNumber = Int32.Parse(Console.ReadLine());
        Console.Write("SecondNumber:");
        secondNumber = Int32.Parse(Console.ReadLine());
        greatestCommonDivider = secondNumber;

        int length = 0;

        if(firstNumber > secondNumber)
        {
            firstNumber ^= secondNumber;
            secondNumber ^= firstNumber;
            firstNumber ^= secondNumber;
        }

        if (firstNumber < secondNumber)
        {
            length = firstNumber;
        }
        else if (firstNumber > secondNumber)
        {
            length = secondNumber;
        }
        else if (firstNumber == secondNumber)
        {
            length = firstNumber;
        }


        for (int i = 1; i <= length; i++)
        {
            if (firstNumber % i == 0 && secondNumber % i == 0)
            {
                greatestCommonDivider = i;
            }
        }
        Console.Write("GCD = " + greatestCommonDivider);
    }
}

