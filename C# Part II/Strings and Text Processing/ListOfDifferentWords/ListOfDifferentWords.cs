/*Write a program that reads a string from the console and lists all 
*different words in the string along with information how many times each word is found.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class ListOfDifferentWords
{
    static void Main(string[] args)
    {

        string text = @"We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. 
                      So we are drinking all the day. We will move out of it in 5 days.";

        Dictionary<string, int> dict = new Dictionary<string, int>();

        int counter = 0;
        foreach (Match item in Regex.Matches(text, @"\w+"))
        {
            if (dict.ContainsKey(item.Value))
            {

                dict[item.Value] = dict[item.Value] + 1;
                continue;
                
            }
            dict.Add(item.Value, 1);
            counter++;
        }

        foreach (var item in dict)
        {
            Console.WriteLine(item.Key +  " --> " +  item.Value);
        }
    
    }
}

