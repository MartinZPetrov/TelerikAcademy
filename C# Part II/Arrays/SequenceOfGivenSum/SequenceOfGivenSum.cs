/*Write a program that finds in given array of integers a sequence of given sum S (if present). 
 * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequenceOfGivenSum
{
    static void Main(string[] args)
    {
        int start = 0, end = 0, sum = 0;
        Console.Write("Sum searched: ");
        int givenSum = Int32.Parse(Console.ReadLine());
        int[] array = { 4, 3, 1, 4, 2, 5, 8 };

        
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                sum += array[j];

                if (sum == givenSum)
                {
                    start  = i;
                    end = j;
                    break;
                }
            }
            if (sum == givenSum)
            {
                break;
            }   
            sum = 0;
        }
        for (int i = start; i <= end; i++)
        {
            Console.Write(array[i] + " ");
        }

    }
}

