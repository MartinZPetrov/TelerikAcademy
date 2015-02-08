using System;
using System.Collections.Generic;
using System.Linq;

class Task5
{
    static void Main()
    {
        int N = Int32.Parse(Console.ReadLine());
        List<string> Numbers = new List<string>();

        for (int i = 0; i < N; i++)
        {
            Numbers.Add(Convert.ToString(long.Parse(Console.ReadLine()), 2).PadLeft(30, '0'));
        }

        string concat = string.Empty;

        foreach (var item in Numbers)
        {
            concat += item;
        }

        int longestZeros = LongestSequence(concat, true);
        int longestOnes = LongestSequence(concat, false);

        Console.WriteLine(longestZeros);
        Console.WriteLine(longestOnes);

    }

    static int LongestSequence(string str, bool isZero)
    {
        int longest = 0;
        int length = 0;
        int i;

        for (i = 0; i < str.Length; i++)
        {
            if (isZero ? str[i] == '0' : str[i] == '1')
            {
                length++;
            }
            else
            {
                if (length > longest)
                {
                    longest = length;
                }
                length = 0;
            }
        }
        if (length > longest)
        {
            longest = length;
        }
        return longest;
    }
}

