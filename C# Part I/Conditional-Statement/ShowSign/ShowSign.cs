//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.
using System;

class ShowSign
{
    static void Main()
    {
        double firstNumber, secondNumber, thirdNumber, produtct;

        Console.Write("First number: ");
        firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        thirdNumber = double.Parse(Console.ReadLine());

        produtct = firstNumber * secondNumber * thirdNumber;

        if (firstNumber  < 0 && secondNumber < 0 && thirdNumber < 0) // if we have thre negative the product is -
        {
            Console.WriteLine("The sing is '-')");
        }
        else if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0) //if we have three positive the product is +
        {
            Console.WriteLine("The sign is '+'");
        }
        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0) // if atleast one is negative the product is  -
        {
            Console.WriteLine("The sign is '-'");
        }
        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0) //  if atleast one is negative the product is  -
        {
            Console.WriteLine("The sign is '-'");
        }
        else if (firstNumber > 0 && secondNumber > 0 && thirdNumber < 0) //  if atleast one is negative the product is  -
        {
            Console.WriteLine("The sign is '-'");
        }
        else if (firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) //  if atleast two is negative the product is  +
        {
            Console.WriteLine("The sign is '+'");
        }

        else if (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0) //  if atleast one is negative the product is  +
        {
            Console.WriteLine("The sign is '+'");
        }

        else if (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0) //  if atleast one is negative the product is  +
        {
            Console.WriteLine("The sign is '+'");
        }

        Console.WriteLine(produtct);

    }
}

