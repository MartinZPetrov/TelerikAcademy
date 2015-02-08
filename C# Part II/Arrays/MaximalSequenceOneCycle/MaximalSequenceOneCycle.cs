/*
Write a program that finds the sequence of maximal sum in given array. Example:
{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
Can you do it with only one loop (with single scan through the elements of the array)?
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaximalSequenceOneCycle
{
    static void Main(string[] args)
    {

        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int maxEndHere = array[0];
        int maxSorFor = array[0];
        int end =0, begin = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (maxEndHere < 0 )
            {
                maxEndHere = array[i];
                begin = i ;
            }
            else
            {
                maxEndHere += array[i];
            }
            if (maxEndHere > maxSorFor)
            {
                maxSorFor = maxEndHere;
                end = i ;
            }
        }
        for (int i = begin; i <= end; i++)
        {
            Console.Write(array[i] + " ");
        }     
    }
}

