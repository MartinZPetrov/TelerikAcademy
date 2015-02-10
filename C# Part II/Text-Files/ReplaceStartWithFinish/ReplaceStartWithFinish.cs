//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

class ReplaceStartWithFinish
{
    static void Main(string[] args)
    {
        using (StreamWriter sw = new StreamWriter("output.txt"))
        {
            using (StreamReader sr = new StreamReader("test.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToLower();
                    line = line.Replace("start", "finish");
                    sw.WriteLine(line);
                }
            }
        }
    }
}   


