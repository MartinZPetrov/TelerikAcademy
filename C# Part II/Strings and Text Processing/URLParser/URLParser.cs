/*Write a program that parses an URL address given in the format:
        [protocol]://[server]/[resource]
		and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class URLParser
{
    static void Main(string[] args)
    {
        string URL = "http://www.nakov.com/tag/using-regular-expressions/";
        var martches = Regex.Match(URL, "(.*)://(.*?)(/.*)").Groups;
        Console.WriteLine(martches[1]);
        Console.WriteLine(martches[2]);
        Console.WriteLine(martches[3]);
    }
}
