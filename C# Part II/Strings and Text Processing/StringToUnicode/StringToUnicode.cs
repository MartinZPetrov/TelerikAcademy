/*Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
 * Sample input: Hi!
   Expected output: \u0048\u0069\u0021

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StringToUnicode
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();
        char[] arr = text.ToCharArray();
        string result = string.Empty;
        foreach (char symbol in arr)
        {
            result += GetUniCode(symbol);
        }
        Console.WriteLine(result);
    }

    static String GetUniCode(char symbol)
    {
        return  "\\u" + ((int)symbol).ToString("X4");
    }


}

