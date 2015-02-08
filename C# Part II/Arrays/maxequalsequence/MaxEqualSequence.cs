/*
Write a program that finds the maximal sequence of equal elements in an array.
Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
*/
using System;

class MaxEqualSequence
{
    static void Main(string[] args)
    {
        int[] array = { 1, 1, 1, 3, 3, 4, 2, 2, 2, 2, 2 };
        int n = array.Length;
        int counter = 1;
        int bestStart = 0;
        int bestLen = 0;
        int i;
        for (i = 0; i < n - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                counter++;
            }
            else if (counter >= bestLen)
            {
                bestLen = counter;
                bestStart = i - bestLen + 1;
                counter = 1;
            }
            else
            {
                counter = 1;
            }
        }

        if(counter >= bestLen)
        {
            bestLen = counter;
            bestStart = i - bestLen + 1;
            counter = 1;
        }

        for (int j = bestStart; j < bestStart + bestLen; j++)
        {
            Console.Write(array[j] + " ");
        }

    }
}

