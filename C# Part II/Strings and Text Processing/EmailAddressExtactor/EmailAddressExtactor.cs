/*Write a program for extracting all email addresses from given text.
 * All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class EmailAddressExtactor
{
    static void Main()
    {
        string email = "jimbusta@yahoo.com";
        string regex = @"\w+@\w+\.\w+";

        MatchCollection matches = Regex.Matches(email, regex, RegexOptions.IgnorePatternWhitespace);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);   
        }

    }
}

