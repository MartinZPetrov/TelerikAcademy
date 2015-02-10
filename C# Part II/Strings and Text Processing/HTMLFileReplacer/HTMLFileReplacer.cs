/*Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment:
<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class HTMLFileReplacer
{
    static void Main(string[] args)
    {
        string html = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        string regex = @"<\s*a\s[^>]*\bhref\b\s*=\s*('(?<hyperlink>[^']*)'|""(?<hyperlink>[^""]*)""|(?<hyperlink>\S*))[^>]*>(?<hyperlinktext>(.|\s)*?)<\s*/a\s*>";
        Console.WriteLine(Regex.Replace(html, regex, m => "[URL=" + m.Groups["hyperlink"].Value + "]" + m.Groups["hyperlinktext"].Value + "[/URL]"));
    }
}
