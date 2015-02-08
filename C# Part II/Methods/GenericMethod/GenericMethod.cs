/** Modify your last program and try to make it work for any number type, not just integer
* (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    class GenericMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average: {0}", GetAverage(1.0, 2, 3, 4));
            Console.WriteLine("Max: {0}", GetMax(1, 2, 3, 4));
            Console.WriteLine("Min: {0}", GetMin(1, 2, 3, 4));
            Console.WriteLine("Product: {0}", GetProduct(1, 2, 3, 4));
            Console.WriteLine("Sum: {0}", GetSum(1, 2, 3, 4));
        }

        static T GetAverage<T>(params T[] arr)
        {
            dynamic sum = 0;
            dynamic average;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return average = sum / arr.Length;
        }

        static T GetMax<T>(params T[] arr)
        {
            dynamic max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static T GetMin<T>(params T[] arr)
        {
            dynamic min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static T GetProduct<T>(params T[] arr)
        {
            dynamic product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }
        static T GetSum<T>(params T[] arr)
        {
            dynamic sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}
