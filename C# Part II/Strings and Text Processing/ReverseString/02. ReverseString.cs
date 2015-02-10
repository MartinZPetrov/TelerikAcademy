/*Write a program that reads a string, reverses it and prints the result at the console.
Example: "sample"  "elpmas".
*/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
    static void Main()
    {

        Console.Write("Enter string: ");
        string str = Console.ReadLine();
        Console.WriteLine("Reversed: {0}", ReversString(str));

    }

    static string ReversString(string str)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = str.Length - 1 ; i >= 0; i--)
        {
            sb.Append(str[i]);
        }
        return sb.ToString();
    }
}
