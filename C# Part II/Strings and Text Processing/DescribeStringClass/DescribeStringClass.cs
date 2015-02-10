﻿/*Describe the strings in C#. What is typical for the string data type? 
 *Describe the most important methods of the String class.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DescribeStringClass
{
    static void Main(string[] args)
    {

        string text = @"Strings are collections of characters. We introduce the string type. This type allows us to test and manipulate character data through methods and properties.
We concatenate, append, replace, search and split strings.A string is a class that holds characters and provides operations such as subscripting, concatenation, and comparison that we usually
associate with the notion of a ""string"".
Method: Split()
With Split, you can separate parts of strings. This isolates and extracts substrings with a single function call. Many programs that process 
text will need to split strings. Many overloads are available.
Method: IndexOf() 
Continuing on, the .NET Framework presents several different string searching methods. The most useful one is IndexOf
Method: Concat()
When you concat strings, you put them together into a larger string. When you append a string, you put it at the end of another string.
Method: Replace()
Your string data may contain a series of characters that you want to replace with another substring in each place it is found. 
The Replace method is useful in this case. It requires just one line of.
Property: Length
We never need to manually count the number of characters in a string. Instead, we access the Length property on a string instance. 
This is faster. Sometimes, specific characters must be counted";

        Console.WriteLine(text);
    }

}
