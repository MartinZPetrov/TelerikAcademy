//Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumberOccuranceInArray
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 2, 7, 2, 4, 4, 5 };
        Console.WriteLine("Enter number: ");
        int number = Int32.Parse(Console.ReadLine());
        int count = CountOccurence(array, number);
        Console.WriteLine("{0} appears {1} times in the array", number, count);

    }
    static int CountOccurence(int[] array, int number)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }
}

