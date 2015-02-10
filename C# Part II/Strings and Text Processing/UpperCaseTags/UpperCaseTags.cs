/*You are given a text. Write a program that changes the text in all regions surrounded by 
 * the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:
 * We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
 * The expected result:
 * We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UpperCaseTags
{
    static void Main(string[] args)
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else <upcase>test.</upcase>";
        Console.WriteLine(text);
        Console.Write("Result: {0}", UpperCase(text));
    }

    public static string UpperCase(string text)
    {     
        while (text.IndexOf("<upcase>") != -1)
        {
            int PosStart = text.IndexOf("<upcase>");
            int PosEnd = text.IndexOf("</upcase>");
            string temp = text.Substring(PosStart + "<upcase>".Length, PosEnd - PosStart - "<upcase>".Length);
            text = text.Replace("<upcase>" + temp + "</upcase>", temp.ToUpper());
        }
        return text;
    }
}

