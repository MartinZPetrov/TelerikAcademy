//You are given an array of strings.
//Write a method that sorts the array by the length of
//its elements (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortStringByLength
{
    static void Main()
    {

        string[] input = { "a", "cc", "aaa", "bb", "dddd" };

        var  sort = from s in input
                    orderby ((string)s).Length ascending
                    select s;

        List<string> sorted = new List<string>(sort); ;

        foreach (var item in sorted)
        {
            Console.WriteLine(item);
        }
    } 
}

