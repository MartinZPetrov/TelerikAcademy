//Write a program that finds the biggest of five numbers by using only five if statements.
using System;

class Program
{
    static void Main()
    {
        
        double firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber;

        Console.Write("First number: ");
        firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Third number: ");
        thirdNumber = double.Parse(Console.ReadLine());

        Console.Write("Foruth number: ");
        fourthNumber = double.Parse(Console.ReadLine());

        Console.Write("Fifth number: ");
        fifthNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber && firstNumber > fourthNumber && firstNumber > fifthNumber)
        {
            Console.WriteLine("The bigest is {0}", firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber && secondNumber > fourthNumber && fourthNumber > fifthNumber )
        {
            Console.WriteLine("The biggest is {0}", secondNumber);
        }
        else if(thirdNumber > firstNumber && thirdNumber > secondNumber && thirdNumber > fourthNumber && thirdNumber > fifthNumber)
        {
            Console.WriteLine("The biggest is {0}", thirdNumber);
        }
        else if (fourthNumber > firstNumber && fourthNumber > secondNumber && fourthNumber > thirdNumber && fourthNumber > fifthNumber)
        {
            Console.WriteLine("The biggest is {0}", fourthNumber);
        }
        else 
        {
            Console.WriteLine("The biggest is {0}",fifthNumber);
        }
    }
}

