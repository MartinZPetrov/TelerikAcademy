//Write a program that compares two char arrays lexicographically (letter by letter)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CompareCharArrays
{
    static void Main()
    {

        Console.Write("Enter characters in first array: ");
        string firstArrayStr = Console.ReadLine();
        Console.Write("Enter characters in second array: ");
        string secondArrayStr = Console.ReadLine();

        char[] firstArray = firstArrayStr.ToCharArray();
        char[] secondArray = secondArrayStr.ToCharArray();
        
        int compareBoth = Math.Min(firstArrayStr.Length, secondArray.Length);

        bool arrEquals = true ;

        for (int i = 0; i < compareBoth; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                arrEquals = false;
                if (firstArrayStr[i] < secondArray[i])
                {
                    Console.WriteLine("The fist array is lexicografically before the second");
                    break;
                }
                else
                {
                    Console.WriteLine("The second array is lexicografically before the first");
                    break;
                }
            }
        }

        if (arrEquals == true && firstArrayStr.Length == secondArrayStr.Length)
        {
            Console.WriteLine("The Two arrays are equal");
        }
        else if (arrEquals == true && firstArrayStr.Length < secondArrayStr.Length)
        {
            Console.WriteLine("The first array is before the second");
        }
        else if (arrEquals == true && firstArrayStr.Length < secondArrayStr.Length)
        {
            Console.WriteLine("The second array is before the first");
        }
    }
}
