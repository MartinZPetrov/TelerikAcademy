/*Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class LetterOccurrenceCounter
{
    static void Main(string[] args)
    {
        string text = "C# is not C++, not PHP and not Delphi";
        var chars = text.ToCharArray().GroupBy(a => a);
        foreach (var ch in chars)
        {
            Console.WriteLine("{0}: {1}", ch.Key, ch.Count());
        }
    }
}
