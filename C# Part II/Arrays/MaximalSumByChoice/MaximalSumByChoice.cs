// Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find in the array those K elements that have maximal sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSumByChoice
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());
        int k = Int32.Parse(Console.ReadLine());
        int sum = 0;
        int greaterSum = 0;

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("array[{0}]: ", i);
            array[i] = Int32.Parse(Console.ReadLine());
        }

        for (int i = 0; i <= n - k; i++)
        {
            for (int j = i; j < k + i; j++)
            {
                sum += array[j];
            }
            if (sum > greaterSum)
            {
                greaterSum = sum;
            }
            sum = 0;
        }
        Console.WriteLine("The greatest sum is {0}", greaterSum);
    }
}
