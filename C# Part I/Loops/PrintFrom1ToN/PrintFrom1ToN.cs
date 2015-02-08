//Write a program that prints all the numbers from 1 to N.

using System;

class PrintFrom1ToN
{
    static void Main()
    {
        int number;
        Console.WriteLine("Enter N: ");
        number = Int32.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.Write(i + " ");
        }
    }
}

