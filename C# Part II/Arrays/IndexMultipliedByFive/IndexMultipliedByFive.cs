//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IndexMultipliedByFive
{
    static void Main()
    {
        int[] array = new int[20];


        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
        }

        foreach (int numbers in array)
        {
            Console.Write(numbers + "  ");
        }
    }
}

