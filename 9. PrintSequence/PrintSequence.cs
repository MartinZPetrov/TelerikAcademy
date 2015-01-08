using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 9. Print a Sequence

//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
namespace _9.PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 2; i < 12; i++)
            {
                if(i%2 == 0)
                {
                   arr[i-2] = i;
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
