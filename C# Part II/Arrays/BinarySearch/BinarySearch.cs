/*Write a program that finds the index of given element in a 
*sorted array of integers by using the binary search algorithm (find it in Wikipedia).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinarySearch
{
    static void Main(string[] args)
    {
        int[] array = {1, 5, 25 , 33, 44, 66 ,77, 88}; //array must be sortred 
        int position;
        Console.Write("Enter value searched: ");
        int valueSearched = Int32.Parse(Console.ReadLine());
        int lenght = array.Length;
        position = BinarySearching(array, 0,  lenght, valueSearched);// with second and third paramter set like this we will search the whole array
        if (position > 0)
        {
            Console.WriteLine("The value is on postion {0} ",position); //counting from zero
        }
        else
        {
            Console.WriteLine("The value does not exist in the array");
        }
    }

    public static int BinarySearching(int[] arr, int lowBound, int highBound, int value)
    {
        int mid;
        while (lowBound <= highBound)
        {
            mid = (lowBound + highBound) / 2;
            if (arr[mid] < value)//the element we search is located to the right from the mid point
            {
                lowBound = mid + 1;
                continue;
            }
            else if (arr[mid] > value)//the element we search is located to the left from the mid point
            {
                highBound = mid - 1;
                continue;
            }
            //at this point low and high bound are equal and we have found the element or
            //arr[mid] is just equal to the value => we have found the searched element
            else
            {
                return mid;
            }
        }
        return -1;//value not found
    }
}

