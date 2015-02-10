//Modify the solution of the previous problem to replace only whole words (not substrings).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;

class ReplaceWholeWord
{
    static void Main()
    {
        using (StreamWriter sw = new StreamWriter("output.txt"))
        {
            using (StreamReader sr = new StreamReader("test.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToLower();
                    line =  Regex.Replace(line, @"\bstart\b", "finish");
                    sw.WriteLine(line);
                }
            }
        }
    }
}

