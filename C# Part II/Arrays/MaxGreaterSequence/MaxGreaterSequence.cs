/*
Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
*/
using System;

class MaxEqualSequence
{
    static void Main(string[] args)
    {
        int[] array = { 2, 3, 4, 2, 3, 4, 5 };
        int n = array.Length;
        int counter = 1;
        int bestStart = 0;
        int bestLen = 0;
        int i;
        for (i = 0; i < n - 1; i++)
        {
            if (array[i] < array[i + 1])
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

        if (counter >= bestLen)
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
