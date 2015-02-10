/*Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintWordsAlphabeticalOrder
{
    static void Main(string[] args)
    {
        string text = @"We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. 
                    So we are drinking all the day. We will move out of it in 5 days.";

        string[] splitText = text.Split(new char[] {' '} ,StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(splitText);
        foreach (var item in splitText)
        {
            if (item != "\r\n")
            Console.WriteLine(item);
        }
    }
}

