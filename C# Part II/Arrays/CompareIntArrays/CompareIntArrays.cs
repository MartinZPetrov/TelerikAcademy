//Write a program that reads two arrays from the console and compares them element by element
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompareIntArrays
{
    static void Main()
    {
        Console.Write("Enter n:");
        int n = Int32.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        

        for (int i = 0; i < n; i++)
        {
            Console.Write("firstArray[{0}]: ",i);
            firstArray[i] = Int32.Parse(Console.ReadLine());

            Console.Write("secondArray[{0}]: ", i);
            secondArray[i] = Int32.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("firstArray value {0} is bigger than secondArray value {1} on {2} position", firstArray[i], secondArray[i], i);
            }
            else if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("firstArray value {0} is less than secondArray value{1} on {2} position", firstArray[i], secondArray[i], i);
            }
            else
            {
                Console.WriteLine("The values on poistion {0} are equals",i);
            }
        }
    }
}

