//Problem 8. Catalan Numbers
//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 < n < 100).
using System;
using System.Numerics;
class CatalanNumber
{
    static void Main()
    {
        decimal catalanNumber, n;
        Console.Write("N: ");
        n = decimal.Parse(Console.ReadLine());
        catalanNumber = 0;
        if (n >= 0)
        {
            catalanNumber = Factorial(n * 2) / (Factorial(n + 1) * Factorial(n));
            Console.Write("Cn = " + catalanNumber);
        }
        else
        {
            Console.Write("N must be >= 0");
        }
    }
    static decimal Factorial(decimal dec)
    {
        decimal sum = 1;

        for (decimal i = dec; i > 0 ; i--)
        {
            sum *= i; 
        }
        return sum ;
    }
}

