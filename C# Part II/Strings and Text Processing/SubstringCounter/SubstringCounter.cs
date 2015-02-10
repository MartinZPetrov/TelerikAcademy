/*Write a program that finds how many times a substring is contained in a given text (perform case insens
 Example: The target substring is "in". The text is as follows:
 We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
 The result is: 9.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SubstringCounter
{
    static void Main(string[] args)
    {
        //currently its hardcoded for easier testing you can change the value of the text variable by static method Console.Readline()
        string text = @"We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. 
                       So we are drinking all the day. We will move out of it in 5 days.";
        Console.Write("Enter substring to search: ");
        string subString =  Console.ReadLine();
        Console.WriteLine("{0} appears in {1} ({2} times)",subString,text.Trim(),CountSubstring(subString,text));

    }

    static int CountSubstring(string subString, string text)
    {
        int index = -1;
        int counter = 0;
        while (true)
        {
            index = text.ToLower().IndexOf(subString, index + 1);

            if (index == -1)
            {
                break;
            }
            string txt = text.Substring(index);
            counter++;
        }
        return counter;
    }
}

