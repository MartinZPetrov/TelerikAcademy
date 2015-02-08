//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GetMaxValue
{

    static void Main()
    {
        Console.Write("First Number: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("Second Number: ");
        int b = Int32.Parse(Console.ReadLine());
        Console.Write("Third Number: ");
        int c = Int32.Parse(Console.ReadLine());
        Console.Write("The greatest is: ");
        Console.WriteLine(GetMax(GetMax(a, b), c));
    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        int greaterNumber = firstNumber;
        if (firstNumber < secondNumber)
        {
            greaterNumber = secondNumber;
        }
        return greaterNumber;
    }

}


