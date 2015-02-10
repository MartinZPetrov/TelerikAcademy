/*Write a program that reads a string from the console and replaces all series of 
 * consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NoneRepeatingLetters
{
    static void Main(string[] args)
    {
        StringBuilder st = new StringBuilder("aaaaabbbbbcdddeeeedssaa");
        for (int i = 0, index = 0; i < st.Length - 1; i++, index++)
        {
            char currentLatter = st[i];
            while (index < st.Length - 1 && currentLatter == st[index + 1])
            {
                st.Remove(index + 1, 1);
            }
        }
        Console.WriteLine(st);
    }
}
