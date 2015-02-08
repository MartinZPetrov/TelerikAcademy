//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxSumOfSquareInMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter rows: ");
        int rowsCount = Int32.Parse(Console.ReadLine());
        Console.Write("Enter cols: ");
        int colsCount = Int32.Parse(Console.ReadLine());
        int[,] matrix = new int[rowsCount, colsCount];
        int sum = 0;
        int bestSum = Int32.MinValue;

        for (int rows = 0; rows < rowsCount; rows++)
        {
            Console.Write("Enter values: ");
            string numbers = Console.ReadLine();
            string[] numbersAsString = numbers.Split(' '); // Example -> 1 2 3 4 

            for (int cols = 0; cols < numbersAsString.Length; cols++)
            {
                if (cols < colsCount)
                {
                    matrix[rows, cols] = Int32.Parse(numbersAsString[cols]);
                }
            }
        }


        for (int rows = 0; rows < rowsCount; rows++) //cycle each possible square 3x3
        {
            if (rows + 3 <= rowsCount)
            {
                for (int cols = 0; cols < colsCount; cols++)
                {
                    if (cols + 3 <= colsCount)
                    {
                        for (int i = rows; i < 3 + rows; i++)
                        {
                            for (int j = cols; j < 3 + cols; j++)
                            {
                                sum += matrix[i, j];
                            }
                        }
                        if (sum >= bestSum)
                        {
                            bestSum = sum;
                            sum = 0;
                        }
                    }
                }
            }
        }

        for (int rows = 0; rows < rowsCount; rows++)
        {
            for (int cols = 0; cols < colsCount; cols++)
            {
                Console.Write("{0,3}", matrix[rows,cols]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Maximum sum from the array is {0}", bestSum);
    }
}

