//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
/* 1 8 9  16
 * 2 7 10 15
 * 3 6 11 14
 * 4 5 12 13
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintMatrixB
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int N = Int32.Parse(Console.ReadLine());
        int[,] matrix = new int[N, N];
        int counter = 1;
        int currentCounter = 1;
        for (int cols = 0; cols < N; cols++)
        {
            for (int rows = 0; rows < N; rows++)
            {
                if (cols % 2 == 0)
                {
                    matrix[rows, cols] = counter++;
                }
                else
                {
                    matrix[rows, cols] = --counter;
                }
            }
            if (cols % 2 == 0)
            {
                currentCounter = counter;
                currentCounter += N;
                counter = currentCounter;
            }
            else
            {
                counter = currentCounter;
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
