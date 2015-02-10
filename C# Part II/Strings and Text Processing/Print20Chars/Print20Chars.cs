//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Print20Chars
{
    static void Main()
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();
        Console.WriteLine(PrintStars(str));
    }

    static string PrintStars(string str)
    {
        if (str.Length < 20 )
        {
            return str.PadRight(20, '*');
        }
        return str;
    }
}

