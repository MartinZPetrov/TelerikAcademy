//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8,
//13, 21, 34, 55, 89, 144, 233, 377, …
using System;

class FibonacciSequence
{
    static void Main()
    {
        int lenght, a, b, c;
        a = 0;
        b = 1;
        Console.WriteLine("Enter lenght: ");
        lenght = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < lenght; i++)
        {
            c = a;
            a = b;
            b = c + a;
            Console.Write(c + ", ");
        }
    }
}

