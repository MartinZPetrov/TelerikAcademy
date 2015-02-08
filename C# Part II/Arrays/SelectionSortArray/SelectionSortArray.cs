using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SelectionSortArray
{
    static void Main()
    {

        int[] array = { 1, 5, 4, 7, 2, 9 };

        int temp, min;

        for (int i = 0; i < array.Length - 1; i++)
        {
            min = i;

            for (int j = i+1; j < array.Length; j++)
            {
                if (array[j] < array[i])
                {
                    min = j;
                }
            }

            temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }

    }
}

