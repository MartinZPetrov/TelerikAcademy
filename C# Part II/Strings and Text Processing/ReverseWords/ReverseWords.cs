/*Write a program that reverses the words in given sentence.
	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class ReverseWords
{
    static void Main(string[] args)
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        string result = string.Empty;
        string regex = @"\s+|\,\s*|\;|s\*|\:\s*|\-\s*|\!\s*|\?\s*";
    
        Stack words = new Stack();
        Queue seperators = new Queue();
        
        string[] splitWords = Regex.Split(text,regex, RegexOptions.IgnorePatternWhitespace);

        foreach (string word in splitWords)
        {
            if (word != "")
            {
                words.Push(word);
            }
        }

        foreach (Match separator  in Regex.Matches(text,regex ))
        {
            seperators.Enqueue(separator);
        }

        StringBuilder reservedSentence = new StringBuilder();

        while (words.Count > 0 && seperators.Count > 0)
        {
            reservedSentence.Append(words.Pop());
            reservedSentence.Append(seperators.Dequeue());
        }
        Console.WriteLine(text);
        Console.WriteLine(reservedSentence.ToString());

    }
}
