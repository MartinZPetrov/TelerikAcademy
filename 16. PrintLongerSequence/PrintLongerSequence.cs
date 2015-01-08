using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 16.* Print Long Sequence

//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
//You might need to learn how to use loops in C# (search in Internet).
namespace _16.PrintLongerSequence
{
    class PrintLongerSequence
    {
        static void Main(string[] args)
        {
            int[] arr = new int[1000];
            for (int i = 2; i < 1002; i++)
            {
                if (i % 2 == 0)
                {
                    arr[i - 2] = i;
                }
                else
                {
                    arr[i - 2] = -i;
                }
            }
            Console.WriteLine(String.Join(", ", arr));
        }
    }
}
