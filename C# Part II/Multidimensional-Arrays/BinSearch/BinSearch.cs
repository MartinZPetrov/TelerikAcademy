/*Write a program, that reads from the console an array of 
 *N integers and an integer K, sorts the array and using the method Array.BinSearch() 
 *finds the largest number in the array which is ≤ K. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinSearch
{
    static void Main(string[] args)
    {
        int Result;
        Console.WriteLine("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Please enter integer number {0}", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Please enter k: ");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(arr);

        if (arr[0] > k)
        {
            Console.WriteLine("There is no number that is less than or equal to k.");
        }
        else
        {
            int IndexOfElement = Array.BinarySearch(arr, k);
            if (IndexOfElement >= 0)
            {
                Result = arr[IndexOfElement];
                Console.WriteLine("Index number: " + IndexOfElement + " With value : " + Result);
            }
            else 
            {
                Console.WriteLine("Value not found : " + IndexOfElement);
            }
        }
    }
}

