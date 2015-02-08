//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CheckIfElementIsBigger
{
    static void Main(string[] args)
    {
        int[] array = {1, 2 ,53 ,22 ,11,44};
        int postion = Int32.Parse(Console.ReadLine());
        if (CheckNeighbours(array, postion))
        {
            Console.WriteLine( "{0} is greater than {1} and {2} ",array[postion],  array[postion-1], array[postion+1]);
        }
        else
        {
            Console.WriteLine("{0} is not greater than {1} and {2} ",array[postion],  array[postion-1], array[postion+1]);
        }

    }

    static bool CheckNeighbours(int[] array, int postion)
    {
        bool isGreater = false;
        if (postion < array.Length && postion > 0 )
        {
            if (array[postion] > array[postion - 1] && array[postion] > array[postion + 1]) //check neighbours
            {
                isGreater = true;
            }
        }
        else
        {
            Console.WriteLine("There are no neighbours to compare ");
            Environment.Exit(1);
        }
        return isGreater;
            
    }
}

