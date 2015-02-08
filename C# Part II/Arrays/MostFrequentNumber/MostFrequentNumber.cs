/*Write a program that finds the most frequent number in an array. Example:
{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MostFrequentNumber
{
    static void Main()
    {

        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        Array.Sort(array);
        int counter = 1;
        int BestCounter = 0;

        for (int i = 0; i < array.Length -1; i++)
        {
            if (array[i] == array[i+1])
            {
                counter++;
            }
            else 
            {
                if ( counter > BestCounter)
                {
                    BestCounter = counter;
                }
                counter = 1;
            }
        }
    }
}

