/** Write a program that reads a positive integer number N (N < 20) 
* from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class PrintMatrixD
{
    static void Main()
    {

        Console.Write("N: ");
        int n = Int32.Parse(Console.ReadLine());
        int number = 1;

        int[,] array = new int[n, n];

        for (int i = 0; i < n; i++) // get top rows and cols
        {
            for (int j = i; j < n - i; j++)
            {
                array[i, j] = number;
                number++;

            }

            for (int j = 0; j < n - 1 - i * 2; j++) // get right coloumns 
            {
                array[j + 1 + i, n - i - 1] = number;
                number++;
            }


            for (int j = 0; j < n - 1 - i * 2; j++) // get botom rows and cols
            {
                array[n - 1 - i, n - j - 2 - i] = number;
                number++;
            }


            for (int j = 0; j < n - 2 - i * 2; j++) //get left cols
            {
                array[n - j - 2 - i, i] = number;
                number++;
            }
        }


        for (int i = 0; i < n; i++) // print
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

