//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReturnIndex
{
    static void Main(string[] args)
    {
         int[] array = {1, 2 ,3 ,22 ,56,44};
         int postion = CheckNeighbours(array);
         if (postion > 0)
         {
             Console.WriteLine("The element is on postion " + postion);
         }
         else
         {
             Console.WriteLine("No such element exists");
         }
    }

    static int CheckNeighbours(int[] array)
    {
        int postion;
        postion = -1;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1]) //check neighbours
            {
                postion = i;
                break;
            }
        }
        return postion;

    }
}

