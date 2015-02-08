//Write a program that finds the biggest of three numbers.
using System;

class BiggestOfThreeNumbers
{
    static void Main()
    {
        double firstNumber, secondNumber, thirdNumber;

        Console.Write("First number: ");
        firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Third number: ");
        thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("The bigest is {0}", firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            Console.WriteLine("The biggest is {0}", secondNumber);
        }
        else
        {
            Console.WriteLine("The biggest is {0}", thirdNumber);
        }
    }
}

