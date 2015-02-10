/*Write a program that extracts from a given text all sentences containing given word.
Example: The word is "in". The text is:
We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
 * So we are drinking all the day. We will move out of it in 5 days.
The expected result is:
Consider that the sentences are separated by "." and the words – by non-letter symbols.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ExtractSentenceByWord
{
    static void Main(string[] args)
    {
        string text = @"We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight.
                      So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";
        Console.WriteLine(ExtractSentence(text, word));
    }

    static string ExtractSentence(string text, string word)
    {
        string result = string.Empty;
        int index = -1;
        int startPos = 0;
        StringBuilder sb = new StringBuilder();

        while (true)
        {
            index = text.IndexOf('.', index + 1);
            if (index == - 1)
            {
                break;
            }
            string temp = text.Substring(startPos , index - startPos + 1);

            if (Regex.IsMatch(temp, @"\b" + word + @"\b"))
            {
                result += string.Concat(temp);
            }
            startPos = index + 1;
        }
        return result;
    }
}

