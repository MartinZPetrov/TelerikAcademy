//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
/* 1 5 9 13
 * 2 6 10 14
 * 3 7 11 16
 * 4 8 12 16
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class PrintMatrixeA
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        int N = Int32.Parse(Console.ReadLine());
        int[,] matrix = new int[N, N];
        int counter = 1;
        for (int cols = 0; cols < N; cols++)
        {
            for (int rows = 0; rows < N; rows++)
            {
                matrix[rows, cols] = counter++;
            }
        }

        for (int rows = 0; rows < N; rows++)
        {
            for (int cols = 0; cols < N; cols++)
            {
                Console.Write("{0, -3}", matrix[rows, cols]);
            }
            Console.WriteLine();
        }

    }
}