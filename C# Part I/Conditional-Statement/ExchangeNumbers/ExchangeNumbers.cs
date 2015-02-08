//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

using System;

class ExchangeNumbers
{
    static void Main()
    {
        int firstNumber, secondNumber, swapNumber;

        Console.Write("First number: ");
        firstNumber = Int32.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        secondNumber = Int32.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            
            swapNumber = firstNumber;
            firstNumber = secondNumber;
            secondNumber = swapNumber;
        }

        Console.WriteLine("{0} {1} ", firstNumber,secondNumber);
       
    }
}

