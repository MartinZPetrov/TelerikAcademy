//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class GreaterFromTwoNumbers
{
    static void Main()
    {
        int firstNumber, secondNumber, greater;
        Console.Write("Enter the first number: ");
        firstNumber = Int32.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        secondNumber = Int32.Parse(Console.ReadLine());
        greater = Math.Max(firstNumber,secondNumber);
        Console.Write("The greater from the {0} and {1} is {2} ",firstNumber, secondNumber, greater);
    }
}

