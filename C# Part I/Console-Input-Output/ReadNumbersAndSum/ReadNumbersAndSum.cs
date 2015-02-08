//Write a program that reads 3 integer numbers from the console and prints their sum.
using System;


class ReadNumbersAndSum
{
    static void Main()
    {
        int firstNumber, secondNumber, thirdnumber, sumNumbers;

        Console.Write("A: ");
        firstNumber = Int32.Parse(Console.ReadLine());
        Console.Write("B: ");
        secondNumber = Int32.Parse(Console.ReadLine());
        Console.Write("B: ");
        thirdnumber = Int32.Parse(Console.ReadLine());
        sumNumbers = firstNumber + secondNumber + thirdnumber;
        Console.WriteLine("{0} + {1} + {2} = {3}",firstNumber, secondNumber, thirdnumber, sumNumbers);
    }
}

